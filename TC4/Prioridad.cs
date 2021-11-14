using System;
using System.Collections.Generic;
using System.Text;

namespace TC4
{
    class Prioridad
    {
        public void RecorrerCola(Nodo cabeza)
        {
            Console.WriteLine("Registro de pacientes:\n");
            Nodo temp = new Nodo();
            while (!isEmpty(cabeza))
            {
                Console.WriteLine(cabeza.dato.id + " = " + cabeza.dato.prioridad + " " + cabeza.dato.nombre + " " + cabeza.dato.apellido);
                temp = cabeza;
                cabeza = cabeza.next;
            }

        }

        public Nodo NewNodo(RegistroPaciente dato, int prioridad)
        {
            Nodo temp = new Nodo();
            temp.dato = dato;
            temp.dato.prioridad = prioridad;
            temp.next = null;
            return temp;
        }

        public Nodo push(Nodo cabeza, RegistroPaciente dato, int prioridad)
        {
            Nodo puntero = cabeza;
            Nodo temp = NewNodo(dato, prioridad);
            if (cabeza.dato.prioridad > prioridad)
            {
                temp.next = cabeza;
                cabeza = temp;
            }
            else
            {
                while (puntero.next != null && puntero.next.dato.prioridad < prioridad)
                {
                    puntero = puntero.next;
                }
                temp.next = puntero.next;
                puntero.next = temp;
            }
            return cabeza;
        }

        public bool isEmpty(Nodo cabeza)
        {
            if (cabeza == null) return true;
            return false;
        }

        public Nodo pop(Nodo cabeza)
        {
            Nodo temp = cabeza;
            (cabeza) = (cabeza).next;
            return cabeza;
        }
    }
}
