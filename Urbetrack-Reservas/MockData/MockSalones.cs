using System.Collections.Generic;
using UrbetrackReservas.Models;

namespace UrbetrackReservas.MockData
{
    public class MockSalones
    {
        public MockSalones()
        {
        }
        public List<Salon> GetSalones()
        {
            List<Salon> salones = new List<Salon>();
            Salon salon1 = new Salon()
            {
                Id = 1,
                Nombre = "Sala 1",
                Tipo = "Reunion",
                Capacidad=3
            };
            salones.Add(salon1);
            Salon salon2 = new Salon()
            {
                Id = 2,
                Nombre = "Sala 2",
                Tipo = "Presentaciones",
                Capacidad = 10
            };
            salones.Add(salon2);
            Salon salon3 = new Salon()
            {
                Id = 3,
                Nombre = "Sala 3",
                Tipo = "Sin Escritorios",
                Capacidad = 15
            };
            salones.Add(salon3);
            Salon salon4 = new Salon()
            {
                Id = 4,
                Nombre = "Sala 4",
                Tipo = "Auditorio",
                Capacidad = 80
            };
            salones.Add(salon4);
            Salon salon5 = new Salon()
            {
                Id = 5,
                Nombre = "Sala 5",
                Tipo = "Con Computadoras",
                Capacidad = 7
            };
            salones.Add(salon5);
            return salones;
        }
    }
}
