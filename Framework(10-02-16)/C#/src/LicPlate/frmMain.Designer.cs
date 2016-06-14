namespace LicPlate
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imgOrig = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnLoadFromFolder = new System.Windows.Forms.Button();
            this.imgRectifiedPlate = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnProcess = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMatchedCount = new System.Windows.Forms.Label();
            this.lblFindPlateErrCount = new System.Windows.Forms.Label();
            this.lblMatchPlateErrCount = new System.Windows.Forms.Label();
            this.lblLowConfidenceCount = new System.Windows.Forms.Label();
            this.lblErrorsCount = new System.Windows.Forms.Label();
            this.lblMatchList = new System.Windows.Forms.Label();
            this.lblLexiconResult = new System.Windows.Forms.Label();
            this.imgPlateBin = new System.Windows.Forms.PictureBox();
            this.btnReloadBblobMatcher = new System.Windows.Forms.Button();
            this.ErrorTB = new System.Windows.Forms.TextBox();
            this.lstMatched = new System.Windows.Forms.ListBox();
            this.lstFindPlateErr = new System.Windows.Forms.ListBox();
            this.lstMatchPlateErr = new System.Windows.Forms.ListBox();
            this.lstLowConfidence = new System.Windows.Forms.ListBox();
            this.lstErrors = new System.Windows.Forms.ListBox();
            this.lbMatchList = new System.Windows.Forms.ListBox();
            this.nupConfidence = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.lstLexicon = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblLexiconCount = new System.Windows.Forms.Label();
            this.lblNrWords = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chkUseLexicon = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblResultCapt = new System.Windows.Forms.Label();
            this.lblLexiconCapt = new System.Windows.Forms.Label();
            this.lblError1 = new System.Windows.Forms.Label();
            this.lblError2 = new System.Windows.Forms.Label();
            this.lblError3 = new System.Windows.Forms.Label();
            this.lblError4 = new System.Windows.Forms.Label();
            this.lblError5 = new System.Windows.Forms.Label();
            this.lblConfidence = new System.Windows.Forms.Label();
            this.lblLexiconConfidence = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lblError6 = new System.Windows.Forms.Label();
            this.lblExpectedCaption = new System.Windows.Forms.Label();
            this.lblExpected = new System.Windows.Forms.Label();
            this.lstRectifyPlateErr = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblRectfyPlateErrCount = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnExportMatched = new System.Windows.Forms.Button();
            this.btnExportMatchedLexicon = new System.Windows.Forms.Button();
            this.btnExportFindPlate = new System.Windows.Forms.Button();
            this.bntExportFindCharacters = new System.Windows.Forms.Button();
            this.btnExportMatchPlate = new System.Windows.Forms.Button();
            this.btnExportLowConfidence = new System.Windows.Forms.Button();
            this.btnExportErrors = new System.Windows.Forms.Button();
            this.lblFolder = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.chkUseScripts = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgOrig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRectifiedPlate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlateBin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupConfidence)).BeginInit();
            this.SuspendLayout();
            // 
            // imgOrig
            // 
            this.imgOrig.Location = new System.Drawing.Point(12, 57);
            this.imgOrig.Name = "imgOrig";
            this.imgOrig.Size = new System.Drawing.Size(256, 243);
            this.imgOrig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOrig.TabIndex = 0;
            this.imgOrig.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(649, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "False Positives";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "True Positives";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(549, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Reject";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 467);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "FindPlate( )";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 467);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "MatchPlate( )";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(555, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Images";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(79, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(24, 25);
            this.lblScore.TabIndex = 14;
            this.lblScore.Text = "0";
            // 
            // btnLoadFromFolder
            // 
            this.btnLoadFromFolder.Location = new System.Drawing.Point(553, 244);
            this.btnLoadFromFolder.Name = "btnLoadFromFolder";
            this.btnLoadFromFolder.Size = new System.Drawing.Size(129, 23);
            this.btnLoadFromFolder.TabIndex = 15;
            this.btnLoadFromFolder.Text = "Load from folder";
            this.btnLoadFromFolder.UseVisualStyleBackColor = true;
            this.btnLoadFromFolder.Click += new System.EventHandler(this.btnLoadFromFolder_Click);
            // 
            // imgRectifiedPlate
            // 
            this.imgRectifiedPlate.Location = new System.Drawing.Point(12, 306);
            this.imgRectifiedPlate.Name = "imgRectifiedPlate";
            this.imgRectifiedPlate.Size = new System.Drawing.Size(288, 63);
            this.imgRectifiedPlate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgRectifiedPlate.TabIndex = 16;
            this.imgRectifiedPlate.TabStop = false;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(553, 273);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(129, 23);
            this.btnProcess.TabIndex = 17;
            this.btnProcess.Tag = "stop";
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Images";
            // 
            // lblMatchedCount
            // 
            this.lblMatchedCount.AutoSize = true;
            this.lblMatchedCount.Location = new System.Drawing.Point(12, 634);
            this.lblMatchedCount.Name = "lblMatchedCount";
            this.lblMatchedCount.Size = new System.Drawing.Size(13, 13);
            this.lblMatchedCount.TabIndex = 19;
            this.lblMatchedCount.Text = "0";
            // 
            // lblFindPlateErrCount
            // 
            this.lblFindPlateErrCount.AutoSize = true;
            this.lblFindPlateErrCount.Location = new System.Drawing.Point(228, 634);
            this.lblFindPlateErrCount.Name = "lblFindPlateErrCount";
            this.lblFindPlateErrCount.Size = new System.Drawing.Size(13, 13);
            this.lblFindPlateErrCount.TabIndex = 20;
            this.lblFindPlateErrCount.Text = "0";
            // 
            // lblMatchPlateErrCount
            // 
            this.lblMatchPlateErrCount.AutoSize = true;
            this.lblMatchPlateErrCount.Location = new System.Drawing.Point(428, 634);
            this.lblMatchPlateErrCount.Name = "lblMatchPlateErrCount";
            this.lblMatchPlateErrCount.Size = new System.Drawing.Size(13, 13);
            this.lblMatchPlateErrCount.TabIndex = 21;
            this.lblMatchPlateErrCount.Text = "0";
            // 
            // lblLowConfidenceCount
            // 
            this.lblLowConfidenceCount.AutoSize = true;
            this.lblLowConfidenceCount.Location = new System.Drawing.Point(549, 634);
            this.lblLowConfidenceCount.Name = "lblLowConfidenceCount";
            this.lblLowConfidenceCount.Size = new System.Drawing.Size(13, 13);
            this.lblLowConfidenceCount.TabIndex = 22;
            this.lblLowConfidenceCount.Text = "0";
            // 
            // lblErrorsCount
            // 
            this.lblErrorsCount.AutoSize = true;
            this.lblErrorsCount.Location = new System.Drawing.Point(649, 634);
            this.lblErrorsCount.Name = "lblErrorsCount";
            this.lblErrorsCount.Size = new System.Drawing.Size(13, 13);
            this.lblErrorsCount.TabIndex = 23;
            this.lblErrorsCount.Text = "0";
            // 
            // lblMatchList
            // 
            this.lblMatchList.AutoSize = true;
            this.lblMatchList.Location = new System.Drawing.Point(671, 206);
            this.lblMatchList.Name = "lblMatchList";
            this.lblMatchList.Size = new System.Drawing.Size(13, 13);
            this.lblMatchList.TabIndex = 24;
            this.lblMatchList.Text = "0";
            // 
            // lblLexiconResult
            // 
            this.lblLexiconResult.AutoSize = true;
            this.lblLexiconResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLexiconResult.Location = new System.Drawing.Point(102, 415);
            this.lblLexiconResult.Name = "lblLexiconResult";
            this.lblLexiconResult.Size = new System.Drawing.Size(96, 25);
            this.lblLexiconResult.TabIndex = 25;
            this.lblLexiconResult.Text = "XXXXXX";
            // 
            // imgPlateBin
            // 
            this.imgPlateBin.Location = new System.Drawing.Point(277, 57);
            this.imgPlateBin.Name = "imgPlateBin";
            this.imgPlateBin.Size = new System.Drawing.Size(256, 242);
            this.imgPlateBin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlateBin.TabIndex = 26;
            this.imgPlateBin.TabStop = false;
            // 
            // btnReloadBblobMatcher
            // 
            this.btnReloadBblobMatcher.Location = new System.Drawing.Point(553, 301);
            this.btnReloadBblobMatcher.Name = "btnReloadBblobMatcher";
            this.btnReloadBblobMatcher.Size = new System.Drawing.Size(129, 23);
            this.btnReloadBblobMatcher.TabIndex = 27;
            this.btnReloadBblobMatcher.Text = "Reload Scripts";
            this.btnReloadBblobMatcher.UseVisualStyleBackColor = true;
            this.btnReloadBblobMatcher.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // ErrorTB
            // 
            this.ErrorTB.Location = new System.Drawing.Point(71, 688);
            this.ErrorTB.Name = "ErrorTB";
            this.ErrorTB.ReadOnly = true;
            this.ErrorTB.Size = new System.Drawing.Size(681, 20);
            this.ErrorTB.TabIndex = 29;
            // 
            // lstMatched
            // 
            this.lstMatched.FormattingEnabled = true;
            this.lstMatched.Location = new System.Drawing.Point(13, 495);
            this.lstMatched.Name = "lstMatched";
            this.lstMatched.Size = new System.Drawing.Size(100, 134);
            this.lstMatched.TabIndex = 30;
            this.lstMatched.DoubleClick += new System.EventHandler(this.MatchImage_DoubleClick);
            // 
            // lstFindPlateErr
            // 
            this.lstFindPlateErr.FormattingEnabled = true;
            this.lstFindPlateErr.Location = new System.Drawing.Point(231, 495);
            this.lstFindPlateErr.Name = "lstFindPlateErr";
            this.lstFindPlateErr.Size = new System.Drawing.Size(100, 134);
            this.lstFindPlateErr.TabIndex = 31;
            this.lstFindPlateErr.DoubleClick += new System.EventHandler(this.MatchImage_DoubleClick);
            // 
            // lstMatchPlateErr
            // 
            this.lstMatchPlateErr.FormattingEnabled = true;
            this.lstMatchPlateErr.Location = new System.Drawing.Point(431, 495);
            this.lstMatchPlateErr.Name = "lstMatchPlateErr";
            this.lstMatchPlateErr.Size = new System.Drawing.Size(100, 134);
            this.lstMatchPlateErr.TabIndex = 32;
            this.lstMatchPlateErr.DoubleClick += new System.EventHandler(this.MatchImage_DoubleClick);
            // 
            // lstLowConfidence
            // 
            this.lstLowConfidence.FormattingEnabled = true;
            this.lstLowConfidence.Location = new System.Drawing.Point(552, 495);
            this.lstLowConfidence.Name = "lstLowConfidence";
            this.lstLowConfidence.Size = new System.Drawing.Size(100, 134);
            this.lstLowConfidence.TabIndex = 33;
            this.lstLowConfidence.DoubleClick += new System.EventHandler(this.MatchImage_DoubleClick);
            // 
            // lstErrors
            // 
            this.lstErrors.FormattingEnabled = true;
            this.lstErrors.Location = new System.Drawing.Point(652, 495);
            this.lstErrors.Name = "lstErrors";
            this.lstErrors.Size = new System.Drawing.Size(100, 134);
            this.lstErrors.TabIndex = 34;
            this.lstErrors.DoubleClick += new System.EventHandler(this.MatchImage_DoubleClick);
            // 
            // lbMatchList
            // 
            this.lbMatchList.FormattingEnabled = true;
            this.lbMatchList.Location = new System.Drawing.Point(557, 70);
            this.lbMatchList.Name = "lbMatchList";
            this.lbMatchList.Size = new System.Drawing.Size(125, 134);
            this.lbMatchList.TabIndex = 35;
            this.lbMatchList.DoubleClick += new System.EventHandler(this.MatchImage_DoubleClick);
            // 
            // nupConfidence
            // 
            this.nupConfidence.Location = new System.Drawing.Point(453, 306);
            this.nupConfidence.Name = "nupConfidence";
            this.nupConfidence.Size = new System.Drawing.Size(80, 20);
            this.nupConfidence.TabIndex = 36;
            this.nupConfidence.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(342, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Confidence Threshold";
            // 
            // lstLexicon
            // 
            this.lstLexicon.FormattingEnabled = true;
            this.lstLexicon.Location = new System.Drawing.Point(113, 495);
            this.lstLexicon.Name = "lstLexicon";
            this.lstLexicon.Size = new System.Drawing.Size(100, 134);
            this.lstLexicon.TabIndex = 38;
            this.lstLexicon.DoubleClick += new System.EventHandler(this.MatchImage_DoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(110, 481);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "with lexicon";
            // 
            // lblLexiconCount
            // 
            this.lblLexiconCount.AutoSize = true;
            this.lblLexiconCount.Location = new System.Drawing.Point(110, 634);
            this.lblLexiconCount.Name = "lblLexiconCount";
            this.lblLexiconCount.Size = new System.Drawing.Size(13, 13);
            this.lblLexiconCount.TabIndex = 40;
            this.lblLexiconCount.Text = "0";
            // 
            // lblNrWords
            // 
            this.lblNrWords.AutoSize = true;
            this.lblNrWords.Location = new System.Drawing.Point(671, 219);
            this.lblNrWords.Name = "lblNrWords";
            this.lblNrWords.Size = new System.Drawing.Size(13, 13);
            this.lblNrWords.TabIndex = 41;
            this.lblNrWords.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(555, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "# Licenseplates";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(555, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "# Unique";
            // 
            // chkUseLexicon
            // 
            this.chkUseLexicon.AutoSize = true;
            this.chkUseLexicon.Enabled = false;
            this.chkUseLexicon.Location = new System.Drawing.Point(453, 332);
            this.chkUseLexicon.Name = "chkUseLexicon";
            this.chkUseLexicon.Size = new System.Drawing.Size(85, 17);
            this.chkUseLexicon.TabIndex = 44;
            this.chkUseLexicon.Text = "Use Lexicon";
            this.chkUseLexicon.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 688);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "Last Error";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(102, 390);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(96, 25);
            this.lblResult.TabIndex = 46;
            this.lblResult.Text = "XXXXXX";
            // 
            // lblResultCapt
            // 
            this.lblResultCapt.AutoSize = true;
            this.lblResultCapt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultCapt.Location = new System.Drawing.Point(6, 390);
            this.lblResultCapt.Name = "lblResultCapt";
            this.lblResultCapt.Size = new System.Drawing.Size(73, 25);
            this.lblResultCapt.TabIndex = 47;
            this.lblResultCapt.Text = "Result";
            // 
            // lblLexiconCapt
            // 
            this.lblLexiconCapt.AutoSize = true;
            this.lblLexiconCapt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLexiconCapt.Location = new System.Drawing.Point(6, 415);
            this.lblLexiconCapt.Name = "lblLexiconCapt";
            this.lblLexiconCapt.Size = new System.Drawing.Size(87, 25);
            this.lblLexiconCapt.TabIndex = 48;
            this.lblLexiconCapt.Text = "Lexicon";
            // 
            // lblError1
            // 
            this.lblError1.AutoSize = true;
            this.lblError1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError1.Location = new System.Drawing.Point(300, 390);
            this.lblError1.Name = "lblError1";
            this.lblError1.Size = new System.Drawing.Size(24, 25);
            this.lblError1.TabIndex = 50;
            this.lblError1.Text = "0";
            // 
            // lblError2
            // 
            this.lblError2.AutoSize = true;
            this.lblError2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError2.Location = new System.Drawing.Point(355, 390);
            this.lblError2.Name = "lblError2";
            this.lblError2.Size = new System.Drawing.Size(24, 25);
            this.lblError2.TabIndex = 52;
            this.lblError2.Text = "0";
            // 
            // lblError3
            // 
            this.lblError3.AutoSize = true;
            this.lblError3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError3.Location = new System.Drawing.Point(410, 390);
            this.lblError3.Name = "lblError3";
            this.lblError3.Size = new System.Drawing.Size(24, 25);
            this.lblError3.TabIndex = 54;
            this.lblError3.Text = "0";
            // 
            // lblError4
            // 
            this.lblError4.AutoSize = true;
            this.lblError4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError4.Location = new System.Drawing.Point(465, 390);
            this.lblError4.Name = "lblError4";
            this.lblError4.Size = new System.Drawing.Size(24, 25);
            this.lblError4.TabIndex = 56;
            this.lblError4.Text = "0";
            // 
            // lblError5
            // 
            this.lblError5.AutoSize = true;
            this.lblError5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError5.Location = new System.Drawing.Point(520, 390);
            this.lblError5.Name = "lblError5";
            this.lblError5.Size = new System.Drawing.Size(24, 25);
            this.lblError5.TabIndex = 58;
            this.lblError5.Text = "0";
            // 
            // lblConfidence
            // 
            this.lblConfidence.AutoSize = true;
            this.lblConfidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfidence.Location = new System.Drawing.Point(204, 390);
            this.lblConfidence.Name = "lblConfidence";
            this.lblConfidence.Size = new System.Drawing.Size(24, 25);
            this.lblConfidence.TabIndex = 59;
            this.lblConfidence.Text = "0";
            // 
            // lblLexiconConfidence
            // 
            this.lblLexiconConfidence.AutoSize = true;
            this.lblLexiconConfidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLexiconConfidence.Location = new System.Drawing.Point(204, 415);
            this.lblLexiconConfidence.Name = "lblLexiconConfidence";
            this.lblLexiconConfidence.Size = new System.Drawing.Size(24, 25);
            this.lblLexiconConfidence.TabIndex = 60;
            this.lblLexiconConfidence.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(206, 377);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 13);
            this.label22.TabIndex = 61;
            this.label22.Text = "Confidence";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(298, 377);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(38, 13);
            this.label24.TabIndex = 62;
            this.label24.Text = "Error 1";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(353, 377);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(38, 13);
            this.label26.TabIndex = 63;
            this.label26.Text = "Error 2";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(408, 377);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(38, 13);
            this.label27.TabIndex = 64;
            this.label27.Text = "Error 3";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(463, 377);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(38, 13);
            this.label28.TabIndex = 65;
            this.label28.Text = "Error 4";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(518, 377);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(38, 13);
            this.label29.TabIndex = 66;
            this.label29.Text = "Error 5";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(573, 377);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(38, 13);
            this.label30.TabIndex = 68;
            this.label30.Text = "Error 6";
            // 
            // lblError6
            // 
            this.lblError6.AutoSize = true;
            this.lblError6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError6.Location = new System.Drawing.Point(575, 390);
            this.lblError6.Name = "lblError6";
            this.lblError6.Size = new System.Drawing.Size(24, 25);
            this.lblError6.TabIndex = 67;
            this.lblError6.Text = "0";
            // 
            // lblExpectedCaption
            // 
            this.lblExpectedCaption.AutoSize = true;
            this.lblExpectedCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpectedCaption.Location = new System.Drawing.Point(6, 441);
            this.lblExpectedCaption.Name = "lblExpectedCaption";
            this.lblExpectedCaption.Size = new System.Drawing.Size(102, 25);
            this.lblExpectedCaption.TabIndex = 69;
            this.lblExpectedCaption.Text = "Expected";
            // 
            // lblExpected
            // 
            this.lblExpected.AutoSize = true;
            this.lblExpected.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpected.Location = new System.Drawing.Point(102, 441);
            this.lblExpected.Name = "lblExpected";
            this.lblExpected.Size = new System.Drawing.Size(96, 25);
            this.lblExpected.TabIndex = 70;
            this.lblExpected.Text = "XXXXXX";
            // 
            // lstRectifyPlateErr
            // 
            this.lstRectifyPlateErr.FormattingEnabled = true;
            this.lstRectifyPlateErr.Location = new System.Drawing.Point(331, 495);
            this.lstRectifyPlateErr.Name = "lstRectifyPlateErr";
            this.lstRectifyPlateErr.Size = new System.Drawing.Size(100, 134);
            this.lstRectifyPlateErr.TabIndex = 71;
            this.lstRectifyPlateErr.DoubleClick += new System.EventHandler(this.MatchImage_DoubleClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(328, 467);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 72;
            this.label14.Text = "FindCharacters ( )";
            // 
            // lblRectfyPlateErrCount
            // 
            this.lblRectfyPlateErrCount.AutoSize = true;
            this.lblRectfyPlateErrCount.Location = new System.Drawing.Point(328, 634);
            this.lblRectfyPlateErrCount.Name = "lblRectfyPlateErrCount";
            this.lblRectfyPlateErrCount.Size = new System.Drawing.Size(13, 13);
            this.lblRectfyPlateErrCount.TabIndex = 73;
            this.lblRectfyPlateErrCount.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(228, 480);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 74;
            this.label15.Text = "Returns false";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(328, 480);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 75;
            this.label16.Text = "Returns false";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(429, 480);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 13);
            this.label17.TabIndex = 76;
            this.label17.Text = "Returns false";
            // 
            // btnExportMatched
            // 
            this.btnExportMatched.Location = new System.Drawing.Point(16, 648);
            this.btnExportMatched.Name = "btnExportMatched";
            this.btnExportMatched.Size = new System.Drawing.Size(75, 23);
            this.btnExportMatched.TabIndex = 77;
            this.btnExportMatched.Text = "Export files";
            this.btnExportMatched.UseVisualStyleBackColor = true;
            this.btnExportMatched.Click += new System.EventHandler(this.btnExportMatched_Click);
            // 
            // btnExportMatchedLexicon
            // 
            this.btnExportMatchedLexicon.Location = new System.Drawing.Point(113, 648);
            this.btnExportMatchedLexicon.Name = "btnExportMatchedLexicon";
            this.btnExportMatchedLexicon.Size = new System.Drawing.Size(75, 23);
            this.btnExportMatchedLexicon.TabIndex = 78;
            this.btnExportMatchedLexicon.Text = "Export files";
            this.btnExportMatchedLexicon.UseVisualStyleBackColor = true;
            this.btnExportMatchedLexicon.Click += new System.EventHandler(this.btnExportMatchedLexicon_Click);
            // 
            // btnExportFindPlate
            // 
            this.btnExportFindPlate.Location = new System.Drawing.Point(231, 648);
            this.btnExportFindPlate.Name = "btnExportFindPlate";
            this.btnExportFindPlate.Size = new System.Drawing.Size(75, 23);
            this.btnExportFindPlate.TabIndex = 79;
            this.btnExportFindPlate.Text = "Export files";
            this.btnExportFindPlate.UseVisualStyleBackColor = true;
            this.btnExportFindPlate.Click += new System.EventHandler(this.btnExportFindPlate_Click);
            // 
            // bntExportFindCharacters
            // 
            this.bntExportFindCharacters.Location = new System.Drawing.Point(331, 648);
            this.bntExportFindCharacters.Name = "bntExportFindCharacters";
            this.bntExportFindCharacters.Size = new System.Drawing.Size(75, 23);
            this.bntExportFindCharacters.TabIndex = 80;
            this.bntExportFindCharacters.Text = "Export files";
            this.bntExportFindCharacters.UseVisualStyleBackColor = true;
            this.bntExportFindCharacters.Click += new System.EventHandler(this.bntExportFindCharacters_Click);
            // 
            // btnExportMatchPlate
            // 
            this.btnExportMatchPlate.Location = new System.Drawing.Point(432, 648);
            this.btnExportMatchPlate.Name = "btnExportMatchPlate";
            this.btnExportMatchPlate.Size = new System.Drawing.Size(75, 23);
            this.btnExportMatchPlate.TabIndex = 81;
            this.btnExportMatchPlate.Text = "Export files";
            this.btnExportMatchPlate.UseVisualStyleBackColor = true;
            this.btnExportMatchPlate.Click += new System.EventHandler(this.btnExportMatchPlate_Click);
            // 
            // btnExportLowConfidence
            // 
            this.btnExportLowConfidence.Location = new System.Drawing.Point(552, 648);
            this.btnExportLowConfidence.Name = "btnExportLowConfidence";
            this.btnExportLowConfidence.Size = new System.Drawing.Size(75, 23);
            this.btnExportLowConfidence.TabIndex = 82;
            this.btnExportLowConfidence.Text = "Export files";
            this.btnExportLowConfidence.UseVisualStyleBackColor = true;
            this.btnExportLowConfidence.Click += new System.EventHandler(this.btnExportLowConfidence_Click);
            // 
            // btnExportErrors
            // 
            this.btnExportErrors.Location = new System.Drawing.Point(652, 648);
            this.btnExportErrors.Name = "btnExportErrors";
            this.btnExportErrors.Size = new System.Drawing.Size(75, 23);
            this.btnExportErrors.TabIndex = 83;
            this.btnExportErrors.Text = "Export files";
            this.btnExportErrors.UseVisualStyleBackColor = true;
            this.btnExportErrors.Click += new System.EventHandler(this.btnExportErrors_Click);
            // 
            // lblFolder
            // 
            this.lblFolder.Location = new System.Drawing.Point(595, 41);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(157, 26);
            this.lblFolder.TabIndex = 84;
            this.lblFolder.Text = "<none>";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(555, 41);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 13);
            this.label18.TabIndex = 85;
            this.label18.Text = "Folder:";
            // 
            // chkUseScripts
            // 
            this.chkUseScripts.AutoSize = true;
            this.chkUseScripts.Checked = true;
            this.chkUseScripts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseScripts.Location = new System.Drawing.Point(558, 332);
            this.chkUseScripts.Name = "chkUseScripts";
            this.chkUseScripts.Size = new System.Drawing.Size(80, 17);
            this.chkUseScripts.TabIndex = 86;
            this.chkUseScripts.Text = "Use Scripts";
            this.chkUseScripts.UseVisualStyleBackColor = true;
            this.chkUseScripts.CheckedChanged += new System.EventHandler(this.chkUseScripts_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 719);
            this.Controls.Add(this.chkUseScripts);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.btnExportErrors);
            this.Controls.Add(this.btnExportLowConfidence);
            this.Controls.Add(this.btnExportMatchPlate);
            this.Controls.Add(this.bntExportFindCharacters);
            this.Controls.Add(this.btnExportFindPlate);
            this.Controls.Add(this.btnExportMatchedLexicon);
            this.Controls.Add(this.btnExportMatched);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblRectfyPlateErrCount);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lstRectifyPlateErr);
            this.Controls.Add(this.lblExpected);
            this.Controls.Add(this.lblExpectedCaption);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.lblError6);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lblLexiconConfidence);
            this.Controls.Add(this.lblConfidence);
            this.Controls.Add(this.lblError5);
            this.Controls.Add(this.lblError4);
            this.Controls.Add(this.lblError3);
            this.Controls.Add(this.lblError2);
            this.Controls.Add(this.lblError1);
            this.Controls.Add(this.lblLexiconCapt);
            this.Controls.Add(this.lblResultCapt);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.chkUseLexicon);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblNrWords);
            this.Controls.Add(this.lblLexiconCount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lstLexicon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nupConfidence);
            this.Controls.Add(this.lbMatchList);
            this.Controls.Add(this.lstErrors);
            this.Controls.Add(this.lstLowConfidence);
            this.Controls.Add(this.lstMatchPlateErr);
            this.Controls.Add(this.lstFindPlateErr);
            this.Controls.Add(this.lstMatched);
            this.Controls.Add(this.ErrorTB);
            this.Controls.Add(this.btnReloadBblobMatcher);
            this.Controls.Add(this.imgPlateBin);
            this.Controls.Add(this.lblLexiconResult);
            this.Controls.Add(this.lblMatchList);
            this.Controls.Add(this.lblErrorsCount);
            this.Controls.Add(this.lblLowConfidenceCount);
            this.Controls.Add(this.lblMatchPlateErrCount);
            this.Controls.Add(this.lblFindPlateErrCount);
            this.Controls.Add(this.lblMatchedCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.imgRectifiedPlate);
            this.Controls.Add(this.btnLoadFromFolder);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgOrig);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plate Matcher";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgOrig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRectifiedPlate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlateBin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupConfidence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgOrig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnLoadFromFolder;
        private System.Windows.Forms.PictureBox imgRectifiedPlate;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMatchedCount;
        private System.Windows.Forms.Label lblFindPlateErrCount;
        private System.Windows.Forms.Label lblMatchPlateErrCount;
        private System.Windows.Forms.Label lblLowConfidenceCount;
        private System.Windows.Forms.Label lblErrorsCount;
        private System.Windows.Forms.Label lblMatchList;
        private System.Windows.Forms.Label lblLexiconResult;
        private System.Windows.Forms.PictureBox imgPlateBin;
        private System.Windows.Forms.Button btnReloadBblobMatcher;
        private System.Windows.Forms.TextBox ErrorTB;
        private System.Windows.Forms.ListBox lstMatched;
        private System.Windows.Forms.ListBox lstFindPlateErr;
        private System.Windows.Forms.ListBox lstMatchPlateErr;
        private System.Windows.Forms.ListBox lstLowConfidence;
        private System.Windows.Forms.ListBox lstErrors;
        private System.Windows.Forms.ListBox lbMatchList;
        private System.Windows.Forms.NumericUpDown nupConfidence;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstLexicon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblLexiconCount;
        private System.Windows.Forms.Label lblNrWords;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chkUseLexicon;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblResultCapt;
        private System.Windows.Forms.Label lblLexiconCapt;
        private System.Windows.Forms.Label lblError1;
        private System.Windows.Forms.Label lblError2;
        private System.Windows.Forms.Label lblError3;
        private System.Windows.Forms.Label lblError4;
        private System.Windows.Forms.Label lblError5;
        private System.Windows.Forms.Label lblConfidence;
        private System.Windows.Forms.Label lblLexiconConfidence;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblError6;
        private System.Windows.Forms.Label lblExpectedCaption;
        private System.Windows.Forms.Label lblExpected;
        private System.Windows.Forms.ListBox lstRectifyPlateErr;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblRectfyPlateErrCount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnExportMatched;
        private System.Windows.Forms.Button btnExportMatchedLexicon;
        private System.Windows.Forms.Button btnExportFindPlate;
        private System.Windows.Forms.Button bntExportFindCharacters;
        private System.Windows.Forms.Button btnExportMatchPlate;
        private System.Windows.Forms.Button btnExportLowConfidence;
        private System.Windows.Forms.Button btnExportErrors;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox chkUseScripts;
    }
}

