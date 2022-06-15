using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_CU36
{
    
    internal class CambioEstadoRT
    {
        private DateTime _fechaDesde;
        private DateTime? _fechaHasta;
        private Estado _estado;
        private CambioEstadoRT(DateTime fechaDesde,Estado estado)
        {
            _fechaDesde = fechaDesde;

            _estado = estado;
        }
        public bool esDisponible()
        {
            return _estado.esDisponible();
        }
    }
}
