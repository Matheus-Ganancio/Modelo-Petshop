using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop
{
    internal class Consulta
    {
        public DateOnly dia;
        public double horario;
        public string local;
        public float valorDaConsulta;

        public Consulta(DateOnly dia, double horario, string local, float valorDaConsulta)
        {
            this.dia = dia;
            this.horario = horario;
            this.local = local;
            this.valorDaConsulta = valorDaConsulta;
        }
    }
}
