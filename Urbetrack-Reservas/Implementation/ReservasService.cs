using System.Collections.Generic;
using UrbetrackReservas.MockData;
using UrbetrackReservas.Models;
using UrbetrackReservas.Services;

namespace UrbetrackReservas.Implementation
{
    public class ReservasService : IReservasService
    {
        public ReservasService()
        {
        }

        public ReservaView GetIndexData()
        {
            ReservaView reservaView = new ReservaView(){
                Reservas= GetReservaList(),
                Salones= GetSalonesList()
            };
            return reservaView;
        }

        private List<Reserva> GetReservaList()
        {
            var mockReservasTabla = new MockReservasTabla();
            var result = mockReservasTabla.GetDataForTable();
            return result;
        }
        private List<Salon> GetSalonesList()
        {
            var mockSalones = new MockSalones();
            var result = mockSalones.GetSalones();
            return result;
        }
    }
}
