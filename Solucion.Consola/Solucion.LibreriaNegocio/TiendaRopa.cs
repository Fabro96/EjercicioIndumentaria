using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class TiendaRopa
    {
        //ATRIBUTOS
        private List<Indumentaria> _inventario;
        private List<Venta> _ventas;
        private int _ultimoCodigo;

        //CONSTRUCTORES
        public TiendaRopa()
        {
            this._inventario = new List<Indumentaria>();
            this._ventas = new List<Venta>();
            this._ultimoCodigo = 1;
   
        }

        //PROPIEDADES
        public List<Indumentaria> Inventario
        {
            get { return _inventario; }
        }
        public List<Venta> Ventas
        {
            get { return _ventas; }
        }
        public int UltimoCodigo
        {
            get { return _ultimoCodigo;  }
        }
        public bool TieneInventario
        {
            get { return Inventario.Count > 0; }
        }

        //MÉTODOS
        public int GetProximoCodigo()
        {
            return this._ultimoCodigo;
        }
        public void AgregarIndumentaria(int tipoIndumentariaElegida, int tipoPrenda, bool tieneBolsillo, string material, 
            bool tieneEstampado, string tipoManga, string talle, double precio, string origen, double porcentajeAlgodon)
        {
            Indumentaria indumentaria;
            TipoIndumentaria tipoIndumentaria;

            switch (tipoIndumentariaElegida)
            {
                case 1:
                    switch (tipoPrenda)
                    {
                        case 1:
                            tipoIndumentaria = new IndumentariaCasual(origen, porcentajeAlgodon);
                            indumentaria = new Pantalon(tieneBolsillo, material, GetProximoCodigo(), tipoIndumentaria, talle, precio);
                            break;
                        case 2:
                            tipoIndumentaria = new IndumentariaCasual(origen, porcentajeAlgodon);
                            indumentaria = new Camisa(tieneEstampado, tipoManga, GetProximoCodigo(), tipoIndumentaria, talle, precio);
                            break;
                        default:
                            throw new Exception("No existe este tipo de prenda.");
                    }
                    break;
                case 2:
                    switch (tipoPrenda)
                    {
                        case 1:
                            tipoIndumentaria = new IndumentariaFormal(origen, porcentajeAlgodon);
                            indumentaria = new Pantalon(tieneBolsillo, material, GetProximoCodigo(), tipoIndumentaria, talle, precio);
                            break;
                        case 2:
                            tipoIndumentaria = new IndumentariaFormal(origen, porcentajeAlgodon);
                            indumentaria = new Camisa(tieneEstampado, tipoManga, GetProximoCodigo(), tipoIndumentaria, talle, precio);
                            break;
                        default:
                            throw new Exception("No existe este tipo de prenda.");
                    }
                    break;
                case 3:
                    switch (tipoPrenda)
                    {
                        case 1:
                            tipoIndumentaria = new IndumentariaDeportiva(origen, porcentajeAlgodon);
                            indumentaria = new Pantalon(tieneBolsillo, material, GetProximoCodigo(), tipoIndumentaria, talle, precio);
                            break;
                        case 2:
                            tipoIndumentaria = new IndumentariaDeportiva(origen, porcentajeAlgodon);
                            indumentaria = new Pantalon(tieneBolsillo, material, GetProximoCodigo(), tipoIndumentaria, talle, precio);
                            break;
                        default:
                            throw new Exception("No existe este tipo de prenda.");
                    }
                    break;
                default:
                    throw new Exception("No existen ese tipo de indumentaria");
            }
            this._inventario.Add(indumentaria);
            this._ultimoCodigo = _ultimoCodigo + 1;
            

        }
        public void ModificarIndumentaria(Indumentaria indumentaria)
        {
            throw new NotImplementedException();
        }
        public void QuitarIndumentaria(int codigo)
        {
            Indumentaria indumentaria = this._inventario.SingleOrDefault(x => x.Codigo == codigo);

            if(indumentaria != null)
            {
                this._inventario.Remove(indumentaria);
            }
            else
            {
                throw new Exception("El Código no se encuentra en la lista.");
            }
        }
        public void IngresarOrden(Venta venta)
        {
            throw new NotImplementedException();
        }
        public List<Indumentaria> ListarIndumentaria()
        {

            return _inventario;
            
        }
        public List<Venta> ListarOrdenVenta()
        {
            throw new NotImplementedException();
        }
        public void DevolverOrdenVenta(Venta venta)
        {
            throw new NotImplementedException();
        }


    }
}
