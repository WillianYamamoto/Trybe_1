//Ex Jogo da forca
//1 - O usuário digitar somente uma letra (limitar o input para somente 1 letra) - OK 
//2 - O programa deve mostrar a palavra como underscores (como uma palavra secreta) - OK
// 3 - Deve revelar as letras conforme vai acertando - OK
// 4 - O usuário tem um número limitado de tentativas, logo deve ser mostrado ao usuário a quantidade de vidas dele 
//5 - Melhorar programa 
//6 - Melhorar UI/UX 

using System;
using System.Collections.Generic;
using System.Linq;

string palavra_secreta = "MOTTU";
char[] letras_underscore = new char[palavra_secreta.Length];
int vidas = 5;
bool ganhou = false;

Console.WriteLine($"A palavra secreta tem:{palavra_secreta.Length} letras");

for (int i = 0; i < palavra_secreta.Length; i++) // Para escrever os "_ "
{
    letras_underscore[i] = '_';
}

string palavraEscondida = string.Join(" ", letras_underscore); // para colocar na tela a palavra escondida
//Console.WriteLine(palavraEscondida);
char chute;

while (vidas > 0 && !ganhou)
{
    Console.WriteLine($"A palavra secreta tem:{palavra_secreta.Length} letras");
    Console.WriteLine("\n" + string.Join(" ", letras_underscore));
    Console.WriteLine($"Tentativas restantes: {vidas}");
    while (true)
    {
        Console.WriteLine("Digite uma letra:");
        string letra = Console.ReadLine()?.Trim().ToUpper();
        if (string.IsNullOrEmpty(letra))
        {
            Console.WriteLine("Nenhuma letra foi digitada!");
            Console.WriteLine("\nPressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            continue;
        }
        else if (letra.Length > 1)
        {
            Console.WriteLine("Erro: Digite apenas UMA letra!");
            Console.WriteLine("\nPressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            continue;
        }
        else if (!char.IsLetter(letra[0]))
        {
            Console.WriteLine("Erro: Digite apenas LETRAS!");
            Console.WriteLine("\nPressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            continue;
        }

        chute = letra[0];
        break;
    }
    ;

    for (int i = 0; i < palavra_secreta.Length; i++)
    {
        if (palavra_secreta[i] == chute)
        {
            letras_underscore[i] = chute;
        }
    }
}
palavraEscondida = string.Join(" ", letras_underscore);
Console.WriteLine(palavraEscondida);