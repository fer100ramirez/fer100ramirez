using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadeU3.modelo.campeonato
{
    class Jornada
    {
        private int _id;
        private DateTime _fechaInicio;
        private DateTime _fechaTermino;
        private bool _isConcluida;

        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaTermino { get; set; }
        public bool IsConcluida { get; set; }
    }
}
