using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_CU36
{
    public class CambioEstadoTurnoRT
    {
        private DateTime _fechaDesde;
        private DateTime? _fechaHasta;
        private Estado _estado;
        public CambioEstadoTurnoRT(DateTime _fechaDesde,DateTime? fechaHasta,Estado estado)
        {
            _fechaDesde = DateTime.Now;
            _fechaHasta = fechaHasta;
            _estado = estado;


        }
        public bool esCancelable()
        {
            return _estado.esCancelable();
        }
        public void  setFechaHasta(DateTime fechaHasta)
        {
            _fechaHasta = fechaHasta;
        }


    }
}
