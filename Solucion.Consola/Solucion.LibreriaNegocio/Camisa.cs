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
        private string _tieneManga;

        //CONSTRUCTORES
        public Camisa() : base()
        {

        }
        public Camisa(bool tieneEstampado, string tieneManga)
        {
            this._tieneEstampado = tieneEstampado;
            this._tieneManga = tieneManga;
        }

        //PROPIEDADES
        public bool TieneEstampado
        {
            set { _tieneEstampado = value; }
            get { return _tieneEstampado;  }
        }
        public string TieneManga
        {
            set { _tieneManga = value; }
            get { return _tieneManga;  }
        }

        //MÉTODOS
        public override string GetDetalle()
        {
            throw new NotImplementedException();
        }
    }
}
