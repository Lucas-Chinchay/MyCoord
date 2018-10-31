using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCords
{
    public class Coord
    {
        public Double latitud { get; set; }
        public Double longitud { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            Console.WriteLine("Hola, ingresa coordenadas (latitud, longitud) o x para salir:");
            Console.WriteLine("Ejemplo: 12.3444,14.2333");
            List<Coord> cordinadas = new List<Coord>();
            while (continuar)
            {
                String input = Console.ReadLine();
                if (input.ToLower().Equals("x"))
                {
                    continuar = false;
                    continue;
                }
                if (input.Split(',').Length != 2)
                {
                    continue;
                }
                // todo lo que es correcto
                Double latitud;
                Double longitud;
                Coord mycoord = new Coord()
                {
                    latitud = Double.TryParse(input.Split(',')[0], out latitud) ? latitud:0,
                    longitud = Double.TryParse(input.Split(',')[1], out longitud) ? longitud : 0,
                };

                cordinadas.Add(mycoord);


            }

            Console.WriteLine("Good bye... tu has ingresado: {0} coordenadas", cordinadas.Count);
            Console.ReadKey();
        }
    }
}
