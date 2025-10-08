using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoPooEncapsulamento.Models.Ex6
{
    internal class Agenda
    {
        public Agenda(string prop)
        {
            _contatos = new List<Contato>();
            Proprietario = prop;
        }

        public string Proprietario { get; set; }

        private readonly List<Contato> _contatos;

        public int Contatos { get => _contatos.Count;  }

        public void AddContato(Contato contato)
        {
            if(_contatos.Any(n => n.Nome == contato.Nome))
            {
                Console.WriteLine("Não pode criar contato com o mesmo nome!");
            }
            else
            {
                _contatos.Add(contato);
            }
        }

        public void ListarContatos()
        {
                Console.WriteLine();
            Console.WriteLine($"Agenda de Contato do: {Proprietario}");
            foreach (var contato in _contatos)
            {
            Console.WriteLine("-----------");
                Console.WriteLine($"nome - {contato.Nome}");
                Console.WriteLine($"telefone - {contato.Telefone}");
            }
            Console.WriteLine("-----------");
            Console.WriteLine("Total de contatos: " + Contatos);
        }
    }
}
