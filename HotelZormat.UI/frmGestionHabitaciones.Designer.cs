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
            this.lblFiltroPiso = new System.Windows.Forms.Label();
            this.cboFiltroPiso = new System.Windows.Forms.ComboBox();
            this.lblFiltroEstado = new System.Windows.Forms.Label();
            this.cboFiltroEstado = new System.Windows.Forms.ComboBox();
            this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblEstadoForm = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lblPiso = new System.Windows.Forms.Label();
            this.lblTarifa = new System.Windows.Forms.Label();
            this.lblIcono = new System.Windows.Forms.Label();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFiltroPiso
            // 
            this.lblFiltroPiso.AutoSize = true;
            this.lblFiltroPiso.Location = new System.Drawing.Point(20, 19);
            this.lblFiltroPiso.Name = "lblFiltroPiso";
            this.lblFiltroPiso.Size = new System.Drawing.Size(30, 13);
            this.lblFiltroPiso.TabIndex = 0;
            this.lblFiltroPiso.Text = "Piso:";
            // 
            // cboFiltroPiso
            // 
            this.cboFiltroPiso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroPiso.FormattingEnabled = true;
            this.cboFiltroPiso.Location = new System.Drawing.Point(60, 15);
            this.cboFiltroPiso.Name = "cboFiltroPiso";
            this.cboFiltroPiso.Size = new System.Drawing.Size(100, 21);
            this.cboFiltroPiso.TabIndex = 1;
            // 
            // lblFiltroEstado
            // 
            this.lblFiltroEstado.AutoSize = true;
            this.lblFiltroEstado.Location = new System.Drawing.Point(176, 19);
            this.lblFiltroEstado.Name = "lblFiltroEstado";
            this.lblFiltroEstado.Size = new System.Drawing.Size(43, 13);
            this.lblFiltroEstado.TabIndex = 2;
            this.lblFiltroEstado.Text = "Estado:";
            // 
            // cboFiltroEstado
            // 
            this.cboFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroEstado.FormattingEnabled = true;
            this.cboFiltroEstado.Location = new System.Drawing.Point(228, 15);
            this.cboFiltroEstado.Name = "cboFiltroEstado";
            this.cboFiltroEstado.Size = new System.Drawing.Size(130, 21);
            this.cboFiltroEstado.TabIndex = 3;
            // 
            // dgvHabitaciones
            // 
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones.Location = new System.Drawing.Point(20, 50);
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.ReadOnly = true;
            this.dgvHabitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHabitaciones.Size = new System.Drawing.Size(650, 300);
            this.dgvHabitaciones.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(20, 365);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 28);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(120, 365);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 28);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(220, 365);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 28);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(320, 365);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 28);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(700, 55);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 9;
            this.lblNumero.Text = "Número:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(700, 85);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(700, 175);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(61, 13);
            this.lblCapacidad.TabIndex = 11;
            this.lblCapacidad.Text = "Capacidad:";
            // 
            // lblEstadoForm
            // 
            this.lblEstadoForm.AutoSize = true;
            this.lblEstadoForm.Location = new System.Drawing.Point(700, 115);
            this.lblEstadoForm.Name = "lblEstadoForm";
            this.lblEstadoForm.Size = new System.Drawing.Size(43, 13);
            this.lblEstadoForm.TabIndex = 12;
            this.lblEstadoForm.Text = "Estado:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(780, 52);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(180, 20);
            this.txtNumero.TabIndex = 14;
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(780, 142);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(180, 20);
            this.txtPiso.TabIndex = 15;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(780, 172);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(180, 20);
            this.txtCapacidad.TabIndex = 16;
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(780, 82);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(180, 21);
            this.cboTipo.TabIndex = 17;
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(780, 112);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(180, 21);
            this.cboEstado.TabIndex = 18;
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(700, 145);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(30, 13);
            this.lblPiso.TabIndex = 19;
            this.lblPiso.Text = "Piso:";
            // 
            // lblTarifa
            // 
            this.lblTarifa.AutoSize = true;
            this.lblTarifa.Location = new System.Drawing.Point(700, 205);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.Size = new System.Drawing.Size(37, 13);
            this.lblTarifa.TabIndex = 20;
            this.lblTarifa.Text = "Tarifa:";
            // 
            // lblIcono
            // 
            this.lblIcono.AutoSize = true;
            this.lblIcono.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcono.Location = new System.Drawing.Point(700, 240);
            this.lblIcono.Name = "lblIcono";
            this.lblIcono.Size = new System.Drawing.Size(79, 31);
            this.lblIcono.TabIndex = 21;
            this.lblIcono.Text = "icono";
            // 
            // txtTarifa
            // 
            this.txtTarifa.Location = new System.Drawing.Point(780, 202);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.Size = new System.Drawing.Size(180, 20);
            this.txtTarifa.TabIndex = 22;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(780, 248);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(39, 13);
            this.lblEstado.TabIndex = 23;
            this.lblEstado.Text = "estado";
            // 
            // frmGestionHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 421);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtTarifa);
            this.Controls.Add(this.lblIcono);
            this.Controls.Add(this.lblTarifa);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.txtPiso);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblEstadoForm);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvHabitaciones);
            this.Controls.Add(this.cboFiltroEstado);
            this.Controls.Add(this.lblFiltroEstado);
            this.Controls.Add(this.cboFiltroPiso);
            this.Controls.Add(this.lblFiltroPiso);
            this.Name = "frmGestionHabitaciones";
            this.Text = "Gestión de habitaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiltroPiso;
        private System.Windows.Forms.ComboBox cboFiltroPiso;
        private System.Windows.Forms.Label lblFiltroEstado;
        private System.Windows.Forms.ComboBox cboFiltroEstado;
        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblEstadoForm;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.Label lblTarifa;
        private System.Windows.Forms.Label lblIcono;
        private System.Windows.Forms.TextBox txtTarifa;
        private System.Windows.Forms.Label lblEstado;
    }
}