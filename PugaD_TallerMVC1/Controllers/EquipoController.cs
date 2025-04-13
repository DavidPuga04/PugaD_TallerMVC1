using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PugaD_TallerMVC1.Models;
using PugaD_TallerMVC1.Repositories;

namespace PugaD_TallerMVC1.Controllers
{
    public class EquipoController : Controller
    {
        public EquipoRepository _repository;
        public EquipoController()
        {
            _repository = new EquipoRepository();
        }
        public ActionResult View()
        {
            return View();
        }
        public ActionResult List()
        {
            var equipos = _repository.DevuelveListadoEquipos();
            equipos = equipos.OrderBy(item => item.PartidosGanados);
            return View(equipos);
        }

        public ActionResult Create()
        {
            return View();
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
                //Proceso guardar 
                _repository.ActualizarEquipo(Id, equipo);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }
    }
}
