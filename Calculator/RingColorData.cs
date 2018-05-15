using System;
using System.Collections.Generic;

namespace Calculator
{    
    public class BandColors
    {
        public static Dictionary<string, int> GetBandColors()
        {
            Dictionary<string, int> BandColorsDict = new Dictionary<string, int>();

            BandColorsDict.Add("Black", 0);
            BandColorsDict.Add("Brown", 1);
            BandColorsDict.Add("Red", 2);
            BandColorsDict.Add("Orange", 3);
            BandColorsDict.Add("Yellow", 4);
            BandColorsDict.Add("Green", 5);
            BandColorsDict.Add("Blue", 6);
            BandColorsDict.Add("Violet", 7);
            BandColorsDict.Add("Gray", 8);
            BandColorsDict.Add("White", 9);

            return BandColorsDict;
        }
    }

    public class Multipliers
    {
        //Dictionary values are ":" delimited (value and unit)
        public static Dictionary<string, string> GetMultipliers()
        {
            Dictionary<string, string> MultipliersDict = new Dictionary<string, string>();

            MultipliersDict.Add("Silver", "0.01:");
            MultipliersDict.Add("Gold", "0.1:");
            MultipliersDict.Add("Black", "1:");
            MultipliersDict.Add("Brown", "10:");
            MultipliersDict.Add("Red", "100:");
            MultipliersDict.Add("Orange", "1:K");
            MultipliersDict.Add("Yellow", "10:K");
            MultipliersDict.Add("Green", "100:K");
            MultipliersDict.Add("Blue", "1:M");
            MultipliersDict.Add("Violet", "10:M");
            MultipliersDict.Add("Gray", "100:M");
            MultipliersDict.Add("White", "1:G");

            return MultipliersDict;
        }
    }

    public class Tolerance
    {
        public static Dictionary<string,double> GetTolerance()
        {
            Dictionary<string, double> ToleranceDict = new Dictionary<string, double>();

            ToleranceDict.Add("None", 20);
            ToleranceDict.Add("Pink	", 0);
            ToleranceDict.Add("Silver", 10);
            ToleranceDict.Add("Gold", 5);
            ToleranceDict.Add("Black", 0);
            ToleranceDict.Add("Brown", 1);
            ToleranceDict.Add("Red", 2);
            ToleranceDict.Add("Orange", 0);
            ToleranceDict.Add("Yellow", 5);
            ToleranceDict.Add("Green", 0.5);
            ToleranceDict.Add("Blue", 0.25);
            ToleranceDict.Add("Violet", 0.1);
            ToleranceDict.Add("Gray", 0.05);
            ToleranceDict.Add("White", 0);

            return ToleranceDict;
        }
    }
}
