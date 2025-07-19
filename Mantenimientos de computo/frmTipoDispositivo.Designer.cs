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
            this.PnlFondo = new System.Windows.Forms.Panel();
            this.lblIngresaTipoDispositivo = new System.Windows.Forms.Label();
            this.txtTipoDispositivo = new System.Windows.Forms.TextBox();
            this.DgvTipoDispositivo = new System.Windows.Forms.DataGridView();
            this.lblIDTipoDispositivo = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.PnCaja = new System.Windows.Forms.Panel();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.PnlFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTipoDispositivo)).BeginInit();
            this.PnCaja.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlFondo
            // 
            this.PnlFondo.BackColor = System.Drawing.Color.Bisque;
            this.PnlFondo.Controls.Add(this.lblIngresaTipoDispositivo);
            this.PnlFondo.Controls.Add(this.txtTipoDispositivo);
            this.PnlFondo.Controls.Add(this.DgvTipoDispositivo);
            this.PnlFondo.Controls.Add(this.lblIDTipoDispositivo);
            this.PnlFondo.Controls.Add(this.btnVolver);
            this.PnlFondo.Controls.Add(this.btnRegistrar);
            this.PnlFondo.Controls.Add(this.PnCaja);
            this.PnlFondo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlFondo.Location = new System.Drawing.Point(1, 2);
            this.PnlFondo.Name = "PnlFondo";
            this.PnlFondo.Size = new System.Drawing.Size(1178, 718);
            this.PnlFondo.TabIndex = 21;
            // 
            // lblIngresaTipoDispositivo
            // 
            this.lblIngresaTipoDispositivo.AutoSize = true;
            this.lblIngresaTipoDispositivo.Location = new System.Drawing.Point(60, 441);
            this.lblIngresaTipoDispositivo.Name = "lblIngresaTipoDispositivo";
            this.lblIngresaTipoDispositivo.Size = new System.Drawing.Size(300, 23);
            this.lblIngresaTipoDispositivo.TabIndex = 39;
            this.lblIngresaTipoDispositivo.Text = "Ingresa el tipo de dispositivo: ";
            this.lblIngresaTipoDispositivo.Visible = false;
            // 
            // txtTipoDispositivo
            // 
            this.txtTipoDispositivo.Location = new System.Drawing.Point(346, 438);
            this.txtTipoDispositivo.Name = "txtTipoDispositivo";
            this.txtTipoDispositivo.Size = new System.Drawing.Size(249, 31);
            this.txtTipoDispositivo.TabIndex = 26;
            this.txtTipoDispositivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipoDispositivo_KeyPress);
            // 
            // DgvTipoDispositivo
            // 
            this.DgvTipoDispositivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTipoDispositivo.Location = new System.Drawing.Point(13, 13);
            this.DgvTipoDispositivo.Name = "DgvTipoDispositivo";
            this.DgvTipoDispositivo.ReadOnly = true;
            this.DgvTipoDispositivo.RowHeadersWidth = 51;
            this.DgvTipoDispositivo.RowTemplate.Height = 24;
            this.DgvTipoDispositivo.Size = new System.Drawing.Size(1144, 259);
            this.DgvTipoDispositivo.TabIndex = 38;
            // 
            // lblIDTipoDispositivo
            // 
            this.lblIDTipoDispositivo.AutoSize = true;
            this.lblIDTipoDispositivo.Location = new System.Drawing.Point(529, 275);
            this.lblIDTipoDispositivo.Name = "lblIDTipoDispositivo";
            this.lblIDTipoDispositivo.Size = new System.Drawing.Size(183, 23);
            this.lblIDTipoDispositivo.TabIndex = 37;
            this.lblIDTipoDispositivo.Text = "lblTipoDispositivo";
            this.lblIDTipoDispositivo.Visible = false;
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
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(124)))), ((int)(((byte)(141)))));
            this.btnRegistrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(320, 544);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(162, 54);
            this.btnRegistrar.TabIndex = 26;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
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
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(121, 104);
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
            // 
            // frmTipoDispositivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 721);
            this.Controls.Add(this.PnlFondo);
            this.Name = "frmTipoDispositivo";
            this.Text = "frmTipoDispositivo";
            this.Load += new System.EventHandler(this.frmTipoDispositivo_Load);
            this.PnlFondo.ResumeLayout(false);
            this.PnlFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTipoDispositivo)).EndInit();
            this.PnCaja.ResumeLayout(false);
            this.PnCaja.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlFondo;
        private System.Windows.Forms.DataGridView DgvTipoDispositivo;
        private System.Windows.Forms.Label lblIDTipoDispositivo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Panel PnCaja;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblIngresaTipoDispositivo;
        private System.Windows.Forms.TextBox txtTipoDispositivo;
    }
}