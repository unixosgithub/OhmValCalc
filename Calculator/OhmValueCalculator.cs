using System;
using System.Collections.Generic;

namespace Calculator
{
    public class OhmValueCalculator : IOhmValueCalculator
    {
        protected Dictionary<string, int> _ringColor;        
        protected Dictionary <string, string> _multiplier;        
        protected Dictionary<string, double> _tolerance;
        protected double _actualOhmValue;        
        protected string _unit;

        public OhmValueCalculator()
        {
            _ringColor = BandColors.GetBandColors();            
            _multiplier = Multipliers.GetMultipliers();
            _tolerance = Tolerance.GetTolerance();

            _actualOhmValue = 0.0;
            _unit = string.Empty;
        }

        public double ActualValue { get { return _actualOhmValue; } }        
        public string UnitValue { get { return _unit; } }

        // Example, a resistor with bands of yellow, violet, red, and gold has first digit 4 (yellow in table below), 
        // second digit 7 (violet), followed by 2 (red) zeroes: 4700 ohms.Gold signifies that the tolerance is ±5%, 
        // so that the resistance could be between 4465 and 4935 ohms.
        // All coded components have at least two value bands and a multiplier; other bands are optional.

        // NOTE: 
        // Assuming that the CalculateOhmValue method returns the ohm Value.
        // The return type in the provided CalculateOhmValue Interface method should have been a "double" instead of an "int" because there are multipliers with 
        // decimal values (for e.g: 0.01 & 0.1). If the multiplier is a decimal value then the result after multiplication can be a decimal value (real number).
        // If that's the case we store the result after multiplication in the _actualOhmValue member variable.
        // The ActualValue property can be used to get the real (decimal) value.
        public int CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
            int ohmValue=0;

            if (string.IsNullOrEmpty(bandAColor) || string.IsNullOrEmpty(bandBColor) || string.IsNullOrEmpty(bandCColor))
                return ohmValue;

            if ((!_ringColor.ContainsKey(bandAColor)) || (!_ringColor.ContainsKey(bandBColor)) || (!_multiplier.ContainsKey(bandCColor)))
                return ohmValue;

            string firstTwoBandValues = _ringColor[bandAColor].ToString() + _ringColor[bandBColor].ToString();

            string strMultiplier = _multiplier[bandCColor];

            string [] valArray = strMultiplier.Split(':');

            if (valArray.Length > 1)
                _unit = valArray[1];

            _actualOhmValue = Math.Round(Int32.Parse(firstTwoBandValues) * (valArray[0].Contains(".") ? Double.Parse(valArray[0]) : Int32.Parse(valArray[0])),2);

            ohmValue = (Int32) ( Int32.Parse(firstTwoBandValues) * (valArray[0].Contains(".") ? Double.Parse(valArray[0]) : Int32.Parse(valArray[0])));

            double tolValue = _tolerance[bandDColor];
            return ohmValue;
        }
    }
}
