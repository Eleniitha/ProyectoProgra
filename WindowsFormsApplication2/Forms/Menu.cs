using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Forms
{
    public class Menu1 : Form
    {
        public Menu1()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void revisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inventario inv = new inventario();
            inv.Show();
        }

        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.revisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revisarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.revisarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.VENTITHAS = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources._4_colour_rainbow;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.usuarioToolStripMenuItem,
            this.toolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(938, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revisarToolStripMenuItem,
            this.toolStripMenuItem4});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(72, 20);
            this.toolStripMenuItem1.Text = "Inventario";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // revisarToolStripMenuItem
            // 
            this.revisarToolStripMenuItem.Name = "revisarToolStripMenuItem";
            this.revisarToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.revisarToolStripMenuItem.Text = "Revisar";
            this.revisarToolStripMenuItem.Click += new System.EventHandler(this.revisarToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(111, 22);
            this.toolStripMenuItem4.Text = "Editar";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revisarToolStripMenuItem1,
            this.toolStripMenuItem6});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // revisarToolStripMenuItem1
            // 
            this.revisarToolStripMenuItem1.Name = "revisarToolStripMenuItem1";
            this.revisarToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.revisarToolStripMenuItem1.Text = "Revisar";
            this.revisarToolStripMenuItem1.Click += new System.EventHandler(this.revisarToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(111, 22);
            this.toolStripMenuItem6.Text = "Editar";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revisarToolStripMenuItem2});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItem2.Text = "Ventas";
            // 
            // revisarToolStripMenuItem2
            // 
            this.revisarToolStripMenuItem2.Name = "revisarToolStripMenuItem2";
            this.revisarToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.revisarToolStripMenuItem2.Text = "Revisar";
            this.revisarToolStripMenuItem2.Click += new System.EventHandler(this.revisarToolStripMenuItem2_Click);
            // 
            // VENTITHAS
            // 
            this.VENTITHAS.Location = new System.Drawing.Point(406, 151);
            this.VENTITHAS.Name = "VENTITHAS";
            this.VENTITHAS.Size = new System.Drawing.Size(123, 48);
            this.VENTITHAS.TabIndex = 1;
            this.VENTITHAS.Text = "VENTAS";
            this.VENTITHAS.UseVisualStyleBackColor = true;
            this.VENTITHAS.Click += new System.EventHandler(this.VENTITHAS_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(818, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calculadora";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu1
            // 
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources._4_colour_rainbow;
            this.ClientSize = new System.Drawing.Size(938, 365);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.VENTITHAS);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Menu1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inventarioToolStripMenuItem;
        private ToolStripMenuItem inventarioToolStripMenuItem1;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem cantidadDeVentasToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem cantidadDeUsuariosToolStripMenuItem;
        private ToolStripMenuItem reporteToolStripMenuItem;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem revisarToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem revisarToolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem revisarToolStripMenuItem2;

        private void revisarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            inventario inv = new inventario();
            inv.Show();
        }

        private void revisarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Usuarios usu = new Usuarios();
            usu.Show();
        }

        private void revisarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Ventas venta = new Ventas();
            venta.Show();
        }
        private Button VENTITHAS;

        private void VENTITHAS_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.Show();
            
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            edicion_usuario ed_us = new edicion_usuario();
            ed_us.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Edicion_invent ed_in = new Edicion_invent();
            ed_in.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private Button button1;

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process calc = new System.Diagnostics.Process { StartInfo = { FileName = @"calc.exe" } };
            calc.Start();
        }

       
    }
}
