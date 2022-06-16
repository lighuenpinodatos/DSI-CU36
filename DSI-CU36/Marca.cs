using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_CU36
{
    public class Marca
    {

        private string _nombre;


        public Marca(string nombre)
        {
            _nombre = nombre;
        }

        public string getNombre()
        {
            return _nombre;
        }
    }
}
