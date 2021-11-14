using System;
using System.Collections.Generic;
using System.Text;

namespace TC4
{
    class RegistroPaciente
    {
        public string nombre, apellido;
        public int id, prioridad;

        public RegistroPaciente(int id, int prioridad, string nombre, string apellido)
        {
            this.id = id;
            this.prioridad = prioridad;
             this.nombre = nombre;
            this.apellido = apellido;            
        }
    }
}
