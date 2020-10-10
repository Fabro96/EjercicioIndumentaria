using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class Cliente
    {
        //ATRIBUTOS
        private int _codigo;
        private string _apellido;
        private string _nombre;

        //CONSTRUCTORES
        public Cliente()
        {

        }
        public Cliente(int codigo, string apellido, string nombre)
        {
            this._codigo = codigo;
            this._apellido = apellido;
            this._nombre = nombre;
        }

        //PROPIEDADES
        public int Codigo
        {
            set { _codigo = value; }
            get { return _codigo;  }
        }
        public string Apellido
        {
            set { _apellido = value; }
            get { return _apellido;  }
        }
        public string Nombre
        {
            set { _nombre = value; }
            get { return _nombre;  }
        }

        //MÉTODOS
        

    }
}
