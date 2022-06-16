using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_CU36
{
    public class Mantenimiento
    {
        private DateTime _fechaHoraInicio;
        private DateTime _fechaHoraFinPrevista;
        private DateTime? _fechaFin;
        private string _motivo;
        public Mantenimiento(DateTime fechaHoraFinPrevista, string motivo)
        {
            _fechaHoraInicio = DateTime.Now;
            _fechaHoraFinPrevista = fechaHoraFinPrevista;
            _motivo = motivo;
        }
    }
}
