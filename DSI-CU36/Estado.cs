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
        private bool _esCancelable;
        public Estado(string nombre, string ambito, bool esCancelable)
        {
            _nombre = nombre;
            _ambito = ambito;
            _esCancelable = esCancelable;
        }
        public bool esDisponible()
        {
            if (_nombre == "disponible")
            {
                return true;
            }
            return false;
            
        }
        //confirmado || pendienteConfirmasion
        public bool esCancelable()
        {
            
            
                return _esCancelable;
            
        }
   
    }
}
