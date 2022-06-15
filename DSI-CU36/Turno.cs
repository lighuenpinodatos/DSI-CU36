using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_CU36
{
    internal class Turno
    {
        private DateTime _fechaHoraInicio;
        private DateTime _fechaHoraFin;
        private ListaCambioEstadoTurnoRT _lcert;
        private PersonalCientifico _pc;
        public Turno(DateTime fechaHoraInicio, DateTime fechaHoraFin,ListaCambioEstadoTurnoRT lcert, PersonalCientifico pc)
        {
            _fechaHoraInicio = fechaHoraInicio;
            _fechaHoraFin = fechaHoraFin;
            _lcert = lcert;
            _pc = pc;   
        }
        public PersonalCientifico obtenerPersonalCientifico()
        {
            return _pc;
        }


    }
}
