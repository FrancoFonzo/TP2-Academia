﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Especialidad : BusinessEntity
    {
        public string Descripcion { get; set; }

        // Para Bind a DataGridView
        public override string ToString()
        {
            return Descripcion;
        }

    }
}
