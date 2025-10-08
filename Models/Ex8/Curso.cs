using RevisaoPooEncapsulamento.Models.Ex7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace RevisaoPooEncapsulamento.Models.Ex8
{
    internal class Curso
    {
        public Curso(string nome, int vagastotais)
        {
            Nome = nome;
            VagasTotais = vagastotais;
            _matriculas = new List<Curseiro>();
        }

        public string Nome { get; set; }

        public int VagasTotais { get; set; }

        private List<Curseiro> _matriculas;

        public bool Matricular(Curseiro estudante)
        {
            if(VagasDisponiveis > 0)
            {
                _matriculas.Add(estudante);
                Console.WriteLine($"Estudante {estudante.Nome} matriculado com sucesso");
                return true;
            }
            else {
                Console.WriteLine("Falha ao matricular!");
                return false; 
            }
        }

        public int VagasDisponiveis { get => VagasTotais - _matriculas.Count ; }
    
        public void ListarMatriculados()
        {
            Console.WriteLine($"Estudantes de: {Nome}:");
            foreach(var i in _matriculas) { Console.WriteLine($"- {i.Nome}"); }
            Console.WriteLine($"Vagas Disponiveis: {VagasDisponiveis}");
        }
        
    
    }
}
