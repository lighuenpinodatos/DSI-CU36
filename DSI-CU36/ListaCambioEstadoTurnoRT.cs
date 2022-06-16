using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_CU36
{
    public class ListaCambioEstadoTurnoRT
    {
        private List<CambioEstadoTurnoRT> list = new List<CambioEstadoTurnoRT>();


        public CambioEstadoTurnoRT obtenerActual()
        {
            return list[list.Count -1];
        }
        public void agregar(CambioEstadoTurnoRT ceturnort)
        {
            list.Add(ceturnort);
        }
    }

}
