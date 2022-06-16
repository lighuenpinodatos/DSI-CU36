using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_CU36
{
    internal class ListaTurno
    {
        private List<Turno> list = new List<Turno>();


        //Agregar::

        public void agregar(Turno turno)
        {
            list.Add(turno);
        }
        
        
        // Obtener actual (ultimo)
        public Turno obtenerActual()
        {
            return list[list.Count - 1];
        }
        /*
 //armamos la lista de turnos para un recurso tecnologico
-ListaTurnos [ListaTurnos] obtenerTurnosCancelables(fechaFinPrevista) Foreach {

 */
        public ListaTurno obtenerTurnosCancelables(DateTime fechaFinPrevista)
        {

            ListaTurno turnosCancelables = new ListaTurno();
            foreach (Turno turno in list)
            {
                var refTurno = turno.esCalcelable(fechaFinPrevista);
                if (refTurno)
                {
                    turnosCancelables.agregar(turno);
                }

            }
            return turnosCancelables;
        }

    }
}
