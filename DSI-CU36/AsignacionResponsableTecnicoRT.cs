using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_CU36
{
   internal class AsignacionResponsableTecnicoRT
    {
        private DateTime _fechaDesde;
        private DateTime? _fechaHasta;

        private ListaRecursoTecnologico list;
        private PersonalCientifico _pc; // asosiacion con personal cientifico
        public AsignacionResponsableTecnicoRT(PersonalCientifico _pc, DateTime fechaDesde)
        {
            _fechaDesde = DateTime.Now;
        }
        public void inabilitar()
        {
            _fechaHasta = DateTime.Now;
        }
        public DateTime? getfechaHasta()
        {
            return _fechaHasta;
        }
        public PersonalCientifico getPersonalCientifico()
        {
            return _pc;
        }
        public ListaRecursoTecnologico busacarRecursosDisponibles()
        {
            
           return list.esDisponible();
        }
    }
}
