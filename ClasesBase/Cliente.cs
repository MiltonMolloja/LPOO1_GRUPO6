using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Cliente
    {
        private string cli_Dni;

        public string Cli_Dni
        {
            get { return cli_Dni; }
            set { cli_Dni = value; }
        }
        private string cli_Nombre;

        public string Cli_Nombre
        {
            get { return cli_Nombre; }
            set { cli_Nombre = value; }
        }
        private string cli_Apellido;

        public string Cli_Apellido
        {
            get { return cli_Apellido; }
            set { cli_Apellido = value; }
        }
        private string cli_Sexo;

        public string Cli_Sexo
        {
            get { return cli_Sexo; }
            set { cli_Sexo = value; }
        }
        private DateTime cli_FechaNacimiento;

        public DateTime Cli_FechaNacimiento
        {
            get { return cli_FechaNacimiento; }
            set { cli_FechaNacimiento = value; }
        }
        private decimal cli_Ingresos;

        public decimal Cli_Ingresos
        {
            get { return cli_Ingresos; }
            set { cli_Ingresos = value; }
        }
        private string cli_Direccion;

        public string Cli_Direccion
        {
            get { return cli_Direccion; }
            set { cli_Direccion = value; }
        }
        private int cli_Telefono;

        public int Cli_Telefono
        {
            get { return cli_Telefono; }
            set { cli_Telefono = value; }
        }
    }
}
