namespace HotelZormat.UI
{
    partial class frmBitacora
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
            this.lblFiltroAccion = new System.Windows.Forms.Label();
            this.cboFiltroAccion = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnVerTodas = new System.Windows.Forms.Button();
            this.pnlGridCard = new System.Windows.Forms.Panel();
            this.dgvBitacora = new System.Windows.Forms.DataGridView();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.tlpRoot.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            this.pnlGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).BeginInit();
            this.pnlHead.SuspendLayout();
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
            this.tlpRoot.Controls.Add(this.pnlGridCard, 0, 1);
            this.tlpRoot.Size = new System.Drawing.Size(984, 561);
            this.tlpRoot.TabIndex = 0;
            //
            // pnlFiltros
            //
            this.pnlFiltros.BackColor = System.Drawing.Color.FromArgb(255, 250, 241);
            this.pnlFiltros.Controls.Add(this.lblFiltroAccion);
            this.pnlFiltros.Controls.Add(this.cboFiltroAccion);
            this.pnlFiltros.Controls.Add(this.btnFiltrar);
            this.pnlFiltros.Controls.Add(this.btnVerTodas);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFiltros.Location = new System.Drawing.Point(20, 16);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(944, 62);
            this.pnlFiltros.TabIndex = 0;
            //
            // lblFiltroAccion
            //
            this.lblFiltroAccion.AutoSize = true;
            this.lblFiltroAccion.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFiltroAccion.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.lblFiltroAccion.Location = new System.Drawing.Point(18, 22);
            this.lblFiltroAccion.Name = "lblFiltroAccion";
            this.lblFiltroAccion.Size = new System.Drawing.Size(45, 15);
            this.lblFiltroAccion.TabIndex = 0;
            this.lblFiltroAccion.Text = "Acción:";
            //
            // cboFiltroAccion
            //
            this.cboFiltroAccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroAccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFiltroAccion.FormattingEnabled = true;
            this.cboFiltroAccion.IntegralHeight = false;
            this.cboFiltroAccion.Location = new System.Drawing.Point(70, 18);
            this.cboFiltroAccion.Name = "cboFiltroAccion";
            this.cboFiltroAccion.Size = new System.Drawing.Size(170, 23);
            this.cboFiltroAccion.TabIndex = 1;
            //
            // btnFiltrar
            //
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(225, 211, 172);
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(251, 243, 228);
            this.btnFiltrar.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnFiltrar.Location = new System.Drawing.Point(254, 16);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(90, 27);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            //
            // btnVerTodas
            //
            this.btnVerTodas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTodas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(225, 211, 172);
            this.btnVerTodas.BackColor = System.Drawing.Color.FromArgb(251, 243, 228);
            this.btnVerTodas.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.btnVerTodas.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnVerTodas.Location = new System.Drawing.Point(352, 16);
            this.btnVerTodas.Name = "btnVerTodas";
            this.btnVerTodas.Size = new System.Drawing.Size(100, 27);
            this.btnVerTodas.TabIndex = 3;
            this.btnVerTodas.Text = "Ver todas";
            this.btnVerTodas.UseVisualStyleBackColor = false;
            this.btnVerTodas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerTodas.Click += new System.EventHandler(this.btnVerTodas_Click);
            //
            // pnlGridCard
            //
            this.pnlGridCard.BackColor = System.Drawing.Color.FromArgb(255, 250, 241);
            this.pnlGridCard.Controls.Add(this.dgvBitacora);
            this.pnlGridCard.Controls.Add(this.pnlHead);
            this.pnlGridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridCard.Padding = new System.Windows.Forms.Padding(14);
            this.pnlGridCard.Location = new System.Drawing.Point(20, 78);
            this.pnlGridCard.Name = "pnlGridCard";
            this.pnlGridCard.Size = new System.Drawing.Size(944, 467);
            this.pnlGridCard.TabIndex = 1;
            //
            // pnlHead
            //
            this.pnlHead.Controls.Add(this.lblSubtitulo);
            this.pnlHead.Controls.Add(this.lblTitulo);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Location = new System.Drawing.Point(14, 14);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(916, 40);
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
            this.lblTitulo.Text = "Registro de auditoría";
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
            this.lblSubtitulo.Text = "Login, check-in, check-out y facturación";
            //
            // dgvBitacora
            //
            this.dgvBitacora.BackgroundColor = System.Drawing.Color.FromArgb(255, 250, 241);
            this.dgvBitacora.AllowUserToResizeColumns = false;
            this.dgvBitacora.AllowUserToResizeRows = false;
            this.dgvBitacora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBitacora.RowHeadersVisible = false;
            this.dgvBitacora.EnableHeadersVisualStyles = false;
            this.dgvBitacora.GridColor = System.Drawing.Color.FromArgb(236, 223, 192);
            this.dgvBitacora.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(28, 38, 36);
            this.dgvBitacora.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(234, 244, 238);
            this.dgvBitacora.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.dgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBitacora.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(224, 179, 148);
            this.dgvBitacora.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(28, 38, 36);
            this.dgvBitacora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBitacora.Location = new System.Drawing.Point(14, 54);
            this.dgvBitacora.Name = "dgvBitacora";
            this.dgvBitacora.ReadOnly = true;
            this.dgvBitacora.Size = new System.Drawing.Size(916, 399);
            this.dgvBitacora.TabIndex = 1;
            //
            // frmBitacora
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(22, 58, 55);
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tlpRoot);
            this.Name = "frmBitacora";
            this.Text = "Bitácora (solo Admin)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBitacora_Load);
            this.tlpRoot.ResumeLayout(false);
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.pnlGridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).EndInit();
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Label lblFiltroAccion;
        private System.Windows.Forms.ComboBox cboFiltroAccion;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnVerTodas;
        private System.Windows.Forms.Panel pnlGridCard;
        private System.Windows.Forms.DataGridView dgvBitacora;
        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
    }
}
