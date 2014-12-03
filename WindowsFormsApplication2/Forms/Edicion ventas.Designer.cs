namespace WindowsFormsApplication2.Forms
{
    partial class Edicion_ventas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CARGAR_DATOS = new System.Windows.Forms.Button();
            this.FOLIO = new System.Windows.Forms.Label();
            this.FECHA = new System.Windows.Forms.Label();
            this.USER_NAME = new System.Windows.Forms.Label();
            this.TOTAL = new System.Windows.Forms.Label();
            this.ID_CAJA = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(732, 225);
            this.dataGridView1.TabIndex = 0;
            // 
            // CARGAR_DATOS
            // 
            this.CARGAR_DATOS.Location = new System.Drawing.Point(791, 12);
            this.CARGAR_DATOS.Name = "CARGAR_DATOS";
            this.CARGAR_DATOS.Size = new System.Drawing.Size(128, 38);
            this.CARGAR_DATOS.TabIndex = 1;
            this.CARGAR_DATOS.Text = "CARGAR DATOS";
            this.CARGAR_DATOS.UseVisualStyleBackColor = true;
            // 
            // FOLIO
            // 
            this.FOLIO.AutoSize = true;
            this.FOLIO.Location = new System.Drawing.Point(9, 253);
            this.FOLIO.Name = "FOLIO";
            this.FOLIO.Size = new System.Drawing.Size(38, 13);
            this.FOLIO.TabIndex = 2;
            this.FOLIO.Text = "FOLIO";
            // 
            // FECHA
            // 
            this.FECHA.AutoSize = true;
            this.FECHA.Location = new System.Drawing.Point(9, 288);
            this.FECHA.Name = "FECHA";
            this.FECHA.Size = new System.Drawing.Size(50, 13);
            this.FECHA.TabIndex = 3;
            this.FECHA.Text = "Producto";
            // 
            // USER_NAME
            // 
            this.USER_NAME.AutoSize = true;
            this.USER_NAME.Location = new System.Drawing.Point(192, 250);
            this.USER_NAME.Name = "USER_NAME";
            this.USER_NAME.Size = new System.Drawing.Size(94, 13);
            this.USER_NAME.TabIndex = 4;
            this.USER_NAME.Text = "Cantidad producto";
            // 
            // TOTAL
            // 
            this.TOTAL.AutoSize = true;
            this.TOTAL.Location = new System.Drawing.Point(192, 285);
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Size = new System.Drawing.Size(42, 13);
            this.TOTAL.TabIndex = 5;
            this.TOTAL.Text = "TOTAL";
            // 
            // ID_CAJA
            // 
            this.ID_CAJA.AutoSize = true;
            this.ID_CAJA.Location = new System.Drawing.Point(453, 249);
            this.ID_CAJA.Name = "ID_CAJA";
            this.ID_CAJA.Size = new System.Drawing.Size(57, 13);
            this.ID_CAJA.TabIndex = 6;
            this.ID_CAJA.Text = "Le atendio";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 250);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(53, 288);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(308, 246);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(308, 278);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(531, 243);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 12;
            // 
            // Edicion_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.canguru;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(953, 346);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ID_CAJA);
            this.Controls.Add(this.TOTAL);
            this.Controls.Add(this.USER_NAME);
            this.Controls.Add(this.FECHA);
            this.Controls.Add(this.FOLIO);
            this.Controls.Add(this.CARGAR_DATOS);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "Edicion_ventas";
            this.Text = "Edicion_ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CARGAR_DATOS;
        private System.Windows.Forms.Label FOLIO;
        private System.Windows.Forms.Label FECHA;
        private System.Windows.Forms.Label USER_NAME;
        private System.Windows.Forms.Label TOTAL;
        private System.Windows.Forms.Label ID_CAJA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}