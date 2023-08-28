
namespace TestForm
{
    partial class FrmEditarCrucero
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCamposEditar = new System.Windows.Forms.ComboBox();
            this.dgvCrucero = new System.Windows.Forms.DataGridView();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCrucero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadCamarotesPremium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadCamarotesTurista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadCasinos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapacidadBodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnRuta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.txtBoxCampo = new System.Windows.Forms.TextBox();
            this.cmbEnViaje = new System.Windows.Forms.ComboBox();
            this.lblEnViaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrucero)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(264, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editar Crucero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione atributo a editar";
            // 
            // cmbCamposEditar
            // 
            this.cmbCamposEditar.FormattingEnabled = true;
            this.cmbCamposEditar.Location = new System.Drawing.Point(291, 266);
            this.cmbCamposEditar.Name = "cmbCamposEditar";
            this.cmbCamposEditar.Size = new System.Drawing.Size(147, 23);
            this.cmbCamposEditar.TabIndex = 2;
            this.cmbCamposEditar.SelectedIndexChanged += new System.EventHandler(this.cmbCamposEditar_SelectedIndexChanged);
            // 
            // dgvCrucero
            // 
            this.dgvCrucero.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCrucero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrucero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricula,
            this.NombreCrucero,
            this.CantidadCamarotesPremium,
            this.CantidadCamarotesTurista,
            this.CantidadCasinos,
            this.CapacidadBodega,
            this.EnRuta});
            this.dgvCrucero.Location = new System.Drawing.Point(12, 71);
            this.dgvCrucero.Name = "dgvCrucero";
            this.dgvCrucero.RowTemplate.Height = 25;
            this.dgvCrucero.Size = new System.Drawing.Size(734, 150);
            this.dgvCrucero.TabIndex = 3;
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            // 
            // NombreCrucero
            // 
            this.NombreCrucero.HeaderText = "Nombre";
            this.NombreCrucero.Name = "NombreCrucero";
            this.NombreCrucero.ReadOnly = true;
            // 
            // CantidadCamarotesPremium
            // 
            this.CantidadCamarotesPremium.HeaderText = "Cant Camaroteres Premium";
            this.CantidadCamarotesPremium.Name = "CantidadCamarotesPremium";
            this.CantidadCamarotesPremium.ReadOnly = true;
            // 
            // CantidadCamarotesTurista
            // 
            this.CantidadCamarotesTurista.HeaderText = "Cant camarotes turista";
            this.CantidadCamarotesTurista.Name = "CantidadCamarotesTurista";
            this.CantidadCamarotesTurista.ReadOnly = true;
            // 
            // CantidadCasinos
            // 
            this.CantidadCasinos.HeaderText = "Cant Casinos";
            this.CantidadCasinos.Name = "CantidadCasinos";
            this.CantidadCasinos.ReadOnly = true;
            // 
            // CapacidadBodega
            // 
            this.CapacidadBodega.HeaderText = "Capacidad Bodega";
            this.CapacidadBodega.Name = "CapacidadBodega";
            this.CapacidadBodega.ReadOnly = true;
            // 
            // EnRuta
            // 
            this.EnRuta.HeaderText = "En ruta";
            this.EnRuta.Name = "EnRuta";
            this.EnRuta.ReadOnly = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(377, 354);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(94, 45);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(258, 354);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(94, 45);
            this.btnGuardarCambios.TabIndex = 5;
            this.btnGuardarCambios.Text = "Guardar cambio";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // txtBoxCampo
            // 
            this.txtBoxCampo.Location = new System.Drawing.Point(258, 313);
            this.txtBoxCampo.Name = "txtBoxCampo";
            this.txtBoxCampo.Size = new System.Drawing.Size(213, 23);
            this.txtBoxCampo.TabIndex = 6;
            // 
            // cmbEnViaje
            // 
            this.cmbEnViaje.FormattingEnabled = true;
            this.cmbEnViaje.Location = new System.Drawing.Point(496, 313);
            this.cmbEnViaje.Name = "cmbEnViaje";
            this.cmbEnViaje.Size = new System.Drawing.Size(121, 23);
            this.cmbEnViaje.TabIndex = 7;
            // 
            // lblEnViaje
            // 
            this.lblEnViaje.AutoSize = true;
            this.lblEnViaje.Location = new System.Drawing.Point(526, 292);
            this.lblEnViaje.Name = "lblEnViaje";
            this.lblEnViaje.Size = new System.Drawing.Size(48, 15);
            this.lblEnViaje.TabIndex = 8;
            this.lblEnViaje.Text = "En Viaje";
            // 
            // FrmEditarCrucero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(758, 412);
            this.Controls.Add(this.lblEnViaje);
            this.Controls.Add(this.cmbEnViaje);
            this.Controls.Add(this.txtBoxCampo);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvCrucero);
            this.Controls.Add(this.cmbCamposEditar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditarCrucero";
            this.Text = "FrmEditarCrucero";
            this.Load += new System.EventHandler(this.FrmEditarCrucero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrucero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCamposEditar;
        private System.Windows.Forms.DataGridView dgvCrucero;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.TextBox txtBoxCampo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCrucero;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadCamarotesPremium;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadCamarotesTurista;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadCasinos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapacidadBodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnRuta;
        private System.Windows.Forms.ComboBox cmbEnViaje;
        private System.Windows.Forms.Label lblEnViaje;
    }
}