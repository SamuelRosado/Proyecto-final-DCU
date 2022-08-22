
namespace FinalProyect
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.pnlinicio = new System.Windows.Forms.Panel();
            this.lbltimeoff = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnganancias = new System.Windows.Forms.Button();
            this.btnproveedores = new System.Windows.Forms.Button();
            this.btnclientes = new System.Windows.Forms.Button();
            this.btntrabajadores = new System.Windows.Forms.Button();
            this.btncompras = new System.Windows.Forms.Button();
            this.btnventas = new System.Windows.Forms.Button();
            this.btnproductos = new System.Windows.Forms.Button();
            this.btndashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.s = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Hours = new System.Windows.Forms.Timer(this.components);
            this.timeoff = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasAlContadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaCreditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlinicio.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlinicio
            // 
            this.pnlinicio.BackColor = System.Drawing.Color.Snow;
            this.pnlinicio.Controls.Add(this.lbltimeoff);
            this.pnlinicio.Controls.Add(this.lblfecha);
            this.pnlinicio.Controls.Add(this.lblhora);
            this.pnlinicio.Controls.Add(this.btnlogout);
            this.pnlinicio.Controls.Add(this.btnganancias);
            this.pnlinicio.Controls.Add(this.btnproveedores);
            this.pnlinicio.Controls.Add(this.btnclientes);
            this.pnlinicio.Controls.Add(this.btntrabajadores);
            this.pnlinicio.Controls.Add(this.btncompras);
            this.pnlinicio.Controls.Add(this.btnventas);
            this.pnlinicio.Controls.Add(this.btnproductos);
            this.pnlinicio.Controls.Add(this.btndashboard);
            this.pnlinicio.Controls.Add(this.panel2);
            this.pnlinicio.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlinicio.Location = new System.Drawing.Point(0, 24);
            this.pnlinicio.Name = "pnlinicio";
            this.pnlinicio.Size = new System.Drawing.Size(186, 542);
            this.pnlinicio.TabIndex = 0;
            this.pnlinicio.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbltimeoff
            // 
            this.lbltimeoff.AutoSize = true;
            this.lbltimeoff.Location = new System.Drawing.Point(148, 544);
            this.lbltimeoff.Name = "lbltimeoff";
            this.lbltimeoff.Size = new System.Drawing.Size(35, 13);
            this.lbltimeoff.TabIndex = 1;
            this.lbltimeoff.Text = "label1";
            this.lbltimeoff.Click += new System.EventHandler(this.lbltimeoff_Click);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(3, 541);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(50, 16);
            this.lblfecha.TabIndex = 1;
            this.lblfecha.Text = "FECHA";
            this.lblfecha.Click += new System.EventHandler(this.lblfecha_Click);
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.Location = new System.Drawing.Point(50, 518);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(46, 16);
            this.lblhora.TabIndex = 1;
            this.lblhora.Text = "HORA";
            // 
            // btnlogout
            // 
            this.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Image = ((System.Drawing.Image)(resources.GetObject("btnlogout.Image")));
            this.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.Location = new System.Drawing.Point(0, 455);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(186, 42);
            this.btnlogout.TabIndex = 10;
            this.btnlogout.Text = "Log out";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            this.btnlogout.Leave += new System.EventHandler(this.btnlogout_Leave);
            // 
            // btnganancias
            // 
            this.btnganancias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnganancias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnganancias.FlatAppearance.BorderSize = 0;
            this.btnganancias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnganancias.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnganancias.Image = ((System.Drawing.Image)(resources.GetObject("btnganancias.Image")));
            this.btnganancias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnganancias.Location = new System.Drawing.Point(0, 413);
            this.btnganancias.Name = "btnganancias";
            this.btnganancias.Size = new System.Drawing.Size(186, 42);
            this.btnganancias.TabIndex = 9;
            this.btnganancias.Text = "Ganancias";
            this.btnganancias.UseVisualStyleBackColor = true;
            this.btnganancias.Click += new System.EventHandler(this.btnganancias_Click);
            this.btnganancias.Leave += new System.EventHandler(this.btnganancias_Leave);
            // 
            // btnproveedores
            // 
            this.btnproveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnproveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnproveedores.FlatAppearance.BorderSize = 0;
            this.btnproveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproveedores.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnproveedores.Image")));
            this.btnproveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproveedores.Location = new System.Drawing.Point(0, 371);
            this.btnproveedores.Name = "btnproveedores";
            this.btnproveedores.Size = new System.Drawing.Size(186, 42);
            this.btnproveedores.TabIndex = 8;
            this.btnproveedores.Text = "Proveedores";
            this.btnproveedores.UseVisualStyleBackColor = true;
            this.btnproveedores.Click += new System.EventHandler(this.btnproveedores_Click);
            this.btnproveedores.Leave += new System.EventHandler(this.btnproveedores_Leave);
            // 
            // btnclientes
            // 
            this.btnclientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnclientes.FlatAppearance.BorderSize = 0;
            this.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclientes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclientes.Image = ((System.Drawing.Image)(resources.GetObject("btnclientes.Image")));
            this.btnclientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclientes.Location = new System.Drawing.Point(0, 329);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(186, 42);
            this.btnclientes.TabIndex = 7;
            this.btnclientes.Text = "Clientes";
            this.btnclientes.UseVisualStyleBackColor = true;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            this.btnclientes.Leave += new System.EventHandler(this.btnclientes_Leave);
            // 
            // btntrabajadores
            // 
            this.btntrabajadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntrabajadores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btntrabajadores.FlatAppearance.BorderSize = 0;
            this.btntrabajadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntrabajadores.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrabajadores.Image = ((System.Drawing.Image)(resources.GetObject("btntrabajadores.Image")));
            this.btntrabajadores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntrabajadores.Location = new System.Drawing.Point(0, 287);
            this.btntrabajadores.Name = "btntrabajadores";
            this.btntrabajadores.Size = new System.Drawing.Size(186, 42);
            this.btntrabajadores.TabIndex = 6;
            this.btntrabajadores.Text = "Trabajadores";
            this.btntrabajadores.UseVisualStyleBackColor = true;
            this.btntrabajadores.Click += new System.EventHandler(this.btntrabajadores_Click);
            this.btntrabajadores.Leave += new System.EventHandler(this.btntrabajadores_Leave);
            // 
            // btncompras
            // 
            this.btncompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncompras.FlatAppearance.BorderSize = 0;
            this.btncompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncompras.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncompras.Image = ((System.Drawing.Image)(resources.GetObject("btncompras.Image")));
            this.btncompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncompras.Location = new System.Drawing.Point(0, 245);
            this.btncompras.Name = "btncompras";
            this.btncompras.Size = new System.Drawing.Size(186, 42);
            this.btncompras.TabIndex = 5;
            this.btncompras.Text = "Compras";
            this.btncompras.UseVisualStyleBackColor = true;
            this.btncompras.Click += new System.EventHandler(this.btncompras_Click);
            this.btncompras.Leave += new System.EventHandler(this.btncompras_Leave);
            // 
            // btnventas
            // 
            this.btnventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnventas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnventas.FlatAppearance.BorderSize = 0;
            this.btnventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnventas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnventas.Image = ((System.Drawing.Image)(resources.GetObject("btnventas.Image")));
            this.btnventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnventas.Location = new System.Drawing.Point(0, 203);
            this.btnventas.Name = "btnventas";
            this.btnventas.Size = new System.Drawing.Size(186, 42);
            this.btnventas.TabIndex = 4;
            this.btnventas.Text = "Ventas";
            this.btnventas.UseVisualStyleBackColor = true;
            this.btnventas.Click += new System.EventHandler(this.btnventas_Click);
            this.btnventas.Leave += new System.EventHandler(this.btnventas_Leave);
            // 
            // btnproductos
            // 
            this.btnproductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnproductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnproductos.FlatAppearance.BorderSize = 0;
            this.btnproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproductos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproductos.Image = ((System.Drawing.Image)(resources.GetObject("btnproductos.Image")));
            this.btnproductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproductos.Location = new System.Drawing.Point(0, 161);
            this.btnproductos.Name = "btnproductos";
            this.btnproductos.Size = new System.Drawing.Size(186, 42);
            this.btnproductos.TabIndex = 3;
            this.btnproductos.Text = "Productos";
            this.btnproductos.UseVisualStyleBackColor = true;
            this.btnproductos.Click += new System.EventHandler(this.btnproductos_Click);
            this.btnproductos.Leave += new System.EventHandler(this.btnproductos_Leave);
            // 
            // btndashboard
            // 
            this.btndashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btndashboard.FlatAppearance.BorderSize = 0;
            this.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndashboard.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashboard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btndashboard.Image = ((System.Drawing.Image)(resources.GetObject("btndashboard.Image")));
            this.btndashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndashboard.Location = new System.Drawing.Point(0, 119);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(186, 42);
            this.btndashboard.TabIndex = 2;
            this.btndashboard.Text = "Dashboard";
            this.btndashboard.UseVisualStyleBackColor = false;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            this.btndashboard.Leave += new System.EventHandler(this.btndashboard_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.s);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 119);
            this.panel2.TabIndex = 1;
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s.Location = new System.Drawing.Point(50, 85);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(88, 18);
            this.s.TabIndex = 2;
            this.s.Text = "User Name";
            this.s.Click += new System.EventHandler(this.s_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FinalProyect.Properties.Resources.Administrador;
            this.pictureBox1.Location = new System.Drawing.Point(53, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Hours
            // 
            this.Hours.Enabled = true;
            this.Hours.Tick += new System.EventHandler(this.Hours_Tick);
            // 
            // timeoff
            // 
            this.timeoff.Enabled = true;
            this.timeoff.Interval = 1000;
            this.timeoff.Tick += new System.EventHandler(this.timeoff_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.registrosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1106, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 20);
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Registro";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturasToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturasAlContadoToolStripMenuItem,
            this.facturaCreditoToolStripMenuItem});
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.facturasToolStripMenuItem.Text = "Facturas";
            // 
            // facturasAlContadoToolStripMenuItem
            // 
            this.facturasAlContadoToolStripMenuItem.Name = "facturasAlContadoToolStripMenuItem";
            this.facturasAlContadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.facturasAlContadoToolStripMenuItem.Text = "Facturas al contado";
            // 
            // facturaCreditoToolStripMenuItem
            // 
            this.facturaCreditoToolStripMenuItem.Name = "facturaCreditoToolStripMenuItem";
            this.facturaCreditoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.facturaCreditoToolStripMenuItem.Text = "Factura Credito";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            this.consultasToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1106, 566);
            this.Controls.Add(this.pnlinicio);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.pnlinicio.ResumeLayout(false);
            this.pnlinicio.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlinicio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.Button btndashboard;
        private System.Windows.Forms.Button btnganancias;
        private System.Windows.Forms.Button btnproveedores;
        private System.Windows.Forms.Button btnclientes;
        private System.Windows.Forms.Button btntrabajadores;
        private System.Windows.Forms.Button btncompras;
        private System.Windows.Forms.Button btnventas;
        private System.Windows.Forms.Button btnproductos;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Timer Hours;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Timer timeoff;
        private System.Windows.Forms.Label lbltimeoff;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasAlContadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaCreditoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
    }
}