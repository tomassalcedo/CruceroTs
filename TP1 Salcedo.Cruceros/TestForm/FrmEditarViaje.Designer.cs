
namespace TestForm
{
    partial class FrmEditarViaje
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
            this.dgvViaje = new System.Windows.Forms.DataGridView();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoTurista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoPremium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoViaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CruceroEncargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAtributos = new System.Windows.Forms.ComboBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtBoxTextos = new System.Windows.Forms.TextBox();
            this.cbCruceros = new System.Windows.Forms.ComboBox();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViaje)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(297, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editar Viaje";
            // 
            // dgvViaje
            // 
            this.dgvViaje.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViaje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaInicio,
            this.Duracion,
            this.CostoTurista,
            this.CostoPremium,
            this.CodigoViaje,
            this.CruceroEncargado});
            this.dgvViaje.Location = new System.Drawing.Point(12, 62);
            this.dgvViaje.Name = "dgvViaje";
            this.dgvViaje.RowTemplate.Height = 25;
            this.dgvViaje.Size = new System.Drawing.Size(705, 105);
            this.dgvViaje.TabIndex = 1;
            // 
            // FechaInicio
            // 
            this.FechaInicio.HeaderText = "Fecha inicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            // 
            // Duracion
            // 
            this.Duracion.HeaderText = "Duracion";
            this.Duracion.Name = "Duracion";
            this.Duracion.ReadOnly = true;
            // 
            // CostoTurista
            // 
            this.CostoTurista.HeaderText = "Costo turista";
            this.CostoTurista.Name = "CostoTurista";
            this.CostoTurista.ReadOnly = true;
            // 
            // CostoPremium
            // 
            this.CostoPremium.HeaderText = "Costo premium";
            this.CostoPremium.Name = "CostoPremium";
            this.CostoPremium.ReadOnly = true;
            // 
            // CodigoViaje
            // 
            this.CodigoViaje.HeaderText = "Codigo viaje";
            this.CodigoViaje.Name = "CodigoViaje";
            this.CodigoViaje.ReadOnly = true;
            // 
            // CruceroEncargado
            // 
            this.CruceroEncargado.HeaderText = "Crucero encargado";
            this.CruceroEncargado.Name = "CruceroEncargado";
            this.CruceroEncargado.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione atributo a editar";
            // 
            // cbAtributos
            // 
            this.cbAtributos.FormattingEnabled = true;
            this.cbAtributos.Location = new System.Drawing.Point(281, 205);
            this.cbAtributos.Name = "cbAtributos";
            this.cbAtributos.Size = new System.Drawing.Size(150, 23);
            this.cbAtributos.TabIndex = 3;
            this.cbAtributos.SelectedIndexChanged += new System.EventHandler(this.cbAtributos_SelectedIndexChanged);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(281, 248);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(150, 23);
            this.dtpFechaInicio.TabIndex = 4;
            // 
            // txtBoxTextos
            // 
            this.txtBoxTextos.Location = new System.Drawing.Point(281, 248);
            this.txtBoxTextos.Name = "txtBoxTextos";
            this.txtBoxTextos.Size = new System.Drawing.Size(150, 23);
            this.txtBoxTextos.TabIndex = 5;
            // 
            // cbCruceros
            // 
            this.cbCruceros.FormattingEnabled = true;
            this.cbCruceros.Location = new System.Drawing.Point(281, 248);
            this.cbCruceros.Name = "cbCruceros";
            this.cbCruceros.Size = new System.Drawing.Size(150, 23);
            this.cbCruceros.TabIndex = 6;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(255, 295);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(92, 41);
            this.btnGuardarCambios.TabIndex = 7;
            this.btnGuardarCambios.Text = "Guardar cambio";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(377, 295);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(92, 41);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmEditarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(729, 347);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.cbCruceros);
            this.Controls.Add(this.txtBoxTextos);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.cbAtributos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvViaje);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditarViaje";
            this.Text = "FrmEditarViaje";
            this.Load += new System.EventHandler(this.FrmEditarViaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvViaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoTurista;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoPremium;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoViaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn CruceroEncargado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAtributos;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.TextBox txtBoxTextos;
        private System.Windows.Forms.ComboBox cbCruceros;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnVolver;
    }
}