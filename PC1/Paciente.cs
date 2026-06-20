using System;

namespace PC1
{
    // Clase que representa los datos del paciente
    public class Paciente
    {
        public string DNI { get; set; }
        public string Nombres { get; set; }
        public int Edad { get; set; }
        public DateTime HoraLlegada { get; set; }
        public string MotivoConsulta { get; set; }

        public Paciente(string dni, string nombres, int edad, DateTime hora, string motivo)
        {
            DNI = dni;
            Nombres = nombres;
            Edad = edad;
            HoraLlegada = hora;
            MotivoConsulta = motivo;
        }
    }

    // Clase Nodo para la Lista Enlazada
    public class Nodo
    {
        public Paciente Paciente { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(Paciente paciente)
        {
            Paciente = paciente;
            Siguiente = null;
        }
    }

    // Estructura de la Lista Enlazada Simple
    public class ListaEnlazadaSimple
    {
        public Nodo Cabeza { get; private set; }

        public ListaEnlazadaSimple()
        {
            Cabeza = null;
        }

        // Insertar al Inicio
        public void InsertarAlInicio(Paciente nuevoPaciente)
        {
            Nodo nuevoNodo = new Nodo(nuevoPaciente);
            nuevoNodo.Siguiente = Cabeza;
            Cabeza = nuevoNodo;
        }

        // Insertar al Final
        public void InsertarAlFinal(Paciente nuevoPaciente)
        {
            Nodo nuevoNodo = new Nodo(nuevoPaciente);
            if (Cabeza == null)
            {
                Cabeza = nuevoNodo;
                return;
            }
            Nodo actual = Cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoNodo;
        }

        // Insertar en una posición específica
        public bool InsertarEnPosicion(Paciente nuevoPaciente, int posicion)
        {
            if (posicion < 0) return false;

            if (posicion == 0)
            {
                InsertarAlInicio(nuevoPaciente);
                return true;
            }

            Nodo nuevoNodo = new Nodo(nuevoPaciente);
            Nodo actual = Cabeza;
            int contador = 0;

            while (actual != null && contador < posicion - 1)
            {
                actual = actual.Siguiente;
                contador++;
            }

            if (actual == null) return false; // Posición fuera de rango

            nuevoNodo.Siguiente = actual.Siguiente;
            actual.Siguiente = nuevoNodo;
            return true;
        }

        // Eliminar el primero de la lista (Paciente Atendido)
        public bool EliminarPrimero()
        {
            if (Cabeza == null) return false;
            Cabeza = Cabeza.Siguiente;
            return true;
        }

        // Buscar paciente por DNI
        public Paciente BuscarPorDNI(string dni)
        {
            Nodo actual = Cabeza;
            while (actual != null)
            {
                if (actual.Paciente.DNI == dni)
                {
                    return actual.Paciente;
                }
                actual = actual.Siguiente;
            }
            return null;
        }

        // Ordenar la lista por Hora de Llegada
        public void OrdenarPorHoraLlegada()
        {
            if (Cabeza == null || Cabeza.Siguiente == null) return;

            bool intercambiado;
            do
            {
                intercambiado = false;
                Nodo actual = Cabeza;
                Nodo siguiente = Cabeza.Siguiente;

                while (siguiente != null)
                {
                    if (actual.Paciente.HoraLlegada > siguiente.Paciente.HoraLlegada)
                    {
                        Paciente temp = actual.Paciente;
                        actual.Paciente = siguiente.Paciente;
                        siguiente.Paciente = temp;
                        intercambiado = true;
                    }
                    actual = siguiente;
                    siguiente = siguiente.Siguiente;
                }
            } while (intercambiado);
        }
    }
}