using System;
using System.Collections.Generic;

namespace PC2
{
    /// Lista doblemente enlazada CIRCULAR.
    public class ListaCircular
    {
        private Nodo cabeza;
        private Nodo actual;
        private int cantidad;

        public int Cantidad => cantidad;

        public bool EstaVacia() => cabeza == null;

        public string ObtenerActual() => actual?.Cancion;

        /// Inserta una canción al final (queda justo antes de la cabeza)
        public void Insertar(string cancion)
        {
            Nodo nuevo = new Nodo(cancion);

            if (EstaVacia())
            {
                nuevo.Siguiente = nuevo;
                nuevo.Anterior = nuevo;
                cabeza = nuevo;
                actual = nuevo;
            }
            else
            {
                Nodo ultimo = cabeza.Anterior;
                ultimo.Siguiente = nuevo;
                nuevo.Anterior = ultimo;
                nuevo.Siguiente = cabeza;
                cabeza.Anterior = nuevo;
            }

            cantidad++;
        }

        /// Avanza a la siguiente canción.
        public string Siguiente()
        {
            if (EstaVacia()) return null;
            actual = actual.Siguiente;
            return actual.Cancion;
        }

        /// Retrocede a la canción anterior.
        public string Anterior()
        {
            if (EstaVacia()) return null;
            actual = actual.Anterior;
            return actual.Cancion;
        }

        public bool EliminarPrimero()
        {
            if (EstaVacia()) return false;
            return Eliminar(cabeza);
        }

        public bool EliminarUltimo()
        {
            if (EstaVacia()) return false;
            return Eliminar(cabeza.Anterior);
        }

        /// Elimina la canción que se está reproduciendo
        public bool EliminarActual()
        {
            if (EstaVacia()) return false;
            return Eliminar(actual);
        }

        /// Elimina una canción puntual, buscándola por nombre.
        public bool EliminarPorValor(string cancion)
        {
            if (EstaVacia()) return false;

            Nodo nodo = cabeza;
            do
            {
                if (nodo.Cancion == cancion)
                    return Eliminar(nodo);
                nodo = nodo.Siguiente;
            } while (nodo != cabeza);

            return false;
        }

        /// Lógica única de eliminación:
        private bool Eliminar(Nodo objetivo)
        {
            if (objetivo == cabeza && cabeza.Siguiente == cabeza)
            {
                // único elemento en la lista
                cabeza = null;
                actual = null;
                cantidad--;
                return true;
            }

            Nodo previo = objetivo.Anterior;
            Nodo siguiente = objetivo.Siguiente;

            previo.Siguiente = siguiente;
            siguiente.Anterior = previo;

            if (objetivo == cabeza)
                cabeza = siguiente;

            if (objetivo == actual)
                actual = siguiente; // si se borró la que sonaba, sigue con la próxima

            objetivo.Anterior = null;
            objetivo.Siguiente = null;

            cantidad--;
            return true;
        }

        /// Devuelve todas las canciones en orden, empezando por la cabeza
        public List<string> ObtenerTodas()
        {
            var resultado = new List<string>();
            if (EstaVacia()) return resultado;

            Nodo nodo = cabeza;
            do
            {
                resultado.Add(nodo.Cancion);
                nodo = nodo.Siguiente;
            } while (nodo != cabeza);

            return resultado;
        }
    }
}
