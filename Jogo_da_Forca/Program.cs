//Ex Jogo da forca
//1 - O usuário digitar somente uma letra (limitar o input para somente 1 letra)
//2 - O programa deve mostrar a palavra como underscores (como uma palavra secreta) - OK
// 3 - Deve revelar as letras conforme vai acertando - OK
// 4 - O usuário tem um número limitado de tentativas, logo deve ser mostrado ao usuário a quantidade de vidas dele 
//6 - Melhorar programa - OK
//7 - Melhorar UI/UX - OK 

using System;
using System.Collections.Generic;
using System.Linq;

string palavra_secreta = "MOTTU";
char[] letras_underscore = new char[palavra_secreta.Length];


Console.WriteLine($"A palavra secreta tem:{palavra_secreta.Length} letras");

for (int i = 0; i < palavra_secreta.Length; i++) // Para escrever os "_ "
{
    letras_underscore[i] = '_';
}

string palavraEscondida = string.Join(" ", letras_underscore);
Console.WriteLine(palavraEscondida);

Console.WriteLine("Digite uma letra:");
string letra = Console.ReadLine()?.ToUpper();

if (string.IsNullOrEmpty(letra))
{
    Console.WriteLine("Nenhuma letra foi digitada!");
    return;
};

char chute = letra[0];

for (int i = 0; i < palavra_secreta.Length; i++)
{
    if (palavra_secreta[i] == chute)
    {
        letras_underscore[i] = chute;
    }
}
palavraEscondida = string.Join(" ", letras_underscore);
Console.WriteLine(palavraEscondida);