using System;

namespace PC2
{
    /// Nodo de una lista doblemente enlazada.
    public class Nodo
    {
        public string Cancion { get; set; }
        public Nodo Anterior { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(string cancion)
        {
            Cancion = cancion;
            Anterior = null;
            Siguiente = null;
        }
    }
}
