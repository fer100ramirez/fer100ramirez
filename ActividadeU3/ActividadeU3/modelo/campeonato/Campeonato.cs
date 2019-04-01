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
        public Campeonato()
        {
            _id = 1;
        }
        public Campeonato(string nombre)
        {
            _nombre = nombre;
        }
        public Campeonato(string nombre, DateTime fechaInicio, DateTime fechaFin)
        {
            _nombre = nombre;
            _fechaInicio = fechaInicio;
            _fechaTermino = fechaFin;
        }
        public DateTime FechaTermino
        {
            get
            {
                return _fechaTermino;
            }
            set
            {
               
                if (value > DateTime.Today)
                    _fechaTermino = value;
            }
        }        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value > 0)
                    _id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 50)
                    _nombre = value;
            }
        }
        public DateTime FechaInicio
        {
            get
            {
                return _fechaInicio;
            }
            set
            {
                if (value > DateTime.Today)
                    _fechaInicio = value;
            }
        }
    }
    


        /*public override string ToString()
        {
            return _id + "|" + _fechaInicio.ToString("dd/MM/yyyy") + "|" + _fechaTermino.ToString("dd/MM/yyyy");
        }*/
    }

