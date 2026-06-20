namespace PC2
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

        #region Código generado por el diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lstReproduccion = new System.Windows.Forms.ListBox();
            this.lblActualTitulo = new System.Windows.Forms.Label();
            this.lblActual = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.txtNuevaCancion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnPruebas = new System.Windows.Forms.Button();
            this.lblResultados = new System.Windows.Forms.Label();
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(520, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Radio Comunitaria - Reproductor de canciones";

            // lstReproduccion
            this.lstReproduccion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstReproduccion.FormattingEnabled = true;
            this.lstReproduccion.ItemHeight = 20;
            this.lstReproduccion.Location = new System.Drawing.Point(20, 55);
            this.lstReproduccion.Name = "lstReproduccion";
            this.lstReproduccion.Size = new System.Drawing.Size(300, 304);
            this.lstReproduccion.TabIndex = 1;

            // lblActualTitulo
            this.lblActualTitulo.AutoSize = true;
            this.lblActualTitulo.Location = new System.Drawing.Point(340, 58);
            this.lblActualTitulo.Name = "lblActualTitulo";
            this.lblActualTitulo.Size = new System.Drawing.Size(140, 17);
            this.lblActualTitulo.TabIndex = 2;
            this.lblActualTitulo.Text = "Reproduciendo ahora:";

            // lblActual
            this.lblActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblActual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblActual.Location = new System.Drawing.Point(340, 80);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(350, 40);
            this.lblActual.TabIndex = 3;
            this.lblActual.Text = "(lista vacía)";
            this.lblActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // btnAnterior
            this.btnAnterior.Location = new System.Drawing.Point(340, 135);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(170, 32);
            this.btnAnterior.TabIndex = 4;
            this.btnAnterior.Text = "<< Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);

            // btnSiguiente
            this.btnSiguiente.Location = new System.Drawing.Point(520, 135);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(170, 32);
            this.btnSiguiente.TabIndex = 5;
            this.btnSiguiente.Text = "Siguiente >>";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);

            // txtNuevaCancion
            this.txtNuevaCancion.Location = new System.Drawing.Point(340, 190);
            this.txtNuevaCancion.Name = "txtNuevaCancion";
            this.txtNuevaCancion.PlaceholderText = "Nombre de la nueva canción...";
            this.txtNuevaCancion.Size = new System.Drawing.Size(230, 23);
            this.txtNuevaCancion.TabIndex = 6;

            // btnAgregar
            this.btnAgregar.Location = new System.Drawing.Point(580, 188);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 27);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            // btnEliminar
            this.btnEliminar.Location = new System.Drawing.Point(340, 230);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(350, 32);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar canción seleccionada";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            // btnPruebas
            this.btnPruebas.Location = new System.Drawing.Point(340, 280);
            this.btnPruebas.Name = "btnPruebas";
            this.btnPruebas.Size = new System.Drawing.Size(350, 32);
            this.btnPruebas.TabIndex = 9;
            this.btnPruebas.Text = "Ejecutar pruebas (casos límite)";
            this.btnPruebas.UseVisualStyleBackColor = true;
            this.btnPruebas.Click += new System.EventHandler(this.btnPruebas_Click);

            // lblResultados
            this.lblResultados.AutoSize = true;
            this.lblResultados.Location = new System.Drawing.Point(20, 372);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(160, 17);
            this.lblResultados.TabIndex = 10;
            this.lblResultados.Text = "Resultado de las pruebas:";

            // txtResultados
            this.txtResultados.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtResultados.Location = new System.Drawing.Point(20, 394);
            this.txtResultados.Multiline = true;
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.ReadOnly = true;
            this.txtResultados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultados.Size = new System.Drawing.Size(670, 150);
            this.txtResultados.TabIndex = 11;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 560);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lstReproduccion);
            this.Controls.Add(this.lblActualTitulo);
            this.Controls.Add(this.lblActual);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.txtNuevaCancion);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnPruebas);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.txtResultados);
            this.Name = "Form1";
            this.Text = "PC2 - Radio Comunitaria (Lista Circular Doblemente Enlazada)";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ListBox lstReproduccion;
        private System.Windows.Forms.Label lblActualTitulo;
        private System.Windows.Forms.Label lblActual;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.TextBox txtNuevaCancion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnPruebas;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.TextBox txtResultados;
    }
}