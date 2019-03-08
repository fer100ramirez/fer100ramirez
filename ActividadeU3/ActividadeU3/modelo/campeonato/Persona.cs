using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadeU3.modelo.campeonato
{
    class Persona
    {
        //Propiedades delequipo
        private int _id;
        private string _nombre;
        private DateTime _fechaNacimiento;
        private string _apellidos;

        //Método Getter´s y Setter's

        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Apellidos { get; set; }

    }
}
