using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadeU3.modelo.campeonato
{
    class Arbitro:Persona
    {
        //Atributos
        private int _aniosExperiencia;
        private bool _tieneGafete;

        //Método Getter´s y Setter's

        public int AniosExperiencia { get; set; }
        public bool TieneGafete { get; set; }

    }
}
