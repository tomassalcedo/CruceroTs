
namespace TestForm
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.txtBoxContrasenia = new System.Windows.Forms.TextBox();
            this.txtBoxUsuario = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ptbLogoLogin = new System.Windows.Forms.PictureBox();
            this.chkBoxMostrarPassword = new System.Windows.Forms.CheckBox();
            this.lblCheckBoxPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Himalaya", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBienvenida.Location = new System.Drawing.Point(45, 125);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(135, 35);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenido";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(63, 169);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(47, 15);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Location = new System.Drawing.Point(63, 232);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(67, 15);
            this.lblContrasenia.TabIndex = 2;
            this.lblContrasenia.Text = "Contraseña";
            // 
            // txtBoxContrasenia
            // 
            this.txtBoxContrasenia.Location = new System.Drawing.Point(63, 250);
            this.txtBoxContrasenia.Name = "txtBoxContrasenia";
            this.txtBoxContrasenia.Size = new System.Drawing.Size(100, 23);
            this.txtBoxContrasenia.TabIndex = 2;
            // 
            // txtBoxUsuario
            // 
            this.txtBoxUsuario.Location = new System.Drawing.Point(63, 187);
            this.txtBoxUsuario.Name = "txtBoxUsuario";
            this.txtBoxUsuario.Size = new System.Drawing.Size(100, 23);
            this.txtBoxUsuario.TabIndex = 1;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(74, 314);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Rellenar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ptbLogoLogin
            // 
            this.ptbLogoLogin.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogoLogin.Image")));
            this.ptbLogoLogin.Location = new System.Drawing.Point(43, 11);
            this.ptbLogoLogin.Name = "ptbLogoLogin";
            this.ptbLogoLogin.Size = new System.Drawing.Size(137, 111);
            this.ptbLogoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLogoLogin.TabIndex = 7;
            this.ptbLogoLogin.TabStop = false;
            // 
            // chkBoxMostrarPassword
            // 
            this.chkBoxMostrarPassword.AutoSize = true;
            this.chkBoxMostrarPassword.Location = new System.Drawing.Point(63, 278);
            this.chkBoxMostrarPassword.Name = "chkBoxMostrarPassword";
            this.chkBoxMostrarPassword.Size = new System.Drawing.Size(83, 19);
            this.chkBoxMostrarPassword.TabIndex = 8;
            this.chkBoxMostrarPassword.Text = "checkBox1";
            this.chkBoxMostrarPassword.UseVisualStyleBackColor = true;
            this.chkBoxMostrarPassword.CheckedChanged += new System.EventHandler(this.chkBoxMostrarPassword_CheckedChanged);
            // 
            // lblCheckBoxPassword
            // 
            this.lblCheckBoxPassword.AutoSize = true;
            this.lblCheckBoxPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCheckBoxPassword.Location = new System.Drawing.Point(83, 279);
            this.lblCheckBoxPassword.Name = "lblCheckBoxPassword";
            this.lblCheckBoxPassword.Size = new System.Drawing.Size(109, 15);
            this.lblCheckBoxPassword.TabIndex = 9;
            this.lblCheckBoxPassword.Text = "Mostrar contraseña";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(231, 393);
            this.Controls.Add(this.lblCheckBoxPassword);
            this.Controls.Add(this.chkBoxMostrarPassword);
            this.Controls.Add(this.ptbLogoLogin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtBoxUsuario);
            this.Controls.Add(this.txtBoxContrasenia);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblBienvenida);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogoLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.TextBox txtBoxContrasenia;
        private System.Windows.Forms.TextBox txtBoxUsuario;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox ptbLogoLogin;
        private System.Windows.Forms.CheckBox chkBoxMostrarPassword;
        private System.Windows.Forms.Label lblCheckBoxPassword;
    }
}

