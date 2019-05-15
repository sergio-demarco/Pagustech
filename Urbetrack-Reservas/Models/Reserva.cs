using System;

namespace UrbetrackReservas.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Sala { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoDeUso { get; set; }
        public int CantDePersonas { get; set; }

        public Reserva(Reserva reserva)
        {
            Id = reserva.Id;
            Nombre = reserva.Nombre;
            Sala = reserva.Sala;
            Fecha = reserva.Fecha;
            TipoDeUso = reserva.TipoDeUso;
            CantDePersonas = reserva.CantDePersonas;
        }

        public Reserva()
        {
        }
    }
}
