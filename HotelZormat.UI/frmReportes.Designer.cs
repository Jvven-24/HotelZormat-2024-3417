namespace HotelZormat.UI
{
    partial class frmReportes
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
            this.tlpRoot = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.tlpContent = new System.Windows.Forms.TableLayoutPanel();
            this.flpKpis = new System.Windows.Forms.FlowLayoutPanel();
            this.tarjetaOcupadas = new System.Windows.Forms.Panel();
            this.franjaOcupadas = new System.Windows.Forms.Panel();
            this.lblCaptionOcupadas = new System.Windows.Forms.Label();
            this.lblTotalOcupadas = new System.Windows.Forms.Label();
            this.tarjetaFacturas = new System.Windows.Forms.Panel();
            this.franjaFacturas = new System.Windows.Forms.Panel();
            this.lblCaptionFacturas = new System.Windows.Forms.Label();
            this.lblCantidadFacturas = new System.Windows.Forms.Label();
            this.tarjetaIngresos = new System.Windows.Forms.Panel();
            this.franjaIngresos = new System.Windows.Forms.Panel();
            this.lblCaptionIngresos = new System.Windows.Forms.Label();
            this.lblIngresosTotales = new System.Windows.Forms.Label();
            this.pnlGridCard = new System.Windows.Forms.Panel();
            this.dgvOcupacion = new System.Windows.Forms.DataGridView();
            this.pnlHeadOcupacion = new System.Windows.Forms.Panel();
            this.lblTituloOcupacion = new System.Windows.Forms.Label();
            this.lblSubOcupacion = new System.Windows.Forms.Label();
            this.tlpRoot.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            this.tlpContent.SuspendLayout();
            this.flpKpis.SuspendLayout();
            this.tarjetaOcupadas.SuspendLayout();
            this.tarjetaFacturas.SuspendLayout();
            this.tarjetaIngresos.SuspendLayout();
            this.pnlGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcupacion)).BeginInit();
            this.pnlHeadOcupacion.SuspendLayout();
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
            this.pnlFiltros.Controls.Add(this.lblDesde);
            this.pnlFiltros.Controls.Add(this.dtpDesde);
            this.pnlFiltros.Controls.Add(this.lblHasta);
            this.pnlFiltros.Controls.Add(this.dtpHasta);
            this.pnlFiltros.Controls.Add(this.btnConsultar);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFiltros.Location = new System.Drawing.Point(20, 16);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(944, 62);
            this.pnlFiltros.TabIndex = 0;
            //
            // lblDesde
            //
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDesde.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.lblDesde.Location = new System.Drawing.Point(18, 22);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 15);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde:";
            //
            // dtpDesde
            //
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(66, 18);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(130, 23);
            this.dtpDesde.TabIndex = 0;
            //
            // lblHasta
            //
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblHasta.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.lblHasta.Location = new System.Drawing.Point(212, 22);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 15);
            this.lblHasta.TabIndex = 1;
            this.lblHasta.Text = "Hasta:";
            //
            // dtpHasta
            //
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(256, 18);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(130, 23);
            this.dtpHasta.TabIndex = 1;
            //
            // btnConsultar
            //
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(200, 90, 52);
            this.btnConsultar.ForeColor = System.Drawing.Color.FromArgb(255, 247, 241);
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.Location = new System.Drawing.Point(406, 16);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(110, 30);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            //
            // tlpContent
            //
            this.tlpContent.ColumnCount = 1;
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContent.RowCount = 2;
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContent.Location = new System.Drawing.Point(20, 78);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.Controls.Add(this.flpKpis, 0, 0);
            this.tlpContent.Controls.Add(this.pnlGridCard, 0, 1);
            this.tlpContent.Size = new System.Drawing.Size(944, 467);
            this.tlpContent.TabIndex = 1;
            //
            // flpKpis
            //
            this.flpKpis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpKpis.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flpKpis.WrapContents = true;
            this.flpKpis.AutoScroll = true;
            this.flpKpis.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.flpKpis.Controls.Add(this.tarjetaOcupadas);
            this.flpKpis.Controls.Add(this.tarjetaFacturas);
            this.flpKpis.Controls.Add(this.tarjetaIngresos);
            this.flpKpis.Location = new System.Drawing.Point(0, 0);
            this.flpKpis.Name = "flpKpis";
            this.flpKpis.Size = new System.Drawing.Size(944, 104);
            this.flpKpis.TabIndex = 0;
            //
            // tarjetaOcupadas
            //
            this.tarjetaOcupadas.BackColor = System.Drawing.Color.FromArgb(255, 250, 241);
            this.tarjetaOcupadas.Controls.Add(this.lblTotalOcupadas);
            this.tarjetaOcupadas.Controls.Add(this.lblCaptionOcupadas);
            this.tarjetaOcupadas.Controls.Add(this.franjaOcupadas);
            this.tarjetaOcupadas.Location = new System.Drawing.Point(0, 0);
            this.tarjetaOcupadas.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.tarjetaOcupadas.Name = "tarjetaOcupadas";
            this.tarjetaOcupadas.Size = new System.Drawing.Size(230, 88);
            this.tarjetaOcupadas.TabIndex = 0;
            //
            // franjaOcupadas
            //
            this.franjaOcupadas.BackColor = System.Drawing.Color.FromArgb(47, 143, 99);
            this.franjaOcupadas.Dock = System.Windows.Forms.DockStyle.Left;
            this.franjaOcupadas.Location = new System.Drawing.Point(0, 0);
            this.franjaOcupadas.Name = "franjaOcupadas";
            this.franjaOcupadas.Size = new System.Drawing.Size(4, 88);
            this.franjaOcupadas.TabIndex = 0;
            //
            // lblCaptionOcupadas
            //
            this.lblCaptionOcupadas.AutoSize = true;
            this.lblCaptionOcupadas.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCaptionOcupadas.ForeColor = System.Drawing.Color.FromArgb(121, 112, 93);
            this.lblCaptionOcupadas.Location = new System.Drawing.Point(16, 14);
            this.lblCaptionOcupadas.Name = "lblCaptionOcupadas";
            this.lblCaptionOcupadas.Size = new System.Drawing.Size(70, 15);
            this.lblCaptionOcupadas.TabIndex = 1;
            this.lblCaptionOcupadas.Text = "Ocupadas hoy";
            //
            // lblTotalOcupadas
            //
            this.lblTotalOcupadas.AutoSize = true;
            this.lblTotalOcupadas.Font = new System.Drawing.Font("Cambria", 22F, System.Drawing.FontStyle.Bold);
            this.lblTotalOcupadas.ForeColor = System.Drawing.Color.FromArgb(28, 38, 36);
            this.lblTotalOcupadas.Location = new System.Drawing.Point(14, 32);
            this.lblTotalOcupadas.Name = "lblTotalOcupadas";
            this.lblTotalOcupadas.Size = new System.Drawing.Size(24, 40);
            this.lblTotalOcupadas.TabIndex = 2;
            this.lblTotalOcupadas.Text = "0";
            //
            // tarjetaFacturas
            //
            this.tarjetaFacturas.BackColor = System.Drawing.Color.FromArgb(255, 250, 241);
            this.tarjetaFacturas.Controls.Add(this.lblCantidadFacturas);
            this.tarjetaFacturas.Controls.Add(this.lblCaptionFacturas);
            this.tarjetaFacturas.Controls.Add(this.franjaFacturas);
            this.tarjetaFacturas.Location = new System.Drawing.Point(246, 0);
            this.tarjetaFacturas.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.tarjetaFacturas.Name = "tarjetaFacturas";
            this.tarjetaFacturas.Size = new System.Drawing.Size(230, 88);
            this.tarjetaFacturas.TabIndex = 1;
            //
            // franjaFacturas
            //
            this.franjaFacturas.BackColor = System.Drawing.Color.FromArgb(177, 128, 47);
            this.franjaFacturas.Dock = System.Windows.Forms.DockStyle.Left;
            this.franjaFacturas.Location = new System.Drawing.Point(0, 0);
            this.franjaFacturas.Name = "franjaFacturas";
            this.franjaFacturas.Size = new System.Drawing.Size(4, 88);
            this.franjaFacturas.TabIndex = 0;
            //
            // lblCaptionFacturas
            //
            this.lblCaptionFacturas.AutoSize = true;
            this.lblCaptionFacturas.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCaptionFacturas.ForeColor = System.Drawing.Color.FromArgb(121, 112, 93);
            this.lblCaptionFacturas.Location = new System.Drawing.Point(16, 14);
            this.lblCaptionFacturas.Name = "lblCaptionFacturas";
            this.lblCaptionFacturas.Size = new System.Drawing.Size(120, 15);
            this.lblCaptionFacturas.TabIndex = 1;
            this.lblCaptionFacturas.Text = "Facturas en el rango";
            //
            // lblCantidadFacturas
            //
            this.lblCantidadFacturas.AutoSize = true;
            this.lblCantidadFacturas.Font = new System.Drawing.Font("Cambria", 22F, System.Drawing.FontStyle.Bold);
            this.lblCantidadFacturas.ForeColor = System.Drawing.Color.FromArgb(28, 38, 36);
            this.lblCantidadFacturas.Location = new System.Drawing.Point(14, 32);
            this.lblCantidadFacturas.Name = "lblCantidadFacturas";
            this.lblCantidadFacturas.Size = new System.Drawing.Size(24, 40);
            this.lblCantidadFacturas.TabIndex = 2;
            this.lblCantidadFacturas.Text = "0";
            //
            // tarjetaIngresos
            //
            this.tarjetaIngresos.BackColor = System.Drawing.Color.FromArgb(255, 250, 241);
            this.tarjetaIngresos.Controls.Add(this.lblIngresosTotales);
            this.tarjetaIngresos.Controls.Add(this.lblCaptionIngresos);
            this.tarjetaIngresos.Controls.Add(this.franjaIngresos);
            this.tarjetaIngresos.Location = new System.Drawing.Point(492, 0);
            this.tarjetaIngresos.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.tarjetaIngresos.Name = "tarjetaIngresos";
            this.tarjetaIngresos.Size = new System.Drawing.Size(260, 88);
            this.tarjetaIngresos.TabIndex = 2;
            //
            // franjaIngresos
            //
            this.franjaIngresos.BackColor = System.Drawing.Color.FromArgb(200, 90, 52);
            this.franjaIngresos.Dock = System.Windows.Forms.DockStyle.Left;
            this.franjaIngresos.Location = new System.Drawing.Point(0, 0);
            this.franjaIngresos.Name = "franjaIngresos";
            this.franjaIngresos.Size = new System.Drawing.Size(4, 88);
            this.franjaIngresos.TabIndex = 0;
            //
            // lblCaptionIngresos
            //
            this.lblCaptionIngresos.AutoSize = true;
            this.lblCaptionIngresos.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCaptionIngresos.ForeColor = System.Drawing.Color.FromArgb(121, 112, 93);
            this.lblCaptionIngresos.Location = new System.Drawing.Point(16, 14);
            this.lblCaptionIngresos.Name = "lblCaptionIngresos";
            this.lblCaptionIngresos.Size = new System.Drawing.Size(92, 15);
            this.lblCaptionIngresos.TabIndex = 1;
            this.lblCaptionIngresos.Text = "Ingresos totales";
            //
            // lblIngresosTotales
            //
            this.lblIngresosTotales.AutoSize = true;
            this.lblIngresosTotales.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.lblIngresosTotales.ForeColor = System.Drawing.Color.FromArgb(28, 38, 36);
            this.lblIngresosTotales.Location = new System.Drawing.Point(14, 36);
            this.lblIngresosTotales.Name = "lblIngresosTotales";
            this.lblIngresosTotales.Size = new System.Drawing.Size(46, 32);
            this.lblIngresosTotales.TabIndex = 2;
            this.lblIngresosTotales.Text = "0.00";
            //
            // pnlGridCard
            //
            this.pnlGridCard.BackColor = System.Drawing.Color.FromArgb(255, 250, 241);
            this.pnlGridCard.Controls.Add(this.dgvOcupacion);
            this.pnlGridCard.Controls.Add(this.pnlHeadOcupacion);
            this.pnlGridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridCard.Padding = new System.Windows.Forms.Padding(14);
            this.pnlGridCard.Location = new System.Drawing.Point(0, 110);
            this.pnlGridCard.Name = "pnlGridCard";
            this.pnlGridCard.Size = new System.Drawing.Size(944, 357);
            this.pnlGridCard.TabIndex = 1;
            //
            // pnlHeadOcupacion
            //
            this.pnlHeadOcupacion.Controls.Add(this.lblSubOcupacion);
            this.pnlHeadOcupacion.Controls.Add(this.lblTituloOcupacion);
            this.pnlHeadOcupacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeadOcupacion.Location = new System.Drawing.Point(14, 14);
            this.pnlHeadOcupacion.Name = "pnlHeadOcupacion";
            this.pnlHeadOcupacion.Size = new System.Drawing.Size(916, 40);
            this.pnlHeadOcupacion.TabIndex = 0;
            //
            // lblTituloOcupacion
            //
            this.lblTituloOcupacion.AutoSize = true;
            this.lblTituloOcupacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTituloOcupacion.ForeColor = System.Drawing.Color.FromArgb(28, 38, 36);
            this.lblTituloOcupacion.Location = new System.Drawing.Point(0, 2);
            this.lblTituloOcupacion.Name = "lblTituloOcupacion";
            this.lblTituloOcupacion.Size = new System.Drawing.Size(115, 19);
            this.lblTituloOcupacion.TabIndex = 0;
            this.lblTituloOcupacion.Text = "Ocupación actual";
            //
            // lblSubOcupacion
            //
            this.lblSubOcupacion.AutoSize = true;
            this.lblSubOcupacion.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSubOcupacion.ForeColor = System.Drawing.Color.FromArgb(121, 112, 93);
            this.lblSubOcupacion.Location = new System.Drawing.Point(1, 24);
            this.lblSubOcupacion.Name = "lblSubOcupacion";
            this.lblSubOcupacion.Size = new System.Drawing.Size(160, 13);
            this.lblSubOcupacion.TabIndex = 1;
            this.lblSubOcupacion.Text = "Habitaciones ocupadas ahora mismo";
            //
            // dgvOcupacion
            //
            this.dgvOcupacion.BackgroundColor = System.Drawing.Color.FromArgb(255, 250, 241);
            this.dgvOcupacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOcupacion.RowHeadersVisible = false;
            this.dgvOcupacion.EnableHeadersVisualStyles = false;
            this.dgvOcupacion.GridColor = System.Drawing.Color.FromArgb(236, 223, 192);
            this.dgvOcupacion.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(28, 38, 36);
            this.dgvOcupacion.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(234, 244, 238);
            this.dgvOcupacion.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.dgvOcupacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOcupacion.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(246, 226, 212);
            this.dgvOcupacion.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(28, 38, 36);
            this.dgvOcupacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOcupacion.Location = new System.Drawing.Point(14, 54);
            this.dgvOcupacion.Name = "dgvOcupacion";
            this.dgvOcupacion.ReadOnly = true;
            this.dgvOcupacion.Size = new System.Drawing.Size(916, 289);
            this.dgvOcupacion.TabIndex = 1;
            //
            // frmReportes
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(22, 58, 55);
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tlpRoot);
            this.Name = "frmReportes";
            this.Text = "Reportes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.tlpRoot.ResumeLayout(false);
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.tlpContent.ResumeLayout(false);
            this.flpKpis.ResumeLayout(false);
            this.tarjetaOcupadas.ResumeLayout(false);
            this.tarjetaOcupadas.PerformLayout();
            this.tarjetaFacturas.ResumeLayout(false);
            this.tarjetaFacturas.PerformLayout();
            this.tarjetaIngresos.ResumeLayout(false);
            this.tarjetaIngresos.PerformLayout();
            this.pnlGridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcupacion)).EndInit();
            this.pnlHeadOcupacion.ResumeLayout(false);
            this.pnlHeadOcupacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private System.Windows.Forms.FlowLayoutPanel flpKpis;
        private System.Windows.Forms.Panel tarjetaOcupadas;
        private System.Windows.Forms.Panel franjaOcupadas;
        private System.Windows.Forms.Label lblCaptionOcupadas;
        private System.Windows.Forms.Label lblTotalOcupadas;
        private System.Windows.Forms.Panel tarjetaFacturas;
        private System.Windows.Forms.Panel franjaFacturas;
        private System.Windows.Forms.Label lblCaptionFacturas;
        private System.Windows.Forms.Label lblCantidadFacturas;
        private System.Windows.Forms.Panel tarjetaIngresos;
        private System.Windows.Forms.Panel franjaIngresos;
        private System.Windows.Forms.Label lblCaptionIngresos;
        private System.Windows.Forms.Label lblIngresosTotales;
        private System.Windows.Forms.Panel pnlGridCard;
        private System.Windows.Forms.DataGridView dgvOcupacion;
        private System.Windows.Forms.Panel pnlHeadOcupacion;
        private System.Windows.Forms.Label lblTituloOcupacion;
        private System.Windows.Forms.Label lblSubOcupacion;
    }
}
