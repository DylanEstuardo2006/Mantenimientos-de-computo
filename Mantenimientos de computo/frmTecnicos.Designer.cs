namespace Mantenimientos_de_computo
{
    partial class frmTecnicos
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
            this.PnlFondo = new System.Windows.Forms.Panel();
            this.DgvTecnicos = new System.Windows.Forms.DataGridView();
            this.lblIDTecnico = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtNumeroTelefono = new System.Windows.Forms.TextBox();
            this.lblIngreseTelefono = new System.Windows.Forms.Label();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.txtNombreTecnico = new System.Windows.Forms.TextBox();
            this.lblNombreTecnico = new System.Windows.Forms.Label();
            this.PnCaja = new System.Windows.Forms.Panel();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.PnlFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTecnicos)).BeginInit();
            this.PnCaja.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlFondo
            // 
            this.PnlFondo.BackColor = System.Drawing.Color.Bisque;
            this.PnlFondo.Controls.Add(this.DgvTecnicos);
            this.PnlFondo.Controls.Add(this.lblIDTecnico);
            this.PnlFondo.Controls.Add(this.btnVolver);
            this.PnlFondo.Controls.Add(this.txtContrasenia);
            this.PnlFondo.Controls.Add(this.lblContrasenia);
            this.PnlFondo.Controls.Add(this.txtEmail);
            this.PnlFondo.Controls.Add(this.lblEmail);
            this.PnlFondo.Controls.Add(this.btnRegistrar);
            this.PnlFondo.Controls.Add(this.txtNumeroTelefono);
            this.PnlFondo.Controls.Add(this.lblIngreseTelefono);
            this.PnlFondo.Controls.Add(this.txtApellidoMaterno);
            this.PnlFondo.Controls.Add(this.lblApellidoMaterno);
            this.PnlFondo.Controls.Add(this.txtApellidoPaterno);
            this.PnlFondo.Controls.Add(this.lblApellidoPaterno);
            this.PnlFondo.Controls.Add(this.txtNombreTecnico);
            this.PnlFondo.Controls.Add(this.lblNombreTecnico);
            this.PnlFondo.Controls.Add(this.PnCaja);
            this.PnlFondo.Location = new System.Drawing.Point(0, 0);
            this.PnlFondo.Name = "PnlFondo";
            this.PnlFondo.Size = new System.Drawing.Size(1178, 718);
            this.PnlFondo.TabIndex = 19;
            // 
            // DgvTecnicos
            // 
            this.DgvTecnicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTecnicos.Location = new System.Drawing.Point(13, 13);
            this.DgvTecnicos.Name = "DgvTecnicos";
            this.DgvTecnicos.ReadOnly = true;
            this.DgvTecnicos.RowHeadersWidth = 51;
            this.DgvTecnicos.RowTemplate.Height = 24;
            this.DgvTecnicos.Size = new System.Drawing.Size(1144, 259);
            this.DgvTecnicos.TabIndex = 38;
            this.DgvTecnicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTecnicos_CellClick);
            // 
            // lblIDTecnico
            // 
            this.lblIDTecnico.AutoSize = true;
            this.lblIDTecnico.Location = new System.Drawing.Point(537, 292);
            this.lblIDTecnico.Name = "lblIDTecnico";
            this.lblIDTecnico.Size = new System.Drawing.Size(112, 23);
            this.lblIDTecnico.TabIndex = 37;
            this.lblIDTecnico.Text = "IblTecnico";
            this.lblIDTecnico.Visible = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnVolver.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(12, 657);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(162, 54);
            this.btnVolver.TabIndex = 26;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(369, 560);
            this.txtContrasenia.MaxLength = 10;
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(249, 31);
            this.txtContrasenia.TabIndex = 36;
            this.txtContrasenia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContrasenia_KeyPress);
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Location = new System.Drawing.Point(143, 568);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(238, 23);
            this.lblContrasenia.TabIndex = 35;
            this.lblContrasenia.Text = "Ingrese su Contraseña:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(369, 515);
            this.txtEmail.MaxLength = 20;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(249, 31);
            this.txtEmail.TabIndex = 34;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(133, 523);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(248, 23);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Text = "Ingrese su correo Email:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(124)))), ((int)(((byte)(141)))));
            this.btnRegistrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(410, 610);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(162, 54);
            this.btnRegistrar.TabIndex = 26;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtNumeroTelefono
            // 
            this.txtNumeroTelefono.Location = new System.Drawing.Point(369, 469);
            this.txtNumeroTelefono.MaxLength = 10;
            this.txtNumeroTelefono.Name = "txtNumeroTelefono";
            this.txtNumeroTelefono.Size = new System.Drawing.Size(249, 31);
            this.txtNumeroTelefono.TabIndex = 32;
            this.txtNumeroTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroTelefono_KeyPress);
            // 
            // lblIngreseTelefono
            // 
            this.lblIngreseTelefono.AutoSize = true;
            this.lblIngreseTelefono.Location = new System.Drawing.Point(68, 477);
            this.lblIngreseTelefono.Name = "lblIngreseTelefono";
            this.lblIngreseTelefono.Size = new System.Drawing.Size(313, 23);
            this.lblIngreseTelefono.TabIndex = 31;
            this.lblIngreseTelefono.Text = "Ingrese su número de telefono:";
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new System.Drawing.Point(369, 422);
            this.txtApellidoMaterno.MaxLength = 20;
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(249, 31);
            this.txtApellidoMaterno.TabIndex = 30;
            this.txtApellidoMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoMaterno_KeyPress);
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Location = new System.Drawing.Point(93, 430);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(288, 23);
            this.lblApellidoMaterno.TabIndex = 29;
            this.lblApellidoMaterno.Text = "Ingrese su apellido materno:";
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(369, 372);
            this.txtApellidoPaterno.MaxLength = 20;
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(249, 31);
            this.txtApellidoPaterno.TabIndex = 28;
            this.txtApellidoPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoPaterno_KeyPress);
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Location = new System.Drawing.Point(98, 380);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(283, 23);
            this.lblApellidoPaterno.TabIndex = 27;
            this.lblApellidoPaterno.Text = "Ingrese su apellido paterno:";
            // 
            // txtNombreTecnico
            // 
            this.txtNombreTecnico.Location = new System.Drawing.Point(369, 321);
            this.txtNombreTecnico.MaxLength = 20;
            this.txtNombreTecnico.Name = "txtNombreTecnico";
            this.txtNombreTecnico.Size = new System.Drawing.Size(249, 31);
            this.txtNombreTecnico.TabIndex = 26;
            this.txtNombreTecnico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreTecnico_KeyPress);
            // 
            // lblNombreTecnico
            // 
            this.lblNombreTecnico.AutoSize = true;
            this.lblNombreTecnico.Location = new System.Drawing.Point(75, 324);
            this.lblNombreTecnico.Name = "lblNombreTecnico";
            this.lblNombreTecnico.Size = new System.Drawing.Size(306, 23);
            this.lblNombreTecnico.TabIndex = 25;
            this.lblNombreTecnico.Text = "Ingrese el nombre del técnico:";
            // 
            // PnCaja
            // 
            this.PnCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(217)))), ((int)(((byte)(230)))));
            this.PnCaja.Controls.Add(this.txtBusqueda);
            this.PnCaja.Controls.Add(this.lblBuscar);
            this.PnCaja.Controls.Add(this.btnActualizar);
            this.PnCaja.Controls.Add(this.btnEliminar);
            this.PnCaja.Location = new System.Drawing.Point(726, 292);
            this.PnCaja.Name = "PnCaja";
            this.PnCaja.Size = new System.Drawing.Size(431, 318);
            this.PnCaja.TabIndex = 20;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(101, 146);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(249, 31);
            this.txtBusqueda.TabIndex = 25;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(117, 104);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(216, 23);
            this.lblBuscar.TabIndex = 24;
            this.lblBuscar.Text = "¿Qué desea buscar? ";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(124)))), ((int)(((byte)(141)))));
            this.btnActualizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(250, 252);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(162, 54);
            this.btnActualizar.TabIndex = 22;
            this.btnActualizar.Text = "Actualizar ";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(30, 252);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(162, 54);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmTecnicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 719);
            this.Controls.Add(this.PnlFondo);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTecnicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTecnicos";
            this.Load += new System.EventHandler(this.frmTecnicos_Load);
            this.PnlFondo.ResumeLayout(false);
            this.PnlFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTecnicos)).EndInit();
            this.PnCaja.ResumeLayout(false);
            this.PnCaja.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlFondo;
        private System.Windows.Forms.Panel PnCaja;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblNombreTecnico;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.TextBox txtNombreTecnico;
        private System.Windows.Forms.TextBox txtNumeroTelefono;
        private System.Windows.Forms.Label lblIngreseTelefono;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblIDTecnico;
        private System.Windows.Forms.DataGridView DgvTecnicos;
    }
}