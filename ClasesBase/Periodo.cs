using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Periodo
    {
        private int per_Codigo;

        public int Per_Codigo
        {
            get { return per_Codigo; }
            set { per_Codigo = value; }
        }
        private string per_Descripcion;

        public string Per_Descripcion
        {
            get { return per_Descripcion; }
            set { per_Descripcion = value; }
        }
    }
}
