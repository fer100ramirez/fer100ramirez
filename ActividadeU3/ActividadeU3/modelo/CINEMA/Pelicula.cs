using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadeU3.modelo.cinema
{
    class Pelicula
    {
        private int _id;
        private string _nombre;
        private string _director;
        private string _clasificacion;
        private string _resumen;

        public Pelicula()
        {
            _clasificacion = "A";
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Direcctor { get; set; }
        public string Clasificacion { get; set; }
        public string Resumen { get; set; }
    }
}
