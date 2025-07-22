namespace Mantenimientos_de_computo
{
    partial class frmEjemplares
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
            this.cmbDispositivo = new System.Windows.Forms.ComboBox();
            this.LblEscojeLaboratorio = new System.Windows.Forms.Label();
            this.txtNombreInventario = new System.Windows.Forms.TextBox();
            this.lblNombreInventario = new System.Windows.Forms.Label();
            this.cmbLaboratorio = new System.Windows.Forms.ComboBox();
            this.DgvEjemplares = new System.Windows.Forms.DataGridView();
            this.lblIdEjemplar = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtNumeroInventario = new System.Windows.Forms.TextBox();
            this.lblNoInventario = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblIdDispositivo = new System.Windows.Forms.Label();
            this.pnlFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEjemplares)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFondo
            // 
            this.pnlFondo.BackColor = System.Drawing.Color.Bisque;
            this.pnlFondo.Controls.Add(this.cmbDispositivo);
            this.pnlFondo.Controls.Add(this.LblEscojeLaboratorio);
            this.pnlFondo.Controls.Add(this.txtNombreInventario);
            this.pnlFondo.Controls.Add(this.lblNombreInventario);
            this.pnlFondo.Controls.Add(this.cmbLaboratorio);
            this.pnlFondo.Controls.Add(this.DgvEjemplares);
            this.pnlFondo.Controls.Add(this.lblIdEjemplar);
            this.pnlFondo.Controls.Add(this.btnVolver);
            this.pnlFondo.Controls.Add(this.btnRegistrar);
            this.pnlFondo.Controls.Add(this.txtNumeroInventario);
            this.pnlFondo.Controls.Add(this.lblNoInventario);
            this.pnlFondo.Controls.Add(this.panel2);
            this.pnlFondo.Controls.Add(this.lblIdDispositivo);
            this.pnlFondo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFondo.Location = new System.Drawing.Point(0, 0);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(1178, 718);
            this.pnlFondo.TabIndex = 22;
            // 
            // cmbDispositivo
            // 
            this.cmbDispositivo.FormattingEnabled = true;
            this.cmbDispositivo.Location = new System.Drawing.Point(392, 380);
            this.cmbDispositivo.Name = "cmbDispositivo";
            this.cmbDispositivo.Size = new System.Drawing.Size(249, 31);
            this.cmbDispositivo.TabIndex = 47;
            // 
            // LblEscojeLaboratorio
            // 
            this.LblEscojeLaboratorio.AutoSize = true;
            this.LblEscojeLaboratorio.Location = new System.Drawing.Point(53, 341);
            this.LblEscojeLaboratorio.Name = "LblEscojeLaboratorio";
            this.LblEscojeLaboratorio.Size = new System.Drawing.Size(350, 23);
            this.LblEscojeLaboratorio.TabIndex = 46;
            this.LblEscojeLaboratorio.Text = "Escoje el Laboratorio del Ejemplar:";
            // 
            // txtNombreInventario
            // 
            this.txtNombreInventario.Location = new System.Drawing.Point(392, 491);
            this.txtNombreInventario.MaxLength = 20;
            this.txtNombreInventario.Name = "txtNombreInventario";
            this.txtNombreInventario.Size = new System.Drawing.Size(249, 31);
            this.txtNombreInventario.TabIndex = 45;
            this.txtNombreInventario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreInventario_KeyPress);
            // 
            // lblNombreInventario
            // 
            this.lblNombreInventario.AutoSize = true;
            this.lblNombreInventario.Location = new System.Drawing.Point(75, 499);
            this.lblNombreInventario.Name = "lblNombreInventario";
            this.lblNombreInventario.Size = new System.Drawing.Size(324, 23);
            this.lblNombreInventario.TabIndex = 44;
            this.lblNombreInventario.Text = "Ingresa el Nombre del Ejemplar:";
            // 
            // cmbLaboratorio
            // 
            this.cmbLaboratorio.FormattingEnabled = true;
            this.cmbLaboratorio.Location = new System.Drawing.Point(392, 338);
            this.cmbLaboratorio.Name = "cmbLaboratorio";
            this.cmbLaboratorio.Size = new System.Drawing.Size(249, 31);
            this.cmbLaboratorio.TabIndex = 40;
            // 
            // DgvEjemplares
            // 
            this.DgvEjemplares.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvEjemplares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEjemplares.Location = new System.Drawing.Point(12, 13);
            this.DgvEjemplares.Name = "DgvEjemplares";
            this.DgvEjemplares.ReadOnly = true;
            this.DgvEjemplares.RowHeadersWidth = 51;
            this.DgvEjemplares.RowTemplate.Height = 24;
            this.DgvEjemplares.Size = new System.Drawing.Size(1144, 259);
            this.DgvEjemplares.TabIndex = 38;
            this.DgvEjemplares.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEjemplares_CellClick);
            // 
            // lblIdEjemplar
            // 
            this.lblIdEjemplar.AutoSize = true;
            this.lblIdEjemplar.Location = new System.Drawing.Point(524, 292);
            this.lblIdEjemplar.Name = "lblIdEjemplar";
            this.lblIdEjemplar.Size = new System.Drawing.Size(141, 23);
            this.lblIdEjemplar.TabIndex = 37;
            this.lblIdEjemplar.Text = "lblIDEjemplar";
            this.lblIdEjemplar.Visible = false;
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
            // txtNumeroInventario
            // 
            this.txtNumeroInventario.Location = new System.Drawing.Point(392, 430);
            this.txtNumeroInventario.MaxLength = 20;
            this.txtNumeroInventario.Name = "txtNumeroInventario";
            this.txtNumeroInventario.Size = new System.Drawing.Size(249, 31);
            this.txtNumeroInventario.TabIndex = 28;
            this.txtNumeroInventario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroInventario_KeyPress);
            // 
            // lblNoInventario
            // 
            this.lblNoInventario.AutoSize = true;
            this.lblNoInventario.Location = new System.Drawing.Point(75, 438);
            this.lblNoInventario.Name = "lblNoInventario";
            this.lblNoInventario.Size = new System.Drawing.Size(328, 23);
            this.lblNoInventario.TabIndex = 27;
            this.lblNoInventario.Text = "Ingresa el Número de inventario:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(217)))), ((int)(((byte)(230)))));
            this.panel2.Controls.Add(this.txtBusqueda);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnActualizar);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Location = new System.Drawing.Point(726, 292);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 318);
            this.panel2.TabIndex = 20;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(114, 155);
            this.txtBusqueda.MaxLength = 10;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(249, 31);
            this.txtBusqueda.TabIndex = 48;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
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
            // lblIdDispositivo
            // 
            this.lblIdDispositivo.AutoSize = true;
            this.lblIdDispositivo.Location = new System.Drawing.Point(179, 383);
            this.lblIdDispositivo.Name = "lblIdDispositivo";
            this.lblIdDispositivo.Size = new System.Drawing.Size(225, 23);
            this.lblIdDispositivo.TabIndex = 43;
            this.lblIdDispositivo.Text = "Ingrese el Dispositivo:";
            // 
            // frmEjemplares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 719);
            this.Controls.Add(this.pnlFondo);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEjemplares";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEjemplares";
            this.Load += new System.EventHandler(this.frmEjemplares_Load);
            this.pnlFondo.ResumeLayout(false);
            this.pnlFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEjemplares)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFondo;
        private System.Windows.Forms.ComboBox cmbLaboratorio;
        private System.Windows.Forms.DataGridView DgvEjemplares;
        private System.Windows.Forms.Label lblIdEjemplar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtNumeroInventario;
        private System.Windows.Forms.Label lblNoInventario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblIdDispositivo;
        private System.Windows.Forms.TextBox txtNombreInventario;
        private System.Windows.Forms.Label lblNombreInventario;
        private System.Windows.Forms.Label LblEscojeLaboratorio;
        private System.Windows.Forms.ComboBox cmbDispositivo;
        private System.Windows.Forms.TextBox txtBusqueda;
    }
}