using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unit_Converter.Properties;

namespace Unit_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double userDist = 0, userWeight = 0, userTemp = 0, total = 0;

        private void btnWeight_Click(object sender, EventArgs e)
        {
            txtWeight.Show();
            grpWeight.Show();
            grpConvertWeight.Show();
            btnBack.Show();
            btnDist.Hide();
            btnWeight.Hide();
            btnConvertWeight.Show();
            imgChoice.Image = Properties.Resources.Kettle_bell;
            imgChoice.Show();
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            txtDist.Hide();
            grpDist.Hide();
            grpConvertDist.Hide();
            btnBack.Hide();
            btnDist.Show();
            btnWeight.Show();
            btnConvertDist.Hide();
            txtWeight.Hide();
            grpWeight.Hide();
            grpConvertWeight.Hide();
            btnBack.Hide();
            btnDist.Show();
            btnWeight.Show();
            btnConvertWeight.Hide();
            imgChoice.Hide();
            lblTotal.Text = " ";
        }

        private void btnDist_Click(object sender, EventArgs e)
        {
            txtDist.Show();
            grpDist.Show();
            grpConvertDist.Show();
            btnBack.Show();
            btnDist.Hide();
            btnWeight.Hide();
            btnConvertDist.Show();
            imgChoice.Image = Properties.Resources.Ruler;
            imgChoice.Show();
        }
        private void btnConvertDist_Click(object sender, EventArgs e)
        {
            if (radMM.Checked && radCmCalc.Checked)
            {
                if (Double.TryParse(txtDist.Text, out userDist))
                {
                    total = (userDist / 10);
                    lblTotal.Text = (total + "Cm");
                }
                else
                {
                    lblTotal.Text = "error";
                }               
            }
            if (radMM.Checked && radMCalc.Checked)
            {
                if (Double.TryParse(txtDist.Text, out userDist))
                {
                    total = (userDist / 1000);
                    lblTotal.Text = (total + "M");
                }
                else
                {
                    lblTotal.Text = "error";
                }              
            }
            if (radMM.Checked && radKmCalc.Checked)
            {
                if (Double.TryParse(txtDist.Text, out userDist))
                {
                total = (userDist / 1000000);
                lblTotal.Text = (total + "Km");
                }
                else
                {
                    lblTotal.Text = "error";
                }               
            }
            if (radMM.Checked && radMmCalc.Checked)
            {
                if (Double.TryParse(txtDist.Text, out userDist))
                {
                    total = userDist;
                    lblTotal.Text = (total + "MM");
                }
                else
                {
                    lblTotal.Text = "error";
                }                
            }
            if (radCm.Checked && radCmCalc.Checked)
            {
                if (Double.TryParse(txtDist.Text, out userDist))
                {
                    total = (userDist);
                    lblTotal.Text = (total + "Cm");
                }
                else
                {
                    lblTotal.Text = "error";
                }                
            }
            if (radCm.Checked && radMCalc.Checked)
            {
                if (Double.TryParse(txtDist.Text, out userDist))
                {
                    total = (userDist / 100);
                    lblTotal.Text = (total + "M");
                }
                else
                {
                    lblTotal.Text = "error";
                }               
            }
            if (radCm.Checked && radKmCalc.Checked)
            {
                if (Double.TryParse(txtDist.Text, out userDist))
                {
                    total = (userDist / 100000);
                    lblTotal.Text = (total + "Km");
                }
                else
                {
                    lblTotal.Text = "error";
                }               
            }
            if (radCm.Checked && radMmCalc.Checked)
            {
                if (Double.TryParse(txtDist.Text, out userDist))
                {
                    total = (userDist * 10);
                    lblTotal.Text = (total + "MM");
                }
                else
                {
                    lblTotal.Text = "error";
                }                
            }
            if (radM.Checked && radCmCalc.Checked)
            {
                if (Double.TryParse(txtDist.Text, out userDist))
                {
                    total = (userDist * 100);
                    lblTotal.Text = (total + "Cm");
                }
                else
                {
                    lblTotal.Text = "error";
                }                
            }
            if (radM.Checked && radMCalc.Checked)
            {
                if (Double.TryParse(txtDist.Text, out userDist))
                {
                    total = (userDist);
                    lblTotal.Text = (total + "M");
                }
                else
                {
                    lblTotal.Text = "error";
                }                
            }
            if (radM.Checked && radKmCalc.Checked)
            {
                if (Double.TryParse(txtDist.Text, out userDist))
                {
                    total = (userDist / 1000);
                    lblTotal.Text = (total + "Km");
                }
                else
                {
                    lblTotal.Text = "error";
                }             
            }
            if (radM.Checked && radMmCalc.Checked)
            {
                if (Double.TryParse(txtDist.Text, out userDist))
                {
                    total = (userDist * 1000);
                    lblTotal.Text = (total + "MM");
                }
                else
                {
                    lblTotal.Text = "error";
                }               
            }
            if (radKm.Checked && radCmCalc.Checked)
            {
                if (Double.TryParse(txtDist.Text, out userDist))
                {
                    total = (userDist * 100000);
                    lblTotal.Text = (total + "Cm");
                }
                else
                {
                    lblTotal.Text = "error";
                }               
            }
            if (radKm.Checked && radMCalc.Checked)
            {
                if (Double.TryParse(txtDist.Text, out userDist))
                {
                    total = (userDist * 1000);
                    lblTotal.Text = (total + "M");
                }
                else
                {
                    lblTotal.Text = "error";
                }
            }
            if (radKm.Checked && radKmCalc.Checked)
            {
                if (Double.TryParse(txtDist.Text, out userDist))
                {
                    total = (userDist );
                    lblTotal.Text = (total + "Km");
                }
                else
                {
                    lblTotal.Text = "error";
                }                
            }
            if (radKm.Checked && radMmCalc.Checked)
            {
                if (Double.TryParse(txtDist.Text, out userDist))
                {
                    total = (userDist * 1000000);
                    lblTotal.Text = (total + "MM");
                }
                else
                {
                    lblTotal.Text = "error";
                }
            }
            lblTotal.Show();
        }
        private void btnConvertWeight_Click(object sender, EventArgs e)
        {
            if (radPounds.Checked && radConvertKilo.Checked) 
            {
                if (Double.TryParse(txtWeight.Text, out userWeight))
                {
                    total = (userWeight / 2.205);
                    lblTotal.Text = (total + "Kg");
                }
                else
                {
                    lblTotal.Text = "error";
                }               
            }
            if (radPounds.Checked && radConvertPounds.Checked)
            {
                if (Double.TryParse(txtWeight.Text, out userWeight))
                {
                    total = userWeight;
                    lblTotal.Text = (total + "lb");
                }
                else
                {
                    lblTotal.Text = "error";
                }                
            }
            if (radKilo.Checked && radConvertPounds.Checked)
            {
                if (Double.TryParse(txtWeight.Text, out userWeight))
                {
                    total = (userWeight * 2.205);
                    lblTotal.Text = (total + "lb");
                }
                else
                {
                    lblTotal.Text = "error";
                }
            }
            if (radKilo.Checked && radConvertKilo.Checked)
            {
                if (Double.TryParse(txtWeight.Text, out userWeight))
                {
                    total = userWeight;
                    lblTotal.Text = (total + "kg");              
                }
                else
                {
                    lblTotal.Text = "error";
                }
            }
            lblTotal.Show();
        }
       

    }
}
