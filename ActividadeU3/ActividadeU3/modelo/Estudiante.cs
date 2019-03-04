using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadeU3.modelo
{
    class Estudiante
    {
        public byte edad { get; set; }
        public string genero { get; set; }
        public string nombre { get; set; }
        public long numeroControl { get; set; }

        public void Estudiar(string texto)
        {
            //Método para estudiar
        }
        public void HacerTarea(string texto)
        {
            //Método que hace tarea
        }//Fin del método Hacer Tarea 

    }
}
