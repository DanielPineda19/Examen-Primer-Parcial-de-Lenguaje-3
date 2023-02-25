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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "BANCO CENTRAL DE HONDURAS";
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
            this.CalcularInteresButton.Location = new System.Drawing.Point(495, 211);
            this.CalcularInteresButton.Name = "CalcularInteresButton";
            this.CalcularInteresButton.Size = new System.Drawing.Size(188, 70);
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
            // Formulario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 419);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox InteresesListBox;
        private System.Windows.Forms.Button CalcularInteresButton;
        private System.Windows.Forms.Label label2;
    }
}