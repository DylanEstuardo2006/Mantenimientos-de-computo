namespace Mantenimientos_de_computo
{
    partial class frmTipoDispositivo
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picTureBoxLocoCarrera = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIdTipoDispositivo = new System.Windows.Forms.Label();
            this.groupBoxRegistrarTipoDispositivo = new System.Windows.Forms.GroupBox();
            this.txtTipoDispositivo = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.gruopBoxBuscarTipoDispositivo = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvTipoDispositivo = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTureBoxLocoCarrera)).BeginInit();
            this.groupBoxRegistrarTipoDispositivo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gruopBoxBuscarTipoDispositivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoDispositivo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(62)))));
            this.pnlHeader.Controls.Add(this.picTureBoxLocoCarrera);
            this.pnlHeader.Controls.Add(this.btnVolver);
            this.pnlHeader.Controls.Add(this.label4);
            this.pnlHeader.Controls.Add(this.lblIdTipoDispositivo);
            this.pnlHeader.Location = new System.Drawing.Point(1, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(784, 110);
            this.pnlHeader.TabIndex = 52;
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
            this.label4.Location = new System.Drawing.Point(248, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 38);
            this.label4.TabIndex = 45;
            this.label4.Text = "Tipo Dispositivo";
            // 
            // lblIdTipoDispositivo
            // 
            this.lblIdTipoDispositivo.AutoSize = true;
            this.lblIdTipoDispositivo.Location = new System.Drawing.Point(300, 9);
            this.lblIdTipoDispositivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdTipoDispositivo.Name = "lblIdTipoDispositivo";
            this.lblIdTipoDispositivo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIdTipoDispositivo.Size = new System.Drawing.Size(202, 23);
            this.lblIdTipoDispositivo.TabIndex = 37;
            this.lblIdTipoDispositivo.Text = "lblIdTipoDispositivo";
            this.lblIdTipoDispositivo.Visible = false;
            // 
            // groupBoxRegistrarTipoDispositivo
            // 
            this.groupBoxRegistrarTipoDispositivo.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxRegistrarTipoDispositivo.Controls.Add(this.txtTipoDispositivo);
            this.groupBoxRegistrarTipoDispositivo.Controls.Add(this.btnActualizar);
            this.groupBoxRegistrarTipoDispositivo.Controls.Add(this.btnRegistrar);
            this.groupBoxRegistrarTipoDispositivo.Controls.Add(this.lblApellidoMaterno);
            this.groupBoxRegistrarTipoDispositivo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxRegistrarTipoDispositivo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRegistrarTipoDispositivo.Location = new System.Drawing.Point(14, 128);
            this.groupBoxRegistrarTipoDispositivo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxRegistrarTipoDispositivo.Name = "groupBoxRegistrarTipoDispositivo";
            this.groupBoxRegistrarTipoDispositivo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxRegistrarTipoDispositivo.Size = new System.Drawing.Size(445, 228);
            this.groupBoxRegistrarTipoDispositivo.TabIndex = 53;
            this.groupBoxRegistrarTipoDispositivo.TabStop = false;
            this.groupBoxRegistrarTipoDispositivo.Text = "Registrar y Actualizar Tipo Dispositivo";
            // 
            // txtTipoDispositivo
            // 
            this.txtTipoDispositivo.Location = new System.Drawing.Point(12, 77);
            this.txtTipoDispositivo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTipoDispositivo.Name = "txtTipoDispositivo";
            this.txtTipoDispositivo.Size = new System.Drawing.Size(252, 31);
            this.txtTipoDispositivo.TabIndex = 51;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.txtEliminar);
            this.groupBox1.Location = new System.Drawing.Point(467, 128);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(318, 130);
            this.groupBox1.TabIndex = 54;
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
            this.btnEliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(8, 30);
            this.txtEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(252, 31);
            this.txtEliminar.TabIndex = 52;
            // 
            // gruopBoxBuscarTipoDispositivo
            // 
            this.gruopBoxBuscarTipoDispositivo.Controls.Add(this.txtBuscar);
            this.gruopBoxBuscarTipoDispositivo.Location = new System.Drawing.Point(467, 264);
            this.gruopBoxBuscarTipoDispositivo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gruopBoxBuscarTipoDispositivo.Name = "gruopBoxBuscarTipoDispositivo";
            this.gruopBoxBuscarTipoDispositivo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gruopBoxBuscarTipoDispositivo.Size = new System.Drawing.Size(318, 92);
            this.gruopBoxBuscarTipoDispositivo.TabIndex = 55;
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
            this.txtBuscar.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dgvTipoDispositivo
            // 
            this.dgvTipoDispositivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoDispositivo.Location = new System.Drawing.Point(12, 362);
            this.dgvTipoDispositivo.Name = "dgvTipoDispositivo";
            this.dgvTipoDispositivo.RowHeadersWidth = 51;
            this.dgvTipoDispositivo.RowTemplate.Height = 24;
            this.dgvTipoDispositivo.Size = new System.Drawing.Size(773, 215);
            this.dgvTipoDispositivo.TabIndex = 56;
            this.dgvTipoDispositivo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // frmTipoDispositivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 589);
            this.Controls.Add(this.dgvTipoDispositivo);
            this.Controls.Add(this.gruopBoxBuscarTipoDispositivo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxRegistrarTipoDispositivo);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTipoDispositivo";
            this.Text = "frmTipoDispositivo";
            this.Load += new System.EventHandler(this.frmTipoDispositivo_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTureBoxLocoCarrera)).EndInit();
            this.groupBoxRegistrarTipoDispositivo.ResumeLayout(false);
            this.groupBoxRegistrarTipoDispositivo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gruopBoxBuscarTipoDispositivo.ResumeLayout(false);
            this.gruopBoxBuscarTipoDispositivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoDispositivo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIdTipoDispositivo;
        private System.Windows.Forms.GroupBox groupBoxRegistrarTipoDispositivo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.TextBox txtTipoDispositivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.GroupBox gruopBoxBuscarTipoDispositivo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox picTureBoxLocoCarrera;
        private System.Windows.Forms.DataGridView dgvTipoDispositivo;
    }
}