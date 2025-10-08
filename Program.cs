using RevisaoPooEncapsulamento.Models.Ex1;
using RevisaoPooEncapsulamento.Models.Ex2;
using RevisaoPooEncapsulamento.Models.Ex3;
using RevisaoPooEncapsulamento.Models.Ex4;
using RevisaoPooEncapsulamento.Models.Ex5;
using RevisaoPooEncapsulamento.Models.Ex6;
using RevisaoPooEncapsulamento.Models.Ex7;
using RevisaoPooEncapsulamento.Models.Ex8;
using RevisaoPooEncapsulamento.Models.Ex9;

Aluno a1 = new Aluno("Lucas", 10); // EX1
Aluno a2 = new Aluno("enzo", 6);

Console.WriteLine($"Aluno: {a1.Name}");
Console.WriteLine($"Nota: {a1.Nota}");

Console.WriteLine($"Aluno: {a2.Name}");
Console.WriteLine($"Nota: {a2.Nota}");

Paciente paciente = new Paciente("Luiz Costa", 42); // EX2
HistoricoMedico historico = new HistoricoMedico("XPT-9987");
historico.ExibirCodigo();

Funcionario f = new Funcionario("Fernanda Lima", 4000); // EX3
f.ReajusteSalarial(3500); // Inválido
Console.WriteLine(f.Salario);
f.ReajusteSalarial(4200); // Válido
Console.WriteLine(f.Salario);

Projeto projeto = new Projeto("Sistema de Inventário"); // EX4
projeto.AddTarefas("Criar tela de login");
projeto.AddTarefas("Implementar banco de dados");
projeto.ExibirTarefas();

ContaBancaria conta = new ContaBancaria("Carlos Silva", 2500); // EX5
conta.Sacar(1500); // inválido
conta.Sacar(800);  // válido


Agenda agenda = new Agenda("Marina Souza");       //EX6
agenda.AddContato(new Contato("Carlos", "11998887777"));
agenda.AddContato(new Contato("Carlos", "11991112222")); // duplicado
agenda.AddContato(new Contato("Julia", "21988776655"));
agenda.ListarContatos();

Estudante estudante = new Estudante("Lucas Rocha", 7.5, 5.0); //EX7
Console.WriteLine(estudante.situacao);


Curso curso = new Curso("Lógica de Programação", 2); // EX8
curso.Matricular(new Curseiro("Rafaela"));
curso.Matricular(new Curseiro("João"));
curso.Matricular(new Curseiro("Mirela")); // excede o limite
curso.ListarMatriculados();


Hospede hospede = new Hospede("Juliana Moura"); //ex9
Quarto quarto = new Quarto(101, (decimal)250);

Reserva reserva = new Reserva(hospede, quarto, 3);

Console.WriteLine("Reserva para: " + reserva.Hospede.Nome);
Console.WriteLine("Quarto: " + reserva.Quarto.Numero);
Console.WriteLine("Valor total: R$ " + reserva.ValorTotal.ToString("F2"));
