using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Prestamo
    {
        private int pre_Numero;

        public int Pre_Numero
        {
            get { return pre_Numero; }
            set { pre_Numero = value; }
        }
        private int cli_Dni;

        public int Cli_Dni
        {
            get { return cli_Dni; }
            set { cli_Dni = value; }
        }
        private int des_Codigo;

        public int Des_Codigo
        {
            get { return des_Codigo; }
            set { des_Codigo = value; }
        }
        private int pre_Codigo;

        public int Pre_Codigo
        {
            get { return pre_Codigo; }
            set { pre_Codigo = value; }
        }
        private DateTime pre_Fecha;

        public DateTime Pre_Fecha1
        {
            get { return pre_Fecha; }
            set { pre_Fecha = value; }
        }

        public DateTime Pre_Fecha
        {
            get { return pre_Fecha; }
            set { pre_Fecha = value; }
        }
        private decimal pre_Importe;

        public decimal Pre_Importe
        {
            get { return pre_Importe; }
            set { pre_Importe = value; }
        }
        private double pre_TasaInteres;

        public double Pre_TasaInteres
        {
            get { return pre_TasaInteres; }
            set { pre_TasaInteres = value; }
        }
        private int pre_CantidadCuotas;

        public int Pre_CantidadCuotas
        {
            get { return pre_CantidadCuotas; }
            set { pre_CantidadCuotas = value; }
        }
        private string pre_Estado;

        public string Pre_Estado
        {
            get { return pre_Estado; }
            set { pre_Estado = value; }
        }
    }
}
