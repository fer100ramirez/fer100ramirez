using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadeU3.modelo.cinema
{
    class Cartelera
    {
        private int _id;
        private DateTime _fecha;
        private string _horario;
        private string _tipo;
        private double _costo;

        public Cartelera()
        {
            _tipo = "3D";
        }
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Horario { get; set; }
        public string Tipo { get; set; }
        public double Costo { get; set; }
    }
}
