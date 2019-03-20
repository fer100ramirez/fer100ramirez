using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadeU3.modelo.cinema
{
    class Sala
    {
        private int _id;
        private string _nombre;
        private int _capacidad;
        private bool _estaLlena;

        private Asiento[] asientos = new Asiento[200];

        public Sala()
        {
            _nombre = "A";

            
            for (int i=0; i <= 199; i++)
            {
                asientos[i] = new Asiento();
                asientos[1] = new Asiento();
            }
            _capacidad = 200;
            _estaLlena = false;
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Capacidad { get; set; }
        public bool EstaLlena { get; set; }
    }
}
