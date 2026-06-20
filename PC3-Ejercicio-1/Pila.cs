using System;

namespace PC3_Ejercicio_1
{
    /// Nodo interno de la pila.
    internal class Nodo<T>
    {
        public T Dato { get; set; }
        public Nodo<T> Siguiente { get; set; }

        public Nodo(T dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }

    /// Pila genérica (LIFO) implementada con lista enlazada.
    public class Pila<T>
    {
        private Nodo<T> _tope;   // Apunta al elemento más reciente
        private int _tamaño;

        public Pila()
        {
            _tope = null;
            _tamaño = 0;
        }

        /// Cantidad de elementos en la pila
        public int Tamaño => _tamaño;

        /// Verdadero si la pila no tiene elementos
        public bool EstaVacia => _tope == null;

        /// PUSH – Inserta un elemento en el tope de la pila.
        public void Apilar(T dato)
        {
            Nodo<T> nuevo = new Nodo<T>(dato);
            nuevo.Siguiente = _tope;
            _tope = nuevo;
            _tamaño++;
        }

        /// POP – Extrae y devuelve el elemento del tope.
        public T Desapilar()
        {
            if (EstaVacia)
                throw new InvalidOperationException("La pila está vacía.");

            T dato = _tope.Dato;
            _tope = _tope.Siguiente;
            _tamaño--;
            return dato;
        }

        /// PEEK – Devuelve el tope sin eliminarlo.
        public T VerTope()
        {
            if (EstaVacia)
                throw new InvalidOperationException("La pila está vacía.");
            return _tope.Dato;
        }

        /// Vacía completamente la pila.
        public void Limpiar()
        {
            _tope = null;
            _tamaño = 0;
        }
    }
}