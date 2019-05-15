using NUnit.Framework;
using UrbetrackReservas.Implementation;
using UrbetrackReservas.Models;

namespace Urbetrack_ReservasTest

{
    public class ReservasServiceTest
    {
        [Test]
        public void CanGetMockDataFromService()
        {
            // Arrange
            ReservasService reservasService = new ReservasService();
            //Act
            ReservaView reservaView = reservasService.GetIndexData();
            // Assert
            Assert.AreNotEqual(reservaView, Is.Null);
        }
    }
}
