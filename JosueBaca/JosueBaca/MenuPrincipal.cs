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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        //Boton para avanzar al Formulario1
        private void Formulario1Button_Click(object sender, EventArgs e)
        {
            Formulario1 form1 = new Formulario1();
            this.Hide();
            form1.Show();
        }

        //Boton para avanzar al Formulario2
        private void Formulario2Button_Click(object sender, EventArgs e)
        {
            Formulario2 form2 = new Formulario2();
            this.Hide();
            form2.Show();
        }

        //Boton para avanzar al Formulario3
        private void Formulario3Button_Click(object sender, EventArgs e)
        {
            Formulario3 form3 = new Formulario3();
            this.Hide();
            form3.Show();
        }
    }
}
