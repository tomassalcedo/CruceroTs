
namespace TestForm
{
    partial class FrmViajes
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
            this.dgvViajes = new System.Windows.Forms.DataGridView();
            this.btnAgregarViaje = new System.Windows.Forms.Button();
            this.btnEliminarViaje = new System.Windows.Forms.Button();
            this.btnEditarViaje = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViajes
            // 
            this.dgvViajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViajes.Location = new System.Drawing.Point(12, 60);
            this.dgvViajes.Name = "dgvViajes";
            this.dgvViajes.RowTemplate.Height = 25;
            this.dgvViajes.Size = new System.Drawing.Size(776, 234);
            this.dgvViajes.TabIndex = 0;
            // 
            // btnAgregarViaje
            // 
            this.btnAgregarViaje.Location = new System.Drawing.Point(12, 331);
            this.btnAgregarViaje.Name = "btnAgregarViaje";
            this.btnAgregarViaje.Size = new System.Drawing.Size(99, 45);
            this.btnAgregarViaje.TabIndex = 1;
            this.btnAgregarViaje.Text = "Agregar Viaje";
            this.btnAgregarViaje.UseVisualStyleBackColor = true;
            this.btnAgregarViaje.Click += new System.EventHandler(this.btnAgregarViaje_Click);
            // 
            // btnEliminarViaje
            // 
            this.btnEliminarViaje.Location = new System.Drawing.Point(251, 331);
            this.btnEliminarViaje.Name = "btnEliminarViaje";
            this.btnEliminarViaje.Size = new System.Drawing.Size(99, 45);
            this.btnEliminarViaje.TabIndex = 2;
            this.btnEliminarViaje.Text = "Eliminar Viaje";
            this.btnEliminarViaje.UseVisualStyleBackColor = true;
            this.btnEliminarViaje.Click += new System.EventHandler(this.btnEliminarViaje_Click);
            // 
            // btnEditarViaje
            // 
            this.btnEditarViaje.Location = new System.Drawing.Point(131, 331);
            this.btnEditarViaje.Name = "btnEditarViaje";
            this.btnEditarViaje.Size = new System.Drawing.Size(99, 45);
            this.btnEditarViaje.TabIndex = 3;
            this.btnEditarViaje.Text = "Editar Viaje";
            this.btnEditarViaje.UseVisualStyleBackColor = true;
            this.btnEditarViaje.Click += new System.EventHandler(this.btnEditarViaje_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(370, 331);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(99, 45);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(317, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lista de viajes";
            // 
            // FrmViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 403);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEditarViaje);
            this.Controls.Add(this.btnEliminarViaje);
            this.Controls.Add(this.btnAgregarViaje);
            this.Controls.Add(this.dgvViajes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmViajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmViajes";
            this.Load += new System.EventHandler(this.FrmViajes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViajes;
        private System.Windows.Forms.Button btnAgregarViaje;
        private System.Windows.Forms.Button btnEliminarViaje;
        private System.Windows.Forms.Button btnEditarViaje;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
    }
}