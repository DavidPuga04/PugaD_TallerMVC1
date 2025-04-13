using PugaD_TallerMVC1.Models;

namespace PugaD_TallerMVC1.Repositories
{
    public class EquipoRepository
    {
        public IEnumerable<Equipo> Equipos;
        public EquipoRepository()
        {
            Equipos = DevuelveListadoEquipos();
        }
        public IEnumerable<Equipo> DevuelveListadoEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();

            Equipo ldu = new Equipo
            {
                Id = 1,
                Nombre = "Liga de Quito",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0
            };

            Equipo barcelona = new Equipo
            {
                Id = 2,
                Nombre = "Barcelona",
                PartidosJugados = 10,
                PartidosGanados = 8,
                PartidosEmpatados = 0,
                PartidosPerdidos = 2
            };

            Equipo emelec = new Equipo
            {
                Id = 3,
                Nombre = "Emelec",
                PartidosJugados = 10,
                PartidosGanados = 5,
                PartidosEmpatados = 0,
                PartidosPerdidos = 5
            };

            Equipo aucas = new Equipo
            {
                Id = 4,
                Nombre = "Aucas",
                PartidosJugados = 10,
                PartidosGanados = 2,
                PartidosEmpatados = 3,
                PartidosPerdidos = 5
            };

            Equipo delfin = new Equipo
            {
                Id = 5,
                Nombre = "Delfin",
                PartidosJugados = 10,
                PartidosGanados = 7,
                PartidosEmpatados = 1,
                PartidosPerdidos = 2
            };

            Equipo nacional = new Equipo
            {
                Id = 6,
                Nombre = "El Nacional",
                PartidosJugados = 10,
                PartidosGanados = 8,
                PartidosEmpatados = 1,
                PartidosPerdidos = 1
            };

            Equipo manta = new Equipo
            {
                Id = 7,
                Nombre = "Manta F.C",
                PartidosJugados = 10,
                PartidosGanados = 3,
                PartidosEmpatados = 5,
                PartidosPerdidos = 2
            };

            Equipo cuenca = new Equipo
            {
                Id = 8,
                Nombre = "Deportivo Cuenca",
                PartidosJugados = 10,
                PartidosGanados = 4,
                PartidosEmpatados = 0,
                PartidosPerdidos = 6
            };

            Equipo macara = new Equipo
            {
                Id = 9,
                Nombre = "Macará",
                PartidosJugados = 10,
                PartidosGanados = 5,
                PartidosEmpatados = 2,
                PartidosPerdidos = 3
            };

            Equipo valle = new Equipo
            {
                Id = 10,
                Nombre = "Independiente del Valle",
                PartidosJugados = 10,
                PartidosGanados = 6,
                PartidosEmpatados = 3,
                PartidosPerdidos = 1
            };


            equipos.Add(ldu);
            equipos.Add(barcelona);
            equipos.Add(emelec);
            equipos.Add(aucas);
            equipos.Add(delfin);
            equipos.Add(nacional);
            equipos.Add(manta);
            equipos.Add(cuenca);
            equipos.Add(macara);
            equipos.Add(valle);


            return equipos;
        }
        public Equipo DevuelveEquipoPorId(int Id)
        {
            var equipo = Equipos.First(item => item.Id == Id);
            return equipo;
        }

        public bool ActualizarEquipo(int Id, Equipo equipo)
        {
           //logica actualizacion
            return true;
        }
    }
}
