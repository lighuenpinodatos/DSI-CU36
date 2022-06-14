using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_CU36
{
    internal class ListaUsuarios
    {
        private List<Usuario> list = new List<Usuario>();

        //Contructor
        public ListaUsuarios()
        {
            //list.Add(new Usuario(1,"Juan","1234"), new Usuario(2, "Hernesto", "1234"), new Usuario(13 ,"Gloria", "1234"));
       } 
        public Usuario getUsuario(int id)
        {
            foreach (Usuario u in list)
            {
                if (u.getID() == id)
                {
                    return u;
                }

            }
            return null;
        
        }
    }
}
