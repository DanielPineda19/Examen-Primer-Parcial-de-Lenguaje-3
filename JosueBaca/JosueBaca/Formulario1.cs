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
            //Limpia el ListBox cuando se vuelve a ejecutar
            InteresesListBox.Items.Clear();

            //Definición de variables
            double capital = 200000.00;
            const double TasaInteresMensual = 0.015;

            //Definición de vector que contiene los meses del año
            string[] meses = new string[] { " Enero ", " Febrero ", " Marzo ", " Abril ", " Mayo ", " Junio ", " Julio ", " Agosto ", " Septiembre ", " Octubre ", " Noviembre ", " Diciembre " };

            int num = 1;

            //Ciclo For
            for (int i = 0; i < meses.Length; i++)
            {
                //Llamado a función que calcula los intereses mensuales
                double InteresMensual = CalcularInteresMensualDelCliente (capital, TasaInteresMensual, num);
               
                //Muestra los intereses en el ListBox
                string mensaje = "En el mes de" + meses[i] + "los intereses son de L." + InteresMensual.ToString("0.#");
                InteresesListBox.Items.Add (mensaje);
                
                //Acumula los intereses en el capital
                capital= capital + InteresMensual;

                //Acumula los meses del año
                num++;
            }

        }


        //Función CalcularInteresMensualDelCliente
        private double CalcularInteresMensualDelCliente(double capital, double TasaInteresMensual, int num)
        {
            double intereses;

            //Calcula los intereses mensuales
            intereses = (capital * TasaInteresMensual * num);
            
            return intereses;
        }


        //Boton para avanzar al Formulario2
        private void SiguienteButton_Click(object sender, EventArgs e)
        {
            Formulario2 form2 = new Formulario2 ();
            this.Hide();
            form2.Show();
        }

        //Boton para regresar al Menu principal
        private void MenuPrincipalButton_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal ();
            this.Hide();
            menuPrincipal.Show();
        }


        
    }
}
