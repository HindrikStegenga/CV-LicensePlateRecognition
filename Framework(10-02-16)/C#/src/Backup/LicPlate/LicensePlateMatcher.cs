using System;

namespace LicPlate
{
    public class LicensePlateMatcher
    {
        /*  Description:
                Find the largest license plate in the image
                    - Segment using ThresholdHSVchannels
                    - Remove blobs which are not license plates
            Input:
	            //Original image
	            RGB888Image plateImage	
            Output:
	            //Segmented license plate
	            ref Int32Image binaryPlateImage
            Return:	
	            //License plate found?
	            bool 
         */	
        public static bool FindPlate(RGB888Image plateImage, ref Int32Image binaryPlateImage)
        {
            //Constants
            const int c_threshold_h_min = 21;
            const int c_threshold_h_max = 50;
            const int c_threshold_s_min = 100;
            const int c_threshold_s_max = 255;
            const int c_threshold_v_min = 100;
            const int c_threshold_v_max = 255;
            const int c_remove_blobs_min = 1;
            const int c_remove_blobs_max = 5000;

            //*******************************//
            //** Exercise:                 **//
            //**   adjust licenseplate     **//
            //**   segmentation            **//
            //*******************************//            
        
            //Find licenseplate
            HSV888Image plateImageHSV = new HSV888Image();
            //Convert to RGB to HSV
            VisionLab.FastRGBToHSV(plateImage, plateImageHSV);

            //Threshold HSV image
            VisionLab.Threshold3Channels(plateImageHSV, binaryPlateImage, c_threshold_h_min, c_threshold_h_max, c_threshold_s_min, c_threshold_s_max, c_threshold_v_min, c_threshold_v_max);
            
            //Remove blobs with small areas
            VisionLab.RemoveBlobs(binaryPlateImage, Connected.EightConnected, BlobAnalyse.BA_Area, c_remove_blobs_min, c_remove_blobs_max);
            
            plateImageHSV.Dispose();
            //GC.Collect();
            //Return true, if pixels found
            return (VisionLab.SumIntPixels(binaryPlateImage) > 0);            
        }

        /*  Description:
                Locates the characters of the license plate
	                - Warp image (Rectify)
	                - Segment characters
	                - Remove blobs which are to small (Lines between characters)
            Input:
	            //Original image
	            RGB888Image plateImage
	            //Segmented license plate
	            Int32Image binaryPlateImage
            Output:
	            //Image containing binary six characters	
	            ref Int32Image binaryCharacterImage 
            Return:
	            //Function executed successfully
	            bool
        */
        public static bool FindCharacters(RGB888Image plateImage, Int32Image binaryPlateImage, ref Int32Image binaryCharacterImage)
        {
            //Constants
            const int c_height = 100;
            const int c_width = 470;
            const int c_remove_blobs_min = 1;
            const int c_remove_blobs_max = 400;

            XYCoord leftTop = new XYCoord();
            XYCoord rightTop = new XYCoord();
            XYCoord leftBottom = new XYCoord();
            XYCoord rightBottom = new XYCoord();


            //Find licenseplate
            VisionLab.FindCornersRectangle(binaryPlateImage, Connected.EightConnected, 0.5, Orientation.Landscape, leftTop, rightTop, leftBottom, rightBottom);

            Int32Image plateImageGray = new Int32Image();
            VisionLab.Convert(plateImage, plateImageGray);

            try
            {
                //Rectify plate
                VisionLab.Warp(plateImageGray, binaryCharacterImage, TransformDirection.ForwardT, new Coord2D(leftTop), new Coord2D(rightTop), new Coord2D(leftBottom), new Coord2D(rightBottom), c_height, c_width, 0);
            }
            catch (Exception )
            {
                //Warp, 3 coords on one line
                return false;
            }
            plateImageGray.Dispose();

            //*******************************//
            //** Exercise:                 **//
            //**   adjust licenseplate     **//
            //**   segmentation            **//
            //*******************************//

            //Find dark text on bright licenseplate using ThresholdISOData
            VisionLab.ThresholdIsoData(binaryCharacterImage, ObjectBrightness.DarkObject);
            
            //Remove blobs connected to the border
            VisionLab.RemoveBorderBlobs(binaryCharacterImage, Connected.EightConnected, Border.AllBorders);
            //Remove small blobs
            VisionLab.RemoveBlobs(binaryCharacterImage, Connected.EightConnected, BlobAnalyse.BA_Area, c_remove_blobs_min, c_remove_blobs_max);

            leftTop.Dispose();
            rightTop.Dispose();
            leftBottom.Dispose();
            rightBottom.Dispose();
            //GC.Collect();
            return true;
        }

        /*
            Description:
                Read the license plate
            Input:
	            //Rectified license plate image containing six characters	
	            Int32Image labeledRectifiedPlateImage
	            BlobMatcher_Int16 matcher	//initialized blobmatcher
	            ClassLexicon lexicon		//initialized lexicon
            Output:
	            //Result by the blob matcher
	            ref LicensePlate result
	            //Result by the lexicon
	            ref LicensePlate lexiconResult
            Return:
	            //six characters found
	        bool 
        */
        public static bool MatchPlate(Int32Image binaryCharacterImage, BlobMatcher_Int16 matcher, ClassLexicon lexicon, ref LicensePlate result, ref LicensePlate lexiconResult)
        {
            //Check if 6 characters/blobs have been found and label image.
            if (VisionLab.LabelBlobs(binaryCharacterImage, Connected.EightConnected) != 6)
                return false;

            //Calculate dimensions and locations of all characters/blobs.
            vector_BlobAnalyse ba_vec = new vector_BlobAnalyse();
            ba_vec.Add(BlobAnalyse.BA_TopLeft);
            ba_vec.Add(BlobAnalyse.BA_Height);
            ba_vec.Add(BlobAnalyse.BA_Width);
            vector_Blob returnBlobs = new vector_Blob();
            VisionLab.BlobAnalysis(binaryCharacterImage, VisionLab.VectorToSet_BlobAnalyse(ba_vec), VisionLab.MaxPixel(binaryCharacterImage), returnBlobs, SortOrder.SortDown, BlobAnalyse.BA_TopLeft, UseXOrY.UseX);
            ba_vec.Dispose();
            Int32Image binaryCharacter = new Int32Image();
            Int16Image binaryCharacter16 = new Int16Image();

            //Create data structure for lexicon.
            vector_vector_LetterMatch match = new vector_vector_LetterMatch();
            
            //Process each character/blob.
            foreach (Blob b in returnBlobs)
            {
                //Cut out character
                VisionLab.ROI(binaryCharacterImage, binaryCharacter, b.TopLeft(), new HeightWidth(b.Height(), b.Width()));
                //Convert ROI result to binary
                VisionLab.ClipPixelValue(binaryCharacter, 0, 1);
                //Calculate character's classification for all classes.
                vector_PatternMatchResult returnMatches = new vector_PatternMatchResult();
                VisionLab.Convert(binaryCharacter, binaryCharacter16); 
                float conf = matcher.AllMatches(binaryCharacter16, (float)-0.5, (float)0.5, returnMatches);
                float err = returnMatches[0].error;
                int id = returnMatches[0].id;
                string chr = matcher.PatternName(id);
                
                //Fill datastructure for lexicon.
                match.Add(VisionLabEx.PatternMatchResultToLetterMatch(returnMatches));
                
                //Store best match in result
                result.characters.Add(new LicenseCharacter(chr, err, conf));
            }

            //Validate match with lexicon.
            vector_int bestWord = new vector_int();
            lexiconResult.confidence = lexicon.FindBestWord(match, bestWord, Optimize.OptimizeForMinimum);
            for (int i = 0; i < bestWord.Count; i++)
            {
                string character = matcher.PatternName(bestWord[i]);
                //Store lexicon result
                lexiconResult.characters.Add(new LicenseCharacter(character));
            }

            binaryCharacter.Dispose();
            binaryCharacter16.Dispose();
            returnBlobs.Dispose();
            match.Dispose();
            bestWord.Dispose();
            //GC.Collect();
            return true;
        }
    }
}

