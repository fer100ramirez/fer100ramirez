using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadeU3.modelo.cinema
{
    class Reservacion
    {
        private DateTime _fecha;
        private string _numeroTarjeta;

        private Asiento[] asientos = new Asiento[200];
        public Reservacion()
        {
            _fecha = DateTime.Today;

            for (int i = 0; i <= 199; i++)
            {
                asientos[i] = new Asiento();
                asientos[1] = new Asiento();
            }
        }

        public DateTime Fecha { get; set; }
        public string NumeroTarjeta { get; set; }
    }
}
