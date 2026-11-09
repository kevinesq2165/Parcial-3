using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var persona = new
            {
                Nombre = "Kevin Esquivel",
                Edad = 21,
                Carrera = "Ingeniería en Sistemas"

            };
            String json=
            JsonConvert.SerializeObject(persona);
            Console.WriteLine(json);
            
        }

    }

}
