using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class IndumentariaFormal : TipoIndumentaria
    {
        public IndumentariaFormal(string origen, double porcentajeAlgondon)
        {
            this._origen = origen;
            this._porcenjateAlgodon = porcentajeAlgondon;
        }
    }
}
