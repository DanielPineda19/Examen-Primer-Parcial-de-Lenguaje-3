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
            if (Producto1TextBox.Text == String.Empty)
            {
                ErrorProvider1.SetError(Producto1TextBox, "Ingrese un producto");
                Producto1TextBox.Focus();
                return;
            }
            ErrorProvider1.Clear();

            //Sentencia If por si el usuario no ingresa un producto
            if (Producto2TextBox.Text == String.Empty)
            {
                ErrorProvider1.SetError(Producto2TextBox, "Ingrese un producto");
                Producto2TextBox.Focus();
                return;
            }
            ErrorProvider1.Clear();

            //Sentencia If por si el usuario no ingresa el precio del producto
            if (Precio1TextBox.Text == String.Empty)
            {
                ErrorProvider1.SetError(Precio1TextBox, "Ingrese el precio producto");
                Precio1TextBox.Focus();
                return;
            }
            ErrorProvider1.Clear();

            //Sentencia If por si el usuario no ingresa el precio del producto
            if (Precio2TextBox.Text == String.Empty)
            {
                ErrorProvider1.SetError(Precio2TextBox, "Ingrese el precio producto");
                Precio2TextBox.Focus();
                return;
            }
            ErrorProvider1.Clear();

            //Sentencia If por si el usuario no ingresa la cantidad del producto
            if (Cantidad1TextBox.Text == String.Empty)
            {
                ErrorProvider1.SetError(Cantidad1TextBox, "Ingrese la cantidad del producto");
                Cantidad1TextBox.Focus();
                return;
            }
            ErrorProvider1.Clear();

            //Sentencia If por si el usuario no ingresa la cantidad del producto
            if (Cantidad2TextBox.Text == String.Empty)
            {
                ErrorProvider1.SetError(Cantidad2TextBox, "Ingrese la cantidad del producto");
                Cantidad2TextBox.Focus();
                return;
            }
            ErrorProvider1.Clear();



            //Declaración de Variables
            double precio1 = Convert.ToDouble(Precio1TextBox.Text);
            double precio2 = Convert.ToDouble(Precio2TextBox.Text);
            int cantidad1 = Convert.ToInt32(Cantidad1TextBox.Text);
            int cantidad2 = Convert.ToInt32(Cantidad2TextBox.Text);

           //Calcula Subtotal
            double SubTotal =(precio1 * cantidad1) + (precio2 * cantidad2);

            //Llamado a función Asincrónica que calcula el descuento
            double descuento = await DescuentoAsync(SubTotal);

            //Calcula Total a pagar
            double TotalPagar = SubTotal - descuento;

            //Imprime la factura
            SubTotalTextBox.Text = "L." + SubTotal;
            PorcentajeTextBox.Text = "15%";
            DescuentoTextBox.Text = "L." + descuento;
            TotalPagarTextBox.Text = "L." + TotalPagar;

            //Imprime fecha y hora de facturación
            DateTime fechaActual = DateTime.Now;
            FechaLabel.Text = "Fecha de facturación: " + fechaActual.ToString();

        }

        //Función Asincrónica
        private async Task<double> DescuentoAsync(double subtotal)
        {
            double Descuento = await Task.Run(() =>
            {
                return subtotal * 0.15;
            });

            return Descuento;
        }

        //Boton para regresar al Formulario1
        private void RegresarButton_Click(object sender, EventArgs e)
        {
            Formulario1 form1 = new Formulario1();
            this.Hide();
            form1.Show();
        }

        //Boton para avanzar al Formulario3
        private void SiguienteButton_Click(object sender, EventArgs e)
        {
            Formulario3 form3 = new Formulario3();
            this.Hide();
            form3.Show();
        }
    }
}
