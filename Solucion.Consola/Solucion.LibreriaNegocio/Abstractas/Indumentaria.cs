using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public abstract class Indumentaria
    {
        //ATRIBUTOS
        protected TipoIndumentaria _tipoIndumentaria;
        protected int _codigo;
        protected int _stock;
        protected string _talle;
        protected double _precio;

        //CONSTRUCTORES
        public Indumentaria()
        {

        }
        public Indumentaria(int codigo, TipoIndumentaria tipoIndumentaria, string talle, double precio)
        {
            this._tipoIndumentaria = tipoIndumentaria;
            this._talle = talle;
            this._precio = precio;
            this._codigo = codigo;
        }

        //PRORIEDADES
        public TipoIndumentaria TipoIndumentaria
        {
            set { _tipoIndumentaria = value; }
            get { return _tipoIndumentaria; }
        }
        public int Codigo
        {
            set { _codigo = value; }
            get { return _codigo;  }
        }
        public int Stock
        {
            set { _stock = value; }
            get { return _stock; }
        }
        public string Talle
        {
            set { _talle = value; }
            get { return _talle;  }
        }
        public double Precio
        {
            set { _precio = value; }
            get { return _precio; }
        }

        //MÉTODOS
        public override string ToString()
        {
            return GetDetalle();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public abstract string GetDetalle();




    }
}
