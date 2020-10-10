using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class Camisa : Indumentaria
    {
        //ATRIBUTOS
        private bool _tieneEstampado;
        private string _tipoManga;

        //CONSTRUCTORES
        public Camisa(bool tieneEstampado, string tipoManga, int codigo, TipoIndumentaria tipoIndumentaria, string talle, double precio)
        {
            this._tieneEstampado = tieneEstampado;
            this._tipoManga = tipoManga;
            this._codigo = codigo;
            this._tipoIndumentaria = tipoIndumentaria;
            this._talle = talle;
            this._precio = precio;
        }

        //PROPIEDADES
        public bool TieneEstampado
        {
            set { _tieneEstampado = value; }
            get { return _tieneEstampado;  }
        }
        public string TieneManga
        {
            set { _tipoManga = value; }
            get { return _tipoManga;  }
        }

        //MÉTODOS
        public override string GetDetalle()
        {
            throw new NotImplementedException();
        }
    }
}
