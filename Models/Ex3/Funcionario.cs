using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoPooEncapsulamento.Models.Ex3
{
    internal class Funcionario
    {
        public string Nome { get; }

        private double _salario;

        public double Salario { get => _salario; }

        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            _salario = salario;
        }

        public void ReajusteSalarial(double salario)
        {
            if (salario > _salario)
            {
                _salario = salario;
            }
            else
            {
                Console.WriteLine("Não pode diminuir salário!!!!!!!!!!!");
            }
        }
    }
}
