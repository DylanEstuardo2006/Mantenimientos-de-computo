namespace Mantenimientos_de_computo
{
    partial class frmMapaNavegacion
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
            this.lblIdDispositivo = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pnlCaja = new System.Windows.Forms.Panel();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnEjemplares = new System.Windows.Forms.Button();
            this.btnModelos = new System.Windows.Forms.Button();
            this.btnTipoDispositivo = new System.Windows.Forms.Button();
            this.lblMapaNavegacion = new System.Windows.Forms.Label();
            this.btnDiagnostico = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnTecnicos = new System.Windows.Forms.Button();
            this.btnDispositivo = new System.Windows.Forms.Button();
            this.btnLaboratorio = new System.Windows.Forms.Button();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.pnlFondo.SuspendLayout();
            this.pnlCaja.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFondo
            // 
            this.pnlFondo.BackColor = System.Drawing.Color.Bisque;
            this.pnlFondo.Controls.Add(this.btnMantenimiento);
            this.pnlFondo.Controls.Add(this.btnLaboratorio);
            this.pnlFondo.Controls.Add(this.btnDispositivo);
            this.pnlFondo.Controls.Add(this.btnTecnicos);
            this.pnlFondo.Controls.Add(this.btnHistorial);
            this.pnlFondo.Controls.Add(this.btnDiagnostico);
            this.pnlFondo.Controls.Add(this.lblMapaNavegacion);
            this.pnlFondo.Controls.Add(this.btnTipoDispositivo);
            this.pnlFondo.Controls.Add(this.btnModelos);
            this.pnlFondo.Controls.Add(this.btnEjemplares);
            this.pnlFondo.Controls.Add(this.btnMarcas);
            this.pnlFondo.Controls.Add(this.lblIdDispositivo);
            this.pnlFondo.Controls.Add(this.btnVolver);
            this.pnlFondo.Controls.Add(this.pnlCaja);
            this.pnlFondo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFondo.Location = new System.Drawing.Point(2, 2);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(1178, 718);
            this.pnlFondo.TabIndex = 24;
            // 
            // lblIdDispositivo
            // 
            this.lblIdDispositivo.AutoSize = true;
            this.lblIdDispositivo.Location = new System.Drawing.Point(524, 292);
            this.lblIdDispositivo.Name = "lblIdDispositivo";
            this.lblIdDispositivo.Size = new System.Drawing.Size(0, 23);
            this.lblIdDispositivo.TabIndex = 37;
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
            // pnlCaja
            // 
            this.pnlCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(217)))), ((int)(((byte)(230)))));
            this.pnlCaja.Controls.Add(this.txtBusqueda);
            this.pnlCaja.Controls.Add(this.label3);
            this.pnlCaja.Controls.Add(this.btnActualizar);
            this.pnlCaja.Controls.Add(this.btnEliminar);
            this.pnlCaja.Location = new System.Drawing.Point(726, 292);
            this.pnlCaja.Name = "pnlCaja";
            this.pnlCaja.Size = new System.Drawing.Size(0, 0);
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
            // btnMarcas
            // 
            this.btnMarcas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(124)))), ((int)(((byte)(141)))));
            this.btnMarcas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcas.ForeColor = System.Drawing.Color.White;
            this.btnMarcas.Location = new System.Drawing.Point(528, 365);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(162, 54);
            this.btnMarcas.TabIndex = 40;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.UseVisualStyleBackColor = false;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // btnEjemplares
            // 
            this.btnEjemplares.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(124)))), ((int)(((byte)(141)))));
            this.btnEjemplares.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjemplares.ForeColor = System.Drawing.Color.White;
            this.btnEjemplares.Location = new System.Drawing.Point(726, 365);
            this.btnEjemplares.Name = "btnEjemplares";
            this.btnEjemplares.Size = new System.Drawing.Size(162, 54);
            this.btnEjemplares.TabIndex = 44;
            this.btnEjemplares.Text = "Ejemplares";
            this.btnEjemplares.UseVisualStyleBackColor = false;
            this.btnEjemplares.Click += new System.EventHandler(this.btnEjemplares_Click);
            // 
            // btnModelos
            // 
            this.btnModelos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(124)))), ((int)(((byte)(141)))));
            this.btnModelos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModelos.ForeColor = System.Drawing.Color.White;
            this.btnModelos.Location = new System.Drawing.Point(298, 365);
            this.btnModelos.Name = "btnModelos";
            this.btnModelos.Size = new System.Drawing.Size(162, 54);
            this.btnModelos.TabIndex = 47;
            this.btnModelos.Text = "Modelos";
            this.btnModelos.UseVisualStyleBackColor = false;
            this.btnModelos.Click += new System.EventHandler(this.btnModelos_Click);
            // 
            // btnTipoDispositivo
            // 
            this.btnTipoDispositivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(124)))), ((int)(((byte)(141)))));
            this.btnTipoDispositivo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoDispositivo.ForeColor = System.Drawing.Color.White;
            this.btnTipoDispositivo.Location = new System.Drawing.Point(954, 365);
            this.btnTipoDispositivo.Name = "btnTipoDispositivo";
            this.btnTipoDispositivo.Size = new System.Drawing.Size(162, 54);
            this.btnTipoDispositivo.TabIndex = 48;
            this.btnTipoDispositivo.Text = "Tipo Dispositivo";
            this.btnTipoDispositivo.UseVisualStyleBackColor = false;
            this.btnTipoDispositivo.Click += new System.EventHandler(this.btnTipoDispositivo_Click);
            // 
            // lblMapaNavegacion
            // 
            this.lblMapaNavegacion.AutoSize = true;
            this.lblMapaNavegacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMapaNavegacion.Location = new System.Drawing.Point(437, 36);
            this.lblMapaNavegacion.Name = "lblMapaNavegacion";
            this.lblMapaNavegacion.Size = new System.Drawing.Size(325, 46);
            this.lblMapaNavegacion.TabIndex = 49;
            this.lblMapaNavegacion.Text = "MAPA DE SITIO";
            // 
            // btnDiagnostico
            // 
            this.btnDiagnostico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(124)))), ((int)(((byte)(141)))));
            this.btnDiagnostico.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagnostico.ForeColor = System.Drawing.Color.White;
            this.btnDiagnostico.Location = new System.Drawing.Point(66, 192);
            this.btnDiagnostico.Name = "btnDiagnostico";
            this.btnDiagnostico.Size = new System.Drawing.Size(162, 54);
            this.btnDiagnostico.TabIndex = 50;
            this.btnDiagnostico.Text = "Diagnostico";
            this.btnDiagnostico.UseVisualStyleBackColor = false;
            this.btnDiagnostico.Click += new System.EventHandler(this.btnDiagnostico_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(124)))), ((int)(((byte)(141)))));
            this.btnHistorial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.ForeColor = System.Drawing.Color.White;
            this.btnHistorial.Location = new System.Drawing.Point(518, 192);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(162, 54);
            this.btnHistorial.TabIndex = 51;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnTecnicos
            // 
            this.btnTecnicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(124)))), ((int)(((byte)(141)))));
            this.btnTecnicos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTecnicos.ForeColor = System.Drawing.Color.White;
            this.btnTecnicos.Location = new System.Drawing.Point(726, 192);
            this.btnTecnicos.Name = "btnTecnicos";
            this.btnTecnicos.Size = new System.Drawing.Size(162, 54);
            this.btnTecnicos.TabIndex = 52;
            this.btnTecnicos.Text = "Técnicos";
            this.btnTecnicos.UseVisualStyleBackColor = false;
            this.btnTecnicos.Click += new System.EventHandler(this.btnTecnicos_Click);
            // 
            // btnDispositivo
            // 
            this.btnDispositivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(124)))), ((int)(((byte)(141)))));
            this.btnDispositivo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispositivo.ForeColor = System.Drawing.Color.White;
            this.btnDispositivo.Location = new System.Drawing.Point(954, 192);
            this.btnDispositivo.Name = "btnDispositivo";
            this.btnDispositivo.Size = new System.Drawing.Size(162, 54);
            this.btnDispositivo.TabIndex = 53;
            this.btnDispositivo.Text = "Dispositivo";
            this.btnDispositivo.UseVisualStyleBackColor = false;
            this.btnDispositivo.Click += new System.EventHandler(this.btnDispositivo_Click);
            // 
            // btnLaboratorio
            // 
            this.btnLaboratorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(124)))), ((int)(((byte)(141)))));
            this.btnLaboratorio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaboratorio.ForeColor = System.Drawing.Color.White;
            this.btnLaboratorio.Location = new System.Drawing.Point(66, 365);
            this.btnLaboratorio.Name = "btnLaboratorio";
            this.btnLaboratorio.Size = new System.Drawing.Size(162, 54);
            this.btnLaboratorio.TabIndex = 54;
            this.btnLaboratorio.Text = "Laboratorio";
            this.btnLaboratorio.UseVisualStyleBackColor = false;
            this.btnLaboratorio.Click += new System.EventHandler(this.btnLaboratorio_Click);
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(124)))), ((int)(((byte)(141)))));
            this.btnMantenimiento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimiento.ForeColor = System.Drawing.Color.White;
            this.btnMantenimiento.Location = new System.Drawing.Point(298, 192);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(162, 54);
            this.btnMantenimiento.TabIndex = 55;
            this.btnMantenimiento.Text = "Mantenimiento";
            this.btnMantenimiento.UseVisualStyleBackColor = false;
            this.btnMantenimiento.Click += new System.EventHandler(this.btnMantenimiento_Click);
            // 
            // frmMapaNavegacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 719);
            this.Controls.Add(this.pnlFondo);
            this.Name = "frmMapaNavegacion";
            this.Text = "Mapa de Sitio";
            this.pnlFondo.ResumeLayout(false);
            this.pnlFondo.PerformLayout();
            this.pnlCaja.ResumeLayout(false);
            this.pnlCaja.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFondo;
        private System.Windows.Forms.Label lblIdDispositivo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel pnlCaja;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblMapaNavegacion;
        private System.Windows.Forms.Button btnTipoDispositivo;
        private System.Windows.Forms.Button btnModelos;
        private System.Windows.Forms.Button btnEjemplares;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnDiagnostico;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnTecnicos;
        private System.Windows.Forms.Button btnDispositivo;
        private System.Windows.Forms.Button btnLaboratorio;
        private System.Windows.Forms.Button btnMantenimiento;
    }
}