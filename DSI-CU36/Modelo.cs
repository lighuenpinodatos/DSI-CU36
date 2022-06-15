using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_CU36
{
    internal class Modelo
    {
        private string _nombre;
        private Marca _marca;


        public Modelo(string nombre, Marca marca)
        {
            _nombre = nombre;
            _marca = marca;
        }

        public string mostrarNombre()
        {
            return _nombre;
        }
        public string mostrarMarca()
        {
            return _marca.getNombre();
        }
    }
}
