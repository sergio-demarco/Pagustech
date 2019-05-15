using System;
namespace UrbetrackReservas.Models
{
    public class Salon
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Tipo { get; set; }
        public int Capacidad { get; set; }
        public Salon()
        {
        }

        public Salon(int id, string nombre, string tipo, int capacidad)
        {
            Id = id;
            Nombre = nombre;
            Tipo = tipo;
            Capacidad = capacidad;
        }
    }
}
