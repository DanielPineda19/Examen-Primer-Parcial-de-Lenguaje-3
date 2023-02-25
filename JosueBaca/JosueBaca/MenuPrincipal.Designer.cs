namespace JosueBaca
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Formulario1Button = new System.Windows.Forms.Button();
            this.Formulario2Button = new System.Windows.Forms.Button();
            this.Formulario3Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡BIENVENIDO USUARIO!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione uno de los siguientes formularios:";
            // 
            // Formulario1Button
            // 
            this.Formulario1Button.Location = new System.Drawing.Point(12, 151);
            this.Formulario1Button.Name = "Formulario1Button";
            this.Formulario1Button.Size = new System.Drawing.Size(143, 75);
            this.Formulario1Button.TabIndex = 2;
            this.Formulario1Button.Text = "Formulario No.1";
            this.Formulario1Button.UseVisualStyleBackColor = true;
            this.Formulario1Button.Click += new System.EventHandler(this.Formulario1Button_Click);
            // 
            // Formulario2Button
            // 
            this.Formulario2Button.Location = new System.Drawing.Point(184, 151);
            this.Formulario2Button.Name = "Formulario2Button";
            this.Formulario2Button.Size = new System.Drawing.Size(143, 75);
            this.Formulario2Button.TabIndex = 3;
            this.Formulario2Button.Text = "Formulario No.2";
            this.Formulario2Button.UseVisualStyleBackColor = true;
            this.Formulario2Button.Click += new System.EventHandler(this.Formulario2Button_Click);
            // 
            // Formulario3Button
            // 
            this.Formulario3Button.Location = new System.Drawing.Point(357, 151);
            this.Formulario3Button.Name = "Formulario3Button";
            this.Formulario3Button.Size = new System.Drawing.Size(146, 75);
            this.Formulario3Button.TabIndex = 4;
            this.Formulario3Button.Text = "Formulario No.3";
            this.Formulario3Button.UseVisualStyleBackColor = true;
            this.Formulario3Button.Click += new System.EventHandler(this.Formulario3Button_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 276);
            this.Controls.Add(this.Formulario3Button);
            this.Controls.Add(this.Formulario2Button);
            this.Controls.Add(this.Formulario1Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Formulario1Button;
        private System.Windows.Forms.Button Formulario2Button;
        private System.Windows.Forms.Button Formulario3Button;
    }
}

