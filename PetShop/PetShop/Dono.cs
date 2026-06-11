using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop
{
    internal class Dono
    {
        public string nomeDoDono;
        public float valorParaPagar;

        public Dono(string nomeDoDono, float valorParaPagar)
        {
            this.nomeDoDono = nomeDoDono;
            this.valorParaPagar = valorParaPagar;
        }
    }
}
