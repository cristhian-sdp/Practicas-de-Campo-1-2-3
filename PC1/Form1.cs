using System;
using System.Windows.Forms;

namespace PC1
{
    public partial class Form1 : Form
    {
        // Instancia global de nuestra lista enlazada
        private ListaEnlazadaSimple listaPacientes = new ListaEnlazadaSimple();

        public Form1()
        {
            InitializeComponent();
            ConfigurarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            dgvPacientes.Columns.Clear();
            dgvPacientes.Columns.Add("DNI", "DNI");
            dgvPacientes.Columns.Add("Nombres", "Nombres");
            dgvPacientes.Columns.Add("Edad", "Edad");
            dgvPacientes.Columns.Add("Hora", "Hora de Llegada");
            dgvPacientes.Columns.Add("Motivo", "Motivo de Consulta");
            dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Método para recorrer la lista y refrescar la pantalla
        private void MostrarLista()
        {
            dgvPacientes.Rows.Clear();
            Nodo actual = listaPacientes.Cabeza;
            while (actual != null)
            {
                dgvPacientes.Rows.Add(
                    actual.Paciente.DNI,
                    actual.Paciente.Nombres,
                    actual.Paciente.Edad,
                    actual.Paciente.HoraLlegada.ToString("HH:mm:ss"),
                    actual.Paciente.MotivoConsulta
                );
                actual = actual.Siguiente;
            }
        }

        // Método de Validación de Entradas de datos
        private Paciente ValidarYCrearPaciente()
        {
            if (string.IsNullOrWhiteSpace(txtDni.Text) || txtDni.Text.Length != 8 || !long.TryParse(txtDni.Text, out _))
            {
                MessageBox.Show("El DNI debe tener exactamente 8 dígitos numéricos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (string.IsNullOrWhiteSpace(txtNombres.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (!int.TryParse(txtEdad.Text, out int edad) || edad <= 0)
            {
                MessageBox.Show("La edad debe ser un número entero positivo.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (string.IsNullOrWhiteSpace(txtMotivo.Text))
            {
                MessageBox.Show("Debe ingresar un motivo de consulta.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            // Si pasan las validaciones, se crea el objeto paciente con la hora actual
            return new Paciente(txtDni.Text.Trim(), txtNombres.Text.Trim(), edad, DateTime.Now, txtMotivo.Text.Trim());
        }

        private void LimpiarCampos()
        {
            txtDni.Clear();
            txtNombres.Clear();
            txtEdad.Clear();
            txtMotivo.Clear();
            txtPosicion.Clear();
        }

        // EVENTOS DE LOS BOTONES
        private void btnInsertarInicio_Click(object sender, EventArgs e)
        {
            Paciente p = ValidarYCrearPaciente();
            if (p != null)
            {
                listaPacientes.InsertarAlInicio(p);
                MostrarLista();
                LimpiarCampos();
            }
        }

        private void btnInsertarFinal_Click(object sender, EventArgs e)
        {
            Paciente p = ValidarYCrearPaciente();
            if (p != null)
            {
                listaPacientes.InsertarAlFinal(p);
                MostrarLista();
                LimpiarCampos();
            }
        }

        private void btnInsertarPosicion_Click(object sender, EventArgs e)
        {
            Paciente p = ValidarYCrearPaciente();
            if (p != null)
            {
                if (int.TryParse(txtPosicion.Text, out int pos))
                {
                    if (listaPacientes.InsertarEnPosicion(p, pos))
                    {
                        MostrarLista();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Posición inválida o fuera de rango.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese una posición numérica válida (Ej: 0 para el inicio).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            if (listaPacientes.EliminarPrimero())
            {
                MessageBox.Show("Paciente atendido y removido de la cola.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarLista();
            }
            else
            {
                MessageBox.Show("No hay pacientes en espera.", "Cola Vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dniBuscar = txtDni.Text.Trim();
            if (string.IsNullOrEmpty(dniBuscar))
            {
                MessageBox.Show("Ingrese un DNI en el cuadro de texto para buscar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Paciente encontrado = listaPacientes.BuscarPorDNI(dniBuscar);
            if (encontrado != null)
            {
                MessageBox.Show($"Paciente Encontrado:\n\nNombre: {encontrado.Nombres}\nEdad: {encontrado.Edad}\nHora: {encontrado.HoraLlegada.ToString("HH:mm:ss")}\nMotivo: {encontrado.MotivoConsulta}", "Resultado de Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontró ningún paciente con ese DNI.", "Resultado de Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            listaPacientes.OrdenarPorHoraLlegada();
            MostrarLista();
            MessageBox.Show("Lista ordenada por hora de llegada correctamente.", "Ordenación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}