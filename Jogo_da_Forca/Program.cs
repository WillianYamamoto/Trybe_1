//Ex Jogo da forca
//1 - O usuário digitar somente uma letra (limitar o input para somente 1 letra) - OK 
//2 - O programa deve mostrar a palavra como underscores (como uma palavra secreta) - OK
// 3 - Deve revelar as letras conforme vai acertando - OK
// 4 - O usuário tem um número limitado de tentativas, logo deve ser mostrado ao usuário a quantidade de vidas dele - OK
//5 - Melhorar programa 
//6 - Melhorar UI/UX 

using System;
using System.Collections.Generic;
using System.Linq;

List<string> banco_palavras = new List<string> // Lista de palavras que podem ser sorteadas no jogo
{
    "MOTTU",
    "TRYBE",
    "WILLIAN",
    "TESTE",
    "PROGRAMACAO",
    "JOGO",
    "BRASIL",
    "MANUTENCAO",
    "ARARA",
    "FORCA"
};

Random random = new Random();
string palavra_secreta = banco_palavras[random.Next(banco_palavras.Count)];//Para sortear uma palavra do banco de palavras


char[] letras_underscore = new char[palavra_secreta.Length];
int vidas = 0;
int dificuldade = 0;
bool ganhou = false;




while (vidas == 0)//Para rodar o menu de opção de vidas 
{
    Console.WriteLine("Antes de iniciar escolha o nível de dificuldade:\n1 - fácil (10 tentativas)\n2 - Médio (8 tentativas)\n3 - Difícil (6 tentativas)");
    string menu = Console.ReadLine();

    if (int.TryParse(menu, out dificuldade))// Validar se está sendo digitado um número
    {
        if (dificuldade == 1)
        {
            vidas = 10;
        }
        else if (dificuldade == 2)
        {
            vidas = 8;
        }
        else if (dificuldade == 3)
        {
            vidas = 6;
        }
        else if (dificuldade != 1 && dificuldade != 2 && dificuldade != 3)
        {
            Console.WriteLine("Você acha que isso só é um jogo e não consegue fazer algo fácil como escolher a dificuldade,então engraçadinho bem vindo ao modo EXTREMO, onde você só tem 1 tentativa!!!!");
            Console.ReadKey();
            vidas = 1;
        }
    }
        else
        {
            Console.WriteLine("Erro encontrado: Digite um NÚMERO válido!");
            Console.WriteLine("\nPressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
    
}


for (int i = 0; i < palavra_secreta.Length; i++) // Para escrever os "_ "
{
    letras_underscore[i] = '_';
}

string palavraEscondida = string.Join(" ", letras_underscore); // para colocar na tela a palavra escondida

while (vidas > 0 && !ganhou) // Condição de loop do jogo ou ele perde todas as vidas ou ele ganha
{
    Console.Clear();
    Console.WriteLine($"\nA palavra secreta tem:{palavra_secreta.Length} letras");
    Console.WriteLine("\n" + string.Join(" ", letras_underscore));
    Console.WriteLine($"Tentativas restantes: {vidas}");

    char chute;
    while (true)// Para validar que está sendo digitado somente 1 letra
    {
        Console.WriteLine("Digite uma letra:");
        string letra = Console.ReadLine()?.Trim().ToUpper();
        if (string.IsNullOrEmpty(letra))
        {
            Console.WriteLine("Erro encontrado:Nenhuma letra foi digitada!");
            Console.WriteLine("\nPressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            continue;
        }
        else if (letra.Length > 1)
        {
            Console.WriteLine("Erro encontrado: Digite apenas UMA letra!");
            Console.WriteLine("\nPressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();

            continue;
        }
        else if (!char.IsLetter(letra[0]))
        {
            Console.WriteLine("Erro encontrado: Digite apenas LETRAS!");
            Console.WriteLine("\nPressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();

            continue;
        }

        chute = letra[0];
        break;
    }
    ;

    bool letraDigitada = false;
    for (int i = 0; i < palavra_secreta.Length; i++)
    {
        if (palavra_secreta[i] == chute)
        {
            letras_underscore[i] = chute;
            letraDigitada = true;
        }
    }
    ;
    if (!letraDigitada)
    {
        vidas--;
        Console.WriteLine($"A letra {chute} não está na palavra!");
        Console.ReadKey();
    }
    if (!letras_underscore.Contains('_'))
    {
        ganhou = true;
    }

}


if (ganhou)
{
    Console.Clear();
    Console.WriteLine("\n" + string.Join(" ", letras_underscore));
    Console.WriteLine("Parabéns! Você acertou a palavra!\n");
}
else
{
    Console.Clear();
    Console.WriteLine("\n" + string.Join(" ", letras_underscore));
    Console.WriteLine($"Você perdeu! A palavra era: {palavra_secreta} tente novamente\n");
}
