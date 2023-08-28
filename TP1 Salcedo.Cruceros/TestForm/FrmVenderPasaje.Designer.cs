
namespace TestForm
{
    partial class FrmVenderPasaje
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerarPasaje = new System.Windows.Forms.Button();
            this.lblDatosPasajero = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.txtBoxCantidadValijas = new System.Windows.Forms.TextBox();
            this.txtBoxPesoEquipaje = new System.Windows.Forms.TextBox();
            this.txtBoxNumeroPasaporte = new System.Windows.Forms.TextBox();
            this.lblDatosPasaporte = new System.Windows.Forms.Label();
            this.txtBoxNacionalidad = new System.Windows.Forms.TextBox();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.cmbPremium = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.btnGuardarDatosPasajero = new System.Windows.Forms.Button();
            this.dgvViajesDisponibles = new System.Windows.Forms.DataGridView();
            this.rtBoxDatosPasaje = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajesDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(560, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Viajes disponibles";
            // 
            // btnGenerarPasaje
            // 
            this.btnGenerarPasaje.Location = new System.Drawing.Point(831, 347);
            this.btnGenerarPasaje.Name = "btnGenerarPasaje";
            this.btnGenerarPasaje.Size = new System.Drawing.Size(149, 56);
            this.btnGenerarPasaje.TabIndex = 2;
            this.btnGenerarPasaje.Text = "Generar pasaje";
            this.btnGenerarPasaje.UseVisualStyleBackColor = true;
            this.btnGenerarPasaje.Click += new System.EventHandler(this.btnGenerarPasaje_Click);
            // 
            // lblDatosPasajero
            // 
            this.lblDatosPasajero.AutoSize = true;
            this.lblDatosPasajero.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDatosPasajero.Location = new System.Drawing.Point(2, 0);
            this.lblDatosPasajero.Name = "lblDatosPasajero";
            this.lblDatosPasajero.Size = new System.Drawing.Size(280, 50);
            this.lblDatosPasajero.TabIndex = 4;
            this.lblDatosPasajero.Text = "Datos pasajero";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(2, 75);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(100, 23);
            this.txtBoxNombre.TabIndex = 5;
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Location = new System.Drawing.Point(186, 75);
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(100, 23);
            this.txtBoxApellido.TabIndex = 6;
            // 
            // txtBoxCantidadValijas
            // 
            this.txtBoxCantidadValijas.Location = new System.Drawing.Point(3, 131);
            this.txtBoxCantidadValijas.Name = "txtBoxCantidadValijas";
            this.txtBoxCantidadValijas.Size = new System.Drawing.Size(100, 23);
            this.txtBoxCantidadValijas.TabIndex = 7;
            // 
            // txtBoxPesoEquipaje
            // 
            this.txtBoxPesoEquipaje.Location = new System.Drawing.Point(186, 131);
            this.txtBoxPesoEquipaje.Name = "txtBoxPesoEquipaje";
            this.txtBoxPesoEquipaje.Size = new System.Drawing.Size(100, 23);
            this.txtBoxPesoEquipaje.TabIndex = 8;
            // 
            // txtBoxNumeroPasaporte
            // 
            this.txtBoxNumeroPasaporte.Location = new System.Drawing.Point(2, 253);
            this.txtBoxNumeroPasaporte.Name = "txtBoxNumeroPasaporte";
            this.txtBoxNumeroPasaporte.Size = new System.Drawing.Size(100, 23);
            this.txtBoxNumeroPasaporte.TabIndex = 9;
            // 
            // lblDatosPasaporte
            // 
            this.lblDatosPasaporte.AutoSize = true;
            this.lblDatosPasaporte.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDatosPasaporte.Location = new System.Drawing.Point(46, 167);
            this.lblDatosPasaporte.Name = "lblDatosPasaporte";
            this.lblDatosPasaporte.Size = new System.Drawing.Size(196, 50);
            this.lblDatosPasaporte.TabIndex = 10;
            this.lblDatosPasaporte.Text = "Pasaporte";
            // 
            // txtBoxNacionalidad
            // 
            this.txtBoxNacionalidad.Location = new System.Drawing.Point(3, 375);
            this.txtBoxNacionalidad.Name = "txtBoxNacionalidad";
            this.txtBoxNacionalidad.Size = new System.Drawing.Size(100, 23);
            this.txtBoxNacionalidad.TabIndex = 14;
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(186, 310);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(100, 23);
            this.dtpFechaVencimiento.TabIndex = 15;
            // 
            // cmbPremium
            // 
            this.cmbPremium.FormattingEnabled = true;
            this.cmbPremium.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmbPremium.Location = new System.Drawing.Point(186, 375);
            this.cmbPremium.Name = "cmbPremium";
            this.cmbPremium.Size = new System.Drawing.Size(100, 23);
            this.cmbPremium.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Cantidad de valijas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Peso equipaje";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Fecha vencimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Sexo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Numero";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Fecha nacimiento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(205, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Premium";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 357);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 15);
            this.label12.TabIndex = 27;
            this.label12.Text = "Nacionalidad";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(2, 310);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(101, 23);
            this.dtpFechaNacimiento.TabIndex = 28;
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbSexo.Location = new System.Drawing.Point(186, 253);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(99, 23);
            this.cmbSexo.TabIndex = 30;
            // 
            // btnGuardarDatosPasajero
            // 
            this.btnGuardarDatosPasajero.Location = new System.Drawing.Point(68, 433);
            this.btnGuardarDatosPasajero.Name = "btnGuardarDatosPasajero";
            this.btnGuardarDatosPasajero.Size = new System.Drawing.Size(144, 56);
            this.btnGuardarDatosPasajero.TabIndex = 31;
            this.btnGuardarDatosPasajero.Text = "Guardar datos pasajero";
            this.btnGuardarDatosPasajero.UseVisualStyleBackColor = true;
            this.btnGuardarDatosPasajero.Click += new System.EventHandler(this.btnGuardarDatosPasajero_Click);
            // 
            // dgvViajesDisponibles
            // 
            this.dgvViajesDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViajesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViajesDisponibles.Location = new System.Drawing.Point(387, 75);
            this.dgvViajesDisponibles.Name = "dgvViajesDisponibles";
            this.dgvViajesDisponibles.ReadOnly = true;
            this.dgvViajesDisponibles.RowTemplate.Height = 25;
            this.dgvViajesDisponibles.Size = new System.Drawing.Size(573, 222);
            this.dgvViajesDisponibles.TabIndex = 32;
            this.dgvViajesDisponibles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViajesDisponibles_CellContentClick);
            // 
            // rtBoxDatosPasaje
            // 
            this.rtBoxDatosPasaje.Location = new System.Drawing.Point(319, 347);
            this.rtBoxDatosPasaje.Name = "rtBoxDatosPasaje";
            this.rtBoxDatosPasaje.ReadOnly = true;
            this.rtBoxDatosPasaje.Size = new System.Drawing.Size(470, 228);
            this.rtBoxDatosPasaje.TabIndex = 33;
            this.rtBoxDatosPasaje.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(495, 316);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 28);
            this.label11.TabIndex = 34;
            this.label11.Text = "Informacion";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(831, 499);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(149, 57);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmVenderPasaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(992, 587);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rtBoxDatosPasaje);
            this.Controls.Add(this.dgvViajesDisponibles);
            this.Controls.Add(this.btnGuardarDatosPasajero);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPremium);
            this.Controls.Add(this.dtpFechaVencimiento);
            this.Controls.Add(this.txtBoxNacionalidad);
            this.Controls.Add(this.lblDatosPasaporte);
            this.Controls.Add(this.txtBoxNumeroPasaporte);
            this.Controls.Add(this.txtBoxPesoEquipaje);
            this.Controls.Add(this.txtBoxCantidadValijas);
            this.Controls.Add(this.txtBoxApellido);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.lblDatosPasajero);
            this.Controls.Add(this.btnGenerarPasaje);
            this.Controls.Add(this.label1);
            this.Name = "FrmVenderPasaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVenderPasaje";
            this.Load += new System.EventHandler(this.FrmVenderPasaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajesDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarPasaje;
        private System.Windows.Forms.Label lblDatosPasajero;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.TextBox txtBoxCantidadValijas;
        private System.Windows.Forms.TextBox txtBoxPesoEquipaje;
        private System.Windows.Forms.TextBox txtBoxNumeroPasaporte;
        private System.Windows.Forms.Label lblDatosPasaporte;
        private System.Windows.Forms.TextBox txtBoxNacionalidad;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.ComboBox cmbPremium;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Button btnGuardarDatosPasajero;
        private System.Windows.Forms.DataGridView dgvViajesDisponibles;
        private System.Windows.Forms.RichTextBox rtBoxDatosPasaje;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCancelar;
    }
}