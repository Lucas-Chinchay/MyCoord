using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCords
{
    public class Coord
    {
        public Double latitude { get; set; }
        public Double longitude { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool toContinue = true;

            Console.WriteLine("Hola, ingresa coordenadas (latitud, longitud) o x para salir:");
            Console.WriteLine("Ejemplo: 12.3444,14.2333");
            List<Coord> coordinates = new List<Coord>();
            while (toContinue)
            {
                String input = Console.ReadLine();
                if (input.ToLower().Equals("x"))
                {
                    toContinue = false;
                    continue;
                }
                if (input.Split(',').Length != 2)
                {
                    continue;
                }
                // todo lo que es correcto
                Double latitude;
                Double longitude;
                Coord mycoord = new Coord()
                {
                    latitude = Double.TryParse(input.Split(',')[0], out latitude) ? latitude:0,
                    longitude = Double.TryParse(input.Split(',')[1], out longitude) ? longitude : 0,
                };

                coordinates.Add(mycoord);


            }

            Console.WriteLine("Good bye... tu has ingresado: {0} coordenadas", coordinates.Count);
            Console.ReadKey();
        }
    }
}
