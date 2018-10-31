using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mis_Coordenadas //MyCords
{
    public class Coordenada //Coord
    {
        public Double latitud { get; set; }
        public Double longitud { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            Console.WriteLine(" -----------------------------------------------------------------");
            Console.WriteLine("☺ Hola ☺, ingrese coordenadas (latitud, longitud) o x para salir:");
            Console.WriteLine(" -----------------------------------------------------------------");
            Console.WriteLine("Ejemplo: 12.3444,14.2333");
            List<Coordenada> coordenadas = new List<Coordenada>();
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
                Coordenada mi_coordenada = new Coordenada()
                {
                    latitud = Double.TryParse(entrar.Split(',')[0], out latitud) ? latitud:0,
                    longitud = Double.TryParse(entrar.Split(',')[1], out longitud) ? longitud : 0,
                };

                coordenadas.Add(mi_coordenada);


            }

            Console.WriteLine("Hasta luego... tu has ingresado: {0} coordenadas", coordenadas.Count);
            Console.ReadKey();
        }
    }
}
