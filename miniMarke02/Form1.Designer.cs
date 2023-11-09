namespace miniMarke02
{
    partial class Form1
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarMinimarketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.toolStripMenuItem5,
            this.clienteToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarMinimarketToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(80, 20);
            this.toolStripMenuItem1.Text = "MiniMarket";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // actualizarMinimarketToolStripMenuItem
            // 
            this.actualizarMinimarketToolStripMenuItem.Name = "actualizarMinimarketToolStripMenuItem";
            this.actualizarMinimarketToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.actualizarMinimarketToolStripMenuItem.Text = "ActualizarMinimarket";
            this.actualizarMinimarketToolStripMenuItem.Click += new System.EventHandler(this.actualizarMinimarketToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarProveedorToolStripMenuItem,
            this.actualizarProveedorToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(73, 20);
            this.toolStripMenuItem3.Text = "Proveedor";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // registrarProveedorToolStripMenuItem
            // 
            this.registrarProveedorToolStripMenuItem.Name = "registrarProveedorToolStripMenuItem";
            this.registrarProveedorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarProveedorToolStripMenuItem.Text = "RegistrarProveedor";
            this.registrarProveedorToolStripMenuItem.Click += new System.EventHandler(this.registrarProveedorToolStripMenuItem_Click);
            // 
            // actualizarProveedorToolStripMenuItem
            // 
            this.actualizarProveedorToolStripMenuItem.Name = "actualizarProveedorToolStripMenuItem";
            this.actualizarProveedorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.actualizarProveedorToolStripMenuItem.Text = "ActualizarProveedor";
            this.actualizarProveedorToolStripMenuItem.Click += new System.EventHandler(this.actualizarProveedorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarCategoriaToolStripMenuItem,
            this.actualizarCategoriaToolStripMenuItem});
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(70, 20);
            this.toolStripMenuItem5.Text = "Categoria";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // registrarCategoriaToolStripMenuItem
            // 
            this.registrarCategoriaToolStripMenuItem.Name = "registrarCategoriaToolStripMenuItem";
            this.registrarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarCategoriaToolStripMenuItem.Text = "RegistrarCategoria";
            this.registrarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.registrarCategoriaToolStripMenuItem_Click);
            // 
            // actualizarCategoriaToolStripMenuItem
            // 
            this.actualizarCategoriaToolStripMenuItem.Name = "actualizarCategoriaToolStripMenuItem";
            this.actualizarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.actualizarCategoriaToolStripMenuItem.Text = "ActualizarCategoria";
            this.actualizarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.actualizarCategoriaToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarClienteToolStripMenuItem,
            this.actualizarClienteToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // registrarClienteToolStripMenuItem
            // 
            this.registrarClienteToolStripMenuItem.Name = "registrarClienteToolStripMenuItem";
            this.registrarClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarClienteToolStripMenuItem.Text = "RegistrarCliente";
            this.registrarClienteToolStripMenuItem.Click += new System.EventHandler(this.registrarClienteToolStripMenuItem_Click);
            // 
            // actualizarClienteToolStripMenuItem
            // 
            this.actualizarClienteToolStripMenuItem.Name = "actualizarClienteToolStripMenuItem";
            this.actualizarClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.actualizarClienteToolStripMenuItem.Text = "ActualizarCliente";
            this.actualizarClienteToolStripMenuItem.Click += new System.EventHandler(this.actualizarClienteToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem actualizarMinimarketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem registrarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem registrarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarClienteToolStripMenuItem;
    }
}

