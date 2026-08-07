namespace HotelZormat.UI
{
    partial class frmGestionReservas
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
            this.lblTituloFiltro = new System.Windows.Forms.Label();
            this.btnProximas = new System.Windows.Forms.Button();
            this.tlpContent = new System.Windows.Forms.TableLayoutPanel();
            this.pnlGridCard = new System.Windows.Forms.Panel();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.pnlCaptura = new System.Windows.Forms.Panel();
            this.lblHuesped = new System.Windows.Forms.Label();
            this.cboHuesped = new System.Windows.Forms.ComboBox();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.cboHabitacion = new System.Windows.Forms.ComboBox();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblTemporada = new System.Windows.Forms.Label();
            this.cboTemporada = new System.Windows.Forms.ComboBox();
            this.lblCaptionNoches = new System.Windows.Forms.Label();
            this.lblNoches = new System.Windows.Forms.Label();
            this.lblCaptionMonto = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlpRoot.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            this.tlpContent.SuspendLayout();
            this.pnlGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
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
            this.pnlFiltros.Controls.Add(this.lblTituloFiltro);
            this.pnlFiltros.Controls.Add(this.btnProximas);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFiltros.Location = new System.Drawing.Point(20, 16);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(944, 62);
            this.pnlFiltros.TabIndex = 0;
            //
            // lblTituloFiltro
            //
            this.lblTituloFiltro.AutoSize = true;
            this.lblTituloFiltro.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTituloFiltro.ForeColor = System.Drawing.Color.FromArgb(28, 38, 36);
            this.lblTituloFiltro.Location = new System.Drawing.Point(18, 21);
            this.lblTituloFiltro.Name = "lblTituloFiltro";
            this.lblTituloFiltro.Size = new System.Drawing.Size(130, 17);
            this.lblTituloFiltro.TabIndex = 0;
            this.lblTituloFiltro.Text = "Reservas registradas";
            //
            // btnProximas
            //
            this.btnProximas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(225, 211, 172);
            this.btnProximas.BackColor = System.Drawing.Color.FromArgb(251, 243, 228);
            this.btnProximas.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.btnProximas.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnProximas.Location = new System.Drawing.Point(796, 15);
            this.btnProximas.Name = "btnProximas";
            this.btnProximas.Size = new System.Drawing.Size(130, 30);
            this.btnProximas.TabIndex = 1;
            this.btnProximas.Text = "Próximas 7 días";
            this.btnProximas.UseVisualStyleBackColor = false;
            this.btnProximas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProximas.Click += new System.EventHandler(this.btnProximas_Click);
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
            this.pnlGridCard.Controls.Add(this.dgvReservas);
            this.pnlGridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridCard.Padding = new System.Windows.Forms.Padding(14);
            this.pnlGridCard.Location = new System.Drawing.Point(0, 0);
            this.pnlGridCard.Name = "pnlGridCard";
            this.pnlGridCard.Size = new System.Drawing.Size(585, 467);
            this.pnlGridCard.TabIndex = 0;
            //
            // dgvReservas
            //
            this.dgvReservas.BackgroundColor = System.Drawing.Color.FromArgb(255, 250, 241);
            this.dgvReservas.AllowUserToResizeColumns = false;
            this.dgvReservas.AllowUserToResizeRows = false;
            this.dgvReservas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReservas.RowHeadersVisible = false;
            this.dgvReservas.EnableHeadersVisualStyles = false;
            this.dgvReservas.GridColor = System.Drawing.Color.FromArgb(236, 223, 192);
            this.dgvReservas.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(28, 38, 36);
            this.dgvReservas.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(234, 244, 238);
            this.dgvReservas.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(224, 179, 148);
            this.dgvReservas.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(28, 38, 36);
            this.dgvReservas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReservas.Location = new System.Drawing.Point(14, 14);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(557, 439);
            this.dgvReservas.TabIndex = 0;
            this.dgvReservas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservas_CellContentClick);
            //
            // pnlCaptura
            //
            this.pnlCaptura.BackColor = System.Drawing.Color.FromArgb(255, 250, 241);
            this.pnlCaptura.Controls.Add(this.lblHuesped);
            this.pnlCaptura.Controls.Add(this.cboHuesped);
            this.pnlCaptura.Controls.Add(this.lblHabitacion);
            this.pnlCaptura.Controls.Add(this.cboHabitacion);
            this.pnlCaptura.Controls.Add(this.lblCheckIn);
            this.pnlCaptura.Controls.Add(this.dtpCheckIn);
            this.pnlCaptura.Controls.Add(this.lblCheckOut);
            this.pnlCaptura.Controls.Add(this.dtpCheckOut);
            this.pnlCaptura.Controls.Add(this.lblTemporada);
            this.pnlCaptura.Controls.Add(this.cboTemporada);
            this.pnlCaptura.Controls.Add(this.lblCaptionNoches);
            this.pnlCaptura.Controls.Add(this.lblNoches);
            this.pnlCaptura.Controls.Add(this.lblCaptionMonto);
            this.pnlCaptura.Controls.Add(this.lblMonto);
            this.pnlCaptura.Controls.Add(this.btnCancelar);
            this.pnlCaptura.Controls.Add(this.btnConfirmar);
            this.pnlCaptura.Controls.Add(this.btnCrear);
            this.pnlCaptura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCaptura.Location = new System.Drawing.Point(603, 0);
            this.pnlCaptura.Name = "pnlCaptura";
            this.pnlCaptura.Size = new System.Drawing.Size(341, 467);
            this.pnlCaptura.TabIndex = 1;
            //
            // lblHuesped
            //
            this.lblHuesped.AutoSize = true;
            this.lblHuesped.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblHuesped.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.lblHuesped.Location = new System.Drawing.Point(18, 4);
            this.lblHuesped.Name = "lblHuesped";
            this.lblHuesped.Size = new System.Drawing.Size(56, 15);
            this.lblHuesped.TabIndex = 0;
            this.lblHuesped.Text = "Huésped";
            //
            // cboHuesped
            //
            this.cboHuesped.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)
            | 0)));
            this.cboHuesped.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHuesped.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboHuesped.FormattingEnabled = true;
            this.cboHuesped.Items.AddRange(new object[] {
            "Id - NombreCompleto"});
            this.cboHuesped.Location = new System.Drawing.Point(18, 21);
            this.cboHuesped.Name = "cboHuesped";
            this.cboHuesped.Size = new System.Drawing.Size(305, 23);
            this.cboHuesped.TabIndex = 1;
            //
            // lblHabitacion
            //
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblHabitacion.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.lblHabitacion.Location = new System.Drawing.Point(18, 54);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(66, 15);
            this.lblHabitacion.TabIndex = 2;
            this.lblHabitacion.Text = "Habitación";
            //
            // cboHabitacion
            //
            this.cboHabitacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)
            | 0)));
            this.cboHabitacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboHabitacion.FormattingEnabled = true;
            this.cboHabitacion.Items.AddRange(new object[] {
            "Numero - Tipo"});
            this.cboHabitacion.Location = new System.Drawing.Point(18, 71);
            this.cboHabitacion.Name = "cboHabitacion";
            this.cboHabitacion.Size = new System.Drawing.Size(305, 23);
            this.cboHabitacion.TabIndex = 3;
            this.cboHabitacion.SelectedIndexChanged += new System.EventHandler(this.cboHabitacion_SelectedIndexChanged);
            //
            // lblCheckIn
            //
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCheckIn.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.lblCheckIn.Location = new System.Drawing.Point(18, 104);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(58, 15);
            this.lblCheckIn.TabIndex = 4;
            this.lblCheckIn.Text = "Check-in";
            //
            // dtpCheckIn
            //
            this.dtpCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)
            | 0)));
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckIn.Location = new System.Drawing.Point(18, 121);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(305, 23);
            this.dtpCheckIn.TabIndex = 5;
            this.dtpCheckIn.ValueChanged += new System.EventHandler(this.dtpCheckIn_ValueChanged);
            //
            // lblCheckOut
            //
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCheckOut.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.lblCheckOut.Location = new System.Drawing.Point(18, 154);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(65, 15);
            this.lblCheckOut.TabIndex = 6;
            this.lblCheckOut.Text = "Check-out";
            //
            // dtpCheckOut
            //
            this.dtpCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)
            | 0)));
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckOut.Location = new System.Drawing.Point(18, 171);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(305, 23);
            this.dtpCheckOut.TabIndex = 7;
            this.dtpCheckOut.ValueChanged += new System.EventHandler(this.dtpCheckOut_ValueChanged);
            //
            // lblTemporada
            //
            this.lblTemporada.AutoSize = true;
            this.lblTemporada.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTemporada.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.lblTemporada.Location = new System.Drawing.Point(18, 204);
            this.lblTemporada.Name = "lblTemporada";
            this.lblTemporada.Size = new System.Drawing.Size(72, 15);
            this.lblTemporada.TabIndex = 8;
            this.lblTemporada.Text = "Temporada";
            //
            // cboTemporada
            //
            this.cboTemporada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)
            | 0)));
            this.cboTemporada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTemporada.FormattingEnabled = true;
            this.cboTemporada.Location = new System.Drawing.Point(18, 221);
            this.cboTemporada.Name = "cboTemporada";
            this.cboTemporada.Size = new System.Drawing.Size(305, 23);
            this.cboTemporada.TabIndex = 9;
            this.cboTemporada.SelectedIndexChanged += new System.EventHandler(this.cboTemporada_SelectedIndexChanged);
            //
            // lblCaptionNoches
            //
            this.lblCaptionNoches.AutoSize = true;
            this.lblCaptionNoches.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCaptionNoches.ForeColor = System.Drawing.Color.FromArgb(121, 112, 93);
            this.lblCaptionNoches.Location = new System.Drawing.Point(18, 258);
            this.lblCaptionNoches.Name = "lblCaptionNoches";
            this.lblCaptionNoches.Size = new System.Drawing.Size(41, 13);
            this.lblCaptionNoches.TabIndex = 10;
            this.lblCaptionNoches.Text = "Noches";
            //
            // lblNoches
            //
            this.lblNoches.AutoSize = true;
            this.lblNoches.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold);
            this.lblNoches.ForeColor = System.Drawing.Color.FromArgb(28, 38, 36);
            this.lblNoches.Location = new System.Drawing.Point(18, 273);
            this.lblNoches.Name = "lblNoches";
            this.lblNoches.Size = new System.Drawing.Size(19, 24);
            this.lblNoches.TabIndex = 11;
            this.lblNoches.Text = "0";
            //
            // lblCaptionMonto
            //
            this.lblCaptionMonto.AutoSize = true;
            this.lblCaptionMonto.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCaptionMonto.ForeColor = System.Drawing.Color.FromArgb(121, 112, 93);
            this.lblCaptionMonto.Location = new System.Drawing.Point(160, 258);
            this.lblCaptionMonto.Name = "lblCaptionMonto";
            this.lblCaptionMonto.Size = new System.Drawing.Size(85, 13);
            this.lblCaptionMonto.TabIndex = 12;
            this.lblCaptionMonto.Text = "Monto estimado";
            //
            // lblMonto
            //
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold);
            this.lblMonto.ForeColor = System.Drawing.Color.FromArgb(28, 38, 36);
            this.lblMonto.Location = new System.Drawing.Point(160, 273);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(50, 24);
            this.lblMonto.TabIndex = 13;
            this.lblMonto.Text = "0.00";
            //
            // btnCancelar
            //
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(230, 195, 189);
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(251, 243, 228);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(178, 59, 49);
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnCancelar.Location = new System.Drawing.Point(18, 424);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(70, 30);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            //
            // btnConfirmar
            //
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(225, 211, 172);
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(251, 243, 228);
            this.btnConfirmar.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnConfirmar.Location = new System.Drawing.Point(94, 424);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(86, 30);
            this.btnConfirmar.TabIndex = 15;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            //
            // btnCrear
            //
            this.btnCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(200, 90, 52);
            this.btnCrear.ForeColor = System.Drawing.Color.FromArgb(255, 247, 241);
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnCrear.Location = new System.Drawing.Point(186, 424);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(130, 30);
            this.btnCrear.TabIndex = 16;
            this.btnCrear.Text = "Crear reserva";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            //
            // errorProvider1
            //
            this.errorProvider1.ContainerControl = this;
            //
            // frmGestionReservas
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(22, 58, 55);
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tlpRoot);
            this.Name = "frmGestionReservas";
            this.Text = "Gestión de reservas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGestionReservas_Load);
            this.tlpRoot.ResumeLayout(false);
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.tlpContent.ResumeLayout(false);
            this.pnlGridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.pnlCaptura.ResumeLayout(false);
            this.pnlCaptura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Label lblTituloFiltro;
        private System.Windows.Forms.Button btnProximas;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private System.Windows.Forms.Panel pnlGridCard;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Panel pnlCaptura;
        private System.Windows.Forms.Label lblHuesped;
        private System.Windows.Forms.ComboBox cboHuesped;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.ComboBox cboHabitacion;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label lblTemporada;
        private System.Windows.Forms.ComboBox cboTemporada;
        private System.Windows.Forms.Label lblCaptionNoches;
        private System.Windows.Forms.Label lblNoches;
        private System.Windows.Forms.Label lblCaptionMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
