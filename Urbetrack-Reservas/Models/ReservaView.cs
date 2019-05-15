using System.Collections.Generic;

namespace UrbetrackReservas.Models
{
    public class ReservaView
    {
        public List<Reserva> Reservas { get; set; }
        public List<Salon> Salones { get; set; }
        public ReservaView()
        {
        }

        public ReservaView(List<Reserva> reservas, List<Salon> salones)
        {
            Reservas = reservas;
            Salones = salones;
        }
    }
}
