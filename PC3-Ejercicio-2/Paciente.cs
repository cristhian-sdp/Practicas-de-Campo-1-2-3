namespace PC3_Ejercicio_2
{
    /// Representa a una mascota y su dueño en la cola de atención.
    public class Paciente
    {
        public string NombreMascota { get; set; }
        public string NombreDueno { get; set; }

        public Paciente(string mascota, string dueno)
        {
            NombreMascota = mascota;
            NombreDueno = dueno;
        }

        public override string ToString()
        {
            return $"{NombreMascota}  —  Dueño: {NombreDueno}";
        }
    }
}