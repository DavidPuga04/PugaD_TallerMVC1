using PugaD_TallerMVC1.Models;

namespace PugaD_TallerMVC1.Repositories
{
    public class EquipoRepository
    {
        public static List<Equipo> Equipos = new List<Equipo>
    {
        new Equipo { Id = 1, Nombre = "Liga de Quito", PartidosJugados = 10, PartidosGanados = 10, PartidosEmpatados = 0, PartidosPerdidos = 0 },
        new Equipo { Id = 2, Nombre = "Barcelona", PartidosJugados = 10, PartidosGanados = 8, PartidosEmpatados = 0, PartidosPerdidos = 2 },
        new Equipo { Id = 3, Nombre = "Emelec", PartidosJugados = 10, PartidosGanados = 5, PartidosEmpatados = 0, PartidosPerdidos = 5 },
        new Equipo { Id = 4, Nombre = "Aucas", PartidosJugados = 10, PartidosGanados = 2, PartidosEmpatados = 3, PartidosPerdidos = 5 },
        new Equipo { Id = 5, Nombre = "Delfin", PartidosJugados = 10, PartidosGanados = 7, PartidosEmpatados = 1, PartidosPerdidos = 2 },
        new Equipo { Id = 6, Nombre = "El Nacional", PartidosJugados = 10, PartidosGanados = 8, PartidosEmpatados = 1, PartidosPerdidos = 1 },
        new Equipo { Id = 7, Nombre = "Manta F.C", PartidosJugados = 10, PartidosGanados = 3, PartidosEmpatados = 5, PartidosPerdidos = 2 },
        new Equipo { Id = 8, Nombre = "Deportivo Cuenca", PartidosJugados = 10, PartidosGanados = 4, PartidosEmpatados = 0, PartidosPerdidos = 6 },
        new Equipo { Id = 9, Nombre = "Macará", PartidosJugados = 10, PartidosGanados = 5, PartidosEmpatados = 2, PartidosPerdidos = 3 },
        new Equipo { Id = 10, Nombre = "Independiente del Valle", PartidosJugados = 10, PartidosGanados = 6, PartidosEmpatados = 3, PartidosPerdidos = 1 }
    };

        public List<Equipo> DevuelveListadoEquipos()
        {
            return Equipos;
        }

        public Equipo DevuelveEquipoPorId(int Id)
        {
            return Equipos.FirstOrDefault(e => e.Id == Id);
        }

        public bool ActualizarEquipo(int Id, Equipo nuevo)
        {
            var existente = Equipos.FirstOrDefault(e => e.Id == Id);
            if (existente == null) return false;

            existente.Nombre = nuevo.Nombre;
            existente.PartidosJugados = nuevo.PartidosJugados;
            existente.PartidosGanados = nuevo.PartidosGanados;
            existente.PartidosEmpatados = nuevo.PartidosEmpatados;
            existente.PartidosPerdidos = nuevo.PartidosPerdidos;

            return true;
        }

    }
}
