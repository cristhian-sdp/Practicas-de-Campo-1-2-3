using System;
using System.Windows.Forms;

namespace PC2
{
    public partial class Form1 : Form
    {
        // Estructura principal: la lista circular doblemente enlazada
        private readonly ListaCircular listaCanciones = new ListaCircular();

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Canciones de ejemplo
            listaCanciones.Insertar("Huayno - Wayra");
            listaCanciones.Insertar("Cumbia - Sonido Andino");
            listaCanciones.Insertar("Vals - Recuerdos del Ande");
            listaCanciones.Insertar("Festejo - Tierra Negra");

            ActualizarPantalla();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            listaCanciones.Siguiente();
            ActualizarPantalla();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            listaCanciones.Anterior();
            ActualizarPantalla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string cancion = txtNuevaCancion.Text.Trim();
            if (string.IsNullOrEmpty(cancion))
            {
                MessageBox.Show("Escribe el nombre de la canción antes de agregarla.",
                    "Dato vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            listaCanciones.Insertar(cancion);
            txtNuevaCancion.Clear();
            ActualizarPantalla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listaCanciones.EstaVacia())
            {
                MessageBox.Show("La lista de reproducción está vacía.",
                    "Nada que eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (lstReproduccion.SelectedItem == null)
            {
                MessageBox.Show("Selecciona en la lista la canción que quieres eliminar.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string seleccionada = lstReproduccion.SelectedItem.ToString();
            listaCanciones.EliminarPorValor(seleccionada);
            ActualizarPantalla();
        }

        private void btnPruebas_Click(object sender, EventArgs e)
        {
            var resultados = Pruebas.EjecutarPruebas();
            txtResultados.Text = string.Join(Environment.NewLine, resultados);
        }

        private void ActualizarPantalla()
        {
            var canciones = listaCanciones.ObtenerTodas();

            lstReproduccion.Items.Clear();
            foreach (string cancion in canciones)
                lstReproduccion.Items.Add(cancion);

            if (listaCanciones.EstaVacia())
            {
                lblActual.Text = "(lista vacía)";
            }
            else
            {
                lblActual.Text = "▶ " + listaCanciones.ObtenerActual();

                int indiceActual = canciones.IndexOf(listaCanciones.ObtenerActual());
                if (indiceActual >= 0)
                    lstReproduccion.SelectedIndex = indiceActual;
            }
        }
    }
}