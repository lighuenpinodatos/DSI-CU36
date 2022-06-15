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
        private TipoRecursoTecnologico _tipoRecursoTecnologico;
        private Mantenimiento? _mantenimiento;
        
        /*public CambioEstadoRT esDisponibleActual()
        {
            foreach (CambioEstadoRT cert in list)
            {
                if (cert.esFechaActual() && cert.esDisponible())
                {
                    return rt;
                }

            }
            return null;
        }*/
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

    }
}
