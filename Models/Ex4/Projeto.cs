using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoPooEncapsulamento.Models.Ex4
{
    internal class Projeto
    {
        public string Nome { get; }

        private List<string> _tarefas;
        private string v;

        public Projeto(string v)
        {
            Nome = v;
            _tarefas = new List<string>();
        }

        public int QuantTarefas { get => _tarefas.Count; }

        public void AddTarefas(string tarefa)
        {
            _tarefas.Add(tarefa);
        }

        public void ExibirTarefas()
        {
            Console.WriteLine("Projeto: " + Nome);
            Console.WriteLine("Tarefas:");
            foreach (var tarefa in _tarefas) Console.WriteLine(tarefa);
            Console.WriteLine("Total: " + QuantTarefas + " tarefas");
        }

    }
}
