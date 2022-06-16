using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_CU36
{

    public class ListaCambioEstadoRT
    {
        private List<CambioEstadoRT> list = new List<CambioEstadoRT>();
        
        public void agregar(CambioEstadoRT cert)
        {
            list.Add(cert);
        }
        public CambioEstadoRT obtenerActual()
        {
            return list[list.Count - 1];
        }
    }
}
