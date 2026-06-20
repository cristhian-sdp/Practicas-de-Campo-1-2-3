using System;
using System.Windows.Forms;

namespace PC3_Ejercicio_2
{
    public partial class Form1 : Form
    {
        // Cola FIFO de pacientes
        private readonly Cola<Paciente> _colaPacientes = new Cola<Paciente>();

        public Form1()
        {
            InitializeComponent();
            ActualizarUI();
        }

        //  BOTÓN REGISTRAR  –  Enqueue
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string mascota = txtMascota.Text.Trim();
            string dueno = txtDueno.Text.Trim();

            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(mascota) || string.IsNullOrEmpty(dueno))
            {
                MostrarMensaje("Completa el nombre de la mascota y del dueño.", false);
                return;
            }

            // Crear el paciente y encolarlo al FINAL
            Paciente nuevoPaciente = new Paciente(mascota, dueno);
            _colaPacientes.Encolar(nuevoPaciente);

            // Limpiar campos de entrada
            txtMascota.Clear();
            txtDueno.Clear();
            txtMascota.Focus();

            MostrarMensaje(
                $"Registrado: {nuevoPaciente.NombreMascota} " +
                $"(posición #{_colaPacientes.Tamaño} en la cola).", true);

            ActualizarUI();
        }

        //  BOTÓN ATENDER  –  Dequeue
        //  Extrae al paciente del FRENTE (el primero en llegar)
        private void btnAtender_Click(object sender, EventArgs e)
        {
            // Verificar underflow (cola vacía)
            if (_colaPacientes.EstaVacia)
            {
                MostrarMensaje("No hay pacientes en espera. La cola está vacía.", false);
                return;
            }

            // Desencolar el paciente más antiguo (frente de la cola)
            Paciente atendido = _colaPacientes.Desencolar();

            MostrarMensaje(
                $"🐾 Atendiendo a: {atendido.NombreMascota}  |  " +
                $"Dueño: {atendido.NombreDueno}  |  " +
                $"En espera: {_colaPacientes.Tamaño}", true);

            ActualizarUI();
        }

        //  HELPER: Actualizar ListBox y etiqueta de contador
        private void ActualizarUI()
        {
            // Refrescar el ListBox con todos los pacientes en cola
            listBoxPacientes.Items.Clear();

            Paciente[] pacientes = _colaPacientes.ObtenerTodos();
            for (int i = 0; i < pacientes.Length; i++)
            {
                // Mostramos el número de turno + datos del paciente
                listBoxPacientes.Items.Add($"#{i + 1}  {pacientes[i]}");
            }

            // Actualizar etiqueta de contador
            int total = _colaPacientes.Tamaño;
            if (total == 0)
                lblContador.Text = "Sin pacientes en espera";
            else if (total == 1)
                lblContador.Text = "1 paciente en espera";
            else
                lblContador.Text = $"{total} pacientes en espera";

            // Habilitar/deshabilitar botón Atender según la cola
            btnAtender.Enabled = !_colaPacientes.EstaVacia;
        }

        //  HELPER: Mostrar resultado en el label de estado
        private void MostrarMensaje(string mensaje, bool exito)
        {
            lblEstado.Text = mensaje;
            lblEstado.ForeColor = exito
                ? System.Drawing.Color.FromArgb(30, 120, 70)
                : System.Drawing.Color.FromArgb(170, 50, 30);
        }
    }
}