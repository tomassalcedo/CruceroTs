
namespace TestForm
{
    partial class FrmEditarPasajero
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
            this.dgvPasajeroEditar = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroPasaporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadValijas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoEquipaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCamposEditar = new System.Windows.Forms.ComboBox();
            this.txtValorEditado = new System.Windows.Forms.TextBox();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajeroEditar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPasajeroEditar
            // 
            this.dgvPasajeroEditar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasajeroEditar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.NumeroPasaporte,
            this.CantidadValijas,
            this.PesoEquipaje});
            this.dgvPasajeroEditar.Location = new System.Drawing.Point(31, 40);
            this.dgvPasajeroEditar.Name = "dgvPasajeroEditar";
            this.dgvPasajeroEditar.RowTemplate.Height = 25;
            this.dgvPasajeroEditar.Size = new System.Drawing.Size(545, 100);
            this.dgvPasajeroEditar.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apelilido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // NumeroPasaporte
            // 
            this.NumeroPasaporte.HeaderText = "Num Pasaporte";
            this.NumeroPasaporte.Name = "NumeroPasaporte";
            this.NumeroPasaporte.ReadOnly = true;
            // 
            // CantidadValijas
            // 
            this.CantidadValijas.HeaderText = "Cant Valijas";
            this.CantidadValijas.Name = "CantidadValijas";
            this.CantidadValijas.ReadOnly = true;
            // 
            // PesoEquipaje
            // 
            this.PesoEquipaje.HeaderText = "Peso equipaje";
            this.PesoEquipaje.Name = "PesoEquipaje";
            this.PesoEquipaje.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(154, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Editar pasajero";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbCamposEditar
            // 
            this.cbCamposEditar.FormattingEnabled = true;
            this.cbCamposEditar.Location = new System.Drawing.Point(227, 197);
            this.cbCamposEditar.Name = "cbCamposEditar";
            this.cbCamposEditar.Size = new System.Drawing.Size(147, 23);
            this.cbCamposEditar.TabIndex = 2;
            this.cbCamposEditar.SelectedIndexChanged += new System.EventHandler(this.cbCamposEditar_SelectedIndexChanged);
            // 
            // txtValorEditado
            // 
            this.txtValorEditado.Location = new System.Drawing.Point(187, 239);
            this.txtValorEditado.Name = "txtValorEditado";
            this.txtValorEditado.Size = new System.Drawing.Size(227, 23);
            this.txtValorEditado.TabIndex = 3;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(187, 292);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(103, 40);
            this.btnGuardarCambios.TabIndex = 4;
            this.btnGuardarCambios.Text = "Guardar cambio";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(311, 292);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(103, 40);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seleccione atributo a editar";
            // 
            // FrmEditarPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(609, 359);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.txtValorEditado);
            this.Controls.Add(this.cbCamposEditar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPasajeroEditar);
            this.Name = "FrmEditarPasajero";
            this.Text = "FrmEditarPasajero";
            this.Load += new System.EventHandler(this.FrmEditarPasajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajeroEditar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPasajeroEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCamposEditar;
        private System.Windows.Forms.TextBox txtValorEditado;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroPasaporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadValijas;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoEquipaje;
        private System.Windows.Forms.Label label2;
    }
}