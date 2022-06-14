using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_CU36
{
    internal class ListaAsignacionResponsableTecnicoRT
    {
        private List<AsignacionResponsableTecnicoRT> list = new List<AsignacionResponsableTecnicoRT>();
        
        public void addResposableRT(AsignacionResponsableTecnicoRT rt)
        {
            list.Add(rt);
        }
        public AsignacionResponsableTecnicoRT esDeUsuarioLogeadoYVigente(PersonalCientifico pc)
        {
            foreach(AsignacionResponsableTecnicoRT rt in list)
            {
                if (rt.getPersonalCientifico() == pc && rt.getfechaHasta()==null) {
                    return rt;
                }

            }return null;
        }


    }
}
