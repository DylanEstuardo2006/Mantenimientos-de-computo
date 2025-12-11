namespace Mantenimientos_de_computo
{
    partial class frmUsuario
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
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtNumeroTelefono = new System.Windows.Forms.TextBox();
            this.lblIngreseTelefono = new System.Windows.Forms.Label();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblNombreTecnico = new System.Windows.Forms.Label();
            this.TlpEliminar = new System.Windows.Forms.ToolTip(this.components);
            this.TlpVolver = new System.Windows.Forms.ToolTip(this.components);
            this.TlpTxtNombreTecnico = new System.Windows.Forms.ToolTip(this.components);
            this.TlpRegistrar = new System.Windows.Forms.ToolTip(this.components);
            this.TlpBuscar = new System.Windows.Forms.ToolTip(this.components);
            this.TlpApellidoPaterno = new System.Windows.Forms.ToolTip(this.components);
            this.TlpApellidoMaterno = new System.Windows.Forms.ToolTip(this.components);
            this.TlpTelefono = new System.Windows.Forms.ToolTip(this.components);
            this.TlpEmail = new System.Windows.Forms.ToolTip(this.components);
            this.TlpContrasenia = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxRegistrarActualizarUsuario = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picTureBoxLocoCarrera = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxEliminar = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxBuscar = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.groupBoxRegistrarActualizarUsuario.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTureBoxLocoCarrera)).BeginInit();
            this.groupBoxEliminar.SuspendLayout();
            this.groupBoxBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(225, 246);
            this.txtContrasenia.MaxLength = 20;
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(249, 26);
            this.txtContrasenia.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 18);
            this.label3.TabIndex = 47;
            this.label3.Text = "Ingrese su contraseña:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(225, 159);
            this.txtMatricula.MaxLength = 10;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(249, 26);
            this.txtMatricula.TabIndex = 46;
            this.txtMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatricula_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 18);
            this.label2.TabIndex = 45;
            this.label2.Text = "Ingrese su matricula:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 44;
            this.label1.Text = "Rol asignado: ";
            // 
            // cmbRoles
            // 
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(21, 84);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(249, 26);
            this.cmbRoles.TabIndex = 43;
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Location = new System.Drawing.Point(859, 59);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIdUsuario.Size = new System.Drawing.Size(89, 18);
            this.lblIdUsuario.TabIndex = 37;
            this.lblIdUsuario.Text = "IblUsuario";
            this.lblIdUsuario.Visible = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(62)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(53, 292);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(153, 38);
            this.btnRegistrar.TabIndex = 26;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            this.btnRegistrar.MouseEnter += new System.EventHandler(this.btnRegistrar_MouseEnter);
            // 
            // txtNumeroTelefono
            // 
            this.txtNumeroTelefono.Location = new System.Drawing.Point(225, 77);
            this.txtNumeroTelefono.MaxLength = 10;
            this.txtNumeroTelefono.Name = "txtNumeroTelefono";
            this.txtNumeroTelefono.Size = new System.Drawing.Size(249, 26);
            this.txtNumeroTelefono.TabIndex = 32;
            this.txtNumeroTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroTelefono_KeyPress);
            // 
            // lblIngreseTelefono
            // 
            this.lblIngreseTelefono.AutoSize = true;
            this.lblIngreseTelefono.Location = new System.Drawing.Point(221, 40);
            this.lblIngreseTelefono.Name = "lblIngreseTelefono";
            this.lblIngreseTelefono.Size = new System.Drawing.Size(169, 18);
            this.lblIngreseTelefono.TabIndex = 31;
            this.lblIngreseTelefono.Text = "Número de telefono:";
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new System.Drawing.Point(6, 246);
            this.txtApellidoMaterno.MaxLength = 20;
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(200, 26);
            this.txtApellidoMaterno.TabIndex = 30;
            this.txtApellidoMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoMaterno_KeyPress);
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Location = new System.Drawing.Point(6, 209);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(148, 18);
            this.lblApellidoMaterno.TabIndex = 29;
            this.lblApellidoMaterno.Text = "Apellido materno:";
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(6, 159);
            this.txtApellidoPaterno.MaxLength = 20;
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(200, 26);
            this.txtApellidoPaterno.TabIndex = 28;
            this.txtApellidoPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoPaterno_KeyPress);
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Location = new System.Drawing.Point(6, 122);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(148, 18);
            this.lblApellidoPaterno.TabIndex = 27;
            this.lblApellidoPaterno.Text = "Apellido paterno: ";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(6, 77);
            this.txtNombreUsuario.MaxLength = 20;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(200, 26);
            this.txtNombreUsuario.TabIndex = 26;
            this.txtNombreUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreTecnico_KeyPress);
            // 
            // lblNombreTecnico
            // 
            this.lblNombreTecnico.AutoSize = true;
            this.lblNombreTecnico.Location = new System.Drawing.Point(2, 40);
            this.lblNombreTecnico.Name = "lblNombreTecnico";
            this.lblNombreTecnico.Size = new System.Drawing.Size(80, 18);
            this.lblNombreTecnico.TabIndex = 25;
            this.lblNombreTecnico.Text = " Nombre:";
            // 
            // groupBoxRegistrarActualizarUsuario
            // 
            this.groupBoxRegistrarActualizarUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxRegistrarActualizarUsuario.Controls.Add(this.btnActualizar);
            this.groupBoxRegistrarActualizarUsuario.Controls.Add(this.groupBox1);
            this.groupBoxRegistrarActualizarUsuario.Controls.Add(this.lblNombreTecnico);
            this.groupBoxRegistrarActualizarUsuario.Controls.Add(this.btnRegistrar);
            this.groupBoxRegistrarActualizarUsuario.Controls.Add(this.txtNombreUsuario);
            this.groupBoxRegistrarActualizarUsuario.Controls.Add(this.lblApellidoPaterno);
            this.groupBoxRegistrarActualizarUsuario.Controls.Add(this.txtContrasenia);
            this.groupBoxRegistrarActualizarUsuario.Controls.Add(this.txtMatricula);
            this.groupBoxRegistrarActualizarUsuario.Controls.Add(this.txtApellidoPaterno);
            this.groupBoxRegistrarActualizarUsuario.Controls.Add(this.lblApellidoMaterno);
            this.groupBoxRegistrarActualizarUsuario.Controls.Add(this.label3);
            this.groupBoxRegistrarActualizarUsuario.Controls.Add(this.txtApellidoMaterno);
            this.groupBoxRegistrarActualizarUsuario.Controls.Add(this.lblIngreseTelefono);
            this.groupBoxRegistrarActualizarUsuario.Controls.Add(this.txtNumeroTelefono);
            this.groupBoxRegistrarActualizarUsuario.Controls.Add(this.label2);
            this.groupBoxRegistrarActualizarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxRegistrarActualizarUsuario.Location = new System.Drawing.Point(25, 126);
            this.groupBoxRegistrarActualizarUsuario.Name = "groupBoxRegistrarActualizarUsuario";
            this.groupBoxRegistrarActualizarUsuario.Size = new System.Drawing.Size(787, 350);
            this.groupBoxRegistrarActualizarUsuario.TabIndex = 49;
            this.groupBoxRegistrarActualizarUsuario.TabStop = false;
            this.groupBoxRegistrarActualizarUsuario.Text = "Registrar y Actualizar Usuario: ";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(62)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(294, 292);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(143, 38);
            this.btnActualizar.TabIndex = 50;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbRoles);
            this.groupBox1.Location = new System.Drawing.Point(480, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 332);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rol del usuario: ";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(25, 494);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(1189, 287);
            this.dgvUsuarios.TabIndex = 50;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(62)))));
            this.pnlHeader.Controls.Add(this.picTureBoxLocoCarrera);
            this.pnlHeader.Controls.Add(this.btnVolver);
            this.pnlHeader.Controls.Add(this.label4);
            this.pnlHeader.Controls.Add(this.lblIdUsuario);
            this.pnlHeader.Location = new System.Drawing.Point(-2, -1);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1228, 121);
            this.pnlHeader.TabIndex = 51;
            // 
            // picTureBoxLocoCarrera
            // 
            this.picTureBoxLocoCarrera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTureBoxLocoCarrera.Image = global::Mantenimientos_de_computo.Properties.Resources.imagenLogoCarrera;
            this.picTureBoxLocoCarrera.Location = new System.Drawing.Point(33, 3);
            this.picTureBoxLocoCarrera.Name = "picTureBoxLocoCarrera";
            this.picTureBoxLocoCarrera.Size = new System.Drawing.Size(124, 115);
            this.picTureBoxLocoCarrera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTureBoxLocoCarrera.TabIndex = 52;
            this.picTureBoxLocoCarrera.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(62)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(1028, 39);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(162, 51);
            this.btnVolver.TabIndex = 51;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(430, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 55);
            this.label4.TabIndex = 45;
            this.label4.Text = "Usuarios ";
            // 
            // groupBoxEliminar
            // 
            this.groupBoxEliminar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxEliminar.Controls.Add(this.label5);
            this.groupBoxEliminar.Controls.Add(this.txtEliminar);
            this.groupBoxEliminar.Controls.Add(this.button1);
            this.groupBoxEliminar.Location = new System.Drawing.Point(818, 126);
            this.groupBoxEliminar.Name = "groupBoxEliminar";
            this.groupBoxEliminar.Size = new System.Drawing.Size(396, 180);
            this.groupBoxEliminar.TabIndex = 45;
            this.groupBoxEliminar.TabStop = false;
            this.groupBoxEliminar.Text = "Eliminar Usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 18);
            this.label5.TabIndex = 50;
            this.label5.Text = "Matricula del Usuario: ";
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(82, 77);
            this.txtEliminar.MaxLength = 10;
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(249, 26);
            this.txtEliminar.TabIndex = 50;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(128, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 38);
            this.button1.TabIndex = 50;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBoxBuscar
            // 
            this.groupBoxBuscar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxBuscar.Controls.Add(this.label6);
            this.groupBoxBuscar.Controls.Add(this.txtBusqueda);
            this.groupBoxBuscar.Location = new System.Drawing.Point(818, 312);
            this.groupBoxBuscar.Name = "groupBoxBuscar";
            this.groupBoxBuscar.Size = new System.Drawing.Size(396, 164);
            this.groupBoxBuscar.TabIndex = 51;
            this.groupBoxBuscar.TabStop = false;
            this.groupBoxBuscar.Text = "Buscar Usuario: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(275, 18);
            this.label6.TabIndex = 50;
            this.label6.Text = "Ingrese la Matricula para buscar: ";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(71, 106);
            this.txtBusqueda.MaxLength = 10;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(249, 26);
            this.txtBusqueda.TabIndex = 50;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged_1);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1226, 791);
            this.Controls.Add(this.groupBoxBuscar);
            this.Controls.Add(this.groupBoxEliminar);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.groupBoxRegistrarActualizarUsuario);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTecnicos";
            this.Load += new System.EventHandler(this.frmTecnicos_Load);
            this.groupBoxRegistrarActualizarUsuario.ResumeLayout(false);
            this.groupBoxRegistrarActualizarUsuario.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTureBoxLocoCarrera)).EndInit();
            this.groupBoxEliminar.ResumeLayout(false);
            this.groupBoxEliminar.PerformLayout();
            this.groupBoxBuscar.ResumeLayout(false);
            this.groupBoxBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNombreTecnico;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtNumeroTelefono;
        private System.Windows.Forms.Label lblIngreseTelefono;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.ToolTip TlpEliminar;
        private System.Windows.Forms.ToolTip TlpVolver;
        private System.Windows.Forms.ToolTip TlpTxtNombreTecnico;
        private System.Windows.Forms.ToolTip TlpRegistrar;
        private System.Windows.Forms.ToolTip TlpBuscar;
        private System.Windows.Forms.ToolTip TlpApellidoPaterno;
        private System.Windows.Forms.ToolTip TlpApellidoMaterno;
        private System.Windows.Forms.ToolTip TlpTelefono;
        private System.Windows.Forms.ToolTip TlpEmail;
        private System.Windows.Forms.ToolTip TlpContrasenia;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.GroupBox groupBoxRegistrarActualizarUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxEliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.GroupBox groupBoxBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.PictureBox picTureBoxLocoCarrera;
    }
}