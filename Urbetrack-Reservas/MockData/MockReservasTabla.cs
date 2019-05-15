using System;
using System.Collections.Generic;
using UrbetrackReservas.Models;

namespace UrbetrackReservas.MockData
{
    public class MockReservasTabla
    {
        public MockReservasTabla()
        {
        }
        public List<Reserva> GetDataForTable()
        {
            List<Reserva> reservas = new List<Reserva>();
            Reserva reserva1 = new Reserva()
            {
                Id = 1,
                Nombre = "Jose Perez",
                Sala = "Sala 1",
                Fecha = DateTime.Today,
                TipoDeUso = "Reunion",
                CantDePersonas = 2
            };
            reservas.Add(reserva1);
            Reserva reserva2 = new Reserva()
            {
                Id = 2,
                Nombre = "Ana Martinez",
                Sala = "Sala 4",
                Fecha = DateTime.Today,
                TipoDeUso = "Charla de Tecnologia",
                CantDePersonas = 50
            };
            reservas.Add(reserva2);
            Reserva reserva3 = new Reserva()
            {
                Id = 3,
                Nombre = "Jose Hernandez",
                Sala = "Sala 5",
                Fecha = DateTime.Today,
                TipoDeUso = "Workshop",
                CantDePersonas = 5
            };
            reservas.Add(reserva3);

            return reservas;
        }
    }
}
