using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_CU36
{
   public class AsignacionResponsableTecnicoRT
    {
        private DateTime _fechaDesde;
        private DateTime? _fechaHasta;

        private ListaRecursoTecnologico _list;
        private PersonalCientifico _pc; // asosiacion con personal cientifico
        public AsignacionResponsableTecnicoRT(PersonalCientifico _pc, DateTime fechaDesde,ListaRecursoTecnologico list)
        {
            _fechaDesde = DateTime.Now;
            _list = list;
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
            
           return _list.esDisponible();
        }
    }
}
