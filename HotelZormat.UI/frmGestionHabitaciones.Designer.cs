namespace HotelZormat.UI
{
    partial class frmGestionHabitaciones
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
            this.lblFiltroPiso = new System.Windows.Forms.Label();
            this.cboFiltroPiso = new System.Windows.Forms.ComboBox();
            this.lblFiltroEstado = new System.Windows.Forms.Label();
            this.cboFiltroEstado = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.tlpContent = new System.Windows.Forms.TableLayoutPanel();
            this.pnlGridCard = new System.Windows.Forms.Panel();
            this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.pnlCaptura = new System.Windows.Forms.Panel();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblPiso = new System.Windows.Forms.Label();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.lblEstadoForm = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.lblTarifa = new System.Windows.Forms.Label();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.lblIcono = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlpRoot.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            this.tlpContent.SuspendLayout();
            this.pnlGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
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
            this.pnlFiltros.Controls.Add(this.lblFiltroPiso);
            this.pnlFiltros.Controls.Add(this.cboFiltroPiso);
            this.pnlFiltros.Controls.Add(this.lblFiltroEstado);
            this.pnlFiltros.Controls.Add(this.cboFiltroEstado);
            this.pnlFiltros.Controls.Add(this.btnFiltrar);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFiltros.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.pnlFiltros.Location = new System.Drawing.Point(20, 16);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(944, 62);
            this.pnlFiltros.TabIndex = 0;
            //
            // lblFiltroPiso
            //
            this.lblFiltroPiso.AutoSize = true;
            this.lblFiltroPiso.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFiltroPiso.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.lblFiltroPiso.Location = new System.Drawing.Point(18, 22);
            this.lblFiltroPiso.Name = "lblFiltroPiso";
            this.lblFiltroPiso.Size = new System.Drawing.Size(30, 15);
            this.lblFiltroPiso.TabIndex = 0;
            this.lblFiltroPiso.Text = "Piso:";
            //
            // cboFiltroPiso
            //
            this.cboFiltroPiso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroPiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFiltroPiso.FormattingEnabled = true;
            this.cboFiltroPiso.Location = new System.Drawing.Point(56, 18);
            this.cboFiltroPiso.Name = "cboFiltroPiso";
            this.cboFiltroPiso.Size = new System.Drawing.Size(110, 23);
            this.cboFiltroPiso.TabIndex = 1;
            //
            // lblFiltroEstado
            //
            this.lblFiltroEstado.AutoSize = true;
            this.lblFiltroEstado.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFiltroEstado.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.lblFiltroEstado.Location = new System.Drawing.Point(190, 22);
            this.lblFiltroEstado.Name = "lblFiltroEstado";
            this.lblFiltroEstado.Size = new System.Drawing.Size(43, 15);
            this.lblFiltroEstado.TabIndex = 2;
            this.lblFiltroEstado.Text = "Estado:";
            //
            // cboFiltroEstado
            //
            this.cboFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFiltroEstado.FormattingEnabled = true;
            this.cboFiltroEstado.Location = new System.Drawing.Point(240, 18);
            this.cboFiltroEstado.Name = "cboFiltroEstado";
            this.cboFiltroEstado.Size = new System.Drawing.Size(140, 23);
            this.cboFiltroEstado.TabIndex = 3;
            //
            // btnFiltrar
            //
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(225, 211, 172);
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(251, 243, 228);
            this.btnFiltrar.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnFiltrar.Location = new System.Drawing.Point(396, 16);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(90, 27);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
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
            this.pnlGridCard.Controls.Add(this.dgvHabitaciones);
            this.pnlGridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridCard.Padding = new System.Windows.Forms.Padding(14);
            this.pnlGridCard.Location = new System.Drawing.Point(0, 0);
            this.pnlGridCard.Name = "pnlGridCard";
            this.pnlGridCard.Size = new System.Drawing.Size(585, 467);
            this.pnlGridCard.TabIndex = 0;
            //
            // dgvHabitaciones
            //
            this.dgvHabitaciones.BackgroundColor = System.Drawing.Color.FromArgb(255, 250, 241);
            this.dgvHabitaciones.AllowUserToResizeColumns = false;
            this.dgvHabitaciones.AllowUserToResizeRows = false;
            this.dgvHabitaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHabitaciones.RowHeadersVisible = false;
            this.dgvHabitaciones.EnableHeadersVisualStyles = false;
            this.dgvHabitaciones.GridColor = System.Drawing.Color.FromArgb(236, 223, 192);
            this.dgvHabitaciones.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(28, 38, 36);
            this.dgvHabitaciones.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(234, 244, 238);
            this.dgvHabitaciones.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(224, 179, 148);
            this.dgvHabitaciones.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(28, 38, 36);
            this.dgvHabitaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHabitaciones.Location = new System.Drawing.Point(14, 14);
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.ReadOnly = true;
            this.dgvHabitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHabitaciones.Size = new System.Drawing.Size(557, 439);
            this.dgvHabitaciones.TabIndex = 0;
            this.dgvHabitaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHabitaciones_CellContentClick);
            //
            // pnlCaptura
            //
            this.pnlCaptura.BackColor = System.Drawing.Color.FromArgb(255, 250, 241);
            this.pnlCaptura.Controls.Add(this.lblNumero);
            this.pnlCaptura.Controls.Add(this.txtNumero);
            this.pnlCaptura.Controls.Add(this.lblTipo);
            this.pnlCaptura.Controls.Add(this.cboTipo);
            this.pnlCaptura.Controls.Add(this.lblPiso);
            this.pnlCaptura.Controls.Add(this.txtPiso);
            this.pnlCaptura.Controls.Add(this.lblEstadoForm);
            this.pnlCaptura.Controls.Add(this.cboEstado);
            this.pnlCaptura.Controls.Add(this.lblCapacidad);
            this.pnlCaptura.Controls.Add(this.txtCapacidad);
            this.pnlCaptura.Controls.Add(this.lblTarifa);
            this.pnlCaptura.Controls.Add(this.txtTarifa);
            this.pnlCaptura.Controls.Add(this.lblIcono);
            this.pnlCaptura.Controls.Add(this.lblEstado);
            this.pnlCaptura.Controls.Add(this.btnBuscar);
            this.pnlCaptura.Controls.Add(this.btnGuardar);
            this.pnlCaptura.Controls.Add(this.btnEliminar);
            this.pnlCaptura.Controls.Add(this.btnLimpiar);
            this.pnlCaptura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCaptura.Location = new System.Drawing.Point(603, 0);
            this.pnlCaptura.Name = "pnlCaptura";
            this.pnlCaptura.Size = new System.Drawing.Size(341, 467);
            this.pnlCaptura.TabIndex = 1;
            //
            // lblNumero
            //
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNumero.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.lblNumero.Location = new System.Drawing.Point(18, 4);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(52, 15);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número";
            //
            // txtNumero
            //
            this.txtNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)
            | 0)));
            this.txtNumero.BackColor = System.Drawing.Color.FromArgb(251, 243, 228);
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumero.Location = new System.Drawing.Point(18, 21);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(305, 23);
            this.txtNumero.TabIndex = 1;
            //
            // lblTipo
            //
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.lblTipo.Location = new System.Drawing.Point(18, 54);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(30, 15);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo";
            //
            // cboTipo
            //
            this.cboTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)
            | 0)));
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(18, 71);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(305, 23);
            this.cboTipo.TabIndex = 3;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            //
            // lblPiso
            //
            this.lblPiso.AutoSize = true;
            this.lblPiso.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblPiso.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.lblPiso.Location = new System.Drawing.Point(18, 104);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(30, 15);
            this.lblPiso.TabIndex = 4;
            this.lblPiso.Text = "Piso";
            //
            // txtPiso
            //
            this.txtPiso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)
            | 0)));
            this.txtPiso.BackColor = System.Drawing.Color.FromArgb(251, 243, 228);
            this.txtPiso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPiso.Location = new System.Drawing.Point(18, 121);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(305, 23);
            this.txtPiso.TabIndex = 5;
            //
            // lblEstadoForm
            //
            this.lblEstadoForm.AutoSize = true;
            this.lblEstadoForm.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEstadoForm.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.lblEstadoForm.Location = new System.Drawing.Point(18, 154);
            this.lblEstadoForm.Name = "lblEstadoForm";
            this.lblEstadoForm.Size = new System.Drawing.Size(45, 15);
            this.lblEstadoForm.TabIndex = 6;
            this.lblEstadoForm.Text = "Estado";
            //
            // cboEstado
            //
            this.cboEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)
            | 0)));
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(18, 171);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(305, 23);
            this.cboEstado.TabIndex = 7;
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboEstado_SelectedIndexChanged);
            //
            // lblCapacidad
            //
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCapacidad.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.lblCapacidad.Location = new System.Drawing.Point(18, 204);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(63, 15);
            this.lblCapacidad.TabIndex = 8;
            this.lblCapacidad.Text = "Capacidad";
            //
            // txtCapacidad
            //
            this.txtCapacidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)
            | 0)));
            this.txtCapacidad.BackColor = System.Drawing.Color.FromArgb(251, 243, 228);
            this.txtCapacidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCapacidad.Location = new System.Drawing.Point(18, 221);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(305, 23);
            this.txtCapacidad.TabIndex = 9;
            //
            // lblTarifa
            //
            this.lblTarifa.AutoSize = true;
            this.lblTarifa.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTarifa.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.lblTarifa.Location = new System.Drawing.Point(18, 254);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.Size = new System.Drawing.Size(39, 15);
            this.lblTarifa.TabIndex = 10;
            this.lblTarifa.Text = "Tarifa";
            //
            // txtTarifa
            //
            this.txtTarifa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)
            | 0)));
            this.txtTarifa.BackColor = System.Drawing.Color.FromArgb(251, 243, 228);
            this.txtTarifa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTarifa.Location = new System.Drawing.Point(18, 271);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.Size = new System.Drawing.Size(305, 23);
            this.txtTarifa.TabIndex = 11;
            //
            // lblIcono
            //
            this.lblIcono.AutoSize = true;
            this.lblIcono.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular);
            this.lblIcono.ForeColor = System.Drawing.Color.FromArgb(28, 38, 36);
            this.lblIcono.Location = new System.Drawing.Point(18, 306);
            this.lblIcono.Name = "lblIcono";
            this.lblIcono.Size = new System.Drawing.Size(22, 31);
            this.lblIcono.TabIndex = 12;
            this.lblIcono.Text = "icono";
            //
            // lblEstado
            //
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstado.Location = new System.Drawing.Point(70, 316);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(45, 15);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "estado";
            //
            // btnBuscar
            //
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(225, 211, 172);
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(251, 243, 228);
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnBuscar.Location = new System.Drawing.Point(18, 424);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(74, 30);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            //
            // btnGuardar
            //
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(200, 90, 52);
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(255, 247, 241);
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Location = new System.Drawing.Point(100, 424);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(74, 30);
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
            this.btnEliminar.Location = new System.Drawing.Point(182, 424);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(74, 30);
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
            this.btnLimpiar.Location = new System.Drawing.Point(264, 424);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(74, 30);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            //
            // errorProvider1
            //
            this.errorProvider1.ContainerControl = this;
            //
            // frmGestionHabitaciones
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(22, 58, 55);
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tlpRoot);
            this.Name = "frmGestionHabitaciones";
            this.Text = "Gestión de habitaciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGestionHabitaciones_Load);
            this.tlpRoot.ResumeLayout(false);
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.tlpContent.ResumeLayout(false);
            this.pnlGridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            this.pnlCaptura.ResumeLayout(false);
            this.pnlCaptura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Label lblFiltroPiso;
        private System.Windows.Forms.ComboBox cboFiltroPiso;
        private System.Windows.Forms.Label lblFiltroEstado;
        private System.Windows.Forms.ComboBox cboFiltroEstado;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private System.Windows.Forms.Panel pnlGridCard;
        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.Panel pnlCaptura;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.Label lblEstadoForm;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.Label lblTarifa;
        private System.Windows.Forms.TextBox txtTarifa;
        private System.Windows.Forms.Label lblIcono;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
