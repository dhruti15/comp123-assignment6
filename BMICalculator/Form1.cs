using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void buttonCalculateBMI_Click(object sender, EventArgs e)
        {
            double bmi = 0;
            if(sender==radioButtonImperial)
            {
                double height = Convert.ToDouble(textBoxHeight.Text);
                double weight = Convert.ToDouble(textBoxWeight.Text);
                bmi = 703.0 * weight / height / height;
                textBoxDisplayBMI.Text = bmi.ToString();
                
            }
            if(sender==radioButtonMetric)
            {
                double height = Convert.ToDouble(textBoxHeight.Text);
                double weight = Convert.ToDouble(textBoxWeight.Text);
                bmi =  weight / height / height;
                textBoxDisplayBMI.Text = bmi.ToString();
                
            }
            if (bmi <= 18.5)
            {
                textBoxMultiline.Text = "Underweight";
            }
             else if (bmi > 18.5 && bmi <= 24.9)
            {
                textBoxMultiline.Text = "Normal";
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                textBoxMultiline.Text = "Overweight";
            }
            else if (bmi >= 30)
            {
                textBoxMultiline.Text = "Obese";
            }
        }

        private void radioButtonImperial_CheckedChanged(object sender, EventArgs e)
        {
            textBoxWeight.Clear();
            textBoxHeight.Clear();
            textBoxMultiline.Clear();
           
        }

        private void radioButtonImperial_Click(object sender, EventArgs e)
        {
            labelMeters.Visible = false;
            labelKilo.Visible = false;
            labelPounds.Visible = true;
            labelInches.Visible = true;
        }

        private void radioButtonMetric_Click(object sender, EventArgs e)
        {

            labelMeters.Visible = true;
            labelKilo.Visible = true;
            labelPounds.Visible = false;
            labelInches.Visible = false;
        }
            

    }
}
