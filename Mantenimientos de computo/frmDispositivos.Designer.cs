namespace Mantenimientos_de_computo
{
    partial class frmDispositivos
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
            this.groupBoxBuscar = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.groupBoxEliminar = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picTureBoxLocoCarrera = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIdDispositivo = new System.Windows.Forms.Label();
            this.dgvDispositivos = new System.Windows.Forms.DataGridView();
            this.groupBoxRegistrarActualizarUsuario = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.lblNombreTecnico = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.groupBoxBuscar.SuspendLayout();
            this.groupBoxEliminar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTureBoxLocoCarrera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispositivos)).BeginInit();
            this.groupBoxRegistrarActualizarUsuario.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBuscar
            // 
            this.groupBoxBuscar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxBuscar.Controls.Add(this.label6);
            this.groupBoxBuscar.Controls.Add(this.txtBusqueda);
            this.groupBoxBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBuscar.Location = new System.Drawing.Point(1089, 313);
            this.groupBoxBuscar.Name = "groupBoxBuscar";
            this.groupBoxBuscar.Size = new System.Drawing.Size(276, 164);
            this.groupBoxBuscar.TabIndex = 55;
            this.groupBoxBuscar.TabStop = false;
            this.groupBoxBuscar.Text = "Buscar Usuario: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(275, 18);
            this.label6.TabIndex = 50;
            this.label6.Text = "Ingrese la Matricula para buscar: ";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(14, 91);
            this.txtBusqueda.MaxLength = 10;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(249, 26);
            this.txtBusqueda.TabIndex = 50;
            // 
            // groupBoxEliminar
            // 
            this.groupBoxEliminar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxEliminar.Controls.Add(this.textBox1);
            this.groupBoxEliminar.Controls.Add(this.label3);
            this.groupBoxEliminar.Controls.Add(this.label5);
            this.groupBoxEliminar.Controls.Add(this.txtEliminar);
            this.groupBoxEliminar.Controls.Add(this.button1);
            this.groupBoxEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEliminar.Location = new System.Drawing.Point(1089, 127);
            this.groupBoxEliminar.Name = "groupBoxEliminar";
            this.groupBoxEliminar.Size = new System.Drawing.Size(276, 180);
            this.groupBoxEliminar.TabIndex = 52;
            this.groupBoxEliminar.TabStop = false;
            this.groupBoxEliminar.Text = "Eliminar Usuario:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 104);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 26);
            this.textBox1.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 18);
            this.label3.TabIndex = 51;
            this.label3.Text = "Matricula del Usuario: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 18);
            this.label5.TabIndex = 50;
            this.label5.Text = "Matricula del Usuario: ";
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(20, 51);
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
            this.button1.Location = new System.Drawing.Point(73, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 38);
            this.button1.TabIndex = 50;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(62)))));
            this.pnlHeader.Controls.Add(this.picTureBoxLocoCarrera);
            this.pnlHeader.Controls.Add(this.btnVolver);
            this.pnlHeader.Controls.Add(this.label4);
            this.pnlHeader.Controls.Add(this.lblIdDispositivo);
            this.pnlHeader.Location = new System.Drawing.Point(-2, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1373, 121);
            this.pnlHeader.TabIndex = 56;
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
            this.btnVolver.Location = new System.Drawing.Point(1198, 34);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(162, 51);
            this.btnVolver.TabIndex = 51;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(430, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 55);
            this.label4.TabIndex = 45;
            this.label4.Text = "Dispositivos";
            // 
            // lblIdDispositivo
            // 
            this.lblIdDispositivo.AutoSize = true;
            this.lblIdDispositivo.Location = new System.Drawing.Point(941, 55);
            this.lblIdDispositivo.Name = "lblIdDispositivo";
            this.lblIdDispositivo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIdDispositivo.Size = new System.Drawing.Size(77, 13);
            this.lblIdDispositivo.TabIndex = 37;
            this.lblIdDispositivo.Text = "lblIdDispositivo";
            this.lblIdDispositivo.Visible = false;
            // 
            // dgvDispositivos
            // 
            this.dgvDispositivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDispositivos.Location = new System.Drawing.Point(12, 483);
            this.dgvDispositivos.Name = "dgvDispositivos";
            this.dgvDispositivos.RowHeadersWidth = 51;
            this.dgvDispositivos.RowTemplate.Height = 24;
            this.dgvDispositivos.Size = new System.Drawing.Size(1346, 287);
            this.dgvDispositivos.TabIndex = 54;
            // 
            // groupBoxRegistrarActualizarUsuario
            // 
            this.groupBoxRegistrarActualizarUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxRegistrarActualizarUsuario.Controls.Add(this.groupBox3);
            this.groupBoxRegistrarActualizarUsuario.Controls.Add(this.groupBox2);
            this.groupBoxRegistrarActualizarUsuario.Controls.Add(this.btnActualizar);
            this.groupBoxRegistrarActualizarUsuario.Controls.Add(this.groupBox1);
            this.groupBoxRegistrarActualizarUsuario.Controls.Add(this.lblNombreTecnico);
            this.groupBoxRegistrarActualizarUsuario.Controls.Add(this.btnRegistrar);
            this.groupBoxRegistrarActualizarUsuario.Controls.Add(this.txtNombreUsuario);
            this.groupBoxRegistrarActualizarUsuario.Controls.Add(this.lblApellidoPaterno);
            this.groupBoxRegistrarActualizarUsuario.Controls.Add(this.txtApellidoPaterno);
            this.groupBoxRegistrarActualizarUsuario.Controls.Add(this.lblApellidoMaterno);
            this.groupBoxRegistrarActualizarUsuario.Controls.Add(this.txtApellidoMaterno);
            this.groupBoxRegistrarActualizarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxRegistrarActualizarUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRegistrarActualizarUsuario.Location = new System.Drawing.Point(12, 127);
            this.groupBoxRegistrarActualizarUsuario.Name = "groupBoxRegistrarActualizarUsuario";
            this.groupBoxRegistrarActualizarUsuario.Size = new System.Drawing.Size(1071, 350);
            this.groupBoxRegistrarActualizarUsuario.TabIndex = 53;
            this.groupBoxRegistrarActualizarUsuario.TabStop = false;
            this.groupBoxRegistrarActualizarUsuario.Text = "Registrar y Actualizar Usuario: ";
            this.groupBoxRegistrarActualizarUsuario.Enter += new System.EventHandler(this.groupBoxRegistrarActualizarUsuario_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Location = new System.Drawing.Point(826, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 332);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rol del usuario: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 44;
            this.label7.Text = "Elija su rol: ";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 84);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(227, 26);
            this.comboBox2.TabIndex = 43;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(586, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 332);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rol del usuario: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 44;
            this.label2.Text = "Elija su rol: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 26);
            this.comboBox1.TabIndex = 43;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(62)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(168, 292);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(143, 38);
            this.btnActualizar.TabIndex = 50;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbRoles);
            this.groupBox1.Location = new System.Drawing.Point(335, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 332);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rol del usuario: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 44;
            this.label1.Text = "Elija su rol: ";
            // 
            // cmbRoles
            // 
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(6, 84);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(230, 26);
            this.cmbRoles.TabIndex = 43;
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
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(62)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(9, 292);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(153, 38);
            this.btnRegistrar.TabIndex = 26;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(6, 77);
            this.txtNombreUsuario.MaxLength = 20;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(200, 26);
            this.txtNombreUsuario.TabIndex = 26;
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
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(6, 159);
            this.txtApellidoPaterno.MaxLength = 20;
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(200, 26);
            this.txtApellidoPaterno.TabIndex = 28;
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
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new System.Drawing.Point(6, 246);
            this.txtApellidoMaterno.MaxLength = 20;
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(200, 26);
            this.txtApellidoMaterno.TabIndex = 30;
            // 
            // frmDispositivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 787);
            this.Controls.Add(this.groupBoxBuscar);
            this.Controls.Add(this.groupBoxEliminar);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dgvDispositivos);
            this.Controls.Add(this.groupBoxRegistrarActualizarUsuario);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDispositivos";
            this.Text = "frmDispositivos";
            this.Load += new System.EventHandler(this.frmDispositivos_Load);
            this.groupBoxBuscar.ResumeLayout(false);
            this.groupBoxBuscar.PerformLayout();
            this.groupBoxEliminar.ResumeLayout(false);
            this.groupBoxEliminar.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTureBoxLocoCarrera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispositivos)).EndInit();
            this.groupBoxRegistrarActualizarUsuario.ResumeLayout(false);
            this.groupBoxRegistrarActualizarUsuario.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.GroupBox groupBoxEliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picTureBoxLocoCarrera;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIdDispositivo;
        private System.Windows.Forms.DataGridView dgvDispositivos;
        private System.Windows.Forms.GroupBox groupBoxRegistrarActualizarUsuario;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Label lblNombreTecnico;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}