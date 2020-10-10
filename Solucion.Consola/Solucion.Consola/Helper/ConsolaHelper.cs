using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.Consola
{
    public static class ConsolaHelper
    {
        public static int OpcionMenu(int min, int max, string msj)
        {
            int res;
            Console.WriteLine(msj);
            do
            {
                if (!int.TryParse(Console.ReadLine(), out res))
                {
                    Console.WriteLine("\nIngrese una opción válida por favor.");
                    res = -1;
                }
            } while (res < min || res > max);
            return res;
        }
        public static int OpcionTipoIndumentaria(int min, int max)
        {
            int res;
            Console.WriteLine("\nIngrese el Tipo de Indumentaria que desea registrar\n" +
                              "1 - Casual\n" +
                              "2 - Formal\n" +
                              "3 - Deportiva\n");
            do
            {
                if (!int.TryParse(Console.ReadLine(), out res))
                {
                    Console.WriteLine("\nIngrese una opción válida por favor.");
                    res = -1;
                }
            } while (res < min || res > max);
            return res;
        }
        public static int OpcionTipoPrenda(int min, int max)
        {
            int res;
            Console.WriteLine("\nIngrese el Tipo de Prenda que desea registrar\n" +
                              "1 - Pantalon\n" +
                              "2 - Camisa\n");
            do
            {
                if (!int.TryParse(Console.ReadLine(), out res))
                {
                    Console.WriteLine("\nIngrese una opción válida por favor.");
                    res = -1;
                }
            } while (res < min || res > max);
            return res;
        }
        public static string OrigenPrenda()
        {
            string s;
            Console.WriteLine("\nIngrese el País de Origen de la prenda: ");
            Regex expresion = new Regex("^[a-zA-Z]+$");
            s = Console.ReadLine();
            while (!expresion.IsMatch(s))
            {
                Console.WriteLine("\nIntentelo Nuevamente");
                s = Console.ReadLine();
            }

            return s.ToUpper() ;
        }
        public static double PorcentajeAlgodon(double min, double max)
        {
            double res;
            Console.WriteLine("\nIngrese el % de Algodón que contiene la prenda: ");
            do
            {
                if (!double.TryParse(Console.ReadLine(), out res))
                {
                    Console.WriteLine("\nIngrese un porcentaje entre 0 y 100 por favor.");
                    res = -1;
                }
            } while (res < min || res > max);
            return res;
        }
        public static string PedirTalle()
        {
            string s;
            Console.WriteLine("\nIngrese el tipo de Manga (Ej. S, M, L)");
            Regex expresion = new Regex("^[a-zA-Z]+$");
            s = Console.ReadLine();
            while (!expresion.IsMatch(s))
            {
                Console.WriteLine("\nIntentelo Nuevamente");
                s = Console.ReadLine();
            }

            return s.ToUpper() ;
        }
        public static double PedirPrecio(double min, double max)
        {
            double res;
            Console.WriteLine("\nIngrese el precio de la prenda que está registrando: ");
            do
            {
                if (!double.TryParse(Console.ReadLine(), out res))
                {
                    Console.WriteLine("\nIngrese un precio válido por favor.");
                    res = -1;
                }
            } while (res < min || res > max);
            return res;
        }
        public static bool TieneBolsillo(int min, int max)
        {
            int res;
            bool respuesta = false;
            Console.WriteLine("\n¿El pantalón tiene bolsillos? (1 - SI / 2 -NO)");
            do
            {
                if (!int.TryParse(Console.ReadLine(), out res))
                {
                    Console.WriteLine("\nIngrese una opción válida por favor.");
                    res = -1;
                }
            } while (res < min || res > max);
            
            if(res == 1)
            {
                respuesta = true;
            }
            
            return respuesta;
        }
        public static string Material()
        {
            string s;
            Console.WriteLine("\nIngrese el material del pantalón");
            Regex expresion = new Regex("^[a-zA-Z]+$");
            s = Console.ReadLine();
            while (!expresion.IsMatch(s))
            {
                Console.WriteLine("\nIntentelo Nuevamente");
                s = Console.ReadLine();
            }

            return s.ToUpper();
        }
        public static bool TieneEstampado(int min, int max)
        {
            int res;
            bool respuesta = false;
            Console.WriteLine("\n¿La camisa tiene estampado? (1 - SI / 2 -NO)");
            do
            {
                if (!int.TryParse(Console.ReadLine(), out res))
                {
                    Console.WriteLine("\nIngrese una opción válida por favor.");
                    res = -1;
                }
            } while (res < min || res > max);
            
            if(res == 1)
            {
                respuesta = true;
            }

            return respuesta;
        }
        public static string tipoManga()
        {
            string s;
            Console.WriteLine("\nIngrese el tipo de Manga (Ej. Corta, Larga)");
            Regex expresion = new Regex("^[a-zA-Z]+$");
            s = Console.ReadLine();
            while (!expresion.IsMatch(s))
            {
                Console.WriteLine("\nIntentelo Nuevamente");
                s = Console.ReadLine();
            }

            return s.ToUpper();
        }
    }
}