using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace LicPlate
{
    public partial class frmMain : Form
    {
        BlobMatcher_Int32 blobMatcher;
        ClassLexicon lexicon;

       /*  Description:
        *      Mainform constructor
        */
        public frmMain()
        {            
            InitializeComponent();
        }

       /*
        *  Description:
        *      Display blob features in the standard output
        *  Input:
        *      //An binary image containing blobs
        *      Image binaryImage
        */
        public void DisplayBlobs(Image binaryImage)
        {
            vector_BlobAnalyse ba = new vector_BlobAnalyse();
            vector_Blob blobs = new vector_Blob();
            ba.Add(BlobAnalyse.BA_Area);
            ba.Add(BlobAnalyse.BA_Eccentricity);
            ba.Add(BlobAnalyse.BA_LengthBreadthRatio);            
            VisionLabEx.GetBlobsInfo(binaryImage, ba, ref blobs);
            System.Diagnostics.Debug.WriteLine("Blob Info: ");
            foreach (Blob b in blobs)
            {
                System.Diagnostics.Debug.WriteLine("   Area: " + b.Area().ToString() +
                                                   " Eccentricity: " + b.Eccentricity().ToString() +
                                                   " LengthBreadthRatio: " + b.LengthBreadthRatio().ToString());
            }
            ba.Dispose();
            blobs.Dispose();
        }

       /*
        *  Description:
        *      Match a single image given the filename
        *  Input:
        *      //Filename of the image
        *      String Filename
        *      //Add the results to  the listboxes?
        *      bool add
        *      //If true, the VisionLab scripts will be called by LicensePlateMatcher. If false, the wrapped functions are called by LicensePlateMatcherScript
        *      bool useScripts
        *  Output:
        */
        private void MatchImage(String Filename, bool add, bool useScripts)
        {
            ErrorTB.Text = "";
            lblExpected.Text = Filename.Substring(0, 6);

            //*************************************//
            //** load and display original image **//
            //*************************************//
            Bitmap bm;
            bm = new Bitmap(Filename);
            RGB888Image plateImage = VisionLabEx.BitmapToJL(bm);
            VisionLabEx.DisplayImage(plateImage, imgOrig);            

            //****************//
            //** Find plate **//
            //****************//
            Int32Image binaryPlateImage = new Int32Image();
            bool success;
            if (useScripts) {
                success = LicensePlateMatcherScript.FindPlate(plateImage, ref binaryPlateImage); 
            } else {
                success = LicensePlateMatcher.FindPlate(plateImage, ref binaryPlateImage);
            }
            if (!success)
            {                
                lblLexiconResult.Text = "";
                if (add)
                {
                    lstFindPlateErr.Items.Add(Filename);
                    lblFindPlateErrCount.Text = lstFindPlateErr.Items.Count.ToString();
                }
                ClearResultLabels();
                ClearPictureBox(imgPlateBin);
                ClearPictureBox(imgRectifiedPlate);
                return;
            }
            VisionLabEx.DisplayImage(binaryPlateImage, imgPlateBin, true, true);

            //**
            //** Enable this to display blob measurements to debug output
            //**
            DisplayBlobs(binaryPlateImage);

            //*******************//
            //** Rectify plate **//
            //*******************//                       
            Int32Image binaryCharacterImage = new Int32Image();
            if (useScripts) {
                success = LicensePlateMatcherScript.FindCharacters(plateImage, binaryPlateImage, ref binaryCharacterImage); 
            } else {
                success = LicensePlateMatcher.FindCharacters(plateImage, binaryPlateImage, ref binaryCharacterImage);                
            }
            if (!success)
            {
                if (imgRectifiedPlate.Image != null)
                    imgRectifiedPlate.Image.Dispose();
                imgRectifiedPlate.Image = null;
                lblLexiconResult.Text = "";
                if (add)
                {
                    lstRectifyPlateErr.Items.Add(Filename);
                    lblRectfyPlateErrCount.Text = lstRectifyPlateErr.Items.Count.ToString();
                }
                ClearResultLabels();
                ClearPictureBox(imgRectifiedPlate);
                return;
            }
            VisionLabEx.DisplayImage(binaryCharacterImage, imgRectifiedPlate, true, true);
            //**
            //** Enable this to display blob measurements to debug output
            //**
            DisplayBlobs(binaryCharacterImage);

            //*****************//
            //** Match Plate **//
            //*****************//
            LicensePlate result = new LicensePlate();
            LicensePlate lexiconResult = new LicensePlate();
            if (useScripts) {
                success = LicensePlateMatcherScript.MatchPlate(binaryCharacterImage, ref result); 
            } else {
                success = LicensePlateMatcher.MatchPlate(binaryCharacterImage, blobMatcher, lexicon, ref result, ref lexiconResult);                
            }
            if (!success)
            {
                lblLexiconResult.Text = "";
                if (add)
                {
                    lstMatchPlateErr.Items.Add(Filename);
                    lblMatchPlateErrCount.Text = lstMatchPlateErr.Items.Count.ToString();
                }
                ClearResultLabels();
                return;
            }            

            //*********************//
            //** Process results **//
            //*********************//            
            ProcessResults(result, lexiconResult, Filename, (double) nupConfidence.Value / 100, add);
            
            bm.Dispose();
            plateImage.Dispose();
            binaryPlateImage.Dispose();
            binaryCharacterImage.Dispose();

            //Force a garbage collect to prevens malloc errors from unmanaged code.
            GC.Collect();
        }

       /*
        *  Description:
        *      Export image from one of the ListBoxes to file
        *  Input:
        *      //Which listbox contains teh filenames
        *      ListBox lb
        */
        public void ExportImages(ListBox lb)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < lb.Items.Count; i++)
                {
                    File.Copy(lblFolder.Text + "\\" + lb.Items[i].ToString(), folderBrowserDialog1.SelectedPath + "\\" + lb.Items[i].ToString());
                }
            }
            MessageBox.Show("Export finished");
        }

       /*
        *  Description:
        *      Calculate the score and place match in appropriate ListBox
        *  Input:
        *      //Classification result of the matcher
        *      LicensePlate result
        *      //Classification result of the lexicon
        *      LicensePlate lexiconResult
        *      //Filename of the image
        *      string filename
        *      //Minimum confidence specified by the UpDownSpinner
        *      double minConfidence
        *      //Add result to the ListBox?
        *      bool add
        */
        public void ProcessResults(LicensePlate result, string filename, double minConfidence, bool add) { ProcessResults(result, null, filename, minConfidence, add); }
        public void ProcessResults(LicensePlate result, LicensePlate lexiconResult, string filename, double minConfidence, bool add)
        {
            string expected = filename.Substring(0, 6);
            lblExpected.Text = expected;
            lblResult.Text = result.getLicensePlateString();
            lblConfidence.Text = Math.Round(result.confidence, 3).ToString();
            if (lexiconResult != null && chkUseLexicon.Checked)
            {
                lblLexiconResult.Text = lexiconResult.getLicensePlateString();
                lblLexiconConfidence.Text = Math.Round(lexiconResult.confidence, 3).ToString();
            }
            else
            {
                lblLexiconResult.Text = "";
            }

            lblError1.Text = Math.Round(result.characters[0].error, 2).ToString();
            lblError2.Text = Math.Round(result.characters[1].error, 2).ToString();
            lblError3.Text = Math.Round(result.characters[2].error, 2).ToString();
            lblError4.Text = Math.Round(result.characters[3].error, 2).ToString();
            lblError5.Text = Math.Round(result.characters[4].error, 2).ToString();
            lblError6.Text = Math.Round(result.characters[5].error, 2).ToString();
            if (!chkUseLexicon.Checked)
            {
                lblLexiconResult.ForeColor = Color.Black;
                if (result.confidence >= minConfidence && expected == result.getLicensePlateString())       //True Positive (Matched)
                {
                    lblResult.ForeColor = Color.Green;
                    if (add)
                    {
                        lstMatched.Items.Add(filename);
                        lblMatchedCount.Text = lstMatched.Items.Count.ToString();
                    }
                }
                if (result.confidence >= minConfidence && expected != result.getLicensePlateString())       //False Positive (Error)
                {
                    lblResult.ForeColor = Color.Red;
                    if (add)
                    {
                        lstErrors.Items.Add(filename);
                        lblErrorsCount.Text = lstErrors.Items.Count.ToString();
                    }
                }
                if ((result.confidence < minConfidence && expected == result.getLicensePlateString()) ||    //False Negative (Low confidence)
                    (result.confidence < minConfidence && expected != result.getLicensePlateString()))      //True Negative (Low confidence)
                {
                    lblResult.ForeColor = Color.Blue;
                    if (add)
                    {
                        lstLowConfidence.Items.Add(filename);
                        lblLowConfidenceCount.Text = lstLowConfidence.Items.Count.ToString();
                    }
                }
            }
            else
            {
                lblResult.ForeColor = Color.Black;
                if (lexiconResult.confidence >= minConfidence && expected == lexiconResult.getLicensePlateString())       //True Positive (Matched)
                {
                    lblLexiconResult.ForeColor = Color.Green;
                    if (add)
                    {
                        if (lexiconResult.getLicensePlateString() != result.getLicensePlateString())
                        {
                            lstLexicon.Items.Add(filename);
                            lblLexiconCount.Text = lstMatched.Items.Count.ToString();
                        }
                        else
                        {
                            lstMatched.Items.Add(filename);
                            lblMatchedCount.Text = lstMatched.Items.Count.ToString();
                        }
                    }
                }
                if (lexiconResult.confidence >= minConfidence && expected != lexiconResult.getLicensePlateString())       //False Positive (Error)
                {
                    lblLexiconResult.ForeColor = Color.Red;
                    if (add)
                    {
                        lstErrors.Items.Add(filename);
                        lblErrorsCount.Text = lstErrors.Items.Count.ToString();
                    }
                }
                if ((lexiconResult.confidence < minConfidence && expected == lexiconResult.getLicensePlateString()) ||    //False Negative (Low confidence)
                    (lexiconResult.confidence < minConfidence && expected != lexiconResult.getLicensePlateString()))      //True Negative (Low confidence)
                {
                    lblLexiconResult.ForeColor = Color.Blue;
                    if (add)
                    {
                        lstLowConfidence.Items.Add(filename);
                        lblLowConfidenceCount.Text = lstLowConfidence.Items.Count.ToString();
                    }
                }
            }
        }

       /*
        *  Description:
        *      Clear all classification labels
        */
        private void ClearResultLabels()
        {
            lblResult.Text = "";
            lblLexiconResult.Text = "";
            lblConfidence.Text = "";
            lblLexiconConfidence.Text = "";
            lblError1.Text = "";
            lblError2.Text = "";
            lblError3.Text = "";
            lblError4.Text = "";
            lblError5.Text = "";
            lblError6.Text = "";
        }

        /*
         *  Description:
         *      Clear image of a picturebox
         */
        private void ClearPictureBox(PictureBox pb)
        {
            if (pb.Image != null)
                pb.Image.Dispose();
            pb.Image = null;
            pb.Refresh();
        }
       /*
        *  Description:
        *      Load the pattern matcher and scripts
        */
        private void LoadFiles()
        {
            try
            {
                ErrorTB.Text = "";
                if (chkUseScripts.Checked)
                {
                    chkUseLexicon.Checked = false;
                    chkUseLexicon.Enabled = false;
                }
                else
                    chkUseLexicon.Enabled = true;
                if (chkUseScripts.Checked)
                {
                    LicensePlateMatcherScript.Init();
                }
                String exePath = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
                if (blobMatcher == null)
                    blobMatcher = new BlobMatcher_Int32();
                blobMatcher.ReadFromFile(exePath + "\\..\\..\\..\\..\\..\\..\\VL\\lic_fonts.pm");

                if (lexicon == null)
                    lexicon = new ClassLexicon(blobMatcher.GetPatternNamesTab());
            }
            catch (System.Exception ex)
            {
                ErrorTB.Text = ex.Message;
            }
        }

       /*
        *  Description:
        *      Match a single image from a ListBox by double clicking it
        */
        private void MatchImage_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                MatchImage((sender as ListBox).Items[(sender as ListBox).SelectedIndex].ToString(), false, chkUseScripts.Checked);
            }
            catch (System.Exception ex)
            {
                ErrorTB.Text = ex.Message;
            }
        }

       /*
        *  Description:
        *      Load filenames from disk
        */
        private void btnLoadFromFolder_Click(object sender, EventArgs e)
        {
            lbMatchList.Items.Clear();
            lblMatchList.Text = "0";
            lblNrWords.Text = "0";
            //if (!chkUseScripts.Checked)
            lexicon.Clear();
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (lblFolder.Text != "<none>")
                    folderBrowserDialog1.SelectedPath = lblFolder.Text;
                else
                    folderBrowserDialog1.SelectedPath = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    Directory.SetCurrentDirectory(folderBrowserDialog1.SelectedPath);
                    lbMatchList.Items.Clear();
                    DirectoryInfo di = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                    lblFolder.Text = folderBrowserDialog1.SelectedPath;
                    foreach (FileInfo fi in di.GetFiles())
                    {
                        if ((fi.Attributes & FileAttributes.Hidden) == 0)
                        {
                            if (fi.Extension.ToLower() == ".jpg")
                            {
                                lbMatchList.Items.Add(Path.GetFileName(fi.FullName).ToUpper());
                                string plate = lbMatchList.Items[lbMatchList.Items.Count - 1].ToString().Substring(0, 6).ToUpper();
                                string splitPlate = "";
                                for (int i = 0; i < plate.Length; i++)
                                {
                                    splitPlate = splitPlate + plate[i] + " ";
                                }
                                splitPlate = splitPlate.Trim();
                                //if (!chkUseScripts.Checked)
                                lexicon.AddWord(splitPlate);
                                lblMatchList.Text = lbMatchList.Items.Count.ToString();
                                Application.DoEvents();
                            }
                        }
                    }
                    if (!chkUseScripts.Checked)
                        lblNrWords.Text = lexicon.NrWords().ToString();
                    else
                        lblNrWords.Text = "NA";
                }
            }
            catch (System.Exception ex)
            {
                ErrorTB.Text = ex.Message;
            }
            Cursor.Current = Cursors.Default;
        }

       /*
        *  Description:
        *      Process all license plates in the ListBox
        */
        private void btnGo_Click(object sender, EventArgs e)
        {
           try
           {
                if (btnProcess.Tag.ToString() != "started")
                {
                    //Start
                    btnProcess.Text = "Stop";
                    Application.DoEvents();

                    btnProcess.Tag = "started";
                    lstLowConfidence.Items.Clear();                    
                    lstMatched.Items.Clear();
                    lstLexicon.Items.Clear();
                    lstRectifyPlateErr.Items.Clear();
                    lstMatchPlateErr.Items.Clear();
                    lstFindPlateErr.Items.Clear();
                    lstErrors.Items.Clear();
                    lblLowConfidenceCount.Text = "0";
                    lblFindPlateErrCount.Text = "0";
                    lblMatchedCount.Text = "0";
                    lblLexiconCount.Text = "0";
                    lblMatchPlateErrCount.Text = "0";
                    lblErrorsCount.Text = "0";

                    foreach (String fn in lbMatchList.Items)
                    {
                        GC.AddMemoryPressure(1 * 1024 * 1024 * 1024); //1 GB
                        MatchImage(fn,true, chkUseScripts.Checked);
                        lblScore.Text = Convert.ToString(Convert.ToInt32(lblMatchedCount.Text) + Convert.ToInt32(lblLexiconCount.Text) - (10 * Convert.ToInt32(lblErrorsCount.Text)));
                        GC.RemoveMemoryPressure(1 * 1024 * 1024 * 1024); //1 GB
                        Application.DoEvents();
                        if (btnProcess.Tag.ToString() == "stop")
                            break;
                    }
                    btnProcess.Tag = "stop";
                    btnProcess.Text = "Process";
                }
                else
                {
                    //Stop
                    btnProcess.Tag = "stop";
                }
            }
            catch (System.Exception ex)
            {
                btnProcess.Tag = "stop";
                btnProcess.Text = "Process";
                ErrorTB.Text = ex.Message;
            }
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            VisionLab.InitVisionLib();
            lexicon = null;
            blobMatcher = null;
            LoadFiles();
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            LoadFiles();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbMatchList.Items.Clear();
            lblMatchList.Text = "0";
            lblNrWords.Text = "0";
            lexicon.Clear();
        }

        private void btnExportMatched_Click(object sender, EventArgs e)
        {
            ExportImages(lstMatched);
        }

        private void btnExportMatchedLexicon_Click(object sender, EventArgs e)
        {
            ExportImages(lstLexicon);
        }

        private void btnExportFindPlate_Click(object sender, EventArgs e)
        {
            ExportImages(lstFindPlateErr);
        }

        private void bntExportFindCharacters_Click(object sender, EventArgs e)
        {
            ExportImages(lstRectifyPlateErr);
        }

        private void btnExportMatchPlate_Click(object sender, EventArgs e)
        {
            ExportImages(lstMatchPlateErr);
        }

        private void btnExportLowConfidence_Click(object sender, EventArgs e)
        {
            ExportImages(lstLowConfidence);
        }

        private void btnExportErrors_Click(object sender, EventArgs e)
        {
            ExportImages(lstErrors);
        }

        private void chkUseScripts_CheckedChanged(object sender, EventArgs e)
        {
            LoadFiles();
        }

    }
}
