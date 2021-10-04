using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1TemasEspeciaisLedon
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            double a, res2, res3, res4, res5, res6, res7, res8, res9, res10, res11, res12, resDesconto;
            string valorCbx = comboBox1.Text;
            labelValorR.Text = txt1.Text;
            ParcelasR.Text = comboBox1.Text;
            a = Double.Parse(txt1.Text);

            if (rBAV.Checked)
            {
                DescontoR.Text = "10%";
                resDesconto = a - (a * 10 / 100);
                TotalR.Text = Convert.ToString(resDesconto);
            }
            else if (!rBAV.Checked)
            {
                DescontoR.Text = "0";
                TotalR.Text = "0";
            }
            else if (rBP.Checked)
            {
                DescontoR.Text = "0";
                TotalR.Text = "0";
                ParcelasR.Text = "0";
            }
            switch (valorCbx) {
                    case "2x":
                        res2 = a / 2;
                        double res2MR = Math.Round(res2, 2);
                        TotalR.Text = Convert.ToString(res2MR);
                        break;

                    case "3x":
                        res3 = a / 3;
                        double res3MR = Math.Round(res3, 2);
                        TotalR.Text = Convert.ToString(res3MR);
                        break;

                    case "4x":
                        res4 = a / 4;
                        double res4MR = Math.Round(res4, 2);
                        TotalR.Text = Convert.ToString(res4MR);
                        break;

                    case "5x":
                        res5 = a / 5;
                        double res5MR = Math.Round(res5, 2);
                        TotalR.Text = Convert.ToString(res5MR);
                        break;

                    case "6x":
                        res6 = a / 6;
                        double res6MR = Math.Round(res6, 2);
                        TotalR.Text = Convert.ToString(res6MR);
                        break;

                    case "7x":
                        res7 = a / 7;
                        double res7MR = Math.Round(res7, 2);
                        TotalR.Text = Convert.ToString(res7MR);
                        break;

                    case "8x":
                        res8 = a / 8;
                        double res8MR = Math.Round(res8, 2);
                        TotalR.Text = Convert.ToString(res8MR);
                        break;

                    case "9x":
                        res9 = a / 9;
                        double res9MR = Math.Round(res9, 2);
                        TotalR.Text = Convert.ToString(res9MR);
                        break;

                    case "10x":
                        res10 = a / 10;
                        double res10MR = Math.Round(res10, 2);
                        TotalR.Text = Convert.ToString(res10MR);
                        break;

                    case "11x":
                        res11 = a / 11;
                        double res11MR = Math.Round(res11, 2);
                        TotalR.Text = Convert.ToString(res11MR);
                        break;

                    case "12x":
                        res12 = a / 12;
                        double res12MR = Math.Round(res12, 2);
                        TotalR.Text = Convert.ToString(res12MR);
                        break;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ValorPagoR_Click(object sender, EventArgs e)
        {
             
        }

        private void labelValorR_Click(object sender, EventArgs e)
        {
            
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)){
                e.Handled = true;
            }
        }

        private void ParcelasR_Click(object sender, EventArgs e)
        {

        }

        private void rBAV_CheckedChanged(object sender, EventArgs e)
        {
            if (rBAV.Checked){
                comboBox1.Enabled = false;
                comboBox1.SelectedItem = null;
                Parcelas.Enabled = false;
                ParcelasR.Enabled = false;
            }else if (!rBAV.Checked) {
                comboBox1.Enabled = true;
                Parcelas.Enabled = true;
                ParcelasR.Enabled = true;
            }

        }
    }
}
