using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace LicPlate
{
    class LicensePlateMatcherScript
    {
        static VisLibCmdInt cmdInt = null;
        /*  
         *  Description:
         *     - Initialize command interpreter
         *     - add BlobMatcher
         *     - Add Scripts
         */
        public static void Init()
        {
            try
            {
                if (cmdInt == null)
                    cmdInt = VisionLab.VisLibCmdIntCreate(100000, EchoMode.EchoOff, false);
                String exePath = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
                String result;
                result = cmdInt.ExecRequest("PM_ReadFromFile PatternMatcher " + exePath + "\\..\\..\\..\\..\\..\\..\\VL\\lic_fonts.pm");
                result = cmdInt.ExecRequest("AddScript FindPlate " + exePath + "\\..\\..\\..\\..\\..\\..\\VL\\find_plate.jls");
                result = cmdInt.ExecRequest("AddScript FindCharacters " + exePath + "\\..\\..\\..\\..\\..\\..\\VL\\find_characters.jls");
                result = cmdInt.ExecRequest("AddScript MatchPlate " + exePath + "\\..\\..\\..\\..\\..\\..\\VL\\match_plate.jls");
                result = cmdInt.ExecRequest("SetPrecision 6");
            }
            catch (System.Exception ex)
            {
                throw new Exception("Init: " + ex.Message);
            }
        }
        
        /*
         * Description:
         *  Strip timing message {xx us}
         */
        public static String StripTime(String str)
        {
            return (str.Substring(0, str.IndexOf('{')));
        }

        /*
         *  Description:
         *      Find the largest license plate in the image
         *      - Segment using ThresholdHSVchannels
         *      - Remove blobs which are not license plates
         *  Input:
         *      //Original image
         *      RGB888Image plateImage	
         *  Output:
         *      //Segmented license plate
         *      ref Int32Image binaryPlateImage
         *  Return:	
         *      //License plate found?
         *      bool 
         */
        public static bool FindPlate(RGB888Image plateImage, ref Int32Image binaryPlateImage)
        {
            try {
                VisionLab.SetRGB888Image(cmdInt, "plateImage", plateImage);
                String result = StripTime(cmdInt.ExecRequest("icall FindPlate plateImage binaryPlateImage"));
                if (result == "true")
                {
                    VisionLab.GetInt32Image(cmdInt, "binaryPlateImage", binaryPlateImage);
                }
                return (result == "true"); 
            }
            catch (System.Exception ex)
            {
                throw new Exception("FindPlate: " + ex.Message);
            }
        }

        /* 
         *  Description:
         *      Locates the characters of the license plate
         *      - Warp image (Rectify)
         *      - Segment characters
         *      - Remove blobs which are to small (Lines between characters)
         *  Input:
         *      //Original image
         *      RGB888Image plateImage
         *      //Segmented license plate
         *      Int32Image binaryPlateImage
         *      Output:
         *      //Image containing binary six characters	
         *      ref Int32Image binaryCharacterImage 
         *  Return:
         *      //Function executed successfully
         *      bool
         */
        public static bool FindCharacters(RGB888Image plateImage, Int32Image binaryPlateImage, ref Int32Image binaryCharacterImage)
        {
            try
            {
                VisionLab.SetRGB888Image(cmdInt, "plateImage", plateImage);
                VisionLab.SetInt32Image(cmdInt, "binaryPlateImage", binaryPlateImage);
                String result = StripTime(cmdInt.ExecRequest("icall FindCharacters plateImage binaryPlateImage binaryCharacterImage"));
                if (result == "true")
                {
                    VisionLab.GetInt32Image(cmdInt, "binaryCharacterImage", binaryCharacterImage);
                }
                return (result == "true");
            }
            catch (System.Exception ex)
            {
                //if (ex.Message.StartsWith("[DefaultLUTForImage]"))
                //    return false;
                ////if (ex.Message.Substring(0, 6) == "[DefaultLUTForImage]")
                ////    return false;
                throw new Exception("FindCharacters: " + ex.Message);
            }
        }

       /*
        *  Description:
        *      Read the license plate
        *  Input:
        *      //Rectified license plate image containing six characters	
        *      Int32Image labeledRectifiedPlateImage
        *  Output:
        *      //Result by the blob matcher
        *      ref LicensePlate result
        *  Return:
        *      //six characters found
        *      bool 
        */
        public static bool MatchPlate(Int32Image binaryCharacterImage, ref LicensePlate result)
        {
            try
            {
                VisionLab.SetInt32Image(cmdInt, "binaryCharacterImage", binaryCharacterImage);
                String plateStr = StripTime(cmdInt.ExecRequest("icall MatchPlate binaryCharacterImage"));
                if (plateStr.Substring(0, 5) != "false")
                {
                    string[] plateResult = plateStr.Split(' ');
                    string plateResultChars = plateResult[0];
                    result.confidence = double.Parse(plateResult[1], CultureInfo.InvariantCulture);
                    for (int c = 0; c < 6; c++)
                    {
                        result.characters.Add(new LicenseCharacter(plateResultChars[c].ToString(), double.Parse(plateResult[2 + c], CultureInfo.InvariantCulture), result.confidence));
                    }
                    return true;
                }
                else
                    return false;
            }
            catch (System.Exception ex)
            {                
                throw new Exception("MatchPlate: " + ex.Message);
            }
        }

    }
}
