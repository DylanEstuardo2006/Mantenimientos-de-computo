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
            this.PnlFondo = new System.Windows.Forms.Panel();
            this.cmbMarcas = new System.Windows.Forms.ComboBox();
            this.LblIngresMarca = new System.Windows.Forms.Label();
            this.lblIngresaNuevoModelo = new System.Windows.Forms.Label();
            this.txtModelos = new System.Windows.Forms.TextBox();
            this.DgvModelos = new System.Windows.Forms.DataGridView();
            this.lblIDModelos = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.PnCaja = new System.Windows.Forms.Panel();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.PnlFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvModelos)).BeginInit();
            this.PnCaja.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlFondo
            // 
            this.PnlFondo.BackColor = System.Drawing.Color.Bisque;
            this.PnlFondo.Controls.Add(this.cmbMarcas);
            this.PnlFondo.Controls.Add(this.LblIngresMarca);
            this.PnlFondo.Controls.Add(this.lblIngresaNuevoModelo);
            this.PnlFondo.Controls.Add(this.txtModelos);
            this.PnlFondo.Controls.Add(this.DgvModelos);
            this.PnlFondo.Controls.Add(this.lblIDModelos);
            this.PnlFondo.Controls.Add(this.btnVolver);
            this.PnlFondo.Controls.Add(this.btnRegistrar);
            this.PnlFondo.Controls.Add(this.PnCaja);
            this.PnlFondo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlFondo.Location = new System.Drawing.Point(0, 2);
            this.PnlFondo.Name = "PnlFondo";
            this.PnlFondo.Size = new System.Drawing.Size(1178, 718);
            this.PnlFondo.TabIndex = 23;
            // 
            // cmbMarcas
            // 
            this.cmbMarcas.FormattingEnabled = true;
            this.cmbMarcas.Location = new System.Drawing.Point(392, 414);
            this.cmbMarcas.Name = "cmbMarcas";
            this.cmbMarcas.Size = new System.Drawing.Size(249, 31);
            this.cmbMarcas.TabIndex = 42;
            this.cmbMarcas.SelectedIndexChanged += new System.EventHandler(this.cmbMarcas_SelectedIndexChanged);
            // 
            // LblIngresMarca
            // 
            this.LblIngresMarca.AutoSize = true;
            this.LblIngresMarca.Location = new System.Drawing.Point(199, 422);
            this.LblIngresMarca.Name = "LblIngresMarca";
            this.LblIngresMarca.Size = new System.Drawing.Size(159, 23);
            this.LblIngresMarca.TabIndex = 40;
            this.LblIngresMarca.Text = "Elige la marca: ";
            this.LblIngresMarca.Click += new System.EventHandler(this.LblIngresMarca_Click);
            // 
            // lblIngresaNuevoModelo
            // 
            this.lblIngresaNuevoModelo.AutoSize = true;
            this.lblIngresaNuevoModelo.Location = new System.Drawing.Point(111, 354);
            this.lblIngresaNuevoModelo.Name = "lblIngresaNuevoModelo";
            this.lblIngresaNuevoModelo.Size = new System.Drawing.Size(257, 23);
            this.lblIngresaNuevoModelo.TabIndex = 39;
            this.lblIngresaNuevoModelo.Text = "Ingresa el Nuevo modelo:";
            // 
            // txtModelos
            // 
            this.txtModelos.Location = new System.Drawing.Point(392, 346);
            this.txtModelos.Name = "txtModelos";
            this.txtModelos.Size = new System.Drawing.Size(249, 31);
            this.txtModelos.TabIndex = 26;
            // 
            // DgvModelos
            // 
            this.DgvModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvModelos.Location = new System.Drawing.Point(13, 13);
            this.DgvModelos.Name = "DgvModelos";
            this.DgvModelos.ReadOnly = true;
            this.DgvModelos.RowHeadersWidth = 51;
            this.DgvModelos.RowTemplate.Height = 24;
            this.DgvModelos.Size = new System.Drawing.Size(1144, 259);
            this.DgvModelos.TabIndex = 38;
            this.DgvModelos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMarcas_CellClick);
            // 
            // lblIDModelos
            // 
            this.lblIDModelos.AutoSize = true;
            this.lblIDModelos.Location = new System.Drawing.Point(529, 275);
            this.lblIDModelos.Name = "lblIDModelos";
            this.lblIDModelos.Size = new System.Drawing.Size(141, 23);
            this.lblIDModelos.TabIndex = 37;
            this.lblIDModelos.Text = "LblIdModelos";
            this.lblIDModelos.Visible = false;
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
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
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
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmModelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 719);
            this.Controls.Add(this.PnlFondo);
            this.Name = "frmModelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModelos";
            this.Load += new System.EventHandler(this.frmModelos_Load);
            this.PnlFondo.ResumeLayout(false);
            this.PnlFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvModelos)).EndInit();
            this.PnCaja.ResumeLayout(false);
            this.PnCaja.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlFondo;
        private System.Windows.Forms.Label LblIngresMarca;
        private System.Windows.Forms.Label lblIngresaNuevoModelo;
        private System.Windows.Forms.TextBox txtModelos;
        private System.Windows.Forms.DataGridView DgvModelos;
        private System.Windows.Forms.Label lblIDModelos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Panel PnCaja;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cmbMarcas;
    }
}