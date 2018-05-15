using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Calculator;

namespace OhmValCalc
{
   
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        protected IOhmValueCalculator _ohmValueCalculator;
        protected int _ohmValue;

        public MainWindow()
        {
            _ohmValue = 0;
            _ohmValueCalculator = new OhmValueCalculator();            

            InitializeComponent();

            textBoxOhmValue.Text = string.Empty;
            comboBandD.SelectedIndex = 0;
        }

        private void buttonCalculate_Click(object sender, RoutedEventArgs e)
        {
            if ((comboBandA.SelectedItem == null) || (comboBandA.SelectedItem == null) || (comboBandA.SelectedItem == null))
            {
                MessageBox.Show("Please select colors for Bands A, B and C");
                return;
            }

            string bandAColor = ((KeyValuePair<string,int>)comboBandA.SelectedItem).Key;
            string bandBColor = ((KeyValuePair<string, int>)comboBandB.SelectedItem).Key;
            string bandCColor = ((KeyValuePair<string, string>)comboBandC.SelectedItem).Key;
            string bandDColor = ((KeyValuePair<string, double>)comboBandD.SelectedItem).Key;

            _ohmValue = _ohmValueCalculator.CalculateOhmValue(bandAColor, bandBColor, bandCColor, bandDColor);            

            double tolValue = ((KeyValuePair<string, double>)comboBandD.SelectedItem).Value;
           
            string unitValue = ((OhmValueCalculator)_ohmValueCalculator).UnitValue;
            textBoxOhmValue.Text = string.Format("{0} {1}. Tolerance: +/- {2}. ", (((KeyValuePair<string, string>)comboBandC.SelectedItem).Value.Contains(".")) ? ((OhmValueCalculator)_ohmValueCalculator).ActualValue:_ohmValue,
                                                    (string.IsNullOrEmpty(unitValue)? "ohms" : unitValue + " ohms"),tolValue);            
        }

        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }        
    }
}
