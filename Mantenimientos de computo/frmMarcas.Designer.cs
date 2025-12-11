namespace Mantenimientos_de_computo
{
    partial class frmMarcas
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
            this.DgvMarcas = new System.Windows.Forms.DataGridView();
            this.gruopBoxBuscarTipoDispositivo = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.groupBoxRegistrarTipoDispositivo = new System.Windows.Forms.GroupBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picTureBoxLocoCarrera = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIdMarca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMarcas)).BeginInit();
            this.gruopBoxBuscarTipoDispositivo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxRegistrarTipoDispositivo.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTureBoxLocoCarrera)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvMarcas
            // 
            this.DgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMarcas.Location = new System.Drawing.Point(13, 363);
            this.DgvMarcas.Name = "DgvMarcas";
            this.DgvMarcas.RowHeadersWidth = 51;
            this.DgvMarcas.RowTemplate.Height = 24;
            this.DgvMarcas.Size = new System.Drawing.Size(773, 215);
            this.DgvMarcas.TabIndex = 61;
            this.DgvMarcas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMarcas_CellClick);
            // 
            // gruopBoxBuscarTipoDispositivo
            // 
            this.gruopBoxBuscarTipoDispositivo.Controls.Add(this.txtBuscar);
            this.gruopBoxBuscarTipoDispositivo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gruopBoxBuscarTipoDispositivo.Location = new System.Drawing.Point(468, 265);
            this.gruopBoxBuscarTipoDispositivo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gruopBoxBuscarTipoDispositivo.Name = "gruopBoxBuscarTipoDispositivo";
            this.gruopBoxBuscarTipoDispositivo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gruopBoxBuscarTipoDispositivo.Size = new System.Drawing.Size(318, 92);
            this.gruopBoxBuscarTipoDispositivo.TabIndex = 60;
            this.gruopBoxBuscarTipoDispositivo.TabStop = false;
            this.gruopBoxBuscarTipoDispositivo.Text = "Buscar Tipo Dispositivo: ";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(8, 42);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(252, 31);
            this.txtBuscar.TabIndex = 52;
            this.txtBuscar.Click += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.txtEliminar);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(468, 129);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(318, 130);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eliminar Tipo Dispositivo: ";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Brown;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(57, 77);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(136, 38);
            this.btnEliminar.TabIndex = 53;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(8, 30);
            this.txtEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(252, 31);
            this.txtEliminar.TabIndex = 52;
            // 
            // groupBoxRegistrarTipoDispositivo
            // 
            this.groupBoxRegistrarTipoDispositivo.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxRegistrarTipoDispositivo.Controls.Add(this.txtMarca);
            this.groupBoxRegistrarTipoDispositivo.Controls.Add(this.btnActualizar);
            this.groupBoxRegistrarTipoDispositivo.Controls.Add(this.btnRegistrar);
            this.groupBoxRegistrarTipoDispositivo.Controls.Add(this.lblApellidoMaterno);
            this.groupBoxRegistrarTipoDispositivo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxRegistrarTipoDispositivo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRegistrarTipoDispositivo.Location = new System.Drawing.Point(15, 129);
            this.groupBoxRegistrarTipoDispositivo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxRegistrarTipoDispositivo.Name = "groupBoxRegistrarTipoDispositivo";
            this.groupBoxRegistrarTipoDispositivo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxRegistrarTipoDispositivo.Size = new System.Drawing.Size(445, 228);
            this.groupBoxRegistrarTipoDispositivo.TabIndex = 58;
            this.groupBoxRegistrarTipoDispositivo.TabStop = false;
            this.groupBoxRegistrarTipoDispositivo.Text = "Registrar y Actualizar Tipo Dispositivo";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(28, 77);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(252, 31);
            this.txtMarca.TabIndex = 51;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(62)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(251, 155);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(172, 44);
            this.btnActualizar.TabIndex = 50;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(62)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(8, 155);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(184, 44);
            this.btnRegistrar.TabIndex = 26;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Location = new System.Drawing.Point(8, 42);
            this.lblApellidoMaterno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(171, 23);
            this.lblApellidoMaterno.TabIndex = 29;
            this.lblApellidoMaterno.Text = "Tipo Dispositivo:";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(62)))));
            this.pnlHeader.Controls.Add(this.picTureBoxLocoCarrera);
            this.pnlHeader.Controls.Add(this.btnVolver);
            this.pnlHeader.Controls.Add(this.label4);
            this.pnlHeader.Controls.Add(this.lblIdMarca);
            this.pnlHeader.Location = new System.Drawing.Point(2, 1);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(796, 110);
            this.pnlHeader.TabIndex = 57;
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
            this.btnVolver.Location = new System.Drawing.Point(594, 37);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(168, 50);
            this.btnVolver.TabIndex = 51;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(300, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 38);
            this.label4.TabIndex = 45;
            this.label4.Text = "Marcas";
            // 
            // lblIdMarca
            // 
            this.lblIdMarca.AutoSize = true;
            this.lblIdMarca.Location = new System.Drawing.Point(335, 21);
            this.lblIdMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdMarca.Name = "lblIdMarca";
            this.lblIdMarca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIdMarca.Size = new System.Drawing.Size(70, 16);
            this.lblIdMarca.TabIndex = 37;
            this.lblIdMarca.Text = "lblIdMarca";
            this.lblIdMarca.Visible = false;
            // 
            // frmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 598);
            this.Controls.Add(this.DgvMarcas);
            this.Controls.Add(this.gruopBoxBuscarTipoDispositivo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxRegistrarTipoDispositivo);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMarcas";
            this.Load += new System.EventHandler(this.frmMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMarcas)).EndInit();
            this.gruopBoxBuscarTipoDispositivo.ResumeLayout(false);
            this.gruopBoxBuscarTipoDispositivo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxRegistrarTipoDispositivo.ResumeLayout(false);
            this.groupBoxRegistrarTipoDispositivo.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTureBoxLocoCarrera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvMarcas;
        private System.Windows.Forms.GroupBox gruopBoxBuscarTipoDispositivo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.GroupBox groupBoxRegistrarTipoDispositivo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picTureBoxLocoCarrera;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIdMarca;
    }
}