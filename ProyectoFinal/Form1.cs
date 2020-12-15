using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Resolver() 
        {
            if (txbIngresa.Text !="" && txbIngresa.Text!="-")
            {
                double dato = Convert.ToDouble(txbIngresa.Text);
                int tipo1 = cobIngresa.SelectedIndex;
                int tipo2 = cobSalida.SelectedIndex;

                //0. Celsius
                //1. Farhe
                //2. Kelvin 

                switch (tipo1)
                {
                    case 0:
                        if (tipo2 == 0)
                            cobIngresa.SelectedIndex = 1;
                        if (tipo2 == 1)
                            txbSalida.Text = (dato * 1.8 + 32).ToString();
                        if (tipo2 == 2)
                            txbSalida.Text = (dato + 273.15).ToString();
                        break;
                    case 1:
                        if (tipo2 == 0)
                            txbSalida.Text = ((dato -32)/1.8).ToString();
                        if (tipo2 == 1)
                            cobIngresa.SelectedIndex = 2;
                        if (tipo2 == 2)
                            txbSalida.Text = (((dato -32)/1.8) + 173.15).ToString();
                        break;
                    case 2:
                        if (tipo2 == 0)
                            txbSalida.Text = (dato - 273.15).ToString();
                        if (tipo2 == 1)
                            txbSalida.Text = ((dato - 273.15) * 1.8 + 32).ToString();
                        if (tipo2 == 2)
                            cobIngresa.SelectedIndex = 0;
                        break;
                }
            }

            else
            {
                txbSalida.Clear();
            }
        }

        private void lblIgual_Click(object sender, EventArgs e)
        {
            Resolver();
        }

        private void txbIngresa_TextChanged(object sender, EventArgs e)
        {
            Resolver();
        }

        private void cobIngresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Resolver();
        }

        private void cobSalida_SelectedIndexChanged(object sender, EventArgs e)
        {
            Resolver();
        }
    }
}
