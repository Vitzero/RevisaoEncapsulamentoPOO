using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoPooEncapsulamento.Models.Ex9
{
    internal class Reserva
    {

        public Reserva(Hospede hospede, Quarto quarto, int diarias)
        {
            Hospede = hospede;
            Quarto = quarto;
            Diarias = diarias;
        }

        private int _diarias;

        public int Diarias { get => _diarias; 
            set
            {
                if(value > 0)
                {
                    _diarias = value;
                }
                else
                {
                    Console.WriteLine("Tem que ser maior que 0!");
                }
            }
        }

        public Hospede Hospede { get; }
        public Quarto Quarto { get; }

        public decimal ValorTotal { get => (Decimal)_diarias * Quarto.ValorDiaria; }

    }
}
