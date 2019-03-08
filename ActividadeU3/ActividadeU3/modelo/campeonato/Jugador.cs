using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadeU3.modelo.campeonato
{
    class Jugador : Persona
    {
        //Atributo
        private string _equipo;
        private int _numero;
        private string _posicion;

        //Enlace con la clase Equipo
        private Equipo _equipe;

        //Método Getter´s y Setter's
        public int Numero { get; set; }
        public string Posicion { get; set; }
        public Equipo Equipe { get; set; }
    }
}
