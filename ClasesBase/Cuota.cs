using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Cuota
    {
        private int cuo_Codigo;

        public int Cuo_Codigo
        {
            get { return cuo_Codigo; }
            set { cuo_Codigo = value; }
        }
        private int pre_Numero;

        public int Pre_Numero
        {
            get { return pre_Numero; }
            set { pre_Numero = value; }
        }
        private int cuo_Numero;

        public int Cuo_Numero
        {
            get { return cuo_Numero; }
            set { cuo_Numero = value; }
        }
        private DateTime cuo_Vencimiento;

        public DateTime Cuo_Vencimiento
        {
            get { return cuo_Vencimiento; }
            set { cuo_Vencimiento = value; }
        }
        private decimal cuo_Importe;

        public decimal Cuo_Importe
        {
            get { return cuo_Importe; }
            set { cuo_Importe = value; }
        }
        private string cuo_Estado;

        public string Cuo_Estado
        {
            get { return cuo_Estado; }
            set { cuo_Estado = value; }
        }
    }
}
