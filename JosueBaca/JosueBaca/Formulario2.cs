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
    public partial class Formulario2 : Form
    {
        public Formulario2()
        {
            InitializeComponent();
        }

        private async void FacturarButton_Click(object sender, EventArgs e)
        {
            //Sentencia If por si el usuario no ingresa un producto
            if (Producto1TextBox.Text == "")
            {
                ErrorProvider1.SetError(Producto1TextBox, "Ingrese un producto");
                return;
            }

            //Sentencia If por si el usuario no ingresa un producto
            if (Producto2TextBox.Text == "")
            {
                ErrorProvider1.SetError(Producto2TextBox, "Ingrese un producto");
                return;
            }

            //Sentencia If por si el usuario no ingresa el precio del producto
            if (Precio1TextBox.Text == "")
            {
                ErrorProvider1.SetError(Precio1TextBox, "Ingrese el precio producto");
                return;
            }

            //Sentencia If por si el usuario no ingresa el precio del producto
            if (Precio2TextBox.Text == "")
            {
                ErrorProvider1.SetError(Precio2TextBox, "Ingrese el precio producto");
                return;
            }

            //Sentencia If por si el usuario no ingresa la cantidad del producto
            if (Cantidad1TextBox.Text == "")
            {
                ErrorProvider1.SetError(Cantidad1TextBox, "Ingrese la cantidad del producto");
                return;
            }

            //Sentencia If por si el usuario no ingresa la cantidad del producto
            if (Cantidad2TextBox.Text == "")
            {
                ErrorProvider1.SetError(Cantidad2TextBox, "Ingrese la cantidad del producto");
                return;
            }
            ErrorProvider1.Clear();



            //Declaración de Variables
            double precio1 = Convert.ToDouble(Precio1TextBox.Text);
            double precio2 = Convert.ToDouble(Precio2TextBox.Text);
            int cantidad1 = Convert.ToInt32(Cantidad1TextBox.Text);
            int cantidad2 = Convert.ToInt32(Cantidad2TextBox.Text);

           
            double SubTotal =(precio1 * cantidad1) + (precio2 * cantidad2);

            double descuento = await DescuentoAsync(SubTotal);

            double TotalPagar = SubTotal - descuento;

            SubTotalTextBox.Text = "L." + SubTotal;
            DescuentoTextBox.Text = "L." + descuento;
            TotalPagarTextBox.Text = "L." + TotalPagar;

            DateTime fechaActual = DateTime.Now;
            FechaLabel.Text = "Fecha de facturación: " + fechaActual.ToString();

        }

        private async Task<double> DescuentoAsync(double subtotal)
        {
            double Descuento = await Task.Run(() =>
            {
                return subtotal * 0.15;
            });

            return Descuento;
        }
    }
}
