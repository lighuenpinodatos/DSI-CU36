﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_CU36.Entidades
{
    public class TipoRecursoTecnologico
    {
        private string _nombre;


        public TipoRecursoTecnologico(string nombre)
        {
            _nombre = nombre;
        }

        public string getNombre()
        {
            return _nombre;
        }
    }
}