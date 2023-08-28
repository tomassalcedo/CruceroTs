
namespace TestForm
{
    partial class FrmCruceros
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
            this.dgvCruceros = new System.Windows.Forms.DataGridView();
            this.EnViaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantCamarotesPremium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantCamarotesTurista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadCasinos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapacidadBodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.btnAgregarCrucero = new System.Windows.Forms.Button();
            this.btnEditarCrucero = new System.Windows.Forms.Button();
            this.btnVerPasajeros = new System.Windows.Forms.Button();
            this.btnEliminarCrucero = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCruceros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCruceros
            // 
            this.dgvCruceros.AllowUserToResizeColumns = false;
            this.dgvCruceros.AllowUserToResizeRows = false;
            this.dgvCruceros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCruceros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCruceros.Location = new System.Drawing.Point(12, 22);
            this.dgvCruceros.Name = "dgvCruceros";
            this.dgvCruceros.ReadOnly = true;
            this.dgvCruceros.RowTemplate.Height = 25;
            this.dgvCruceros.Size = new System.Drawing.Size(949, 263);
            this.dgvCruceros.TabIndex = 0;
            this.dgvCruceros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCruceros_CellContentClick);
            // 
            // EnViaje
            // 
            this.EnViaje.HeaderText = "EnViaje";
            this.EnViaje.Name = "EnViaje";
            this.EnViaje.ReadOnly = true;
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // CantCamarotesPremium
            // 
            this.CantCamarotesPremium.HeaderText = "Cant camarotes premium";
            this.CantCamarotesPremium.Name = "CantCamarotesPremium";
            this.CantCamarotesPremium.ReadOnly = true;
            // 
            // CantCamarotesTurista
            // 
            this.CantCamarotesTurista.HeaderText = "Cant camarotes turista";
            this.CantCamarotesTurista.Name = "CantCamarotesTurista";
            this.CantCamarotesTurista.ReadOnly = true;
            // 
            // CantidadCasinos
            // 
            this.CantidadCasinos.HeaderText = "Cantidad casinos";
            this.CantidadCasinos.Name = "CantidadCasinos";
            this.CantidadCasinos.ReadOnly = true;
            // 
            // CapacidadBodega
            // 
            this.CapacidadBodega.HeaderText = "Capacidad bodega";
            this.CapacidadBodega.Name = "CapacidadBodega";
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.Location = new System.Drawing.Point(815, 340);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(146, 45);
            this.btnVolverMenu.TabIndex = 2;
            this.btnVolverMenu.Text = "Volver al menu";
            this.btnVolverMenu.UseVisualStyleBackColor = true;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // btnAgregarCrucero
            // 
            this.btnAgregarCrucero.Location = new System.Drawing.Point(12, 340);
            this.btnAgregarCrucero.Name = "btnAgregarCrucero";
            this.btnAgregarCrucero.Size = new System.Drawing.Size(146, 45);
            this.btnAgregarCrucero.TabIndex = 3;
            this.btnAgregarCrucero.Text = "Agregar Crucero";
            this.btnAgregarCrucero.UseVisualStyleBackColor = true;
            this.btnAgregarCrucero.Click += new System.EventHandler(this.btnAgregarCrucero_Click);
            // 
            // btnEditarCrucero
            // 
            this.btnEditarCrucero.Location = new System.Drawing.Point(164, 340);
            this.btnEditarCrucero.Name = "btnEditarCrucero";
            this.btnEditarCrucero.Size = new System.Drawing.Size(146, 45);
            this.btnEditarCrucero.TabIndex = 4;
            this.btnEditarCrucero.Text = "Editar Crucero";
            this.btnEditarCrucero.UseVisualStyleBackColor = true;
            this.btnEditarCrucero.Click += new System.EventHandler(this.btnEditarCrucero_Click);
            // 
            // btnVerPasajeros
            // 
            this.btnVerPasajeros.Location = new System.Drawing.Point(316, 340);
            this.btnVerPasajeros.Name = "btnVerPasajeros";
            this.btnVerPasajeros.Size = new System.Drawing.Size(146, 45);
            this.btnVerPasajeros.TabIndex = 5;
            this.btnVerPasajeros.Text = "Ver Pasajeros";
            this.btnVerPasajeros.UseVisualStyleBackColor = true;
            this.btnVerPasajeros.Click += new System.EventHandler(this.btnVerPasajeros_Click);
            // 
            // btnEliminarCrucero
            // 
            this.btnEliminarCrucero.Location = new System.Drawing.Point(468, 340);
            this.btnEliminarCrucero.Name = "btnEliminarCrucero";
            this.btnEliminarCrucero.Size = new System.Drawing.Size(146, 45);
            this.btnEliminarCrucero.TabIndex = 6;
            this.btnEliminarCrucero.Text = "Eliminar Crucero";
            this.btnEliminarCrucero.UseVisualStyleBackColor = true;
            this.btnEliminarCrucero.Click += new System.EventHandler(this.btnEliminarCrucero_Click);
            // 
            // FrmCruceros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(973, 393);
            this.Controls.Add(this.btnEliminarCrucero);
            this.Controls.Add(this.btnVerPasajeros);
            this.Controls.Add(this.btnEditarCrucero);
            this.Controls.Add(this.btnAgregarCrucero);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.dgvCruceros);
            this.Name = "FrmCruceros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCruceros";
            this.Load += new System.EventHandler(this.FrmCruceros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCruceros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCruceros;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnViaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantCamarotesPremium;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantCamarotesTurista;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadCasinos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapacidadBodega;
        private System.Windows.Forms.Button btnVolverMenu;
        private System.Windows.Forms.Button btnAgregarCrucero;
        private System.Windows.Forms.Button btnEditarCrucero;
        private System.Windows.Forms.Button btnVerPasajeros;
        private System.Windows.Forms.Button btnEliminarCrucero;
    }
}