using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JosueBaca
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }

        private void CalcularInteresButton_Click(object sender, EventArgs e)
        {

            double capital = 200000.00;
            const double TasaInteresMensual = 0.015;


            string[] meses = new string[] { " Enero ", " Febrero ", " Marzo ", " Abril ", " Mayo ", " Junio ", " Julio ", " Agosto ", " Septiembre ", " Octubre ", " Noviembre ", " Diciembre " };

            int num = 1;


            for (int i = 0; i < meses.Length; i++)
            {
                double InteresMensual = CalcularInteresMensualDelCliente (capital, TasaInteresMensual, num);
               
                string mensaje = "En el mes de" + meses[i] + "los intereses son de L." + InteresMensual.ToString("0.#");
                InteresesListBox.Items.Add (mensaje);

                capital= capital + InteresMensual;
                num++;
            }

        }

        private double CalcularInteresMensualDelCliente(double capital, double TasaInteresMensual, int num)
        {
            double intereses;

            intereses = (capital * TasaInteresMensual * num);
            
            return intereses;
        }

        
    }
}
