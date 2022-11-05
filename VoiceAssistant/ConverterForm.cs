using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Configuration;

namespace VoiceAssistant
{
    public partial class ConverterForm : Form
    {
        Dictionary<String, double> data = new Dictionary<string, double>();
        bool temperature;
        public ConverterForm()
        {
            InitializeComponent();
        }

        private void ConverterForm_Load(object sender, EventArgs e)
        {
            ReadUnits(@"Units.txt");
            if (Properties.Settings.Default.Theme) { 
            this.BackColor = Color.FromArgb(34, 34, 34);
            this.ForeColor = Color.Bisque;
            this.UnitComboBox.BackColor = Color.FromArgb(51, 78, 108);
            this.FirstValComboBox.BackColor = Color.FromArgb(51, 78, 108);
            this.SecondValComboBox.BackColor = Color.FromArgb(51, 78, 108);
            this.InputToTxtBox.BackColor = Color.FromArgb(72, 101, 129);
            this.InputFromTxtBox.BackColor = Color.FromArgb(72, 101, 129);
            }
        }

        private void UnitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            temperature = false;
            InputFromTxtBox.ReadOnly = true;
            FirstValComboBox.Items.Clear();
            SecondValComboBox.Items.Clear();
            FirstValComboBox.Text = "";
            SecondValComboBox.Text = "";
            InputFromTxtBox.Text = "";
            InputToTxtBox.Text = "";
            if (UnitComboBox.Text == "Time")
            {
                string[] values = { "seconds", "minutes", "hours", "days", "years" };
                FirstValComboBox.Items.AddRange(values);
                SecondValComboBox.Items.AddRange(values);

            }
            else if (UnitComboBox.Text == "Distance")
            {
                string[] values = { "meters", "kilometers", "centimeters", "inches", "feet", "yards", "miles"};
                FirstValComboBox.Items.AddRange(values);
                SecondValComboBox.Items.AddRange(values);
            }
            else if (UnitComboBox.Text == "Mass")
            {
                string[] values = { "kilograms", "grams", "tons", "ounces", "pounds", "stones"};
                FirstValComboBox.Items.AddRange(values);
                SecondValComboBox.Items.AddRange(values);
            }
            else if (UnitComboBox.Text == "Temperature")
            {
                temperature = true;
                string[] values = { "°C", "°F", "K"};
                FirstValComboBox.Items.AddRange(values);
                SecondValComboBox.Items.AddRange(values);
            }
            else if (UnitComboBox.Text == "Currency")
            {
                string[] values = { "AUD", "BGN", "BRL", "CAD", "CHF", "CNY", "CZK", "DKK", "EUR", "GBP", "HKD", "HRK", "HUF",
                 "IDR", "ILS", "INR", "ISK", "JPY", "KRW", "MXN", "MYR" , "NOK", "NZD", "PHP" , "PLN", "RON", "RUB", "SEK" , "SGD",
                "THB", "TRY", "USD", "ZAR",};
                FirstValComboBox.Items.AddRange(values);
                SecondValComboBox.Items.AddRange(values);

            }
        }

        private void FirstValComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SecondValComboBox.Text != "")
            {
                InputFromTxtBox.ReadOnly = false;
                InputFromTxtBox_TextChanged(sender, e);
            }
        }

        private void SecondValComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FirstValComboBox.Text != "")
            {
                InputFromTxtBox.ReadOnly = false;
                InputFromTxtBox_TextChanged(sender, e);
            }
        }

        private void Calculate(string input, string output)
        {
            double total = double.Parse(InputFromTxtBox.Text);
            double inVal, outVal;
            data.TryGetValue(input,out inVal);
            data.TryGetValue(output, out outVal);
            total = total * inVal / outVal;
            InputToTxtBox.Text = total.ToString("F2");
        }
        
        private void ReadUnits(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName, Encoding.UTF8);
            foreach(string line in lines)
            {
                string[] values = line.Split(' ');
                string unit = values[0];
                double value = double.Parse(values[1], CultureInfo.InvariantCulture);
                data.Add(unit, value);
            }
        }

        private void InputFromTxtBox_TextChanged(object sender, EventArgs e)
        {
            double value;
            if (Double.TryParse(InputFromTxtBox.Text,out value) && value >=0 && !temperature)
            {
                Calculate(FirstValComboBox.Text, SecondValComboBox.Text);
            }
            else if(Double.TryParse(InputFromTxtBox.Text, out value) && temperature)
            {
                switch (FirstValComboBox.Text)
                {
                    case "°C":
                        value = value + 273.15;
                        break;
                    case "°F":
                        value = (value - 32) / 1.8 + 273.15;
                        break;
                }
                switch (SecondValComboBox.Text)
                {
                    case "°C":
                        value = value - 273.15;
                        break;
                    case "°F":
                        value = (value - 273.15) * 1.8 + 32;
                        break;
                }
                InputToTxtBox.Text = value.ToString("F2");
            }
            else
            {
                InputToTxtBox.Text = "-";
            }
        }

    }
}
