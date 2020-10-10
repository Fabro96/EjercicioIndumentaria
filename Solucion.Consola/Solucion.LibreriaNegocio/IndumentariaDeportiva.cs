using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class IndumentariaDeportiva : TipoIndumentaria
    {
        public IndumentariaDeportiva(string origen, double porcentajeAlgondon)
        {
            this._origen = origen;
            this._porcenjateAlgodon = porcentajeAlgondon;
        }
    }
}
