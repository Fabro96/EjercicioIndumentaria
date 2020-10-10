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
        private List<Indumentaria> _inventarios;
        private List<Venta> _ventas;
        private int _ultimoCodigo;

        //CONSTRUCTORES
        public TiendaRopa()
        {
            this._inventarios = new List<Indumentaria>();
            this._ventas = new List<Venta>();
            
        }

        //PROPIEDADES
        public List<Indumentaria> Inventario
        {
            get { return _inventarios; }
        }
        public List<Venta> Ventas
        {
            get { return _ventas; }
        }
        public int UltimoCodigo
        {
            get { return _ultimoCodigo; }
        }

        //MÉTODOS
        public int GetProximoCodigo()
        {
            throw new NotImplementedException();
        }
        public void AgregarIndumentaria(Indumentaria indumentaria)
        {
            throw new NotImplementedException();
        }
        public void ModificarIndumentaria(Indumentaria indumentaria)
        {
            throw new NotImplementedException();
        }
        public void QuitarIndumentaria(Indumentaria indumentaria)
        {
            throw new NotImplementedException();
        }
        public void IngresarOrden(Venta venta)
        {
            throw new NotImplementedException();
        }
        public List<Indumentaria> ListarIndumentaria()
        {
            throw new NotImplementedException();
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
