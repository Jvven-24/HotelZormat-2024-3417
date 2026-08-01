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
            this.lblInfo = new System.Windows.Forms.Label();
            this.dgvEstadiasActivas = new System.Windows.Forms.DataGridView();
            this.dgvReservasConfirmadas = new System.Windows.Forms.DataGridView();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadiasActivas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasConfirmadas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblInfo.Location = new System.Drawing.Point(20, 15);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(315, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Info — \"Seleccione una reserva confirmada o una estadía activa\"";
            // 
            // dgvEstadiasActivas
            // 
            this.dgvEstadiasActivas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEstadiasActivas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadiasActivas.Location = new System.Drawing.Point(520, 62);
            this.dgvEstadiasActivas.Name = "dgvEstadiasActivas";
            this.dgvEstadiasActivas.ReadOnly = true;
            this.dgvEstadiasActivas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstadiasActivas.Size = new System.Drawing.Size(460, 320);
            this.dgvEstadiasActivas.TabIndex = 1;
            this.dgvEstadiasActivas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstadiasActivas_CellContentClick);
            // 
            // dgvReservasConfirmadas
            // 
            this.dgvReservasConfirmadas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvReservasConfirmadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservasConfirmadas.Location = new System.Drawing.Point(20, 62);
            this.dgvReservasConfirmadas.Name = "dgvReservasConfirmadas";
            this.dgvReservasConfirmadas.ReadOnly = true;
            this.dgvReservasConfirmadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservasConfirmadas.Size = new System.Drawing.Size(460, 320);
            this.dgvReservasConfirmadas.TabIndex = 2;
            this.dgvReservasConfirmadas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservasConfirmadas_CellContentClick);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckOut.Location = new System.Drawing.Point(520, 395);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(150, 32);
            this.btnCheckOut.TabIndex = 3;
            this.btnCheckOut.Text = "Registrar Check-out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCheckIn.Location = new System.Drawing.Point(20, 395);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(150, 32);
            this.btnCheckIn.TabIndex = 4;
            this.btnCheckIn.Text = "Registrar Check-in";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // frmCheckInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.dgvReservasConfirmadas);
            this.Controls.Add(this.dgvEstadiasActivas);
            this.Controls.Add(this.lblInfo);
            this.Name = "frmCheckInOut";
            this.Text = "Check-in / Check-out";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCheckInOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadiasActivas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasConfirmadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DataGridView dgvEstadiasActivas;
        private System.Windows.Forms.DataGridView dgvReservasConfirmadas;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnCheckIn;
    }
}