using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoPooEncapsulamento.Models.Ex9
{
    internal class Quarto
    {
        public Quarto(int numero, decimal valorDiaria)
        {
            Numero = numero;
            ValorDiaria = valorDiaria;
        }
        public int Numero { get; set; }

        private decimal _valorDiaria;
        public decimal ValorDiaria
        {
            get
            {
                return _valorDiaria;
            }

            set
            {
                if(value > 0)
                {
                   _valorDiaria = value;
                }
                else
                {
                    Console.WriteLine("Tem que ser maior que 0!");
                }
            } 
        }

    }
}
