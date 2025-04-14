using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PugaD_TallerMVC1.Models;
using PugaD_TallerMVC1.Repositories;

namespace PugaD_TallerMVC1.Controllers
{
    public class EquipoController : Controller
    {
        private static EquipoRepository _repository = new EquipoRepository();

        public ActionResult List()
        {
            var equipos = _repository.DevuelveListadoEquipos()
                                     .OrderBy(e => e.PartidosGanados)
                                     .ToList();
            return View(equipos);
        }

        public ActionResult Edit(int Id)
        {
            var equipo = _repository.DevuelveEquipoPorId(Id);
            return View(equipo);
        }

        [HttpPost]
        public ActionResult Edit(int Id, Equipo equipo)
        {
            try
            {
                _repository.ActualizarEquipo(Id, equipo);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View(equipo);
            }
        }
    }
}
