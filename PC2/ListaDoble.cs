using System;

namespace PC2
{
    /// Lista doblemente enlazada NO circular.
    public class ListaDoble
    {
        private Nodo cabeza;
        private Nodo cola;
        private Nodo actual;
        private int cantidad;

        public int Cantidad => cantidad;

        public bool EstaVacia() => cabeza == null;

        /// Agrega una canción al final de la lista.
        public void InsertarAlFinal(string cancion)
        {
            Nodo nuevo = new Nodo(cancion);

            if (EstaVacia())
            {
                cabeza = nuevo;
                cola = nuevo;
                actual = nuevo;
            }
            else
            {
                nuevo.Anterior = cola;
                cola.Siguiente = nuevo;
                cola = nuevo;
            }

            cantidad++;
        }

        /// Agrega una canción al inicio de la lista.
        public void InsertarAlInicio(string cancion)
        {
            Nodo nuevo = new Nodo(cancion);

            if (EstaVacia())
            {
                cabeza = nuevo;
                cola = nuevo;
                actual = nuevo;
            }
            else
            {
                nuevo.Siguiente = cabeza;
                cabeza.Anterior = nuevo;
                cabeza = nuevo;
            }

            cantidad++;
        }

        public string ObtenerActual() => actual?.Cancion;

        /// Avanza una posición
        public string Siguiente()
        {
            if (EstaVacia()) return null;
            if (actual.Siguiente != null)
                actual = actual.Siguiente;
            return actual.Cancion;
        }

        /// Retrocede una posición. Si ya está en el primero, se queda allí.
        public string Anterior()
        {
            if (EstaVacia()) return null;
            if (actual.Anterior != null)
                actual = actual.Anterior;
            return actual.Cancion;
        }

        public bool EliminarPrimero()
        {
            if (EstaVacia()) return false;

            if (cabeza == cola) // un solo elemento
            {
                cabeza = null;
                cola = null;
                actual = null;
            }
            else
            {
                if (actual == cabeza) actual = cabeza.Siguiente;
                cabeza = cabeza.Siguiente;
                cabeza.Anterior = null;
            }

            cantidad--;
            return true;
        }

        public bool EliminarUltimo()
        {
            if (EstaVacia()) return false;

            if (cabeza == cola) // un solo elemento
            {
                cabeza = null;
                cola = null;
                actual = null;
            }
            else
            {
                if (actual == cola) actual = cola.Anterior;
                cola = cola.Anterior;
                cola.Siguiente = null;
            }

            cantidad--;
            return true;
        }
    }
}
