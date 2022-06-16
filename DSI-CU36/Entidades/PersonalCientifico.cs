using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_CU36.Entidades
{

    public class PersonalCientifico
    {

        private string _legajo;
        private string _nombre;
        private string _apellido;
        private int _id;
        public PersonalCientifico(int id, string legajo, string nombre, string apellido)
        {
            _legajo = legajo;
            _id = id;
            _nombre = nombre;
            _apellido = apellido;
        }
        public string getNombre()
        {
            return _nombre;
        }
        public string getApellido()
        {
            return _apellido;
        }
        public string getLegajo()
        {
            return _legajo;
        }
    }
}
