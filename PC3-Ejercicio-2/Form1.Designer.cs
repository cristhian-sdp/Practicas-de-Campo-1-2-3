namespace PC3_Ejercicio_2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Controles
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpEntrada;
        private System.Windows.Forms.Label lblMascota;
        private System.Windows.Forms.TextBox txtMascota;
        private System.Windows.Forms.Label lblDueno;
        private System.Windows.Forms.TextBox txtDueno;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.GroupBox grpCola;
        private System.Windows.Forms.ListBox listBoxPacientes;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label lblEstado;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpEntrada = new System.Windows.Forms.GroupBox();
            this.lblMascota = new System.Windows.Forms.Label();
            this.txtMascota = new System.Windows.Forms.TextBox();
            this.lblDueno = new System.Windows.Forms.Label();
            this.txtDueno = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnAtender = new System.Windows.Forms.Button();
            this.grpCola = new System.Windows.Forms.GroupBox();
            this.listBoxPacientes = new System.Windows.Forms.ListBox();
            this.lblContador = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();

            this.grpEntrada.SuspendLayout();
            this.grpCola.SuspendLayout();
            this.SuspendLayout();
            // Formulario principal
            this.Text = "PC3-Ejercicio-2 | Cola de Atención · PatitasFelices";
            this.Size = new System.Drawing.Size(560, 560);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Font = new System.Drawing.Font("Segoe UI", 9.5f);
            // lblTitulo
            this.lblTitulo.Text = "🐾 Gestión de Cola · Veterinaria PatitasFelices";
            this.lblTitulo.Location = new System.Drawing.Point(12, 12);
            this.lblTitulo.Size = new System.Drawing.Size(520, 28);
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12f,
                                           System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(15, 100, 70);
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // grpEntrada
            this.grpEntrada.Text = "Registrar nuevo paciente";
            this.grpEntrada.Location = new System.Drawing.Point(12, 50);
            this.grpEntrada.Size = new System.Drawing.Size(520, 130);
            this.grpEntrada.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            // lblMascota
            this.lblMascota.Text = "Nombre de la mascota:";
            this.lblMascota.Location = new System.Drawing.Point(10, 26);
            this.lblMascota.Size = new System.Drawing.Size(160, 20);
            // txtMascota
            this.txtMascota.Location = new System.Drawing.Point(10, 46);
            this.txtMascota.Size = new System.Drawing.Size(230, 28);
            this.txtMascota.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.txtMascota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMascota.PlaceholderText = "Ej: Luna, Max, Mochi...";
            // Presionar Enter en txtMascota pasa a txtDueno
            this.txtMascota.KeyDown += (s, e) =>
            {
                if (e.KeyCode == System.Windows.Forms.Keys.Enter)
                    txtDueno.Focus();
            };
            // lblDueno
            this.lblDueno.Text = "Nombre del dueño:";
            this.lblDueno.Location = new System.Drawing.Point(260, 26);
            this.lblDueno.Size = new System.Drawing.Size(140, 20);
            // txtDueno
            this.txtDueno.Location = new System.Drawing.Point(260, 46);
            this.txtDueno.Size = new System.Drawing.Size(240, 28);
            this.txtDueno.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.txtDueno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDueno.PlaceholderText = "Ej: María García...";
            // Presionar Enter en txtDueno dispara Registrar
            this.txtDueno.KeyDown += (s, e) =>
            {
                if (e.KeyCode == System.Windows.Forms.Keys.Enter)
                    btnRegistrar_Click(s, e);
            };
            // btnRegistrar
            this.btnRegistrar.Text = "➕ Registrar";
            this.btnRegistrar.Location = new System.Drawing.Point(10, 86);
            this.btnRegistrar.Size = new System.Drawing.Size(230, 38);
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(15, 120, 70);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 10f,
                                              System.Drawing.FontStyle.Bold);
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // btnAtender
            this.btnAtender.Text = "✔ Atender siguiente";
            this.btnAtender.Location = new System.Drawing.Point(260, 86);
            this.btnAtender.Size = new System.Drawing.Size(240, 38);
            this.btnAtender.BackColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.btnAtender.ForeColor = System.Drawing.Color.White;
            this.btnAtender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtender.FlatAppearance.BorderSize = 0;
            this.btnAtender.Font = new System.Drawing.Font("Segoe UI", 10f,
                                            System.Drawing.FontStyle.Bold);
            this.btnAtender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtender.Enabled = false; // Desactivado si cola vacía
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // grpCola
            this.grpCola.Text = "Pacientes en espera (FIFO — primero en llegar, primero en salir)";
            this.grpCola.Location = new System.Drawing.Point(12, 196);
            this.grpCola.Size = new System.Drawing.Size(520, 240);
            this.grpCola.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            // listBoxPacientes
            this.listBoxPacientes.Location = new System.Drawing.Point(10, 26);
            this.listBoxPacientes.Size = new System.Drawing.Size(490, 168);
            this.listBoxPacientes.Font = new System.Drawing.Font("Consolas", 9.5f);
            this.listBoxPacientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxPacientes.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxPacientes.BackColor = System.Drawing.Color.White;
            // lblContador
            this.lblContador.Text = "Sin pacientes en espera";
            this.lblContador.Location = new System.Drawing.Point(10, 202);
            this.lblContador.Size = new System.Drawing.Size(490, 26);
            this.lblContador.Font = new System.Drawing.Font("Segoe UI", 9.5f,
                                             System.Drawing.FontStyle.Bold);
            this.lblContador.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblContador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblEstado
            this.lblEstado.Text = "Sistema listo. Registra el primer paciente.";
            this.lblEstado.Location = new System.Drawing.Point(12, 448);
            this.lblEstado.Size = new System.Drawing.Size(520, 50);
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9.5f);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblEstado.AutoSize = false;
            // Nota inferior
            var lblNota = new System.Windows.Forms.Label
            {
                Text = "PC3-Ejercicio-2  |  Cola FIFO con nodos enlazados",
                Location = new System.Drawing.Point(12, 506),
                Size = new System.Drawing.Size(520, 20),
                ForeColor = System.Drawing.Color.FromArgb(160, 160, 160),
                Font = new System.Drawing.Font("Segoe UI", 8f),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };
            // Agregar controles
            this.grpEntrada.Controls.Add(this.lblMascota);
            this.grpEntrada.Controls.Add(this.txtMascota);
            this.grpEntrada.Controls.Add(this.lblDueno);
            this.grpEntrada.Controls.Add(this.txtDueno);
            this.grpEntrada.Controls.Add(this.btnRegistrar);
            this.grpEntrada.Controls.Add(this.btnAtender);
            this.grpCola.Controls.Add(this.listBoxPacientes);
            this.grpCola.Controls.Add(this.lblContador);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grpEntrada);
            this.Controls.Add(this.grpCola);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(lblNota);
            this.grpEntrada.ResumeLayout(false);
            this.grpCola.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}