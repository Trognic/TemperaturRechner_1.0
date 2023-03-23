using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperaturModifikator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void radioButton_change(object sender, EventArgs e)
        {
            if(radioButtonCF.Checked || radioButtonCK.Checked)
            {
                labelEinheit.Text = "°C";
            }
            else if (radioButtonKF.Checked || radioButtonKC.Checked)
            {
                labelEinheit.Text = "K";
            }
            else if (radioButtonFC.Checked || radioButtonFK.Checked)
            {
                labelEinheit.Text = "°F";
            }
        }

        private void buttonUMRECHNEN_Click(object sender, EventArgs e)
        {
            double temp;
            if (radioButtonCK.Checked)
            {
                try
                {
                    temp = Convert.ToDouble(textBoxTEMP.Text);
                    temp = temp + 273.15;
                    labelResultat.Text = Convert.ToString(temp + " K");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (radioButtonKC.Checked)
            {
                try
                {
                    temp = Convert.ToDouble(textBoxTEMP.Text);
                    temp = temp - 273.15;
                    labelResultat.Text = Convert.ToString(temp + " °C");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (radioButtonCF.Checked)
            {
                try
                {
                    temp = Convert.ToDouble(textBoxTEMP.Text);
                    temp = (temp * 1.8) + 32;
                    labelResultat.Text = Convert.ToString(temp + " °F");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (radioButtonFC.Checked)
            {
                try
                {
                    temp = Convert.ToDouble(textBoxTEMP.Text);
                    temp = (temp - 32) / 1.8;
                    labelResultat.Text = Convert.ToString(temp + " °C" );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (radioButtonFK.Checked)
            {
                try
                {
                    temp = Convert.ToDouble(textBoxTEMP.Text);
                    temp = ((temp - 273.15) * 1.8) + 32;
                    labelResultat.Text = Convert.ToString(temp + " K");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (radioButtonKF.Checked)
            {
                try
                {
                    temp = Convert.ToDouble(textBoxTEMP.Text);
                    temp = ((temp - 32) / 1.8) + 273.15;
                    labelResultat.Text = Convert.ToString(temp + " °F");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
