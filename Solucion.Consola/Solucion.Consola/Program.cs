using System;
using Solucion.LibreriaNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Solucion.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool _continuarActivo = true;

            TiendaRopa Lupo = new TiendaRopa();

            Console.WriteLine("BIENVENIDOS A LA TIENDA DE ROPA LUPO!\n\nIngrese una tecla para pasar al Menú Principal.");
            Console.ReadKey();

            do
            {
                Console.Clear();
                Console.WriteLine("MENÚ PRINCIPAL\n");
                Console.WriteLine("1 - REGISTRAR INDUMENTARIA\n" +
                                  "2 - MODIFICAR INDUMENTARIA\n" +
                                  "3 - QUITAR INDUMENTARIA\n" +
                                  "4 - LISTAR INDUMENTARIA\n" +
                                  "5 - INGRESAR ORDEN\n" +
                                  "6 - LISTAR ORDEN\n" +
                                  "7 - DEVOLVER ORDER\n" +
                                  "8 - EXIT\n");

                try
                {

                    int opcion = ConsolaHelper.OpcionMenu(1, 8, "Ingrese la opción en la que desee ingresar: ");
                    Console.Clear();

                    switch (opcion)
                    {
                        case 1:
                            Program.RegistrarIndumentaria(Lupo);
                            break;
                        case 2:
                            break;
                        case 3:
                            Program.QuitarIndumentaria(Lupo);
                            break;
                        case 4:
                            Program.ListarIndumentaria(Lupo);
                            break;
                        case 5:
                            break;
                        case 6:
                            break;
                        case 7:
                            break;
                        case 8:
                            Program.Exit();
                            _continuarActivo = false;
                            break;
                        default:
                            Console.WriteLine("Ha ingresado una opción inválida. Por favor, intentelo nuevamente.");
                            break;
                    }
                } catch (Exception ex)
                {
                    Console.WriteLine("Lo sentimos, hubo un error durante la ejecución. " + ex.Message);
                }
               
            } while (_continuarActivo);

        }
        public static void RegistrarIndumentaria(TiendaRopa Lupo)
        {
            try
            {
                
                Console.WriteLine("REGISTRACIÓN DE INDUMENTARIA\n");
                int tipoIndumentaria = ConsolaHelper.OpcionTipoIndumentaria(1, 3);
                int tipoPrenda = ConsolaHelper.OpcionTipoPrenda(1, 2);

                bool tieneBolsillo = false;
                string material = string.Empty;

                if (tipoPrenda == 1)
                {
                    tieneBolsillo = ConsolaHelper.TieneBolsillo(1, 2);
                    material = ConsolaHelper.Material();
                    
                }
                bool tieneEstampado = false;
                string tipoManga = string.Empty;

                if (tipoPrenda == 2)
                {
                    tieneEstampado = ConsolaHelper.TieneEstampado(1, 2);
                    tipoManga = ConsolaHelper.tipoManga();
                    
                }
                string talle = ConsolaHelper.PedirTalle();
                double precio = ConsolaHelper.PedirPrecio(0, 999999);
                string origen = ConsolaHelper.OrigenPrenda();
                double porcentajeAlgodon = ConsolaHelper.PorcentajeAlgodon(0, 100);

                
                Lupo.AgregarIndumentaria(tipoIndumentaria, tipoPrenda, tieneBolsillo, material,
                    tieneEstampado, tipoManga, talle, precio, origen, porcentajeAlgodon);

                Console.WriteLine("\nPrenda incorporada a la tienda!");

                Console.ReadKey();

            } catch (Exception ex)
            {
                Console.WriteLine("Lo sentimos, hubo un error durante la ejecución. " + ex.Message);
            }
            
        }
        public static void ModificarIndumentaria(TiendaRopa Lupo)
        {
            throw new NotImplementedException();
        }
        public static void QuitarIndumentaria(TiendaRopa Lupo)
        {
            try
            {
                if (Lupo.TieneInventario is true)
                {
                    Program.ListarIndumentaria(Lupo);
                    int codigo = ConsolaHelper.PedirCodigo(1, Lupo.GetProximoCodigo());
                    Lupo.QuitarIndumentaria(codigo);
                    Console.WriteLine("\nLa prenda ha sido eliminada.");

                }
                else
                {
                    throw new SinStockException("La tienda no tiene stock para eliminar.");
                }
            }
            catch (SinStockException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
        public static void ListarIndumentaria(TiendaRopa Lupo)
        {

            try
            {
                if (Lupo.TieneInventario is true)
                {
                    foreach (Indumentaria indumentaria in Lupo.Inventario)
                    {
                        Console.WriteLine(indumentaria.GetDetalle());
                    }   
                }
                else
                {
                    throw new SinStockException("No hay stock en la tienda.");
                }
            }
            catch (SinStockException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
        public static void IngresarOrden(TiendaRopa Lupo)
        {
            throw new NotImplementedException();
        }
        public static void ListarOrden(TiendaRopa Lupo)
        {
            throw new NotImplementedException();
        }
        public static void DevolverOrden(TiendaRopa Lupo)
        {
            throw new NotImplementedException();
        }
        public static void Exit()
        {
            Console.WriteLine("Gracias por haber usado la aplicación! Nos vemos la próxima :)");
            Console.WriteLine("\nIngrese una tecla y saldrá del sistema.");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
