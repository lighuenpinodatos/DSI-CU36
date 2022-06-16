using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_CU36.Entidades
{
    public class Usuario
    {
        private int _id;
        private string _nombre;
        private string _clave;
        private bool _habilitado;
        private PersonalCientifico _pc;
        public int getID()
        {
            return _id;


        }
        public Usuario(int id, string nombre, string clave, PersonalCientifico pc)
        {
            _id = id;
            _nombre = nombre;
            _clave = clave;
            _habilitado = true;
            _pc = pc;
        }
        public PersonalCientifico obtenerCientifico()
        {
            return _pc;
        }

    }
}
