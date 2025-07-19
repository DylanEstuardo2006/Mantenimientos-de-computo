namespace Mantenimientos_de_computo
{
    partial class frmDiagnosticos
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
            this.lblTecnico = new System.Windows.Forms.Label();
            this.RtbResumenDiagnostico = new System.Windows.Forms.RichTextBox();
            this.cmbTipoMantenimiento = new System.Windows.Forms.ComboBox();
            this.cmbTecnico = new System.Windows.Forms.ComboBox();
            this.DtmFechaDiagnostico = new System.Windows.Forms.DateTimePicker();
            this.DgvDiagnosticos = new System.Windows.Forms.DataGridView();
            this.lblIDDiagnostico = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblResumenDiagnostico = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblTipoMantenimiento = new System.Windows.Forms.Label();
            this.txtIdEjemplar = new System.Windows.Forms.TextBox();
            this.lblIdEjemplar = new System.Windows.Forms.Label();
            this.lblFechaDiagnostico = new System.Windows.Forms.Label();
            this.PnCaja = new System.Windows.Forms.Panel();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.PnlFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDiagnosticos)).BeginInit();
            this.PnCaja.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlFondo
            // 
            this.PnlFondo.BackColor = System.Drawing.Color.Bisque;
            this.PnlFondo.Controls.Add(this.lblTecnico);
            this.PnlFondo.Controls.Add(this.RtbResumenDiagnostico);
            this.PnlFondo.Controls.Add(this.cmbTipoMantenimiento);
            this.PnlFondo.Controls.Add(this.cmbTecnico);
            this.PnlFondo.Controls.Add(this.DtmFechaDiagnostico);
            this.PnlFondo.Controls.Add(this.DgvDiagnosticos);
            this.PnlFondo.Controls.Add(this.lblIDDiagnostico);
            this.PnlFondo.Controls.Add(this.btnVolver);
            this.PnlFondo.Controls.Add(this.lblResumenDiagnostico);
            this.PnlFondo.Controls.Add(this.btnRegistrar);
            this.PnlFondo.Controls.Add(this.lblTipoMantenimiento);
            this.PnlFondo.Controls.Add(this.txtIdEjemplar);
            this.PnlFondo.Controls.Add(this.lblIdEjemplar);
            this.PnlFondo.Controls.Add(this.lblFechaDiagnostico);
            this.PnlFondo.Controls.Add(this.PnCaja);
            this.PnlFondo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlFondo.Location = new System.Drawing.Point(0, 0);
            this.PnlFondo.Name = "PnlFondo";
            this.PnlFondo.Size = new System.Drawing.Size(1178, 718);
            this.PnlFondo.TabIndex = 20;
            // 
            // lblTecnico
            // 
            this.lblTecnico.AutoSize = true;
            this.lblTecnico.Location = new System.Drawing.Point(311, 383);
            this.lblTecnico.Name = "lblTecnico";
            this.lblTecnico.Size = new System.Drawing.Size(94, 23);
            this.lblTecnico.TabIndex = 43;
            this.lblTecnico.Text = "Técnico:";
            // 
            // RtbResumenDiagnostico
            // 
            this.RtbResumenDiagnostico.Location = new System.Drawing.Point(46, 511);
            this.RtbResumenDiagnostico.MaxLength = 300;
            this.RtbResumenDiagnostico.Name = "RtbResumenDiagnostico";
            this.RtbResumenDiagnostico.Size = new System.Drawing.Size(595, 110);
            this.RtbResumenDiagnostico.TabIndex = 42;
            this.RtbResumenDiagnostico.Text = "";
            // 
            // cmbTipoMantenimiento
            // 
            this.cmbTipoMantenimiento.FormattingEnabled = true;
            this.cmbTipoMantenimiento.Location = new System.Drawing.Point(395, 438);
            this.cmbTipoMantenimiento.Name = "cmbTipoMantenimiento";
            this.cmbTipoMantenimiento.Size = new System.Drawing.Size(249, 31);
            this.cmbTipoMantenimiento.TabIndex = 41;
            // 
            // cmbTecnico
            // 
            this.cmbTecnico.FormattingEnabled = true;
            this.cmbTecnico.Location = new System.Drawing.Point(395, 380);
            this.cmbTecnico.Name = "cmbTecnico";
            this.cmbTecnico.Size = new System.Drawing.Size(249, 31);
            this.cmbTecnico.TabIndex = 40;
            // 
            // DtmFechaDiagnostico
            // 
            this.DtmFechaDiagnostico.Location = new System.Drawing.Point(395, 301);
            this.DtmFechaDiagnostico.Name = "DtmFechaDiagnostico";
            this.DtmFechaDiagnostico.Size = new System.Drawing.Size(246, 31);
            this.DtmFechaDiagnostico.TabIndex = 39;
            // 
            // DgvDiagnosticos
            // 
            this.DgvDiagnosticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDiagnosticos.Location = new System.Drawing.Point(13, 13);
            this.DgvDiagnosticos.Name = "DgvDiagnosticos";
            this.DgvDiagnosticos.ReadOnly = true;
            this.DgvDiagnosticos.RowHeadersWidth = 51;
            this.DgvDiagnosticos.RowTemplate.Height = 24;
            this.DgvDiagnosticos.Size = new System.Drawing.Size(1144, 259);
            this.DgvDiagnosticos.TabIndex = 38;
            this.DgvDiagnosticos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDiagnosticos_CellContentClick);
            // 
            // lblIDDiagnostico
            // 
            this.lblIDDiagnostico.AutoSize = true;
            this.lblIDDiagnostico.Location = new System.Drawing.Point(529, 275);
            this.lblIDDiagnostico.Name = "lblIDDiagnostico";
            this.lblIDDiagnostico.Size = new System.Drawing.Size(150, 23);
            this.lblIDDiagnostico.TabIndex = 37;
            this.lblIDDiagnostico.Text = "IblDiagnostico";
            this.lblIDDiagnostico.Visible = false;
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
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click_1);
            // 
            // lblResumenDiagnostico
            // 
            this.lblResumenDiagnostico.AutoSize = true;
            this.lblResumenDiagnostico.Location = new System.Drawing.Point(42, 485);
            this.lblResumenDiagnostico.Name = "lblResumenDiagnostico";
            this.lblResumenDiagnostico.Size = new System.Drawing.Size(396, 23);
            this.lblResumenDiagnostico.TabIndex = 35;
            this.lblResumenDiagnostico.Text = "Comentarios(Resumen del Diagnóstico)";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(124)))), ((int)(((byte)(141)))));
            this.btnRegistrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(395, 641);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(162, 54);
            this.btnRegistrar.TabIndex = 26;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblTipoMantenimiento
            // 
            this.lblTipoMantenimiento.AutoSize = true;
            this.lblTipoMantenimiento.Location = new System.Drawing.Point(187, 441);
            this.lblTipoMantenimiento.Name = "lblTipoMantenimiento";
            this.lblTipoMantenimiento.Size = new System.Drawing.Size(242, 23);
            this.lblTipoMantenimiento.TabIndex = 31;
            this.lblTipoMantenimiento.Text = "Tipo de Mantenimiento: ";
            // 
            // txtIdEjemplar
            // 
            this.txtIdEjemplar.Location = new System.Drawing.Point(395, 338);
            this.txtIdEjemplar.MaxLength = 10;
            this.txtIdEjemplar.Name = "txtIdEjemplar";
            this.txtIdEjemplar.Size = new System.Drawing.Size(249, 31);
            this.txtIdEjemplar.TabIndex = 28;
            this.txtIdEjemplar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdEjemplar_KeyPress);
            // 
            // lblIdEjemplar
            // 
            this.lblIdEjemplar.AutoSize = true;
            this.lblIdEjemplar.Location = new System.Drawing.Point(265, 346);
            this.lblIdEjemplar.Name = "lblIdEjemplar";
            this.lblIdEjemplar.Size = new System.Drawing.Size(164, 23);
            this.lblIdEjemplar.TabIndex = 27;
            this.lblIdEjemplar.Text = "ID del Ejemplar:";
            // 
            // lblFechaDiagnostico
            // 
            this.lblFechaDiagnostico.AutoSize = true;
            this.lblFechaDiagnostico.Location = new System.Drawing.Point(119, 307);
            this.lblFechaDiagnostico.Name = "lblFechaDiagnostico";
            this.lblFechaDiagnostico.Size = new System.Drawing.Size(334, 23);
            this.lblFechaDiagnostico.TabIndex = 25;
            this.lblFechaDiagnostico.Text = "Ingrese la Fecha del Diagnóstico:";
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
            this.lblBuscar.Location = new System.Drawing.Point(134, 104);
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
            // frmDiagnosticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 719);
            this.Controls.Add(this.PnlFondo);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDiagnosticos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagnosticos";
            this.Load += new System.EventHandler(this.frmDiagnosticos_Load);
            this.PnlFondo.ResumeLayout(false);
            this.PnlFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDiagnosticos)).EndInit();
            this.PnCaja.ResumeLayout(false);
            this.PnCaja.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlFondo;
        private System.Windows.Forms.DataGridView DgvDiagnosticos;
        private System.Windows.Forms.Label lblIDDiagnostico;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblResumenDiagnostico;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblTipoMantenimiento;
        private System.Windows.Forms.TextBox txtIdEjemplar;
        private System.Windows.Forms.Label lblIdEjemplar;
        private System.Windows.Forms.Label lblFechaDiagnostico;
        private System.Windows.Forms.Panel PnCaja;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DateTimePicker DtmFechaDiagnostico;
        private System.Windows.Forms.ComboBox cmbTecnico;
        private System.Windows.Forms.RichTextBox RtbResumenDiagnostico;
        private System.Windows.Forms.ComboBox cmbTipoMantenimiento;
        private System.Windows.Forms.Label lblTecnico;
    }
}