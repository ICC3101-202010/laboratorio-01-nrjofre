using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parte 1 Crear instancia en blanco para Persona (con parametros ya que al crear el constructor para la parte 2 tira error

            Persona p1 = new Persona("","");
            p1.Lanzar();

            //Parte 2 objeto Persona con atributos bob kunga
            Persona p2 = new Persona("Bob","Kunga");

            //para que la consola no se cierre :D
            Console.ReadLine();
        }
    }
}
