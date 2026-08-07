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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.flpNav = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.btnNavHabitaciones = new System.Windows.Forms.Button();
            this.btnNavHuespedes = new System.Windows.Forms.Button();
            this.btnNavReservas = new System.Windows.Forms.Button();
            this.btnNavCheckInOut = new System.Windows.Forms.Button();
            this.btnNavReportes = new System.Windows.Forms.Button();
            this.btnNavBitacora = new System.Windows.Forms.Button();
            this.btnNavUsuarios = new System.Windows.Forms.Button();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.flpFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlBrand = new System.Windows.Forms.Panel();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblMarcaSub = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.flpNav.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.flpFooter.SuspendLayout();
            this.pnlBrand.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlBrand
            //
            this.pnlBrand.BackColor = System.Drawing.Color.FromArgb(12, 37, 35);
            this.pnlBrand.Controls.Add(this.lblMarcaSub);
            this.pnlBrand.Controls.Add(this.lblMarca);
            this.pnlBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBrand.Location = new System.Drawing.Point(0, 0);
            this.pnlBrand.Name = "pnlBrand";
            this.pnlBrand.Size = new System.Drawing.Size(232, 68);
            this.pnlBrand.TabIndex = 0;
            //
            // lblMarca
            //
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMarca.ForeColor = System.Drawing.Color.FromArgb(234, 244, 238);
            this.lblMarca.Location = new System.Drawing.Point(18, 12);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(139, 24);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "HotelZormat";
            //
            // lblMarcaSub
            //
            this.lblMarcaSub.AutoSize = true;
            this.lblMarcaSub.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMarcaSub.ForeColor = System.Drawing.Color.FromArgb(143, 179, 170);
            this.lblMarcaSub.Location = new System.Drawing.Point(19, 40);
            this.lblMarcaSub.Name = "lblMarcaSub";
            this.lblMarcaSub.Size = new System.Drawing.Size(130, 13);
            this.lblMarcaSub.TabIndex = 1;
            this.lblMarcaSub.Text = "Sistema de gestión hotelera";
            //
            // flpNav
            //
            this.flpNav.BackColor = System.Drawing.Color.Transparent;
            this.flpNav.Controls.Add(this.btnNavDashboard);
            this.flpNav.Controls.Add(this.btnNavHabitaciones);
            this.flpNav.Controls.Add(this.btnNavHuespedes);
            this.flpNav.Controls.Add(this.btnNavReservas);
            this.flpNav.Controls.Add(this.btnNavCheckInOut);
            this.flpNav.Controls.Add(this.btnNavReportes);
            this.flpNav.Controls.Add(this.btnNavBitacora);
            this.flpNav.Controls.Add(this.btnNavUsuarios);
            this.flpNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpNav.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpNav.Location = new System.Drawing.Point(0, 68);
            this.flpNav.Name = "flpNav";
            this.flpNav.Padding = new System.Windows.Forms.Padding(12, 14, 12, 10);
            this.flpNav.AutoScroll = true;
            this.flpNav.WrapContents = false;
            this.flpNav.Size = new System.Drawing.Size(232, 375);
            this.flpNav.TabIndex = 1;
            //
            // btnNavDashboard
            //
            this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDashboard.FlatAppearance.BorderSize = 0;
            this.btnNavDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(22, 58, 55);
            this.btnNavDashboard.BackColor = System.Drawing.Color.FromArgb(16, 48, 46);
            this.btnNavDashboard.ForeColor = System.Drawing.Color.FromArgb(143, 179, 170);
            this.btnNavDashboard.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavDashboard.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnNavDashboard.Name = "btnNavDashboard";
            this.btnNavDashboard.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnNavDashboard.Size = new System.Drawing.Size(206, 42);
            this.btnNavDashboard.TabIndex = 0;
            this.btnNavDashboard.Text = "Dashboard";
            this.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDashboard.UseVisualStyleBackColor = false;
            this.btnNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavDashboard.Click += new System.EventHandler(this.btnNavDashboard_Click);
            //
            // btnNavHabitaciones
            //
            this.btnNavHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavHabitaciones.FlatAppearance.BorderSize = 0;
            this.btnNavHabitaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(22, 58, 55);
            this.btnNavHabitaciones.BackColor = System.Drawing.Color.FromArgb(16, 48, 46);
            this.btnNavHabitaciones.ForeColor = System.Drawing.Color.FromArgb(143, 179, 170);
            this.btnNavHabitaciones.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavHabitaciones.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnNavHabitaciones.Name = "btnNavHabitaciones";
            this.btnNavHabitaciones.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnNavHabitaciones.Size = new System.Drawing.Size(206, 42);
            this.btnNavHabitaciones.TabIndex = 1;
            this.btnNavHabitaciones.Text = "Habitaciones";
            this.btnNavHabitaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavHabitaciones.UseVisualStyleBackColor = false;
            this.btnNavHabitaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavHabitaciones.Click += new System.EventHandler(this.btnNavHabitaciones_Click);
            //
            // btnNavHuespedes
            //
            this.btnNavHuespedes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavHuespedes.FlatAppearance.BorderSize = 0;
            this.btnNavHuespedes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(22, 58, 55);
            this.btnNavHuespedes.BackColor = System.Drawing.Color.FromArgb(16, 48, 46);
            this.btnNavHuespedes.ForeColor = System.Drawing.Color.FromArgb(143, 179, 170);
            this.btnNavHuespedes.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavHuespedes.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnNavHuespedes.Name = "btnNavHuespedes";
            this.btnNavHuespedes.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnNavHuespedes.Size = new System.Drawing.Size(206, 42);
            this.btnNavHuespedes.TabIndex = 2;
            this.btnNavHuespedes.Text = "Huéspedes";
            this.btnNavHuespedes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavHuespedes.UseVisualStyleBackColor = false;
            this.btnNavHuespedes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavHuespedes.Click += new System.EventHandler(this.btnNavHuespedes_Click);
            //
            // btnNavReservas
            //
            this.btnNavReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavReservas.FlatAppearance.BorderSize = 0;
            this.btnNavReservas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(22, 58, 55);
            this.btnNavReservas.BackColor = System.Drawing.Color.FromArgb(16, 48, 46);
            this.btnNavReservas.ForeColor = System.Drawing.Color.FromArgb(143, 179, 170);
            this.btnNavReservas.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavReservas.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnNavReservas.Name = "btnNavReservas";
            this.btnNavReservas.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnNavReservas.Size = new System.Drawing.Size(206, 42);
            this.btnNavReservas.TabIndex = 3;
            this.btnNavReservas.Text = "Reservas";
            this.btnNavReservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavReservas.UseVisualStyleBackColor = false;
            this.btnNavReservas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavReservas.Click += new System.EventHandler(this.btnNavReservas_Click);
            //
            // btnNavCheckInOut
            //
            this.btnNavCheckInOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavCheckInOut.FlatAppearance.BorderSize = 0;
            this.btnNavCheckInOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(22, 58, 55);
            this.btnNavCheckInOut.BackColor = System.Drawing.Color.FromArgb(16, 48, 46);
            this.btnNavCheckInOut.ForeColor = System.Drawing.Color.FromArgb(143, 179, 170);
            this.btnNavCheckInOut.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavCheckInOut.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnNavCheckInOut.Name = "btnNavCheckInOut";
            this.btnNavCheckInOut.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnNavCheckInOut.Size = new System.Drawing.Size(206, 42);
            this.btnNavCheckInOut.TabIndex = 4;
            this.btnNavCheckInOut.Text = "Check-in / out";
            this.btnNavCheckInOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavCheckInOut.UseVisualStyleBackColor = false;
            this.btnNavCheckInOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavCheckInOut.Click += new System.EventHandler(this.btnNavCheckInOut_Click);
            //
            // btnNavReportes
            //
            this.btnNavReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavReportes.FlatAppearance.BorderSize = 0;
            this.btnNavReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(22, 58, 55);
            this.btnNavReportes.BackColor = System.Drawing.Color.FromArgb(16, 48, 46);
            this.btnNavReportes.ForeColor = System.Drawing.Color.FromArgb(143, 179, 170);
            this.btnNavReportes.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavReportes.Margin = new System.Windows.Forms.Padding(0, 10, 0, 4);
            this.btnNavReportes.Name = "btnNavReportes";
            this.btnNavReportes.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnNavReportes.Size = new System.Drawing.Size(206, 42);
            this.btnNavReportes.TabIndex = 5;
            this.btnNavReportes.Text = "Reportes";
            this.btnNavReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavReportes.UseVisualStyleBackColor = false;
            this.btnNavReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavReportes.Click += new System.EventHandler(this.btnNavReportes_Click);
            //
            // btnNavBitacora
            //
            this.btnNavBitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavBitacora.FlatAppearance.BorderSize = 0;
            this.btnNavBitacora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(22, 58, 55);
            this.btnNavBitacora.BackColor = System.Drawing.Color.FromArgb(16, 48, 46);
            this.btnNavBitacora.ForeColor = System.Drawing.Color.FromArgb(143, 179, 170);
            this.btnNavBitacora.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavBitacora.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnNavBitacora.Name = "btnNavBitacora";
            this.btnNavBitacora.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnNavBitacora.Size = new System.Drawing.Size(206, 42);
            this.btnNavBitacora.TabIndex = 6;
            this.btnNavBitacora.Text = "Bitácora";
            this.btnNavBitacora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavBitacora.UseVisualStyleBackColor = false;
            this.btnNavBitacora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavBitacora.Click += new System.EventHandler(this.btnNavBitacora_Click);
            //
            // btnNavUsuarios
            //
            this.btnNavUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavUsuarios.FlatAppearance.BorderSize = 0;
            this.btnNavUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(22, 58, 55);
            this.btnNavUsuarios.BackColor = System.Drawing.Color.FromArgb(16, 48, 46);
            this.btnNavUsuarios.ForeColor = System.Drawing.Color.FromArgb(143, 179, 170);
            this.btnNavUsuarios.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavUsuarios.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnNavUsuarios.Name = "btnNavUsuarios";
            this.btnNavUsuarios.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnNavUsuarios.Size = new System.Drawing.Size(206, 42);
            this.btnNavUsuarios.TabIndex = 7;
            this.btnNavUsuarios.Text = "Usuarios";
            this.btnNavUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavUsuarios.UseVisualStyleBackColor = false;
            this.btnNavUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavUsuarios.Click += new System.EventHandler(this.btnNavUsuarios_Click);
            //
            // pnlFooter
            //
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(12, 37, 35);
            this.pnlFooter.Controls.Add(this.flpFooter);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 443);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.pnlFooter.Size = new System.Drawing.Size(232, 118);
            this.pnlFooter.TabIndex = 2;
            //
            // flpFooter
            //
            this.flpFooter.Controls.Add(this.lblUsuario);
            this.flpFooter.Controls.Add(this.btnCerrarSesion);
            this.flpFooter.Controls.Add(this.btnSalir);
            this.flpFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpFooter.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpFooter.Location = new System.Drawing.Point(16, 12);
            this.flpFooter.Name = "flpFooter";
            this.flpFooter.WrapContents = false;
            this.flpFooter.Size = new System.Drawing.Size(200, 94);
            this.flpFooter.TabIndex = 0;
            //
            // lblUsuario
            //
            this.lblUsuario.AutoSize = false;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(234, 244, 238);
            this.lblUsuario.Location = new System.Drawing.Point(0, 0);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(200, 34);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            //
            // btnCerrarSesion
            //
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 1;
            this.btnCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(28, 67, 63);
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(22, 58, 55);
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(12, 37, 35);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(143, 179, 170);
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(200, 32);
            this.btnCerrarSesion.TabIndex = 1;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            //
            // btnSalir
            //
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(12, 37, 35);
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(143, 179, 170);
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(200, 22);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            //
            // pnlSidebar
            //
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(16, 48, 46);
            this.pnlSidebar.Controls.Add(this.flpNav);
            this.pnlSidebar.Controls.Add(this.pnlFooter);
            this.pnlSidebar.Controls.Add(this.pnlBrand);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(232, 561);
            this.pnlSidebar.TabIndex = 0;
            //
            // FrmPrincipal
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(22, 58, 55);
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pnlSidebar);
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.Text = "Hotel Zormat — Sistema de Gestión";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.flpNav.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.flpFooter.ResumeLayout(false);
            this.pnlBrand.ResumeLayout(false);
            this.pnlBrand.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlBrand;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblMarcaSub;
        private System.Windows.Forms.FlowLayoutPanel flpNav;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnNavHabitaciones;
        private System.Windows.Forms.Button btnNavHuespedes;
        private System.Windows.Forms.Button btnNavReservas;
        private System.Windows.Forms.Button btnNavCheckInOut;
        private System.Windows.Forms.Button btnNavReportes;
        private System.Windows.Forms.Button btnNavBitacora;
        private System.Windows.Forms.Button btnNavUsuarios;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.FlowLayoutPanel flpFooter;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnSalir;
    }
}
