using Microsoft.AspNetCore.Mvc;
using UrbetrackReservas.Models;
using UrbetrackReservas.Services;

namespace UrbetrackReservas.Controllers
{
    public class ReservasController : Controller
    {
        IReservasService _reservasService;

        public ReservasController(IReservasService reservasService)
        {
            _reservasService = reservasService;
        }
        public IActionResult Index()
        {
            ReservaView reservaView = _reservasService.GetIndexData();
            return View(reservaView);
        }
    }
}
