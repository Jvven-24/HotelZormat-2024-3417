namespace HotelZormat.UI
{
    partial class FrmPrincipal
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuDashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHabitaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHuespedes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCheckInOut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBitacora = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuPrincipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDashboard,
            this.menuHabitaciones,
            this.menuHuespedes,
            this.menuReservas,
            this.menuCheckInOut,
            this.menuReportes,
            this.menuBitacora,
            this.menuSalir});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(984, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            this.IsMdiContainer = true;
            // 
            // menuDashboard
            // 
            this.menuDashboard.Name = "menuDashboard";
            this.menuDashboard.Size = new System.Drawing.Size(76, 20);
            this.menuDashboard.Text = "Dashboard";
            this.menuDashboard.Click += new System.EventHandler(this.menuDashboard_Click);
            // 
            // menuHabitaciones
            // 
            this.menuHabitaciones.Name = "menuHabitaciones";
            this.menuHabitaciones.Size = new System.Drawing.Size(88, 20);
            this.menuHabitaciones.Text = "Habitaciones";
            this.menuHabitaciones.Click += new System.EventHandler(this.menuHabitaciones_Click);
            // 
            // menuHuespedes
            // 
            this.menuHuespedes.Name = "menuHuespedes";
            this.menuHuespedes.Size = new System.Drawing.Size(77, 20);
            this.menuHuespedes.Text = "Huéspedes";
            this.menuHuespedes.Click += new System.EventHandler(this.huespedesToolStripMenuItem_Click);
            // 
            // menuReservas
            // 
            this.menuReservas.Name = "menuReservas";
            this.menuReservas.Size = new System.Drawing.Size(64, 20);
            this.menuReservas.Text = "Reservas";
            this.menuReservas.Click += new System.EventHandler(this.menuReservas_Click);
            // 
            // menuCheckInOut
            // 
            this.menuCheckInOut.Name = "menuCheckInOut";
            this.menuCheckInOut.Size = new System.Drawing.Size(93, 20);
            this.menuCheckInOut.Text = "Check- in/out";
            this.menuCheckInOut.Click += new System.EventHandler(this.menuCheckInOut_Click);
            // 
            // menuReportes
            // 
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(65, 20);
            this.menuReportes.Text = "Reportes";
            this.menuReportes.Click += new System.EventHandler(this.menuReportes_Click);
            // 
            // menuBitacora
            // 
            this.menuBitacora.Name = "menuBitacora";
            this.menuBitacora.Size = new System.Drawing.Size(62, 20);
            this.menuBitacora.Text = "Bitacora";
            this.menuBitacora.Click += new System.EventHandler(this.menuBitacora_Click);
            // 
            // menuSalir
            // 
            this.menuSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuSalir.Name = "menuSalir";
            this.menuSalir.Size = new System.Drawing.Size(41, 20);
            this.menuSalir.Text = "Salir";
            this.menuSalir.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.menuSalir.Click += new System.EventHandler(this.menuSalir_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 559);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(47, 17);
            this.lblUsuario.Text = "Usuario";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 581);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FrmPrincipal";
            this.Text = "Hotel Zormat — Sistema de Gestión";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuDashboard;
        private System.Windows.Forms.ToolStripMenuItem menuHabitaciones;
        private System.Windows.Forms.ToolStripMenuItem menuHuespedes;
        private System.Windows.Forms.ToolStripMenuItem menuReservas;
        private System.Windows.Forms.ToolStripMenuItem menuCheckInOut;
        private System.Windows.Forms.ToolStripMenuItem menuReportes;
        private System.Windows.Forms.ToolStripMenuItem menuBitacora;
        private System.Windows.Forms.ToolStripMenuItem menuSalir;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
    }
}

