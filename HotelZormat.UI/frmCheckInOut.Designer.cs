namespace HotelZormat.UI
{
    partial class frmCheckInOut
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.tlpContent = new System.Windows.Forms.TableLayoutPanel();
            this.pnlReservas = new System.Windows.Forms.Panel();
            this.pnlHeadReservas = new System.Windows.Forms.Panel();
            this.lblTituloReservas = new System.Windows.Forms.Label();
            this.lblSubReservas = new System.Windows.Forms.Label();
            this.dgvReservasConfirmadas = new System.Windows.Forms.DataGridView();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.pnlEstadias = new System.Windows.Forms.Panel();
            this.pnlHeadEstadias = new System.Windows.Forms.Panel();
            this.lblTituloEstadias = new System.Windows.Forms.Label();
            this.lblSubEstadias = new System.Windows.Forms.Label();
            this.dgvEstadiasActivas = new System.Windows.Forms.DataGridView();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.tlpRoot.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            this.tlpContent.SuspendLayout();
            this.pnlReservas.SuspendLayout();
            this.pnlHeadReservas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasConfirmadas)).BeginInit();
            this.pnlEstadias.SuspendLayout();
            this.pnlHeadEstadias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadiasActivas)).BeginInit();
            this.SuspendLayout();
            //
            // tlpRoot
            //
            this.tlpRoot.ColumnCount = 1;
            this.tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.RowCount = 2;
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
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
            this.pnlFiltros.Controls.Add(this.lblInfo);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFiltros.Location = new System.Drawing.Point(20, 16);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(944, 54);
            this.pnlFiltros.TabIndex = 0;
            //
            // lblInfo
            //
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(121, 112, 93);
            this.lblInfo.Location = new System.Drawing.Point(18, 18);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(330, 15);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Selecciona una reserva confirmada o una estadía activa";
            //
            // tlpContent
            //
            this.tlpContent.ColumnCount = 3;
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tlpContent.RowCount = 1;
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContent.Location = new System.Drawing.Point(20, 70);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.Controls.Add(this.pnlReservas, 0, 0);
            this.tlpContent.Controls.Add(this.pnlEstadias, 2, 0);
            this.tlpContent.Size = new System.Drawing.Size(944, 475);
            this.tlpContent.TabIndex = 1;
            //
            // pnlReservas
            //
            this.pnlReservas.BackColor = System.Drawing.Color.FromArgb(255, 250, 241);
            this.pnlReservas.Controls.Add(this.dgvReservasConfirmadas);
            this.pnlReservas.Controls.Add(this.btnCheckIn);
            this.pnlReservas.Controls.Add(this.pnlHeadReservas);
            this.pnlReservas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReservas.Padding = new System.Windows.Forms.Padding(14);
            this.pnlReservas.Location = new System.Drawing.Point(0, 0);
            this.pnlReservas.Name = "pnlReservas";
            this.pnlReservas.Size = new System.Drawing.Size(453, 475);
            this.pnlReservas.TabIndex = 0;
            //
            // pnlHeadReservas
            //
            this.pnlHeadReservas.Controls.Add(this.lblSubReservas);
            this.pnlHeadReservas.Controls.Add(this.lblTituloReservas);
            this.pnlHeadReservas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeadReservas.Location = new System.Drawing.Point(14, 14);
            this.pnlHeadReservas.Name = "pnlHeadReservas";
            this.pnlHeadReservas.Size = new System.Drawing.Size(425, 44);
            this.pnlHeadReservas.TabIndex = 0;
            //
            // lblTituloReservas
            //
            this.lblTituloReservas.AutoSize = true;
            this.lblTituloReservas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTituloReservas.ForeColor = System.Drawing.Color.FromArgb(28, 38, 36);
            this.lblTituloReservas.Location = new System.Drawing.Point(0, 2);
            this.lblTituloReservas.Name = "lblTituloReservas";
            this.lblTituloReservas.Size = new System.Drawing.Size(160, 19);
            this.lblTituloReservas.TabIndex = 0;
            this.lblTituloReservas.Text = "Reservas confirmadas";
            //
            // lblSubReservas
            //
            this.lblSubReservas.AutoSize = true;
            this.lblSubReservas.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSubReservas.ForeColor = System.Drawing.Color.FromArgb(121, 112, 93);
            this.lblSubReservas.Location = new System.Drawing.Point(1, 24);
            this.lblSubReservas.Name = "lblSubReservas";
            this.lblSubReservas.Size = new System.Drawing.Size(110, 13);
            this.lblSubReservas.TabIndex = 1;
            this.lblSubReservas.Text = "Listas para check-in";
            //
            // dgvReservasConfirmadas
            //
            this.dgvReservasConfirmadas.BackgroundColor = System.Drawing.Color.FromArgb(255, 250, 241);
            this.dgvReservasConfirmadas.AllowUserToResizeColumns = false;
            this.dgvReservasConfirmadas.AllowUserToResizeRows = false;
            this.dgvReservasConfirmadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReservasConfirmadas.RowHeadersVisible = false;
            this.dgvReservasConfirmadas.EnableHeadersVisualStyles = false;
            this.dgvReservasConfirmadas.GridColor = System.Drawing.Color.FromArgb(236, 223, 192);
            this.dgvReservasConfirmadas.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(28, 38, 36);
            this.dgvReservasConfirmadas.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(234, 244, 238);
            this.dgvReservasConfirmadas.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.dgvReservasConfirmadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservasConfirmadas.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(224, 179, 148);
            this.dgvReservasConfirmadas.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(28, 38, 36);
            this.dgvReservasConfirmadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReservasConfirmadas.Location = new System.Drawing.Point(14, 58);
            this.dgvReservasConfirmadas.Name = "dgvReservasConfirmadas";
            this.dgvReservasConfirmadas.ReadOnly = true;
            this.dgvReservasConfirmadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservasConfirmadas.Size = new System.Drawing.Size(425, 353);
            this.dgvReservasConfirmadas.TabIndex = 1;
            this.dgvReservasConfirmadas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservasConfirmadas_CellContentClick);
            //
            // btnCheckIn
            //
            this.btnCheckIn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.FlatAppearance.BorderSize = 0;
            this.btnCheckIn.BackColor = System.Drawing.Color.FromArgb(200, 90, 52);
            this.btnCheckIn.ForeColor = System.Drawing.Color.FromArgb(255, 247, 241);
            this.btnCheckIn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCheckIn.Location = new System.Drawing.Point(14, 411);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(425, 40);
            this.btnCheckIn.TabIndex = 2;
            this.btnCheckIn.Text = "Registrar check-in";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            //
            // pnlEstadias
            //
            this.pnlEstadias.BackColor = System.Drawing.Color.FromArgb(255, 250, 241);
            this.pnlEstadias.Controls.Add(this.dgvEstadiasActivas);
            this.pnlEstadias.Controls.Add(this.btnCheckOut);
            this.pnlEstadias.Controls.Add(this.pnlHeadEstadias);
            this.pnlEstadias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEstadias.Padding = new System.Windows.Forms.Padding(14);
            this.pnlEstadias.Location = new System.Drawing.Point(471, 0);
            this.pnlEstadias.Name = "pnlEstadias";
            this.pnlEstadias.Size = new System.Drawing.Size(453, 475);
            this.pnlEstadias.TabIndex = 1;
            //
            // pnlHeadEstadias
            //
            this.pnlHeadEstadias.Controls.Add(this.lblSubEstadias);
            this.pnlHeadEstadias.Controls.Add(this.lblTituloEstadias);
            this.pnlHeadEstadias.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeadEstadias.Location = new System.Drawing.Point(14, 14);
            this.pnlHeadEstadias.Name = "pnlHeadEstadias";
            this.pnlHeadEstadias.Size = new System.Drawing.Size(425, 44);
            this.pnlHeadEstadias.TabIndex = 0;
            //
            // lblTituloEstadias
            //
            this.lblTituloEstadias.AutoSize = true;
            this.lblTituloEstadias.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTituloEstadias.ForeColor = System.Drawing.Color.FromArgb(28, 38, 36);
            this.lblTituloEstadias.Location = new System.Drawing.Point(0, 2);
            this.lblTituloEstadias.Name = "lblTituloEstadias";
            this.lblTituloEstadias.Size = new System.Drawing.Size(110, 19);
            this.lblTituloEstadias.TabIndex = 0;
            this.lblTituloEstadias.Text = "Estadías activas";
            //
            // lblSubEstadias
            //
            this.lblSubEstadias.AutoSize = true;
            this.lblSubEstadias.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSubEstadias.ForeColor = System.Drawing.Color.FromArgb(121, 112, 93);
            this.lblSubEstadias.Location = new System.Drawing.Point(1, 24);
            this.lblSubEstadias.Name = "lblSubEstadias";
            this.lblSubEstadias.Size = new System.Drawing.Size(115, 13);
            this.lblSubEstadias.TabIndex = 1;
            this.lblSubEstadias.Text = "Listas para check-out";
            //
            // dgvEstadiasActivas
            //
            this.dgvEstadiasActivas.BackgroundColor = System.Drawing.Color.FromArgb(255, 250, 241);
            this.dgvEstadiasActivas.AllowUserToResizeColumns = false;
            this.dgvEstadiasActivas.AllowUserToResizeRows = false;
            this.dgvEstadiasActivas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEstadiasActivas.RowHeadersVisible = false;
            this.dgvEstadiasActivas.EnableHeadersVisualStyles = false;
            this.dgvEstadiasActivas.GridColor = System.Drawing.Color.FromArgb(236, 223, 192);
            this.dgvEstadiasActivas.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(28, 38, 36);
            this.dgvEstadiasActivas.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(234, 244, 238);
            this.dgvEstadiasActivas.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.dgvEstadiasActivas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadiasActivas.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(224, 179, 148);
            this.dgvEstadiasActivas.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(28, 38, 36);
            this.dgvEstadiasActivas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEstadiasActivas.Location = new System.Drawing.Point(14, 58);
            this.dgvEstadiasActivas.Name = "dgvEstadiasActivas";
            this.dgvEstadiasActivas.ReadOnly = true;
            this.dgvEstadiasActivas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstadiasActivas.Size = new System.Drawing.Size(425, 353);
            this.dgvEstadiasActivas.TabIndex = 1;
            this.dgvEstadiasActivas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstadiasActivas_CellContentClick);
            //
            // btnCheckOut
            //
            this.btnCheckOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(200, 90, 52);
            this.btnCheckOut.ForeColor = System.Drawing.Color.FromArgb(255, 247, 241);
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCheckOut.Location = new System.Drawing.Point(14, 411);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(425, 40);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "Registrar check-out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            //
            // frmCheckInOut
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(22, 58, 55);
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tlpRoot);
            this.Name = "frmCheckInOut";
            this.Text = "Check-in / Check-out";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCheckInOut_Load);
            this.tlpRoot.ResumeLayout(false);
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.tlpContent.ResumeLayout(false);
            this.pnlReservas.ResumeLayout(false);
            this.pnlHeadReservas.ResumeLayout(false);
            this.pnlHeadReservas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasConfirmadas)).EndInit();
            this.pnlEstadias.ResumeLayout(false);
            this.pnlHeadEstadias.ResumeLayout(false);
            this.pnlHeadEstadias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadiasActivas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private System.Windows.Forms.Panel pnlReservas;
        private System.Windows.Forms.Panel pnlHeadReservas;
        private System.Windows.Forms.Label lblTituloReservas;
        private System.Windows.Forms.Label lblSubReservas;
        private System.Windows.Forms.DataGridView dgvReservasConfirmadas;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Panel pnlEstadias;
        private System.Windows.Forms.Panel pnlHeadEstadias;
        private System.Windows.Forms.Label lblTituloEstadias;
        private System.Windows.Forms.Label lblSubEstadias;
        private System.Windows.Forms.DataGridView dgvEstadiasActivas;
        private System.Windows.Forms.Button btnCheckOut;
    }
}
