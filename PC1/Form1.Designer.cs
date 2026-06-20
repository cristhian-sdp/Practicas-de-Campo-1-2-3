namespace PC1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.txtPosicion = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.btnInsertarInicio = new System.Windows.Forms.Button();
            this.btnInsertarFinal = new System.Windows.Forms.Button();
            this.btnInsertarPosicion = new System.Windows.Forms.Button();
            this.btnAtender = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.SuspendLayout();
            // txtDni
            this.txtDni.Location = new System.Drawing.Point(120, 20);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(150, 20);
            this.txtDni.TabIndex = 0;
            // txtNombres
            this.txtNombres.Location = new System.Drawing.Point(120, 50);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(150, 20);
            this.txtNombres.TabIndex = 1;
            // txtEdad
            this.txtEdad.Location = new System.Drawing.Point(120, 80);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(150, 20);
            this.txtEdad.TabIndex = 2;
            // txtMotivo
            this.txtMotivo.Location = new System.Drawing.Point(120, 110);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(150, 20);
            this.txtMotivo.TabIndex = 3;
            // txtPosicion
            this.txtPosicion.Location = new System.Drawing.Point(420, 80);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(60, 20);
            this.txtPosicion.TabIndex = 4;
            // lblDni
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(30, 23);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 5;
            this.lblDni.Text = "DNI:";
            // lblNombres
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(30, 53);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(52, 13);
            this.lblNombres.TabIndex = 6;
            this.lblNombres.Text = "Nombres:";
            // lblEdad
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(30, 83);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 7;
            this.lblEdad.Text = "Edad:";
            // lblMotivo
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(30, 113);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(42, 13);
            this.lblMotivo.TabIndex = 8;
            this.lblMotivo.Text = "Motivo:";
            // lblPosicion
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Location = new System.Drawing.Point(315, 83);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(99, 13);
            this.lblPosicion.TabIndex = 9;
            this.lblPosicion.Text = "Posición Urgencia:";
            // btnInsertarInicio
            this.btnInsertarInicio.Location = new System.Drawing.Point(315, 18);
            this.btnInsertarInicio.Name = "btnInsertarInicio";
            this.btnInsertarInicio.Size = new System.Drawing.Size(110, 23);
            this.btnInsertarInicio.TabIndex = 10;
            this.btnInsertarInicio.Text = "Insertar Inicio";
            this.btnInsertarInicio.UseVisualStyleBackColor = true;
            this.btnInsertarInicio.Click += new System.EventHandler(this.btnInsertarInicio_Click);
            // btnInsertarFinal
            this.btnInsertarFinal.Location = new System.Drawing.Point(315, 48);
            this.btnInsertarFinal.Name = "btnInsertarFinal";
            this.btnInsertarFinal.Size = new System.Drawing.Size(110, 23);
            this.btnInsertarFinal.TabIndex = 11;
            this.btnInsertarFinal.Text = "Insertar Final";
            this.btnInsertarFinal.UseVisualStyleBackColor = true;
            this.btnInsertarFinal.Click += new System.EventHandler(this.btnInsertarFinal_Click);
            // btnInsertarPosicion
            this.btnInsertarPosicion.Location = new System.Drawing.Point(490, 78);
            this.btnInsertarPosicion.Name = "btnInsertarPosicion";
            this.btnInsertarPosicion.Size = new System.Drawing.Size(110, 23);
            this.btnInsertarPosicion.TabIndex = 12;
            this.btnInsertarPosicion.Text = "Insertar Posición";
            this.btnInsertarPosicion.UseVisualStyleBackColor = true;
            this.btnInsertarPosicion.Click += new System.EventHandler(this.btnInsertarPosicion_Click);
            // btnAtender
            this.btnAtender.BackColor = System.Drawing.Color.LightCoral;
            this.btnAtender.Location = new System.Drawing.Point(450, 18);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(150, 23);
            this.btnAtender.TabIndex = 13;
            this.btnAtender.Text = "Atender Paciente";
            this.btnAtender.UseVisualStyleBackColor = false;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // btnBuscar
            this.btnBuscar.Location = new System.Drawing.Point(450, 48);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(150, 23);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar por DNI";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // btnOrdenar
            this.btnOrdenar.Location = new System.Drawing.Point(315, 110);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(285, 23);
            this.btnOrdenar.TabIndex = 15;
            this.btnOrdenar.Text = "Ordenar por Hora de Llegada";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // dgvPacientes
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Location = new System.Drawing.Point(33, 160);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.Size = new System.Drawing.Size(567, 230);
            this.dgvPacientes.TabIndex = 16;
            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.btnInsertarPosicion);
            this.Controls.Add(this.btnInsertarFinal);
            this.Controls.Add(this.btnInsertarInicio);
            this.Controls.Add(this.lblPosicion);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtPosicion);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtDni);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo de Registro de Pacientes - Clínica (PC1)";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.TextBox txtPosicion;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.Button btnInsertarInicio;
        private System.Windows.Forms.Button btnInsertarFinal;
        private System.Windows.Forms.Button btnInsertarPosicion;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.DataGridView dgvPacientes;
    }
}