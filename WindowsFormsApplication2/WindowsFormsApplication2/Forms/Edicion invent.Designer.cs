namespace WindowsFormsApplication2.Forms
{
    partial class Edicion_invent
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
            this.Grid1 = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.Label();
            this.NOMBRE = new System.Windows.Forms.Label();
            this.PRECIO = new System.Windows.Forms.Label();
            this.STOCK = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CARGAR_DATOS = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid1
            // 
            this.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid1.Location = new System.Drawing.Point(12, 1);
            this.Grid1.Name = "Grid1";
            this.Grid1.Size = new System.Drawing.Size(759, 230);
            this.Grid1.TabIndex = 1;
            // 
            // CODIGO
            // 
            this.CODIGO.AutoSize = true;
            this.CODIGO.Location = new System.Drawing.Point(35, 251);
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.Size = new System.Drawing.Size(63, 13);
            this.CODIGO.TabIndex = 2;
            this.CODIGO.Text = "Descripcion";
            // 
            // NOMBRE
            // 
            this.NOMBRE.AutoSize = true;
            this.NOMBRE.Location = new System.Drawing.Point(35, 277);
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.Size = new System.Drawing.Size(44, 13);
            this.NOMBRE.TabIndex = 3;
            this.NOMBRE.Text = "Nombre";
            // 
            // PRECIO
            // 
            this.PRECIO.AutoSize = true;
            this.PRECIO.Location = new System.Drawing.Point(279, 255);
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.Size = new System.Drawing.Size(34, 13);
            this.PRECIO.TabIndex = 4;
            this.PRECIO.Text = "Costo";
            // 
            // STOCK
            // 
            this.STOCK.AutoSize = true;
            this.STOCK.Location = new System.Drawing.Point(279, 281);
            this.STOCK.Name = "STOCK";
            this.STOCK.Size = new System.Drawing.Size(31, 13);
            this.STOCK.TabIndex = 5;
            this.STOCK.Text = "Total";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 248);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 274);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(332, 281);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(332, 255);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Clave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ubicacion";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(332, 307);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(100, 307);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(101, 20);
            this.textBox3.TabIndex = 16;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(547, 261);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(103, 20);
            this.textBox7.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(541, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 39);
            this.button1.TabIndex = 18;
            this.button1.Text = "Incertar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CARGAR_DATOS
            // 
            this.CARGAR_DATOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CARGAR_DATOS.Location = new System.Drawing.Point(777, 1);
            this.CARGAR_DATOS.Name = "CARGAR_DATOS";
            this.CARGAR_DATOS.Size = new System.Drawing.Size(182, 105);
            this.CARGAR_DATOS.TabIndex = 0;
            this.CARGAR_DATOS.Text = "CARGAR DATOS";
            this.CARGAR_DATOS.UseVisualStyleBackColor = true;
            this.CARGAR_DATOS.Click += new System.EventHandler(this.CARGAR_DATOS_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(826, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 53);
            this.button2.TabIndex = 19;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(826, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 40);
            this.button3.TabIndex = 20;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(826, 198);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 21;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(826, 298);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 22;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(675, 292);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 34);
            this.button4.TabIndex = 23;
            this.button4.Text = "Actualizar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(713, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Clave";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(696, 266);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(65, 20);
            this.textBox10.TabIndex = 25;
            // 
            // Edicion_invent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.classical_funk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(953, 343);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.STOCK);
            this.Controls.Add(this.PRECIO);
            this.Controls.Add(this.NOMBRE);
            this.Controls.Add(this.CODIGO);
            this.Controls.Add(this.Grid1);
            this.Controls.Add(this.CARGAR_DATOS);
            this.Name = "Edicion_invent";
            this.Text = "Edicion_invent";
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CARGAR_DATOS;
        private System.Windows.Forms.DataGridView Grid1;
        private System.Windows.Forms.Label CODIGO;
        private System.Windows.Forms.Label NOMBRE;
        private System.Windows.Forms.Label PRECIO;
        private System.Windows.Forms.Label STOCK;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox10;
    }
}