namespace JosueBaca
{
    partial class Formulario1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.InteresesListBox = new System.Windows.Forms.ListBox();
            this.CalcularInteresButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SiguienteButton = new System.Windows.Forms.Button();
            this.MenuPrincipalButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "BAC HONDURAS";
            // 
            // InteresesListBox
            // 
            this.InteresesListBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InteresesListBox.FormattingEnabled = true;
            this.InteresesListBox.ItemHeight = 22;
            this.InteresesListBox.Location = new System.Drawing.Point(12, 101);
            this.InteresesListBox.Name = "InteresesListBox";
            this.InteresesListBox.Size = new System.Drawing.Size(453, 290);
            this.InteresesListBox.TabIndex = 1;
            // 
            // CalcularInteresButton
            // 
            this.CalcularInteresButton.Location = new System.Drawing.Point(495, 220);
            this.CalcularInteresButton.Name = "CalcularInteresButton";
            this.CalcularInteresButton.Size = new System.Drawing.Size(188, 52);
            this.CalcularInteresButton.TabIndex = 2;
            this.CalcularInteresButton.Text = "Calcular Intereses";
            this.CalcularInteresButton.UseVisualStyleBackColor = true;
            this.CalcularInteresButton.Click += new System.EventHandler(this.CalcularInteresButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Intereses Mensuales";
            // 
            // SiguienteButton
            // 
            this.SiguienteButton.Location = new System.Drawing.Point(495, 303);
            this.SiguienteButton.Name = "SiguienteButton";
            this.SiguienteButton.Size = new System.Drawing.Size(188, 52);
            this.SiguienteButton.TabIndex = 4;
            this.SiguienteButton.Text = "Siguiente Formulario";
            this.SiguienteButton.UseVisualStyleBackColor = true;
            this.SiguienteButton.Click += new System.EventHandler(this.SiguienteButton_Click);
            // 
            // MenuPrincipalButton
            // 
            this.MenuPrincipalButton.Location = new System.Drawing.Point(495, 138);
            this.MenuPrincipalButton.Name = "MenuPrincipalButton";
            this.MenuPrincipalButton.Size = new System.Drawing.Size(188, 52);
            this.MenuPrincipalButton.TabIndex = 5;
            this.MenuPrincipalButton.Text = "Menú Principal";
            this.MenuPrincipalButton.UseVisualStyleBackColor = true;
            this.MenuPrincipalButton.Click += new System.EventHandler(this.MenuPrincipalButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JosueBaca.Properties.Resources.BAC_Credomatic_v_rgb1;
            this.pictureBox1.Location = new System.Drawing.Point(225, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Formulario1
            // 
            this.AcceptButton = this.CalcularInteresButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 419);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MenuPrincipalButton);
            this.Controls.Add(this.SiguienteButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CalcularInteresButton);
            this.Controls.Add(this.InteresesListBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Formulario1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox InteresesListBox;
        private System.Windows.Forms.Button CalcularInteresButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SiguienteButton;
        private System.Windows.Forms.Button MenuPrincipalButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}