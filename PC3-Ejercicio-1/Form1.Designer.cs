namespace PC3_Ejercicio_1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.TextBox txtFormula;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.Button btnDeshacer;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.GroupBox grpFormula;
        private System.Windows.Forms.GroupBox grpResultado;

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
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.txtFormula = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.btnDeshacer = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.grpFormula = new System.Windows.Forms.GroupBox();
            this.grpResultado = new System.Windows.Forms.GroupBox();

            this.grpFormula.SuspendLayout();
            this.grpResultado.SuspendLayout();
            this.SuspendLayout();
            //Formulario principal
            this.Text = "PC3-Ejercicio-1 | Validador de Fórmulas Financieras";
            this.Size = new System.Drawing.Size(560, 420);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Font = new System.Drawing.Font("Segoe UI", 9.5f);
            // lblTitulo
            this.lblTitulo.Text = "💹 Validador y Evaluador de Fórmulas Financieras";
            this.lblTitulo.Location = new System.Drawing.Point(12, 12);
            this.lblTitulo.Size = new System.Drawing.Size(520, 28);
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(30, 100, 160);
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // grpFormula
            this.grpFormula.Text = "Fórmula";
            this.grpFormula.Location = new System.Drawing.Point(12, 50);
            this.grpFormula.Size = new System.Drawing.Size(520, 130);
            this.grpFormula.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            // lblInstruccion
            this.lblInstruccion.Text = "Escribe la fórmula financiera (ej: (3 + 4) * 2):";
            this.lblInstruccion.Location = new System.Drawing.Point(10, 22);
            this.lblInstruccion.Size = new System.Drawing.Size(490, 20);
            this.lblInstruccion.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            // txtFormula
            this.txtFormula.Location = new System.Drawing.Point(10, 46);
            this.txtFormula.Size = new System.Drawing.Size(490, 28);
            this.txtFormula.Font = new System.Drawing.Font("Consolas", 11f);
            this.txtFormula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFormula.BackColor = System.Drawing.Color.White;
            this.txtFormula.PlaceholderText = "Ejemplo: (3 + 4) * 2 - 1.5";
            // Botones
            // btnValidar
            this.btnValidar.Text = "✔ Validar";
            this.btnValidar.Location = new System.Drawing.Point(10, 86);
            this.btnValidar.Size = new System.Drawing.Size(148, 36);
            this.btnValidar.BackColor = System.Drawing.Color.FromArgb(30, 130, 76);
            this.btnValidar.ForeColor = System.Drawing.Color.White;
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidar.FlatAppearance.BorderSize = 0;
            this.btnValidar.Font = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.btnValidar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // btnEvaluar
            this.btnEvaluar.Text = "🧮 Evaluar";
            this.btnEvaluar.Location = new System.Drawing.Point(176, 86);
            this.btnEvaluar.Size = new System.Drawing.Size(148, 36);
            this.btnEvaluar.BackColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.btnEvaluar.ForeColor = System.Drawing.Color.White;
            this.btnEvaluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvaluar.FlatAppearance.BorderSize = 0;
            this.btnEvaluar.Font = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.btnEvaluar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // btnDeshacer
            this.btnDeshacer.Text = "↩ Deshacer";
            this.btnDeshacer.Location = new System.Drawing.Point(352, 86);
            this.btnDeshacer.Size = new System.Drawing.Size(148, 36);
            this.btnDeshacer.BackColor = System.Drawing.Color.FromArgb(150, 100, 20);
            this.btnDeshacer.ForeColor = System.Drawing.Color.White;
            this.btnDeshacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeshacer.FlatAppearance.BorderSize = 0;
            this.btnDeshacer.Font = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.btnDeshacer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeshacer.Click += new System.EventHandler(this.btnDeshacer_Click);
            // grpResultado
            this.grpResultado.Text = "Resultado";
            this.grpResultado.Location = new System.Drawing.Point(12, 196);
            this.grpResultado.Size = new System.Drawing.Size(520, 80);
            this.grpResultado.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            // lblResultado
            this.lblResultado.Text = "El resultado aparecerá aquí...";
            this.lblResultado.Location = new System.Drawing.Point(10, 24);
            this.lblResultado.Size = new System.Drawing.Size(490, 44);
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.lblResultado.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblResultado.AutoSize = false;
            // Área de ejemplos (Label informativo)
            var lblEjemplos = new System.Windows.Forms.Label
            {
                Text = "Ejemplos: (3+4)*2    100*(1+0.05)    [(10-2)*3]/4",
                Location = new System.Drawing.Point(12, 290),
                Size = new System.Drawing.Size(520, 22),
                ForeColor = System.Drawing.Color.FromArgb(120, 120, 120),
                Font = new System.Drawing.Font("Consolas", 8.5f),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };

            var lblNota = new System.Windows.Forms.Label
            {
                Text = "Operadores soportados: +  -  *  /  ( )  [ ]  { }",
                Location = new System.Drawing.Point(12, 316),
                Size = new System.Drawing.Size(520, 20),
                ForeColor = System.Drawing.Color.FromArgb(150, 150, 150),
                Font = new System.Drawing.Font("Segoe UI", 8f),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };

            // Agregar controles
            this.grpFormula.Controls.Add(this.lblInstruccion);
            this.grpFormula.Controls.Add(this.txtFormula);
            this.grpFormula.Controls.Add(this.btnValidar);
            this.grpFormula.Controls.Add(this.btnEvaluar);
            this.grpFormula.Controls.Add(this.btnDeshacer);

            this.grpResultado.Controls.Add(this.lblResultado);

            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grpFormula);
            this.Controls.Add(this.grpResultado);
            this.Controls.Add(lblEjemplos);
            this.Controls.Add(lblNota);

            this.grpFormula.ResumeLayout(false);
            this.grpResultado.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}