using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp7.Properties;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        double calculateBMI(double height, double weight)
        {
            double bmi = weight / (height * height);
            return bmi;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void CALCULATE_Click(object sender, EventArgs e)
        {
            try
            {
                double height = double.Parse(txtHeight.Text);
                double weight = double.Parse(txtWeight.Text);
                double bmi = calculateBMI(height, weight);

                lblBMI.Text = bmi.ToString();

                if (bmi < 18.5)
                {
                    lblRemarks.Text = "Underweight";
                    pbxBMI.Image = Resources.lotus;
                } else if (bmi >= 18.5 && bmi <= 24.9)
                {
                    lblRemarks.Text = "Normal";
                    pbxBMI.Image = Resources.normal;
                } else if (bmi >= 25 && bmi <= 29.5)
                {
                    lblRemarks.Text = "Overweight";
                    pbxBMI.Image = Resources.overweight;
                } else if (bmi > 30)
                {
                    lblRemarks.Text = "Obese";
                    pbxBMI.Image = Resources.obese;
                }



            } catch (Exception ex)
            {
                MessageBox.Show("Invalid Height or Weight");
            }
           
        }
    }
}
