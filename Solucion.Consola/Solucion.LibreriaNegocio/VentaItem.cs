using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class VentaItem
    {
        //ATRIBUTOS
        private Indumentaria _prenda;
        private int _cantidad;

        //CONSTRUCTORES
        public VentaItem()
        {

        }
        public VentaItem(Indumentaria prenda, int cantidad)
        {
            this._prenda = prenda;
            this._cantidad = cantidad;
        }

        //PROPIEDADES
        public Indumentaria Prenda
        {
            set { _prenda = value; }
            get { return _prenda;  }
        }
        public int Cantidad
        {
            set { _cantidad = value; }
            get { return _cantidad;  }
        }

        //MÉTODOS
        public double GetTotal()
        {
            throw new NotImplementedException();
        }
    }
}
