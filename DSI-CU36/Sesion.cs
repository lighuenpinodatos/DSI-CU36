using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_CU36
{
    internal class Sesion
    {
        private Usuario _u; // referencia al usuario
        private DateTime _fechaHoraInicio; 
        public Sesion(Usuario u)
        {
            _u = u;
            _fechaHoraInicio = DateTime.Now;
        }
        public PersonalCientifico mostrarCientificoLogueado()
        {
            return _u.obtenerCientifico();
        }
    }
}
