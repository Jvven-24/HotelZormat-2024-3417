namespace HotelZormat.UI
{
    partial class frmGestionUsuarios
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
            this.tlpContent = new System.Windows.Forms.TableLayoutPanel();
            this.pnlGridCard = new System.Windows.Forms.Panel();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.pnlCaptura = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblAyudaContrasena = new System.Windows.Forms.Label();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlpContent.SuspendLayout();
            this.pnlGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.pnlHead.SuspendLayout();
            this.pnlCaptura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            //
            // tlpContent
            //
            this.tlpContent.ColumnCount = 3;
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62F));
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tlpContent.RowCount = 1;
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContent.Location = new System.Drawing.Point(0, 0);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.Padding = new System.Windows.Forms.Padding(20, 16, 20, 16);
            this.tlpContent.Controls.Add(this.pnlGridCard, 0, 0);
            this.tlpContent.Controls.Add(this.pnlCaptura, 2, 0);
            this.tlpContent.Size = new System.Drawing.Size(984, 561);
            this.tlpContent.TabIndex = 0;
            //
            // pnlGridCard
            //
            this.pnlGridCard.BackColor = System.Drawing.Color.FromArgb(255, 250, 241);
            this.pnlGridCard.Controls.Add(this.dgvUsuarios);
            this.pnlGridCard.Controls.Add(this.pnlHead);
            this.pnlGridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridCard.Padding = new System.Windows.Forms.Padding(14);
            this.pnlGridCard.Location = new System.Drawing.Point(20, 16);
            this.pnlGridCard.Name = "pnlGridCard";
            this.pnlGridCard.Size = new System.Drawing.Size(585, 529);
            this.pnlGridCard.TabIndex = 0;
            //
            // pnlHead
            //
            this.pnlHead.Controls.Add(this.lblSubtitulo);
            this.pnlHead.Controls.Add(this.lblTitulo);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Location = new System.Drawing.Point(14, 14);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(557, 40);
            this.pnlHead.TabIndex = 0;
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(28, 38, 36);
            this.lblTitulo.Location = new System.Drawing.Point(0, 2);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(140, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cuentas del sistema";
            //
            // lblSubtitulo
            //
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(121, 112, 93);
            this.lblSubtitulo.Location = new System.Drawing.Point(1, 24);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(230, 13);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Alta, edición y baja lógica — solo Administrador";
            //
            // dgvUsuarios
            //
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(255, 250, 241);
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.GridColor = System.Drawing.Color.FromArgb(236, 223, 192);
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(28, 38, 36);
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(234, 244, 238);
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(224, 179, 148);
            this.dgvUsuarios.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(28, 38, 36);
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(14, 54);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(557, 461);
            this.dgvUsuarios.TabIndex = 1;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            //
            // pnlCaptura
            //
            this.pnlCaptura.BackColor = System.Drawing.Color.FromArgb(255, 250, 241);
            this.pnlCaptura.Controls.Add(this.lblNombreUsuario);
            this.pnlCaptura.Controls.Add(this.txtNombreUsuario);
            this.pnlCaptura.Controls.Add(this.lblContrasena);
            this.pnlCaptura.Controls.Add(this.txtContrasena);
            this.pnlCaptura.Controls.Add(this.lblAyudaContrasena);
            this.pnlCaptura.Controls.Add(this.lblNombreCompleto);
            this.pnlCaptura.Controls.Add(this.txtNombreCompleto);
            this.pnlCaptura.Controls.Add(this.lblRol);
            this.pnlCaptura.Controls.Add(this.cboRol);
            this.pnlCaptura.Controls.Add(this.btnEliminar);
            this.pnlCaptura.Controls.Add(this.btnLimpiar);
            this.pnlCaptura.Controls.Add(this.btnGuardar);
            this.pnlCaptura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCaptura.Location = new System.Drawing.Point(603, 16);
            this.pnlCaptura.Name = "pnlCaptura";
            this.pnlCaptura.Size = new System.Drawing.Size(361, 529);
            this.pnlCaptura.TabIndex = 1;
            //
            // lblNombreUsuario
            //
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.lblNombreUsuario.Location = new System.Drawing.Point(18, 4);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(50, 15);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Usuario";
            //
            // txtNombreUsuario
            //
            this.txtNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)
            | 0)));
            this.txtNombreUsuario.BackColor = System.Drawing.Color.FromArgb(251, 243, 228);
            this.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreUsuario.MaxLength = 50;
            this.txtNombreUsuario.Location = new System.Drawing.Point(18, 21);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(325, 23);
            this.txtNombreUsuario.TabIndex = 1;
            //
            // lblContrasena
            //
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblContrasena.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.lblContrasena.Location = new System.Drawing.Point(18, 54);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(72, 15);
            this.lblContrasena.TabIndex = 2;
            this.lblContrasena.Text = "Contraseña";
            //
            // txtContrasena
            //
            this.txtContrasena.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)
            | 0)));
            this.txtContrasena.BackColor = System.Drawing.Color.FromArgb(251, 243, 228);
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasena.Location = new System.Drawing.Point(18, 71);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(325, 23);
            this.txtContrasena.TabIndex = 3;
            //
            // lblAyudaContrasena
            //
            this.lblAyudaContrasena.AutoSize = true;
            this.lblAyudaContrasena.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblAyudaContrasena.ForeColor = System.Drawing.Color.FromArgb(177, 128, 47);
            this.lblAyudaContrasena.Location = new System.Drawing.Point(18, 96);
            this.lblAyudaContrasena.Name = "lblAyudaContrasena";
            this.lblAyudaContrasena.Size = new System.Drawing.Size(0, 13);
            this.lblAyudaContrasena.TabIndex = 4;
            //
            // lblNombreCompleto
            //
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNombreCompleto.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.lblNombreCompleto.Location = new System.Drawing.Point(18, 116);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(96, 15);
            this.lblNombreCompleto.TabIndex = 5;
            this.lblNombreCompleto.Text = "Nombre completo";
            //
            // txtNombreCompleto
            //
            this.txtNombreCompleto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)
            | 0)));
            this.txtNombreCompleto.BackColor = System.Drawing.Color.FromArgb(251, 243, 228);
            this.txtNombreCompleto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCompleto.MaxLength = 100;
            this.txtNombreCompleto.Location = new System.Drawing.Point(18, 133);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(325, 23);
            this.txtNombreCompleto.TabIndex = 6;
            //
            // lblRol
            //
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.lblRol.Location = new System.Drawing.Point(18, 166);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(24, 15);
            this.lblRol.TabIndex = 7;
            this.lblRol.Text = "Rol";
            //
            // cboRol
            //
            this.cboRol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)
            | 0)));
            this.cboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Location = new System.Drawing.Point(18, 183);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(325, 23);
            this.cboRol.TabIndex = 8;
            //
            // btnEliminar
            //
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(230, 195, 189);
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(251, 243, 228);
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(178, 59, 49);
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnEliminar.Location = new System.Drawing.Point(18, 486);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 30);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Desactivar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            //
            // btnLimpiar
            //
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(225, 211, 172);
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(251, 243, 228);
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnLimpiar.Location = new System.Drawing.Point(126, 486);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            //
            // btnGuardar
            //
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(200, 90, 52);
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(255, 247, 241);
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Location = new System.Drawing.Point(234, 486);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 30);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            //
            // errorProvider1
            //
            this.errorProvider1.ContainerControl = this;
            //
            // frmGestionUsuarios
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(22, 58, 55);
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tlpContent);
            this.Name = "frmGestionUsuarios";
            this.Text = "Gestión de usuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGestionUsuarios_Load);
            this.tlpContent.ResumeLayout(false);
            this.pnlGridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            this.pnlCaptura.ResumeLayout(false);
            this.pnlCaptura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private System.Windows.Forms.Panel pnlGridCard;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel pnlCaptura;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblAyudaContrasena;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
