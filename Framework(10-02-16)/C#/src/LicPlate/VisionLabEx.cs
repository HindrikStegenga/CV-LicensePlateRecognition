using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LicPlate {
    public class VisionLabEx
    {

        [DllImport("msvcrt.dll", EntryPoint = "memcpy", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static unsafe extern IntPtr CopyMemory(IntPtr pDest, IntPtr pSrc, ulong length);

        public static RGB888Image BitmapToJL(Bitmap bm)
        {
            RGB888Image vlimage;
            BitmapData bmdata = bm.LockBits(new Rectangle(0, 0, bm.Width, bm.Height), System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            try
            {
                vlimage = new RGB888Image(bmdata.Height, bm.Width);
                ulong len = (ulong)bm.Width * (ulong)bm.Height * 4;
                CopyMemory(vlimage.GetBufPtr(), bmdata.Scan0, len);
            }
            finally
            {
                bm.UnlockBits(bmdata);
            }
            return vlimage;
        }

        public static Bitmap JLToBitmap(Image img)
        {
            Bitmap bm = new Bitmap(img.GetWidth(), img.GetHeight(), PixelFormat.Format32bppRgb);
            BitmapData bmdata = bm.LockBits(new Rectangle(0, 0, bm.Width, bm.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppRgb);
            try
            {
                RGB888Image vlimage = new RGB888Image();
                VisionLab.Convert(img, vlimage);
                ulong len = (ulong)vlimage.GetWidth() * (ulong)vlimage.GetHeight() * 4;
                CopyMemory(bmdata.Scan0, vlimage.GetBufPtr(), len);
                vlimage.Dispose();
            }
            finally
            {
                bm.UnlockBits(bmdata);
            }
            return bm;
        }

        public static vector_LetterMatch PatternMatchResultToLetterMatch(vector_PatternMatchResult vpmr)
        {
            vector_LetterMatch ret = new vector_LetterMatch();
            for (int i = 0; i < vpmr.Count; i++)
            {
                ret.Add(PatternMatchResultToLetterMatch(vpmr[i]));
            }
            return ret;
        }

        public static LetterMatch PatternMatchResultToLetterMatch(PatternMatchResult pmr)
        {
            return new LetterMatch(pmr.id, pmr.error);
        }

        public static void DisplayImage(Image img, PictureBox pb) { DisplayImage(img, pb, false, false); }
        public static void DisplayImage(Image img, PictureBox pb, bool stretch) { DisplayImage(img, pb, stretch, false); }
        public static void DisplayImage(Image img, PictureBox pb, bool stretch, bool invert)
        {
            Bitmap bm;
            if (img is Int32Image)
            {
                Int32Image disp = new Int32Image((Int32Image)img);
                if (invert)
                    VisionLab.Not((Int32Image)disp);
                if (stretch)
                    VisionLab.Multiply((Int32Image)disp, 255);

                bm = VisionLabEx.JLToBitmap(disp);
                disp.Dispose();
            }
            else
                bm = VisionLabEx.JLToBitmap(img);

            if (pb.Image != null)
            {
                pb.Image.Dispose();
            }
            pb.Image = bm;
        }

        public static void GetBlobsInfo(Image binaryImage, vector_BlobAnalyse analysis, ref vector_Blob blobs)
        {
            Int32Image labeledBinaryImage = new Int32Image();
            VisionLab.Convert(binaryImage, labeledBinaryImage);
            int maxlabel = VisionLab.LabelBlobs(labeledBinaryImage, Connected.EightConnected);
            VisionLab.BlobAnalysis(labeledBinaryImage, VisionLab.VectorToSet_BlobAnalyse(analysis), maxlabel, blobs);
            labeledBinaryImage.Dispose();
            //GC.Collect();
        }
    }
}