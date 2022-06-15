using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_CU36
{
    internal class CambioEstadoTurnoRT
    {
        private DateTime _fechaDesde;
        private DateTime? _fechaHasta;
        //private Estado _estado;
        public CambioEstadoTurnoRT(DateTime? fechaHasta=null)
        {
            _fechaDesde = DateTime.Now;


        }


    }
}
