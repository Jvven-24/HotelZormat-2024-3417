namespace HotelZormat.UI
{
    partial class frmGestionHuespedes
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
            this.tlpRoot = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tlpContent = new System.Windows.Forms.TableLayoutPanel();
            this.pnlGridCard = new System.Windows.Forms.Panel();
            this.dgvHuespedes = new System.Windows.Forms.DataGridView();
            this.pnlCaptura = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlpRoot.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            this.tlpContent.SuspendLayout();
            this.pnlGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuespedes)).BeginInit();
            this.pnlCaptura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            //
            // tlpRoot
            //
            this.tlpRoot.ColumnCount = 1;
            this.tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.RowCount = 2;
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRoot.Location = new System.Drawing.Point(0, 0);
            this.tlpRoot.Name = "tlpRoot";
            this.tlpRoot.Padding = new System.Windows.Forms.Padding(20, 16, 20, 16);
            this.tlpRoot.Controls.Add(this.pnlFiltros, 0, 0);
            this.tlpRoot.Controls.Add(this.tlpContent, 0, 1);
            this.tlpRoot.Size = new System.Drawing.Size(984, 561);
            this.tlpRoot.TabIndex = 0;
            //
            // pnlFiltros
            //
            this.pnlFiltros.BackColor = System.Drawing.Color.FromArgb(255, 250, 241);
            this.pnlFiltros.Controls.Add(this.lblBuscar);
            this.pnlFiltros.Controls.Add(this.txtBuscar);
            this.pnlFiltros.Controls.Add(this.btnBuscar);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFiltros.Location = new System.Drawing.Point(20, 16);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(944, 62);
            this.pnlFiltros.TabIndex = 0;
            //
            // lblBuscar
            //
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.lblBuscar.Location = new System.Drawing.Point(18, 22);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(48, 15);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar:";
            //
            // txtBuscar
            //
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(251, 243, 228);
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Location = new System.Drawing.Point(78, 18);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(300, 23);
            this.txtBuscar.TabIndex = 1;
            //
            // btnBuscar
            //
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(225, 211, 172);
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(251, 243, 228);
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnBuscar.Location = new System.Drawing.Point(388, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 27);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.tlpContent.Location = new System.Drawing.Point(20, 78);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.Controls.Add(this.pnlGridCard, 0, 0);
            this.tlpContent.Controls.Add(this.pnlCaptura, 2, 0);
            this.tlpContent.Size = new System.Drawing.Size(944, 467);
            this.tlpContent.TabIndex = 1;
            //
            // pnlGridCard
            //
            this.pnlGridCard.BackColor = System.Drawing.Color.FromArgb(255, 250, 241);
            this.pnlGridCard.Controls.Add(this.dgvHuespedes);
            this.pnlGridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridCard.Padding = new System.Windows.Forms.Padding(14);
            this.pnlGridCard.Location = new System.Drawing.Point(0, 0);
            this.pnlGridCard.Name = "pnlGridCard";
            this.pnlGridCard.Size = new System.Drawing.Size(585, 467);
            this.pnlGridCard.TabIndex = 0;
            //
            // dgvHuespedes
            //
            this.dgvHuespedes.BackgroundColor = System.Drawing.Color.FromArgb(255, 250, 241);
            this.dgvHuespedes.AllowUserToResizeColumns = false;
            this.dgvHuespedes.AllowUserToResizeRows = false;
            this.dgvHuespedes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHuespedes.RowHeadersVisible = false;
            this.dgvHuespedes.EnableHeadersVisualStyles = false;
            this.dgvHuespedes.GridColor = System.Drawing.Color.FromArgb(236, 223, 192);
            this.dgvHuespedes.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(28, 38, 36);
            this.dgvHuespedes.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(234, 244, 238);
            this.dgvHuespedes.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.dgvHuespedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHuespedes.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(224, 179, 148);
            this.dgvHuespedes.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(28, 38, 36);
            this.dgvHuespedes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHuespedes.Location = new System.Drawing.Point(14, 14);
            this.dgvHuespedes.Name = "dgvHuespedes";
            this.dgvHuespedes.ReadOnly = true;
            this.dgvHuespedes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHuespedes.Size = new System.Drawing.Size(557, 439);
            this.dgvHuespedes.TabIndex = 0;
            this.dgvHuespedes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHuespedes_CellContentClick);
            //
            // pnlCaptura
            //
            this.pnlCaptura.BackColor = System.Drawing.Color.FromArgb(255, 250, 241);
            this.pnlCaptura.Controls.Add(this.lblNombre);
            this.pnlCaptura.Controls.Add(this.txtNombre);
            this.pnlCaptura.Controls.Add(this.lblApellido);
            this.pnlCaptura.Controls.Add(this.txtApellido);
            this.pnlCaptura.Controls.Add(this.lblTipoDocumento);
            this.pnlCaptura.Controls.Add(this.cboTipoDocumento);
            this.pnlCaptura.Controls.Add(this.lblNumeroDocumento);
            this.pnlCaptura.Controls.Add(this.txtNumeroDocumento);
            this.pnlCaptura.Controls.Add(this.lblAyuda);
            this.pnlCaptura.Controls.Add(this.lblNacionalidad);
            this.pnlCaptura.Controls.Add(this.txtNacionalidad);
            this.pnlCaptura.Controls.Add(this.lblTelefono);
            this.pnlCaptura.Controls.Add(this.txtTelefono);
            this.pnlCaptura.Controls.Add(this.lblEmail);
            this.pnlCaptura.Controls.Add(this.txtEmail);
            this.pnlCaptura.Controls.Add(this.btnGuardar);
            this.pnlCaptura.Controls.Add(this.btnEliminar);
            this.pnlCaptura.Controls.Add(this.btnLimpiar);
            this.pnlCaptura.Controls.Add(this.btnHistorial);
            this.pnlCaptura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCaptura.Location = new System.Drawing.Point(603, 0);
            this.pnlCaptura.Name = "pnlCaptura";
            this.pnlCaptura.Size = new System.Drawing.Size(341, 467);
            this.pnlCaptura.TabIndex = 1;
            //
            // lblNombre
            //
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.lblNombre.Location = new System.Drawing.Point(18, 4);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(53, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            //
            // txtNombre
            //
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)
            | 0)));
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(251, 243, 228);
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(18, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(305, 23);
            this.txtNombre.TabIndex = 1;
            //
            // lblApellido
            //
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.lblApellido.Location = new System.Drawing.Point(18, 54);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(52, 15);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            //
            // txtApellido
            //
            this.txtApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)
            | 0)));
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(251, 243, 228);
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Location = new System.Drawing.Point(18, 71);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(305, 23);
            this.txtApellido.TabIndex = 3;
            //
            // lblTipoDocumento
            //
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTipoDocumento.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.lblTipoDocumento.Location = new System.Drawing.Point(18, 104);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(66, 15);
            this.lblTipoDocumento.TabIndex = 4;
            this.lblTipoDocumento.Text = "Tipo Doc.";
            //
            // cboTipoDocumento
            //
            this.cboTipoDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)
            | 0)));
            this.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Location = new System.Drawing.Point(18, 121);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(305, 23);
            this.cboTipoDocumento.TabIndex = 5;
            this.cboTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cboTipoDocumento_SelectedIndexChanged);
            //
            // lblNumeroDocumento
            //
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNumeroDocumento.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.lblNumeroDocumento.Location = new System.Drawing.Point(18, 154);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(75, 15);
            this.lblNumeroDocumento.TabIndex = 6;
            this.lblNumeroDocumento.Text = "Núm. Doc.";
            //
            // txtNumeroDocumento
            //
            this.txtNumeroDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)
            | 0)));
            this.txtNumeroDocumento.BackColor = System.Drawing.Color.FromArgb(251, 243, 228);
            this.txtNumeroDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroDocumento.Location = new System.Drawing.Point(18, 171);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(305, 23);
            this.txtNumeroDocumento.TabIndex = 7;
            //
            // lblAyuda
            //
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblAyuda.ForeColor = System.Drawing.Color.FromArgb(177, 128, 47);
            this.lblAyuda.Location = new System.Drawing.Point(18, 196);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(0, 13);
            this.lblAyuda.TabIndex = 8;
            //
            // lblNacionalidad
            //
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNacionalidad.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.lblNacionalidad.Location = new System.Drawing.Point(18, 214);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(78, 15);
            this.lblNacionalidad.TabIndex = 9;
            this.lblNacionalidad.Text = "Nacionalidad";
            //
            // txtNacionalidad
            //
            this.txtNacionalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)
            | 0)));
            this.txtNacionalidad.BackColor = System.Drawing.Color.FromArgb(251, 243, 228);
            this.txtNacionalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNacionalidad.Location = new System.Drawing.Point(18, 231);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(305, 23);
            this.txtNacionalidad.TabIndex = 10;
            //
            // lblTelefono
            //
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.lblTelefono.Location = new System.Drawing.Point(18, 264);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(56, 15);
            this.lblTelefono.TabIndex = 11;
            this.lblTelefono.Text = "Teléfono";
            //
            // txtTelefono
            //
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)
            | 0)));
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(251, 243, 228);
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Location = new System.Drawing.Point(18, 281);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(305, 23);
            this.txtTelefono.TabIndex = 12;
            //
            // lblEmail
            //
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.lblEmail.Location = new System.Drawing.Point(18, 314);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 15);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email";
            //
            // txtEmail
            //
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)
            | 0)));
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(251, 243, 228);
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(18, 331);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(305, 23);
            this.txtEmail.TabIndex = 14;
            //
            // btnGuardar
            //
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(200, 90, 52);
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(255, 247, 241);
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Location = new System.Drawing.Point(18, 424);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(72, 30);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            //
            // btnEliminar
            //
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(230, 195, 189);
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(251, 243, 228);
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(178, 59, 49);
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnEliminar.Location = new System.Drawing.Point(96, 424);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(72, 30);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
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
            this.btnLimpiar.Location = new System.Drawing.Point(174, 424);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(72, 30);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            //
            // btnHistorial
            //
            this.btnHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(225, 211, 172);
            this.btnHistorial.BackColor = System.Drawing.Color.FromArgb(251, 243, 228);
            this.btnHistorial.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.btnHistorial.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnHistorial.Location = new System.Drawing.Point(252, 424);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(90, 30);
            this.btnHistorial.TabIndex = 18;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            //
            // errorProvider1
            //
            this.errorProvider1.ContainerControl = this;
            //
            // frmGestionHuespedes
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(22, 58, 55);
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tlpRoot);
            this.Name = "frmGestionHuespedes";
            this.Text = "Gestión de huéspedes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGestionHuespedes_Load);
            this.tlpRoot.ResumeLayout(false);
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.tlpContent.ResumeLayout(false);
            this.pnlGridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuespedes)).EndInit();
            this.pnlCaptura.ResumeLayout(false);
            this.pnlCaptura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private System.Windows.Forms.Panel pnlGridCard;
        private System.Windows.Forms.DataGridView dgvHuespedes;
        private System.Windows.Forms.Panel pnlCaptura;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.Label lblAyuda;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
