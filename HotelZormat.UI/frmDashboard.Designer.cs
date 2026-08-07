namespace HotelZormat.UI
{
    partial class frmDashboard
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
            this.tlpDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.flpKpis = new System.Windows.Forms.FlowLayoutPanel();
            this.flpHabitaciones = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpDashboard.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            //
            // tlpDashboard
            //
            this.tlpDashboard.ColumnCount = 1;
            this.tlpDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDashboard.RowCount = 3;
            this.tlpDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tlpDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDashboard.Location = new System.Drawing.Point(0, 0);
            this.tlpDashboard.Name = "tlpDashboard";
            this.tlpDashboard.Padding = new System.Windows.Forms.Padding(20, 16, 20, 16);
            this.tlpDashboard.Controls.Add(this.pnlHeader, 0, 0);
            this.tlpDashboard.Controls.Add(this.flpKpis, 0, 1);
            this.tlpDashboard.Controls.Add(this.flpHabitaciones, 0, 2);
            this.tlpDashboard.Size = new System.Drawing.Size(934, 521);
            this.tlpDashboard.TabIndex = 0;
            //
            // pnlHeader
            //
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.btnRefrescar);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(20, 16);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(894, 64);
            this.pnlHeader.TabIndex = 0;
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(234, 244, 238);
            this.lblTitulo.Location = new System.Drawing.Point(0, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(220, 26);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Panel de habitaciones";
            //
            // lblSubtitulo
            //
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(143, 179, 170);
            this.lblSubtitulo.Location = new System.Drawing.Point(2, 34);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(260, 15);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Así está el hotel ahora mismo";
            //
            // btnRefrescar
            //
            this.btnRefrescar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(225, 211, 172);
            this.btnRefrescar.BackColor = System.Drawing.Color.FromArgb(251, 243, 228);
            this.btnRefrescar.ForeColor = System.Drawing.Color.FromArgb(74, 68, 56);
            this.btnRefrescar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefrescar.Location = new System.Drawing.Point(784, 10);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(110, 32);
            this.btnRefrescar.TabIndex = 2;
            this.btnRefrescar.Text = "↻ Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            //
            // flpKpis
            //
            this.flpKpis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpKpis.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flpKpis.WrapContents = true;
            this.flpKpis.AutoScroll = true;
            this.flpKpis.Location = new System.Drawing.Point(20, 86);
            this.flpKpis.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.flpKpis.Name = "flpKpis";
            this.flpKpis.Size = new System.Drawing.Size(894, 104);
            this.flpKpis.TabIndex = 1;
            //
            // flpHabitaciones
            //
            this.flpHabitaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpHabitaciones.AutoScroll = true;
            this.flpHabitaciones.Location = new System.Drawing.Point(20, 196);
            this.flpHabitaciones.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.flpHabitaciones.Name = "flpHabitaciones";
            this.flpHabitaciones.Size = new System.Drawing.Size(894, 309);
            this.flpHabitaciones.TabIndex = 2;
            //
            // frmDashboard
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(22, 58, 55);
            this.ClientSize = new System.Drawing.Size(934, 521);
            this.Controls.Add(this.tlpDashboard);
            this.Name = "frmDashboard";
            this.Text = "Tablero de habitaciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tlpDashboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpDashboard;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.FlowLayoutPanel flpKpis;
        private System.Windows.Forms.FlowLayoutPanel flpHabitaciones;
    }
}
