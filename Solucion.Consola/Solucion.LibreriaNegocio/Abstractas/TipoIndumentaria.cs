using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public abstract class TipoIndumentaria
    {
        //ATRIBUTOS
        protected string _origen;
        protected double _porcenjateAlgodon;

        //CONSTRUCTORES
        public TipoIndumentaria()
        {

        }
        public TipoIndumentaria(string origen, double porcentajeAlgondon)
        {
            this._origen = origen;
            this._porcenjateAlgodon = porcentajeAlgondon;
        }

        //PROPIEDADES
        public string Origen
        {
            set { _origen = value; }
            get { return _origen;  }
        }
        public double PorcentajeAlgodon
        {
            set { _porcenjateAlgodon = value; }
            get { return _porcenjateAlgodon; }
        }

        //MÉTODOS

    }
}
