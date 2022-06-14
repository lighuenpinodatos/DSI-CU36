using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_CU36
{
    internal class Estado
    {
        private string _nombre;
        private string _ambito;
        Estado(string nombre, string ambito)
        {
            _nombre = nombre;
            _ambito = ambito;
        }
        public bool esDisponible()
        {
            if (_nombre == "disponible")
            {
                return true;
            }
            return false;
            
        }
    }
}
