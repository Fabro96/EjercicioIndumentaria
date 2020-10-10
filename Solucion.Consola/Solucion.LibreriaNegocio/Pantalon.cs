using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class Pantalon : Indumentaria
    {
        //ATRIBUTOS
        private bool _tieneBolsillo;
        private string _material;

        //CONSTRUCTORES
        public Pantalon(bool tieneBolsillo, string material, int codigo, TipoIndumentaria tipoIndumentaria, string talle, double precio)
        {
            this._tieneBolsillo = tieneBolsillo;
            this._material = material;
            this._codigo = codigo;
            this._tipoIndumentaria = tipoIndumentaria;
            this._talle = talle;
            this._precio = precio;
        }

        //PROPIEDADES
        public bool TieneBolsillo
        {
            set { _tieneBolsillo = value; }
            get { return _tieneBolsillo; }
        }
        public string Material
        {
            set { _material = value; }
            get { return _material; }
        }

        //MÉTODOS
        public override string GetDetalle()
        {
            return string.Format("{0} - {1 } {2} {3} $ {4}", this._codigo, this._tieneBolsillo, this._material ,this._talle, this._precio); ;
        }
    }
}
