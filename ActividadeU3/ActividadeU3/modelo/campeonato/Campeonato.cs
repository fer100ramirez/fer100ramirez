using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadeU3.modelo.campeonato
{
    class Campeonato
    {
        private int _id;
        private string _nombre;
        private DateTime _fechaInicio;
        private DateTime _fechaTermino;
        private List<Jornada> _jornadas;

        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaTermino { get; set; }
        public List<Jornada> Jornadas { get; set; }
    }
}
