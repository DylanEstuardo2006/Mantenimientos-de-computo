namespace Mantenimientos_de_computo
{
    partial class frmModelos
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
            this.dgvModelos = new System.Windows.Forms.DataGridView();
            this.gruopBoxBuscarTipoDispositivo = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.groupBoxRegistrarTipoDispositivo = new System.Windows.Forms.GroupBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picTureBoxLocoCarrera = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIdModelo = new System.Windows.Forms.Label();
            this.groupBoxMarcas = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMarcas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelos)).BeginInit();
            this.gruopBoxBuscarTipoDispositivo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxRegistrarTipoDispositivo.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTureBoxLocoCarrera)).BeginInit();
            this.groupBoxMarcas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvModelos
            // 
            this.dgvModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModelos.Location = new System.Drawing.Point(2, 470);
            this.dgvModelos.Name = "dgvModelos";
            this.dgvModelos.RowHeadersWidth = 51;
            this.dgvModelos.RowTemplate.Height = 24;
            this.dgvModelos.Size = new System.Drawing.Size(1010, 239);
            this.dgvModelos.TabIndex = 66;
            // 
            // gruopBoxBuscarTipoDispositivo
            // 
            this.gruopBoxBuscarTipoDispositivo.Controls.Add(this.label2);
            this.gruopBoxBuscarTipoDispositivo.Controls.Add(this.txtBuscar);
            this.gruopBoxBuscarTipoDispositivo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gruopBoxBuscarTipoDispositivo.Location = new System.Drawing.Point(681, 324);
            this.gruopBoxBuscarTipoDispositivo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gruopBoxBuscarTipoDispositivo.Name = "gruopBoxBuscarTipoDispositivo";
            this.gruopBoxBuscarTipoDispositivo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gruopBoxBuscarTipoDispositivo.Size = new System.Drawing.Size(331, 134);
            this.gruopBoxBuscarTipoDispositivo.TabIndex = 65;
            this.gruopBoxBuscarTipoDispositivo.TabStop = false;
            this.gruopBoxBuscarTipoDispositivo.Text = "Buscar Modelo:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(16, 84);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(252, 31);
            this.txtBuscar.TabIndex = 52;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.txtEliminar);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(686, 143);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(315, 150);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eliminar Modelo:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Brown;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(93, 88);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(136, 38);
            this.btnEliminar.TabIndex = 53;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(37, 47);
            this.txtEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(252, 31);
            this.txtEliminar.TabIndex = 52;
            // 
            // groupBoxRegistrarTipoDispositivo
            // 
            this.groupBoxRegistrarTipoDispositivo.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxRegistrarTipoDispositivo.Controls.Add(this.groupBoxMarcas);
            this.groupBoxRegistrarTipoDispositivo.Controls.Add(this.txtModelo);
            this.groupBoxRegistrarTipoDispositivo.Controls.Add(this.btnActualizar);
            this.groupBoxRegistrarTipoDispositivo.Controls.Add(this.btnRegistrar);
            this.groupBoxRegistrarTipoDispositivo.Controls.Add(this.lblApellidoMaterno);
            this.groupBoxRegistrarTipoDispositivo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxRegistrarTipoDispositivo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRegistrarTipoDispositivo.Location = new System.Drawing.Point(13, 131);
            this.groupBoxRegistrarTipoDispositivo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxRegistrarTipoDispositivo.Name = "groupBoxRegistrarTipoDispositivo";
            this.groupBoxRegistrarTipoDispositivo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxRegistrarTipoDispositivo.Size = new System.Drawing.Size(660, 333);
            this.groupBoxRegistrarTipoDispositivo.TabIndex = 63;
            this.groupBoxRegistrarTipoDispositivo.TabStop = false;
            this.groupBoxRegistrarTipoDispositivo.Text = "Registrar y Actualizar Modelos";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(12, 96);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(252, 31);
            this.txtModelo.TabIndex = 51;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(62)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(195, 169);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(150, 44);
            this.btnActualizar.TabIndex = 50;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(62)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(8, 169);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(167, 44);
            this.btnRegistrar.TabIndex = 26;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Location = new System.Drawing.Point(8, 58);
            this.lblApellidoMaterno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(92, 23);
            this.lblApellidoMaterno.TabIndex = 29;
            this.lblApellidoMaterno.Text = "Modelos";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(62)))));
            this.pnlHeader.Controls.Add(this.picTureBoxLocoCarrera);
            this.pnlHeader.Controls.Add(this.btnVolver);
            this.pnlHeader.Controls.Add(this.label4);
            this.pnlHeader.Controls.Add(this.lblIdModelo);
            this.pnlHeader.Location = new System.Drawing.Point(2, 3);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1022, 120);
            this.pnlHeader.TabIndex = 62;
            // 
            // picTureBoxLocoCarrera
            // 
            this.picTureBoxLocoCarrera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTureBoxLocoCarrera.Image = global::Mantenimientos_de_computo.Properties.Resources.imagenLogoCarrera;
            this.picTureBoxLocoCarrera.Location = new System.Drawing.Point(41, 2);
            this.picTureBoxLocoCarrera.Name = "picTureBoxLocoCarrera";
            this.picTureBoxLocoCarrera.Size = new System.Drawing.Size(107, 105);
            this.picTureBoxLocoCarrera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTureBoxLocoCarrera.TabIndex = 53;
            this.picTureBoxLocoCarrera.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(62)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(831, 32);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(168, 50);
            this.btnVolver.TabIndex = 51;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(432, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 38);
            this.label4.TabIndex = 45;
            this.label4.Text = "Modelos";
            // 
            // lblIdModelo
            // 
            this.lblIdModelo.AutoSize = true;
            this.lblIdModelo.Location = new System.Drawing.Point(468, 18);
            this.lblIdModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdModelo.Name = "lblIdModelo";
            this.lblIdModelo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIdModelo.Size = new System.Drawing.Size(78, 16);
            this.lblIdModelo.TabIndex = 37;
            this.lblIdModelo.Text = "lblIdModelo";
            this.lblIdModelo.Visible = false;
            // 
            // groupBoxMarcas
            // 
            this.groupBoxMarcas.Controls.Add(this.label1);
            this.groupBoxMarcas.Controls.Add(this.cmbMarcas);
            this.groupBoxMarcas.Location = new System.Drawing.Point(352, 12);
            this.groupBoxMarcas.Name = "groupBoxMarcas";
            this.groupBoxMarcas.Size = new System.Drawing.Size(295, 315);
            this.groupBoxMarcas.TabIndex = 52;
            this.groupBoxMarcas.TabStop = false;
            this.groupBoxMarcas.Text = "Marcas Disponibles: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 23);
            this.label1.TabIndex = 44;
            this.label1.Text = "Elija una marca: ";
            // 
            // cmbMarcas
            // 
            this.cmbMarcas.FormattingEnabled = true;
            this.cmbMarcas.Location = new System.Drawing.Point(13, 84);
            this.cmbMarcas.Name = "cmbMarcas";
            this.cmbMarcas.Size = new System.Drawing.Size(249, 31);
            this.cmbMarcas.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 23);
            this.label2.TabIndex = 53;
            this.label2.Text = "Escriba el Modelo para buscar: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmModelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 721);
            this.Controls.Add(this.dgvModelos);
            this.Controls.Add(this.gruopBoxBuscarTipoDispositivo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxRegistrarTipoDispositivo);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmModelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModelos";
            this.Load += new System.EventHandler(this.frmModelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelos)).EndInit();
            this.gruopBoxBuscarTipoDispositivo.ResumeLayout(false);
            this.gruopBoxBuscarTipoDispositivo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxRegistrarTipoDispositivo.ResumeLayout(false);
            this.groupBoxRegistrarTipoDispositivo.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTureBoxLocoCarrera)).EndInit();
            this.groupBoxMarcas.ResumeLayout(false);
            this.groupBoxMarcas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvModelos;
        private System.Windows.Forms.GroupBox gruopBoxBuscarTipoDispositivo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.GroupBox groupBoxRegistrarTipoDispositivo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picTureBoxLocoCarrera;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIdModelo;
        private System.Windows.Forms.GroupBox groupBoxMarcas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMarcas;
        private System.Windows.Forms.Label label2;
    }
}