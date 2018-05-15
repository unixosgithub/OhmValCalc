Hello,

I used the information from the Wikipedia page to implement the CalculateOhmValue method.
The OhmValueCalc solution was created using Visual Studio 2015. It has 3 projects.

1. Calculator: A DLL class library that implements the CalculateOhmValue method provided in the interface.

2. OhmValCalc: A WPF application that uses the "Calculator" project to perform the actual calculation.

3. TestOhmValueCalc: A Test application that tests the CalculateOhmValue method in the Calculator project created in Step (1).
   The tests were written using the VisualStudio Test Framework. Once you build the project you can run test right inside the
   Visual Studio 2015.
   
NOTE: The return value type (int) provided in the signature of the CalculateOhmValue method in the interface doesn't work well for calculating all the color cases. Some of the Multipler (BandCColor) values are decimal, those Multiplier values when used in the calculation will produce a "real" (decimal) number. To accomodate those cases, I have an additional "_actualOhmValue" member in the Calculator project. The ActualValue property can be used to get that "_actualOhmValue" value.


Thank You.
Mohammed Ali.

