using System;
using System.Collections.Generic;

namespace LicPlate
{
    public class LicenseCharacter
    {
        private string chr;
        private double err;
        private double conf;
        public string character
        {
            get
            {
                return chr;
            }
            set
            {
                chr = value;
            }
        }
        public double error
        {
            get
            {
                return err;
            }
            set
            {
                err = value;
            }
        }
        public double confidence
        {
            get
            {
                return conf;
            }
            set
            {
                conf = value;
            }
        }
        public new string ToString()
        {
            return chr.ToString() + " " + Math.Round(err, 2).ToString();
        }

        public LicenseCharacter(string character) : this(character, -1) { }
        public LicenseCharacter(string character, double error) : this(character, -1, -1) { }
        public LicenseCharacter(string character, double error, double confidence)
        {
            chr = character;
            err = error;
            conf = confidence;
        }
    }

    public class LicensePlate
    {
        private double conf;
        private List<LicenseCharacter> chars;
        public LicensePlate()
        {
            confidence = -1;
            chars = new List<LicenseCharacter>();
        }
        private double getSmallestConfidence()
        {
            double min = double.MaxValue;
            for (int i = 0; i < chars.Count; i++)
            {
                if (chars[i].confidence < min)
                {
                    min = chars[i].confidence;
                }
            }
            return min;
        }
        public double confidence
        {
            get
            {
                if (conf != -1)
                {
                    return conf;
                }
                else
                {
                    return getSmallestConfidence();
                }
            }
            set
            {
                conf = value;
            }
        }
        public List<LicenseCharacter> characters
        {
            get
            {
                return chars;
            }
        }

        public new string ToString()
        {
            return getLicensePlateString() + " " + Math.Round(confidence, 2).ToString() + " " + getLicensePlateErrorsString();
        }

        public string getLicensePlateErrorsString()
        {
            string res = "";
            foreach (LicenseCharacter c in characters)
            {
                res = res + " " + Math.Round(c.error, 2).ToString();
            }
            return res.Trim();
        }

        public string getLicensePlateString()
        {
            string res = "";
            foreach (LicenseCharacter c in characters)
            {
                res = res + c.character;
            }
            return res;
        }
    }
}