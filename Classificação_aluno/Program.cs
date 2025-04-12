//Crie uma lista que pega o nome e nota dos alunos
//O programa deve calcular a média da turma e exibir as pessoas com nota acima da média 
// Etapas:
//1 - Crie uma lista que pega o nome dos alunos - OK
//2 - Crie uma lista qeu pega as notas dos alunos - OK
//3 - Calcular qual a média desses alunos - OK
//4 - Exibir a média - OK 
//5 - Exibir alunos com nota acima da média - OK 
//6 - Melhorar programa - OK
//7 - Melhorar UI/UX - OK 

using System;
using System.Collections.Generic;
using System.Linq;

var nomes = new List<string>();
var notas = new List<double>();

double Calcular_Media(List<double> nota)
{
    return nota.Count > 0 ? nota.Average() : 0;
}

string nome_novo;
do
{
    Console.Clear();
    Console.Write("Digite o nome de um aluno(a) ou fechar para encerrar a lista de alunos e mostrar os alunos acima da média: ");
    nome_novo = Console.ReadLine();

    if (nome_novo.ToUpper() != "FECHAR")
    {
        nomes.Add(nome_novo);
        
        Console.Write("Digite a nota do aluno(a) (de o a 100): ");
        if (double.TryParse(Console.ReadLine(), out double nota) && nota >= 0 && nota <= 100)
        {
            notas.Add(nota);
        }
        else
        {
            Console.WriteLine("Nota inválida. Digite NOVAMENTE o nome e nota correta (Entre 0 e 100).");
            nomes.RemoveAt(nomes.Count - 1); // Remove o nome adicionado, caso o número seja inválido
            Console.ReadKey();
            continue;
        }
        if (nome_novo.ToUpper() != "FECHAR") // Para deixar a UI/UX melhor
        {
            Console.WriteLine("\nPressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
    }
} while (nome_novo.ToUpper() != "FECHAR");

Console.WriteLine("\nAlunos e notas:");
for (int i = 0; i < nomes.Count; i++)
{
    Console.WriteLine($"{nomes[i]} - Nota: {notas[i]}");
}

double media = Calcular_Media(notas); // calcula a média 
Console.WriteLine($"\nMédia da turma: {media}");

Console.WriteLine("\nAlunos com nota acima da média:");
for (int i = 0; i < nomes.Count; i++)
{
    if (notas[i] > media)
    {
        Console.WriteLine($"{nomes[i]} - Nota: {notas[i]}");
    }
}