using System;

namespace PC3_Ejercicio_2
{
    /// Nodo interno de la cola
    internal class NodoCola<T>
    {
        public T Dato { get; set; }
        public NodoCola<T> Siguiente { get; set; }

        public NodoCola(T dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }

    /// Cola genérica FIFO implementada con lista enlazada
    public class Cola<T>
    {
        private NodoCola<T> _frente;
        private NodoCola<T> _final;
        private int _tamaño;

        public Cola()
        {
            _frente = null;
            _final = null;
            _tamaño = 0;
        }

        /// Cantidad de elementos en la cola
        public int Tamaño => _tamaño;

        /// Verdadero si la cola no tiene elementos
        public bool EstaVacia => _frente == null;

        /// ENQUEUE – Inserta un elemento al FINAL de la cola
        public void Encolar(T dato)
        {
            NodoCola<T> nuevo = new NodoCola<T>(dato);

            if (EstaVacia)
            {
                // La cola estaba vacía: frente y final apuntan al mismo nodo
                _frente = nuevo;
                _final = nuevo;
            }
            else
            {
                // El último nodo ahora apunta al recién llegado
                _final.Siguiente = nuevo;
                _final = nuevo;
            }

            _tamaño++;
        }

        /// DEQUEUE – Extrae y devuelve el elemento del FRENTE
        public T Desencolar()
        {
            if (EstaVacia)
                throw new InvalidOperationException(
                    "Underflow: la cola de pacientes está vacía.");

            T dato = _frente.Dato;
            _frente = _frente.Siguiente;

            if (_frente == null)
                _final = null; // La cola quedó vacía

            _tamaño--;
            return dato;
        }

        /// PEEK – Devuelve el elemento del frente sin extraerlo
        public T VerFrente()
        {
            if (EstaVacia)
                throw new InvalidOperationException("La cola está vacía.");
            return _frente.Dato;
        }

        /// Devuelve todos los elementos como arreglo
        public T[] ObtenerTodos()
        {
            T[] arreglo = new T[_tamaño];
            NodoCola<T> actual = _frente;
            int i = 0;
            while (actual != null)
            {
                arreglo[i++] = actual.Dato;
                actual = actual.Siguiente;
            }
            return arreglo;
        }

        /// Vacía completamente la cola
        public void Limpiar()
        {
            _frente = null;
            _final = null;
            _tamaño = 0;
        }
    }
}