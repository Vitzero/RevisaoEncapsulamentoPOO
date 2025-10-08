using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoPooEncapsulamento.Models.Ex7
{
    internal class Estudante
    {
        public Estudante(string nome, double n1, double n2)
        {
            Nome = nome;
            this.n1 = n1;
            this.n2 = n2;
        }

        public string  Nome { get; set; }

        public double n1 { get; set; }
        public double n2 { get; set; }

        public double media { get => (n1 + n2) / 2; }

        public string situacao {
            get
            {
                return media >= 6.0 ? "Aprovado" : "Reprovado";
            }
        
        }

    }
}
