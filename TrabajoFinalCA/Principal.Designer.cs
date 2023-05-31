namespace TrabajoFinalCA
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.crearTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirOCrearFicheroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearTicketToolStripMenuItem,
            this.consultarTicketsToolStripMenuItem,
            this.modificarTicketsToolStripMenuItem,
            this.eliminarTicketsToolStripMenuItem,
            this.abrirOCrearFicheroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // crearTicketToolStripMenuItem
            // 
            this.crearTicketToolStripMenuItem.Name = "crearTicketToolStripMenuItem";
            this.crearTicketToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.crearTicketToolStripMenuItem.Text = "Crear Ticket";
            this.crearTicketToolStripMenuItem.Click += new System.EventHandler(this.crearTicketToolStripMenuItem_Click);
            // 
            // consultarTicketsToolStripMenuItem
            // 
            this.consultarTicketsToolStripMenuItem.Name = "consultarTicketsToolStripMenuItem";
            this.consultarTicketsToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.consultarTicketsToolStripMenuItem.Text = "Consultar Tickets";
            this.consultarTicketsToolStripMenuItem.Click += new System.EventHandler(this.consultarTicketsToolStripMenuItem_Click);
            // 
            // modificarTicketsToolStripMenuItem
            // 
            this.modificarTicketsToolStripMenuItem.Name = "modificarTicketsToolStripMenuItem";
            this.modificarTicketsToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.modificarTicketsToolStripMenuItem.Text = "Modificar Tickets";
            this.modificarTicketsToolStripMenuItem.Click += new System.EventHandler(this.modificarTicketsToolStripMenuItem_Click);
            // 
            // eliminarTicketsToolStripMenuItem
            // 
            this.eliminarTicketsToolStripMenuItem.Name = "eliminarTicketsToolStripMenuItem";
            this.eliminarTicketsToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.eliminarTicketsToolStripMenuItem.Text = "Eliminar tickets";
            this.eliminarTicketsToolStripMenuItem.Click += new System.EventHandler(this.eliminarTicketsToolStripMenuItem_Click);
            // 
            // abrirOCrearFicheroToolStripMenuItem
            // 
            this.abrirOCrearFicheroToolStripMenuItem.Name = "abrirOCrearFicheroToolStripMenuItem";
            this.abrirOCrearFicheroToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.abrirOCrearFicheroToolStripMenuItem.Text = "Abrir o crear fichero";
            this.abrirOCrearFicheroToolStripMenuItem.Click += new System.EventHandler(this.abrirOCrearFicheroToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabajoFinalCA.Properties.Resources.fondoTickets;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Gestión Tickets";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem crearTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarTicketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarTicketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarTicketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirOCrearFicheroToolStripMenuItem;
    }
}

