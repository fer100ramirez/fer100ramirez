using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadeU3.modelo
{
    class Estudiante
    {
        public string nombre;
        public byte edad;
        public char genero;
        public long numeroControl;
        public byte Edad { get; set; }
        public char Genero { get; set; }
        public string Nombre { get; set; }
        public long NumeroControl { get; set; }

        public void Estudiar(string tema)
        {
            //Método para estudiar
        }
        public void HacerTarea(string tema)
        {
            //Método que hace tarea
        }//Fin del método Hacer Tarea 

    }
}
