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
                String entrar = Console.ReadLine();
                if (entrar.ToLower().Equals("x"))
                {
                    continuar = false;
                    continue;
                }
                if (entrar.Split(',').Length != 2)
                {
                    continue;
                }
                // todo lo que es correcto
                Double latitud;
                Double longitud;
                Coord mi_cordinada = new Coord()
                {
                    latitud = Double.TryParse(entrar.Split(',')[0], out latitud) ? latitud:0,
                    longitud = Double.TryParse(entrar.Split(',')[1], out longitud) ? longitud : 0,
                };

                cordinadas.Add(mi_cordinada);


            }

            Console.WriteLine("A dios... tu has ingresado: {0} coordenadas", cordinadas.Count);
            Console.ReadKey();
        }
    }
}
