//Crie uma lista que pega o nome e nota dos alunos
//O programa deve calcular a média da turma e exibir as pessoas com nota acima da média 
// Etapas:
//1 - Crie uma lista que pega o nome dos alunos - OK
//2 - Crie uma lista qeu pega as notas dos alunos - OK
//3 - Calcular qual a média desses alunos - OK
//4 - Exibir a média - OK 
//5 - Exibir alunos com nota acima da média - OK 
//6 - Melhorar programa
//7 - Melhorar UI/UX

using System;
using System.Collections.Generic;
using System.Linq;

var nomes = new List<string>();
var notas = new List<double>();

double Calcular_média(List<double> nota)
{
    return nota.Count > 0 ? nota.Average() : 0;
}

for (int i = 0; i < 3; i++)
{
    Console.Write("Digite o nome do aluno(a): ");
    nomes.Add(Console.ReadLine());

    Console.Write("Digite a nota do aluno(a): ");
    notas.Add(double.Parse(Console.ReadLine()));
}

Console.WriteLine("\nAlunos e notas:");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"{nomes[i]} - Nota: {notas[i]}");
}
Console.WriteLine($"\nAlunos com nota acima da média: {Calcular_média(notas)}");
for (int i = 0; i < 3; i++)
{
    if (notas[i] > Calcular_média(notas))
    {
        Console.WriteLine($"{nomes[i]} - Nota: {notas[i]}\n");
    }
}