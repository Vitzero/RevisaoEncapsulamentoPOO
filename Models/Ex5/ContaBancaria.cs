using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoPooEncapsulamento.Models.Ex5
{
    internal class ContaBancaria
    {
        SegurancaConta checar = new SegurancaConta();
        public string Titular { get; set; }

        private decimal _saldo;

        public ContaBancaria(string titular, decimal saldo)
        {
            Titular = titular;
            _saldo = saldo;
        }

        public void Sacar(decimal valor)
        {
            if (checar.ValidarSaque(valor))
            {
                _saldo -= valor;
                Console.WriteLine($"Foi sacado o valor de {valor}");
                Console.WriteLine($"Seu novo saldo é: {_saldo}");
            }
            else
            {
                Console.WriteLine("Valor acima do limite!");
            }
        }
    }
}
