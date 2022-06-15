using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_CU36
{
    internal class RecursoTecnologico
    {
        private int _nro;
        private Modelo _modelo;
        private ListaTurno _turnos;
        private ListaCambioEstadoRT _cambiosEstadoRT;
        private TipoRecursoTecnologico _tipoRecursoTecnologico;
        private Mantenimiento? _mantenimiento;
        
        
        public RecursoTecnologico(int numero, Modelo modelo, ListaTurno turnos, TipoRecursoTecnologico tipoRecursoTecnologico)
        {
            _nro = numero;
            _modelo = modelo;
            _turnos = turnos;
            _tipoRecursoTecnologico = tipoRecursoTecnologico;
        }
        public int getNumero()
        {
            return _nro;
        }
        public string obtenerMarca()
        {
            return _modelo.mostrarMarca();
        }
        public string getModelo()
        {
            return _modelo.mostrarNombre();
        } 
        public RecursoTecnologico? esDisponible()
        {
            // cambio de estado actual
            CambioEstadoRT cea = _cambiosEstadoRT.obtenerActual();
            if (cea.esDisponible()) { return this; }
            return null;
            
        }
        public ListaTurno obtenerTurnosCancelables(DateTime fechaFinPrevista)
        {
            return  
        }

    }
}
