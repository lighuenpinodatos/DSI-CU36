using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_CU36
{
    
    public class PersonalCientifico
    {

        private string _legajo;
        private string _nombre;
        private int _id;
        public PersonalCientifico(int id,string legajo, string nombre) {
            _legajo = legajo;
            _id = id;
            _nombre = nombre;
        }
        public string getNombre()
        {
            return _nombre;
        } 
    }
}
