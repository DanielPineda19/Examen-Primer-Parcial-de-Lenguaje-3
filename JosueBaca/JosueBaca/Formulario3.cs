using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JosueBaca
{
    public partial class Formulario3 : Form
    {
        public Formulario3()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            //Limpia el ListBox cuando se vuelve a ejecutar
            MultiplosListBox.Items.Clear();

            //Llamado a función para imprimir los multiplos
            Multiplos();
        }

        //Función Multiplos
        private string Multiplos()
        {
            //Ciclo For que imprime los números del 1 al 100
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    //Imprime nombre y apellido si es multiplo de 3 y 5
                    MultiplosListBox.Items.Add("Josué Baca");
                else
                    if (i % 3 == 0)
                    //Imprime nombre si es multiplo de 3
                    MultiplosListBox.Items.Add("Josué");
                else
                    //Imprime apellido si es multiplo de 5
                    if (i % 5 == 0)
                    MultiplosListBox.Items.Add("Baca");
                else
                    //Imprime los números si no se cumple ninguna las condiciones anteriores
                    MultiplosListBox.Items.Add(i);
            }

            return "";
        }


        //Boton para finalizar 
        private void FinalizarButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        //Boton para regresar al Formulario2
        private void RegresarButton_Click(object sender, EventArgs e)
        {
            Formulario2 form2 = new Formulario2();
            this.Hide();
            form2.Show();
        }
    }
}
