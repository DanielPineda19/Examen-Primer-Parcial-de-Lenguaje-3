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
    public partial class Formulario3 : Form
    {
        public Formulario3()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            Multiplos();
        }

        private string Multiplos()
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    MultiplosListBox.Items.Add("Josué Baca");
                else
                    if (i % 3 == 0)
                    MultiplosListBox.Items.Add("Josué");
                else
                    if (i % 5 == 0)
                    MultiplosListBox.Items.Add("Baca");
                else
                    MultiplosListBox.Items.Add(i);
            }

            return "";
        }
    }
}
