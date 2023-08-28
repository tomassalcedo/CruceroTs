
namespace TestForm
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.btnVenderPasaje = new System.Windows.Forms.Button();
            this.btnMostrarVentas = new System.Windows.Forms.Button();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.timerFecha = new System.Windows.Forms.Timer(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMostrarCruceros = new System.Windows.Forms.Button();
            this.btnMostrarViajes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVenderPasaje
            // 
            this.btnVenderPasaje.Location = new System.Drawing.Point(12, 126);
            this.btnVenderPasaje.Name = "btnVenderPasaje";
            this.btnVenderPasaje.Size = new System.Drawing.Size(109, 31);
            this.btnVenderPasaje.TabIndex = 0;
            this.btnVenderPasaje.Text = "Vender pasaje";
            this.btnVenderPasaje.UseVisualStyleBackColor = true;
            this.btnVenderPasaje.Click += new System.EventHandler(this.btnVenderPasaje_Click);
            // 
            // btnMostrarVentas
            // 
            this.btnMostrarVentas.Location = new System.Drawing.Point(12, 190);
            this.btnMostrarVentas.Name = "btnMostrarVentas";
            this.btnMostrarVentas.Size = new System.Drawing.Size(109, 31);
            this.btnMostrarVentas.TabIndex = 1;
            this.btnMostrarVentas.Text = "Mostrar ventas";
            this.btnMostrarVentas.UseVisualStyleBackColor = true;
            this.btnMostrarVentas.Click += new System.EventHandler(this.btnMostrarVentas_Click);
            // 
            // ptbLogo
            // 
            this.ptbLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogo.Image")));
            this.ptbLogo.Location = new System.Drawing.Point(12, 12);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(109, 74);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLogo.TabIndex = 2;
            this.ptbLogo.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(127, 12);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 21);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "label1";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(127, 65);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(57, 21);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "label1";
            // 
            // timerFecha
            // 
            this.timerFecha.Enabled = true;
            this.timerFecha.Tick += new System.EventHandler(this.timerFecha_Tick);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 249);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 31);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMostrarCruceros
            // 
            this.btnMostrarCruceros.Location = new System.Drawing.Point(520, 126);
            this.btnMostrarCruceros.Name = "btnMostrarCruceros";
            this.btnMostrarCruceros.Size = new System.Drawing.Size(109, 31);
            this.btnMostrarCruceros.TabIndex = 6;
            this.btnMostrarCruceros.Text = "Mostrar cruceros";
            this.btnMostrarCruceros.UseVisualStyleBackColor = true;
            this.btnMostrarCruceros.Click += new System.EventHandler(this.btnMostrarCruceros_Click);
            // 
            // btnMostrarViajes
            // 
            this.btnMostrarViajes.Location = new System.Drawing.Point(520, 190);
            this.btnMostrarViajes.Name = "btnMostrarViajes";
            this.btnMostrarViajes.Size = new System.Drawing.Size(109, 31);
            this.btnMostrarViajes.TabIndex = 7;
            this.btnMostrarViajes.Text = "Mostrar viajes";
            this.btnMostrarViajes.UseVisualStyleBackColor = true;
            this.btnMostrarViajes.Click += new System.EventHandler(this.btnMostrarViajes_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(641, 402);
            this.Controls.Add(this.btnMostrarViajes);
            this.Controls.Add(this.btnMostrarCruceros);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.ptbLogo);
            this.Controls.Add(this.btnMostrarVentas);
            this.Controls.Add(this.btnVenderPasaje);
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVenderPasaje;
        private System.Windows.Forms.Button btnMostrarVentas;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer timerFecha;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMostrarCruceros;
        private System.Windows.Forms.Button btnMostrarViajes;
    }
}