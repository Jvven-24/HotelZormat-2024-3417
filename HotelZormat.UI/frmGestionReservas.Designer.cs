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
            this.lblHuesped = new System.Windows.Forms.Label();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.lblTemporada = new System.Windows.Forms.Label();
            this.cboHuesped = new System.Windows.Forms.ComboBox();
            this.cboHabitacion = new System.Windows.Forms.ComboBox();
            this.cboTemporada = new System.Windows.Forms.ComboBox();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblNoches = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.btnProximas = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHuesped
            // 
            this.lblHuesped.AutoSize = true;
            this.lblHuesped.Location = new System.Drawing.Point(20, 19);
            this.lblHuesped.Name = "lblHuesped";
            this.lblHuesped.Size = new System.Drawing.Size(53, 13);
            this.lblHuesped.TabIndex = 0;
            this.lblHuesped.Text = "Huésped:";
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Location = new System.Drawing.Point(330, 19);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(61, 13);
            this.lblHabitacion.TabIndex = 1;
            this.lblHabitacion.Text = "Habitación:";
            // 
            // lblTemporada
            // 
            this.lblTemporada.AutoSize = true;
            this.lblTemporada.Location = new System.Drawing.Point(575, 19);
            this.lblTemporada.Name = "lblTemporada";
            this.lblTemporada.Size = new System.Drawing.Size(64, 13);
            this.lblTemporada.TabIndex = 2;
            this.lblTemporada.Text = "Temporada:";
            // 
            // cboHuesped
            // 
            this.cboHuesped.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHuesped.FormattingEnabled = true;
            this.cboHuesped.Items.AddRange(new object[] {
            "Id - NombreCompleto"});
            this.cboHuesped.Location = new System.Drawing.Point(90, 15);
            this.cboHuesped.Name = "cboHuesped";
            this.cboHuesped.Size = new System.Drawing.Size(220, 21);
            this.cboHuesped.TabIndex = 3;
            // 
            // cboHabitacion
            // 
            this.cboHabitacion.FormattingEnabled = true;
            this.cboHabitacion.Items.AddRange(new object[] {
            "Numero - Tipo"});
            this.cboHabitacion.Location = new System.Drawing.Point(405, 15);
            this.cboHabitacion.Name = "cboHabitacion";
            this.cboHabitacion.Size = new System.Drawing.Size(150, 21);
            this.cboHabitacion.TabIndex = 4;
            this.cboHabitacion.SelectedIndexChanged += new System.EventHandler(this.cboHabitacion_SelectedIndexChanged);
            // 
            // cboTemporada
            // 
            this.cboTemporada.FormattingEnabled = true;
            this.cboTemporada.Location = new System.Drawing.Point(645, 15);
            this.cboTemporada.Name = "cboTemporada";
            this.cboTemporada.Size = new System.Drawing.Size(110, 21);
            this.cboTemporada.TabIndex = 5;
            this.cboTemporada.SelectedIndexChanged += new System.EventHandler(this.cboTemporada_SelectedIndexChanged);
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Location = new System.Drawing.Point(20, 56);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(52, 13);
            this.lblCheckIn.TabIndex = 6;
            this.lblCheckIn.Text = "Check-in:";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckIn.Location = new System.Drawing.Point(90, 52);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(150, 20);
            this.dtpCheckIn.TabIndex = 7;
            this.dtpCheckIn.ValueChanged += new System.EventHandler(this.dtpCheckIn_ValueChanged);
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckOut.Location = new System.Drawing.Point(330, 52);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(150, 20);
            this.dtpCheckOut.TabIndex = 8;
            this.dtpCheckOut.ValueChanged += new System.EventHandler(this.dtpCheckOut_ValueChanged);
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Location = new System.Drawing.Point(260, 56);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(59, 13);
            this.lblCheckOut.TabIndex = 9;
            this.lblCheckOut.Text = "Check-out:";
            // 
            // lblNoches
            // 
            this.lblNoches.AutoSize = true;
            this.lblNoches.Location = new System.Drawing.Point(568, 56);
            this.lblNoches.Name = "lblNoches";
            this.lblNoches.Size = new System.Drawing.Size(47, 13);
            this.lblNoches.TabIndex = 10;
            this.lblNoches.Text = "Noches:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(670, 56);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(40, 13);
            this.lblMonto.TabIndex = 11;
            this.lblMonto.Text = "Monto:";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(800, 13);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(100, 60);
            this.btnCrear.TabIndex = 12;
            this.btnCrear.Text = "Crear reserva";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // dgvReservas
            // 
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(20, 105);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(880, 300);
            this.dgvReservas.TabIndex = 13;
            this.dgvReservas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservas_CellContentClick);
            // 
            // btnProximas
            // 
            this.btnProximas.Location = new System.Drawing.Point(260, 420);
            this.btnProximas.Name = "btnProximas";
            this.btnProximas.Size = new System.Drawing.Size(150, 28);
            this.btnProximas.TabIndex = 14;
            this.btnProximas.Text = "Próximas 7 días";
            this.btnProximas.UseVisualStyleBackColor = true;
            this.btnProximas.Click += new System.EventHandler(this.btnProximas_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(140, 420);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 28);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(20, 420);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(110, 28);
            this.btnConfirmar.TabIndex = 16;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmGestionReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 481);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnProximas);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblNoches);
            this.Controls.Add(this.lblCheckOut);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.lblCheckIn);
            this.Controls.Add(this.cboTemporada);
            this.Controls.Add(this.cboHabitacion);
            this.Controls.Add(this.cboHuesped);
            this.Controls.Add(this.lblTemporada);
            this.Controls.Add(this.lblHabitacion);
            this.Controls.Add(this.lblHuesped);
            this.Name = "frmGestionReservas";
            this.Text = "Gestión de reservas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGestionReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHuesped;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.Label lblTemporada;
        private System.Windows.Forms.ComboBox cboHuesped;
        private System.Windows.Forms.ComboBox cboHabitacion;
        private System.Windows.Forms.ComboBox cboTemporada;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblNoches;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Button btnProximas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}