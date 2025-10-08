using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoPooEncapsulamento.Models.Ex1
{
    internal class Aluno
    {
        private int _nota;
        public string Name { get; }

        public int Nota {

            get => _nota;
            
            private set
            {
                if(value >= 0 && value <= 10)
                {
                    _nota = value;
                }
                else
                {
                    throw new Exception($"Valor Inválido!");
                }
            }
        }

        public Aluno(string name, int nota)
        {
            Name = name;
            Nota = nota;
        }
    }
}
