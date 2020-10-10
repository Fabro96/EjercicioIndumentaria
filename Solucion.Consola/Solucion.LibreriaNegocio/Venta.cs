using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class Venta
    {
        //ATRIBUTOS
        private List<VentaItem> _ventaItems;
        private Cliente _cliente;
        private int _estado;
        private int _codigo;

        //CONSTRUCTORES
        public Venta()
        {

        }
        public Venta(Cliente cliente, int estado, int codigo)
        {
            this._ventaItems = new List<VentaItem>();
            this._cliente = cliente;
            this._estado = estado;
            this._codigo = codigo;
        }

        //PROPIEDADES
        public List<VentaItem> VentaItems
        {
            get { return _ventaItems; }
        }
        public Cliente Cliente
        {
            set { _cliente = value; }
            get { return _cliente;  }
        }
        public int Estado
        {
            set { _estado = value; }
            get { return _estado;  }
        }
        public int Codigo
        {
            set { _codigo = value; }
            get { return _codigo;  }
        }

        //MÉTODOS
        public double GetTotalPedido()
        {
            throw new NotFiniteNumberException();
        }
    }

}
