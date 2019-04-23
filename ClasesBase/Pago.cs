using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Pago
    {
        private int pag_Codigo;

        public int Pag_Codigo
        {
            get { return pag_Codigo; }
            set { pag_Codigo = value; }
        }
        private int cuo_Codigo;

        public int Cuo_Codigo
        {
            get { return cuo_Codigo; }
            set { cuo_Codigo = value; }
        }
        private DateTime pag_Fecha;

        public DateTime Pag_Fecha
        {
            get { return pag_Fecha; }
            set { pag_Fecha = value; }
        }
        private decimal pag_Importe;

        public decimal Pag_Importe
        {
            get { return pag_Importe; }
            set { pag_Importe = value; }
        }
    }
}
