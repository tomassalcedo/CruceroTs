
namespace TestForm
{
    partial class FrmAgregarViaje
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAgregarViaje = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCruceros = new System.Windows.Forms.ComboBox();
            this.cmbDestinos = new System.Windows.Forms.ComboBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtBoxCodigoViaje = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipoViaje = new System.Windows.Forms.ComboBox();
            this.btnVerDetalles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(302, 255);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(102, 30);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAgregarViaje
            // 
            this.btnAgregarViaje.Location = new System.Drawing.Point(302, 203);
            this.btnAgregarViaje.Name = "btnAgregarViaje";
            this.btnAgregarViaje.Size = new System.Drawing.Size(102, 30);
            this.btnAgregarViaje.TabIndex = 1;
            this.btnAgregarViaje.Text = "Agregar viaje";
            this.btnAgregarViaje.UseVisualStyleBackColor = true;
            this.btnAgregarViaje.Click += new System.EventHandler(this.btnAgregarViaje_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(143, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Agregar Viaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccione fecha de inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingrese codigo del viaje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Seleccione destino";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Seleccione crucero";
            // 
            // cmbCruceros
            // 
            this.cmbCruceros.FormattingEnabled = true;
            this.cmbCruceros.Location = new System.Drawing.Point(51, 82);
            this.cmbCruceros.Name = "cmbCruceros";
            this.cmbCruceros.Size = new System.Drawing.Size(233, 23);
            this.cmbCruceros.TabIndex = 12;
            this.cmbCruceros.SelectedIndexChanged += new System.EventHandler(this.cmbCruceros_SelectedIndexChanged);
            // 
            // cmbDestinos
            // 
            this.cmbDestinos.FormattingEnabled = true;
            this.cmbDestinos.Location = new System.Drawing.Point(51, 203);
            this.cmbDestinos.Name = "cmbDestinos";
            this.cmbDestinos.Size = new System.Drawing.Size(233, 23);
            this.cmbDestinos.TabIndex = 13;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(51, 317);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(233, 23);
            this.dtpFechaInicio.TabIndex = 14;
            this.dtpFechaInicio.Value = new System.DateTime(2023, 5, 1, 0, 0, 0, 0);
            // 
            // txtBoxCodigoViaje
            // 
            this.txtBoxCodigoViaje.Location = new System.Drawing.Point(51, 262);
            this.txtBoxCodigoViaje.Name = "txtBoxCodigoViaje";
            this.txtBoxCodigoViaje.Size = new System.Drawing.Size(233, 23);
            this.txtBoxCodigoViaje.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Seleccione tipo de viaje";
            // 
            // cmbTipoViaje
            // 
            this.cmbTipoViaje.FormattingEnabled = true;
            this.cmbTipoViaje.Location = new System.Drawing.Point(51, 142);
            this.cmbTipoViaje.Name = "cmbTipoViaje";
            this.cmbTipoViaje.Size = new System.Drawing.Size(233, 23);
            this.cmbTipoViaje.TabIndex = 17;
            this.cmbTipoViaje.SelectedIndexChanged += new System.EventHandler(this.cmbTipoViaje_SelectedIndexChanged);
            // 
            // btnVerDetalles
            // 
            this.btnVerDetalles.Location = new System.Drawing.Point(302, 81);
            this.btnVerDetalles.Name = "btnVerDetalles";
            this.btnVerDetalles.Size = new System.Drawing.Size(102, 23);
            this.btnVerDetalles.TabIndex = 19;
            this.btnVerDetalles.Text = "Ver detalles";
            this.btnVerDetalles.UseVisualStyleBackColor = true;
            this.btnVerDetalles.Click += new System.EventHandler(this.btnVerDetalles_Click);
            // 
            // FrmAgregarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(456, 355);
            this.Controls.Add(this.btnVerDetalles);
            this.Controls.Add(this.cmbTipoViaje);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxCodigoViaje);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.cmbDestinos);
            this.Controls.Add(this.cmbCruceros);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarViaje);
            this.Controls.Add(this.btnVolver);
            this.Name = "FrmAgregarViaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarViaje";
            this.Load += new System.EventHandler(this.FrmAgregarViaje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAgregarViaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCruceros;
        private System.Windows.Forms.ComboBox cmbDestinos;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.TextBox txtBoxCodigoViaje;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTipoViaje;
        private System.Windows.Forms.Button btnVerDetalles;
    }
}