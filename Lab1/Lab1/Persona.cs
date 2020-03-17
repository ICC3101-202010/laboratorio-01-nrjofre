using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Persona
    {
        public string nombre;
        public string apellido;

        public void Lanzar()
        {
            var Random = new Random();
            var value = Random.Next(0, 3);
            Console.WriteLine(value);
        }

        //Constructor clase persona con atributos nombre y apellido
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
    }
}
