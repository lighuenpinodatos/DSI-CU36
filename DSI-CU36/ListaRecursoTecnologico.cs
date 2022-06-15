using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_CU36
{
    
    internal class ListaRecursoTecnologico
    {

        public List<RecursoTecnologico> list = new List<RecursoTecnologico>();
        

        public void Agregar(RecursoTecnologico rt)
        {
            list.Add(rt);
        }
        public ListaRecursoTecnologico esDisponible()
        {
            ListaRecursoTecnologico lrdiponibles= new ListaRecursoTecnologico();
            foreach (RecursoTecnologico rt in list) {
                var refRt = rt.esDisponible();
                if (refRt != null)
                {
                    lrdiponibles.Agregar(refRt);
                }
                
            }
            return lrdiponibles;
        }



    }
}
