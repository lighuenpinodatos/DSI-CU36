using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_CU36.Entidades
{

    public class CambioEstadoRT
    {
        private DateTime _fechaDesde;
        private DateTime? _fechaHasta;
        private Estado _estado;
        public CambioEstadoRT(DateTime fechaDesde, DateTime? fechaHasta, Estado estado)
        {
            _fechaDesde = fechaDesde;
            _fechaHasta = fechaHasta;
            _estado = estado;


        }
        public bool esDisponible()
        {
            return _estado.esDisponible();
        }
    }
}
