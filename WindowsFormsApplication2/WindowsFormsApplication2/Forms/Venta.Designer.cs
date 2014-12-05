namespace WindowsFormsApplication2.Forms
{
    partial class Venta
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
            this.VENTAS_CAJA = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.Label();
            this.Vendedor = new System.Windows.Forms.Label();
            this.Id_Caja = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Mensaje = new System.Windows.Forms.Label();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.datagrid2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // VENTAS_CAJA
            // 
            this.VENTAS_CAJA.AutoSize = true;
            this.VENTAS_CAJA.Location = new System.Drawing.Point(148, 93);
            this.VENTAS_CAJA.Name = "VENTAS_CAJA";
            this.VENTAS_CAJA.Size = new System.Drawing.Size(0, 13);
            this.VENTAS_CAJA.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(347, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(87, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(537, 57);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(111, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(654, 57);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 8;
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(365, 34);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(44, 13);
            this.Fecha.TabIndex = 11;
            this.Fecha.Text = "Nombre";
            // 
            // Vendedor
            // 
            this.Vendedor.AutoSize = true;
            this.Vendedor.Location = new System.Drawing.Point(555, 34);
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.Size = new System.Drawing.Size(49, 13);
            this.Vendedor.TabIndex = 12;
            this.Vendedor.Text = "Cantidad";
            // 
            // Id_Caja
            // 
            this.Id_Caja.AutoSize = true;
            this.Id_Caja.Location = new System.Drawing.Point(683, 34);
            this.Id_Caja.Name = "Id_Caja";
            this.Id_Caja.Size = new System.Drawing.Size(57, 13);
            this.Id_Caja.TabIndex = 14;
            this.Id_Caja.Text = "Le atendio";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(860, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 42);
            this.button1.TabIndex = 16;
            this.button1.Text = "agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mensaje
            // 
            this.Mensaje.AutoSize = true;
            this.Mensaje.Location = new System.Drawing.Point(879, 9);
            this.Mensaje.Name = "Mensaje";
            this.Mensaje.Size = new System.Drawing.Size(47, 13);
            this.Mensaje.TabIndex = 17;
            this.Mensaje.Text = "Mensaje";
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(3, 118);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(213, 231);
            this.datagrid.TabIndex = 18;
            this.datagrid.ColumnDefaultCellStyleChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.nombrepre_ColumnDefaultCellStyleChanged);
            // 
            // datagrid2
            // 
            this.datagrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid2.Location = new System.Drawing.Point(298, 118);
            this.datagrid2.Name = "datagrid2";
            this.datagrid2.Size = new System.Drawing.Size(539, 231);
            this.datagrid2.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(860, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 39);
            this.button2.TabIndex = 20;
            this.button2.Text = "Imprimir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(854, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 38);
            this.button3.TabIndex = 21;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(222, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 46);
            this.button4.TabIndex = 22;
            this.button4.Text = "buscar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(222, 197);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(69, 20);
            this.textBox6.TabIndex = 23;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(221, 259);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 51);
            this.button5.TabIndex = 24;
            this.button5.Text = "Cargar inventario";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Precio";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(440, 57);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(82, 20);
            this.textBox7.TabIndex = 26;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(868, 159);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 38);
            this.button6.TabIndex = 27;
            this.button6.Text = "To excel";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(264, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(53, 20);
            this.textBox1.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Folio";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(868, 203);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(72, 56);
            this.button7.TabIndex = 30;
            this.button7.Text = "Actualizar borrado esconder";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.Angry_Cells;
            this.ClientSize = new System.Drawing.Size(954, 361);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.datagrid2);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.Mensaje);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Id_Caja);
            this.Controls.Add(this.Vendedor);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.VENTAS_CAJA);
            this.Name = "Venta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VENTAS_CAJA;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label Vendedor;
        private System.Windows.Forms.Label Id_Caja;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Mensaje;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.DataGridView datagrid2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;


    }
}