
namespace TestForm
{
    partial class FrmInfoCrucero
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
            this.dgvInfoPasajeros = new System.Windows.Forms.DataGridView();
            this.lblCruceroInfo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEliminarPasajero = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.rtbNombre = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoPasajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInfoPasajeros
            // 
            this.dgvInfoPasajeros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInfoPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoPasajeros.Location = new System.Drawing.Point(12, 60);
            this.dgvInfoPasajeros.Name = "dgvInfoPasajeros";
            this.dgvInfoPasajeros.RowTemplate.Height = 25;
            this.dgvInfoPasajeros.Size = new System.Drawing.Size(776, 304);
            this.dgvInfoPasajeros.TabIndex = 0;
            this.dgvInfoPasajeros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfoPasajeros_CellContentClick);
            // 
            // lblCruceroInfo
            // 
            this.lblCruceroInfo.AutoSize = true;
            this.lblCruceroInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCruceroInfo.Location = new System.Drawing.Point(12, 24);
            this.lblCruceroInfo.Name = "lblCruceroInfo";
            this.lblCruceroInfo.Size = new System.Drawing.Size(72, 21);
            this.lblCruceroInfo.TabIndex = 1;
            this.lblCruceroInfo.Text = "Crucero: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Editar pasajero";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminarPasajero
            // 
            this.btnEliminarPasajero.Location = new System.Drawing.Point(255, 392);
            this.btnEliminarPasajero.Name = "btnEliminarPasajero";
            this.btnEliminarPasajero.Size = new System.Drawing.Size(75, 46);
            this.btnEliminarPasajero.TabIndex = 3;
            this.btnEliminarPasajero.Text = "Eliminar pasajero";
            this.btnEliminarPasajero.UseVisualStyleBackColor = true;
            this.btnEliminarPasajero.Click += new System.EventHandler(this.btnEliminarPasajero_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(45, 392);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 46);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // rtbNombre
            // 
            this.rtbNombre.Location = new System.Drawing.Point(354, 392);
            this.rtbNombre.Name = "rtbNombre";
            this.rtbNombre.ReadOnly = true;
            this.rtbNombre.Size = new System.Drawing.Size(329, 43);
            this.rtbNombre.TabIndex = 5;
            this.rtbNombre.Text = "";
            // 
            // FrmInfoCrucero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbNombre);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEliminarPasajero);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCruceroInfo);
            this.Controls.Add(this.dgvInfoPasajeros);
            this.Name = "FrmInfoCrucero";
            this.Text = "FrmInfoCrucero";
            this.Load += new System.EventHandler(this.FrmInfoCrucero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoPasajeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInfoPasajeros;
        private System.Windows.Forms.Label lblCruceroInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEliminarPasajero;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.RichTextBox rtbNombre;
    }
}