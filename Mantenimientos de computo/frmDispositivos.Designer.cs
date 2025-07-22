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
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.lblcmbTipoDispositivo = new System.Windows.Forms.Label();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.cmbTipoDispositivo = new System.Windows.Forms.ComboBox();
            this.DgvDispositivos = new System.Windows.Forms.DataGridView();
            this.lblIdDispositivo = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.pnlCaja = new System.Windows.Forms.Panel();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCmbModelo = new System.Windows.Forms.Label();
            this.pnlFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDispositivos)).BeginInit();
            this.pnlCaja.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFondo
            // 
            this.pnlFondo.BackColor = System.Drawing.Color.Bisque;
            this.pnlFondo.Controls.Add(this.lblcmbTipoDispositivo);
            this.pnlFondo.Controls.Add(this.cmbModelo);
            this.pnlFondo.Controls.Add(this.cmbTipoDispositivo);
            this.pnlFondo.Controls.Add(this.DgvDispositivos);
            this.pnlFondo.Controls.Add(this.lblIdDispositivo);
            this.pnlFondo.Controls.Add(this.btnVolver);
            this.pnlFondo.Controls.Add(this.btnRegistrar);
            this.pnlFondo.Controls.Add(this.pnlCaja);
            this.pnlFondo.Controls.Add(this.lblCmbModelo);
            this.pnlFondo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFondo.Location = new System.Drawing.Point(1, 1);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(1178, 718);
            this.pnlFondo.TabIndex = 23;
            // 
            // lblcmbTipoDispositivo
            // 
            this.lblcmbTipoDispositivo.AutoSize = true;
            this.lblcmbTipoDispositivo.Location = new System.Drawing.Point(99, 346);
            this.lblcmbTipoDispositivo.Name = "lblcmbTipoDispositivo";
            this.lblcmbTipoDispositivo.Size = new System.Drawing.Size(263, 23);
            this.lblcmbTipoDispositivo.TabIndex = 48;
            this.lblcmbTipoDispositivo.Text = "Escoja el Tipo Dispositivo:";
            // 
            // cmbModelo
            // 
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Location = new System.Drawing.Point(392, 447);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(249, 31);
            this.cmbModelo.TabIndex = 47;
            // 
            // cmbTipoDispositivo
            // 
            this.cmbTipoDispositivo.FormattingEnabled = true;
            this.cmbTipoDispositivo.Location = new System.Drawing.Point(392, 338);
            this.cmbTipoDispositivo.Name = "cmbTipoDispositivo";
            this.cmbTipoDispositivo.Size = new System.Drawing.Size(249, 31);
            this.cmbTipoDispositivo.TabIndex = 40;
            // 
            // DgvDispositivos
            // 
            this.DgvDispositivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDispositivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDispositivos.Location = new System.Drawing.Point(12, 13);
            this.DgvDispositivos.Name = "DgvDispositivos";
            this.DgvDispositivos.ReadOnly = true;
            this.DgvDispositivos.RowHeadersWidth = 51;
            this.DgvDispositivos.RowTemplate.Height = 24;
            this.DgvDispositivos.Size = new System.Drawing.Size(1144, 259);
            this.DgvDispositivos.TabIndex = 38;
            // 
            // lblIdDispositivo
            // 
            this.lblIdDispositivo.AutoSize = true;
            this.lblIdDispositivo.Location = new System.Drawing.Point(524, 292);
            this.lblIdDispositivo.Name = "lblIdDispositivo";
            this.lblIdDispositivo.Size = new System.Drawing.Size(159, 23);
            this.lblIdDispositivo.TabIndex = 37;
            this.lblIdDispositivo.Text = "lblIdDispositivo";
            this.lblIdDispositivo.Visible = false;
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
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(124)))), ((int)(((byte)(141)))));
            this.btnRegistrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(392, 600);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(162, 54);
            this.btnRegistrar.TabIndex = 26;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // pnlCaja
            // 
            this.pnlCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(217)))), ((int)(((byte)(230)))));
            this.pnlCaja.Controls.Add(this.txtBusqueda);
            this.pnlCaja.Controls.Add(this.label3);
            this.pnlCaja.Controls.Add(this.btnActualizar);
            this.pnlCaja.Controls.Add(this.btnEliminar);
            this.pnlCaja.Location = new System.Drawing.Point(726, 292);
            this.pnlCaja.Name = "pnlCaja";
            this.pnlCaja.Size = new System.Drawing.Size(431, 318);
            this.pnlCaja.TabIndex = 20;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(114, 155);
            this.txtBusqueda.MaxLength = 10;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(249, 31);
            this.txtBusqueda.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "¿Qué desea buscar? ";
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
            // 
            // lblCmbModelo
            // 
            this.lblCmbModelo.AutoSize = true;
            this.lblCmbModelo.Location = new System.Drawing.Point(183, 455);
            this.lblCmbModelo.Name = "lblCmbModelo";
            this.lblCmbModelo.Size = new System.Drawing.Size(179, 23);
            this.lblCmbModelo.TabIndex = 43;
            this.lblCmbModelo.Text = "Escoja el Modelo:";
            // 
            // frmDispositivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 719);
            this.Controls.Add(this.pnlFondo);
            this.Name = "frmDispositivos";
            this.Text = "frmDispositivos";
            this.Load += new System.EventHandler(this.frmDispositivos_Load);
            this.pnlFondo.ResumeLayout(false);
            this.pnlFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDispositivos)).EndInit();
            this.pnlCaja.ResumeLayout(false);
            this.pnlCaja.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFondo;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.ComboBox cmbTipoDispositivo;
        private System.Windows.Forms.DataGridView DgvDispositivos;
        private System.Windows.Forms.Label lblIdDispositivo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Panel pnlCaja;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCmbModelo;
        private System.Windows.Forms.Label lblcmbTipoDispositivo;
    }
}