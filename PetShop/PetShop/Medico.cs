using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop
{
    internal class Medico
    {

        public string nomeDoMedico;
        public DateOnly DiasDisponiveis;
        public double horario;

        public Medico(string nomeDoMedico, DateOnly diasDisponiveis, double horario)
        {
            this.nomeDoMedico = nomeDoMedico;
            DiasDisponiveis = diasDisponiveis;
            this.horario = horario;
        }
    }
}
