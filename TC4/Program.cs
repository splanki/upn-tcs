using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC4
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistroPaciente estudiante1 = new RegistroPaciente(1250, 1, "Roberto", "Rodriguez");
            RegistroPaciente estudiante2 = new RegistroPaciente(2365, 2, "Angelica", "Delgado");
            RegistroPaciente estudiante3 = new RegistroPaciente(1240, 3, "Jimena", "Jimenez");
            RegistroPaciente estudiante4 = new RegistroPaciente(8904, 4, "Carlos", "Perez");
            RegistroPaciente estudiante5 = new RegistroPaciente(7592, 5, "Mario", "Aquiles");

            Nodo cola = null;
            Prioridad lista = new Prioridad();

            Console.WriteLine("Registro de pacientes *Yuki Consulting*");

            Console.WriteLine("\n*Prioridad de pacientes según llegada normal*");
            cola = lista.NewNodo(estudiante1, estudiante1.prioridad);
            cola = lista.push(cola, estudiante2, estudiante2.prioridad);
            cola = lista.push(cola, estudiante3, estudiante3.prioridad);
            cola = lista.push(cola, estudiante4, estudiante4.prioridad);
            cola = lista.push(cola, estudiante5, estudiante5.prioridad);
            lista.RecorrerCola(cola);

            Console.WriteLine("\n*Procesando 2 pacientes*");
            cola = lista.pop(cola);
            cola = lista .pop(cola);
            lista.RecorrerCola(cola);

            Console.WriteLine("\n*Registrando nuevo paciente: -Reynaldo Molleda-*\n");
            RegistroPaciente estudiante0 = new RegistroPaciente(4566, 0 , "Reynaldo", "Molleda");
            cola = lista.push(cola, estudiante0, estudiante0.prioridad);
            Console.WriteLine("Asignar prioridad: " + estudiante0.id + " " + estudiante0.nombre + " " + estudiante0.apellido + "\n");
            lista.RecorrerCola(cola);

            Console.WriteLine("\n*Procesando 2 pacientes*");
            cola = lista.pop(cola);
            cola = lista.pop(cola);
            lista.RecorrerCola(cola);
            Console.ReadKey();
        }
    }
}
