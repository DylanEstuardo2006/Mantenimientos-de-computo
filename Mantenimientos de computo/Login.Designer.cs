namespace Mantenimientos_de_computo
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.PtbAudio = new System.Windows.Forms.PictureBox();
            this.PtbOjito = new System.Windows.Forms.PictureBox();
            this.PtbUsuario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PtbAudio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbOjito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(221, 287);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(233, 31);
            this.txtUsuario.TabIndex = 0;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(217)))), ((int)(((byte)(230)))));
            this.btnIngresar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(253, 582);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(162, 54);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.White;
            this.lblContraseña.Location = new System.Drawing.Point(219, 336);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(135, 23);
            this.lblContraseña.TabIndex = 7;
            this.lblContraseña.Text = "Contraseña: ";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(217, 261);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(97, 23);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "Usuario: ";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenia.Location = new System.Drawing.Point(221, 372);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(233, 31);
            this.txtContrasenia.TabIndex = 10;
            this.txtContrasenia.UseSystemPasswordChar = true;
            // 
            // PtbAudio
            // 
            this.PtbAudio.Image = global::Mantenimientos_de_computo.Properties.Resources.voice_login1;
            this.PtbAudio.Location = new System.Drawing.Point(40, 36);
            this.PtbAudio.Name = "PtbAudio";
            this.PtbAudio.Size = new System.Drawing.Size(110, 98);
            this.PtbAudio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbAudio.TabIndex = 11;
            this.PtbAudio.TabStop = false;
            this.PtbAudio.Click += new System.EventHandler(this.PtbAudio_Click);
            this.PtbAudio.MouseEnter += new System.EventHandler(this.PtbAudio_MouseEnter);
            // 
            // PtbOjito
            // 
            this.PtbOjito.Image = global::Mantenimientos_de_computo.Properties.Resources.ojito_;
            this.PtbOjito.Location = new System.Drawing.Point(476, 372);
            this.PtbOjito.Name = "PtbOjito";
            this.PtbOjito.Size = new System.Drawing.Size(41, 31);
            this.PtbOjito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbOjito.TabIndex = 9;
            this.PtbOjito.TabStop = false;
            this.PtbOjito.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.PtbOjito.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // PtbUsuario
            // 
            this.PtbUsuario.Image = global::Mantenimientos_de_computo.Properties.Resources.icon_user_;
            this.PtbUsuario.Location = new System.Drawing.Point(221, 36);
            this.PtbUsuario.Name = "PtbUsuario";
            this.PtbUsuario.Size = new System.Drawing.Size(233, 191);
            this.PtbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbUsuario.TabIndex = 6;
            this.PtbUsuario.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(658, 667);
            this.Controls.Add(this.PtbAudio);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.PtbOjito);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.PtbUsuario);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PtbAudio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbOjito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.PictureBox PtbUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox PtbOjito;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.PictureBox PtbAudio;
    }
}

