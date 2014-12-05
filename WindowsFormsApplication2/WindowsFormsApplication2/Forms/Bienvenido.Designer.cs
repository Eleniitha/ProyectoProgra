namespace WindowsFormsApplication2.Forms
{
    partial class Bienvenido
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
            this.Botonini = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Botonini
            // 
            this.Botonini.Location = new System.Drawing.Point(295, 223);
            this.Botonini.Name = "Botonini";
            this.Botonini.Size = new System.Drawing.Size(382, 88);
            this.Botonini.TabIndex = 0;
            this.Botonini.Text = "Bienvenido ";
            this.Botonini.UseVisualStyleBackColor = true;
            this.Botonini.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bienvenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.Brown_MM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(957, 393);
            this.Controls.Add(this.Botonini);
            this.DoubleBuffered = true;
            this.Name = "Bienvenido";
            this.Text = "Bienvenido al punto de venta xD";
            this.Load += new System.EventHandler(this.Bienvenido_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Botonini;
    }
}