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
int jogar = 0;
bool ganhou = false;

while (jogar == 0) // Menu de jogar ou sair
{
    Console.WriteLine("Selecione a opção:\n1 - Jogar o jogo da forca\n2 - Sair do programa");
    string opcaoMenu = Console.ReadLine();

    if (int.TryParse(opcaoMenu, out jogar))
    {
        if (jogar == 1)
        {
            while (vidas == 0) // Menu de dificuldade
            {
                Console.Clear();
                Console.WriteLine("Antes de iniciar escolha o nível de dificuldade:\n1 - Fácil (10 tentativas)\n2 - Médio (8 tentativas)\n3 - Difícil (6 tentativas)");
                string opcaoDificuldade = Console.ReadLine();

                if (int.TryParse(opcaoDificuldade, out dificuldade))
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
                    else
                    {
                        Console.WriteLine("Você acha que isso só é um jogo e não consegue fazer algo fácil como escolher a dificuldade,então engraçadinho bem vindo ao modo EXTREMO, onde você só tem 1 tentativa!!!!");
                        Console.ReadKey();
                        vidas = 1;
                    }
                }
                else
                {
                    Console.WriteLine("Erro encontrado: Digite um número válido!");
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            for (int i = 0; i < palavra_secreta.Length; i++)
            {
                letras_underscore[i] = '_';
            }

            while (vidas > 0 && !ganhou)
            {
                Console.Clear();
                Console.WriteLine($"\nA palavra secreta tem: {palavra_secreta.Length} letras");
                Console.WriteLine("\n" + string.Join(" ", letras_underscore));
                Console.WriteLine($"Tentativas restantes: {vidas}");

                char chute;
                while (true)
                {
                    Console.WriteLine("Digite uma letra:");
                    string letra = Console.ReadLine()?.Trim().ToUpper();

                    if (string.IsNullOrEmpty(letra))
                    {
                        Console.WriteLine("Erro encontrado: Nenhuma letra foi digitada!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    else if (letra.Length > 1)
                    {
                        Console.WriteLine("Erro encontrado: Digite apenas UMA letra!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    else if (!char.IsLetter(letra[0]))
                    {
                        Console.WriteLine("Erro encontrado: Digite apenas LETRAS!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }

                    chute = letra[0];
                    break;
                }

                bool letraEncontrada = false;
                for (int i = 0; i < palavra_secreta.Length; i++)
                {
                    if (palavra_secreta[i] == chute)
                    {
                        letras_underscore[i] = chute;
                        letraEncontrada = true;
                    }
                }

                if (!letraEncontrada)
                {
                    vidas--;
                    Console.WriteLine($"A letra '{chute}' não está na palavra!");
                    Console.ReadKey();
                }

                if (!letras_underscore.Contains('_'))
                {
                    ganhou = true;
                }
            }

            Console.Clear();
            Console.WriteLine("\n" + string.Join(" ", letras_underscore));

            if (ganhou)
            {
                Console.WriteLine("Parabéns! Você acertou a palavra!\n");
            }
            else
            {
                Console.WriteLine($"Você perdeu! A palavra era: {palavra_secreta}\n");
            }
        }
        else if (jogar == 2)
        {
            Console.WriteLine("Saindo do jogo");
            break;
        }
        else
        {
            Console.WriteLine("Erro encontrado: Digite 1 para jogar ou 2 para sair.");
            Console.ReadKey();
            Console.Clear();
            jogar = 0;
        }
    }
    else
    {
        Console.WriteLine("Erro encontrado: Digite um número válido!");
        Console.WriteLine("Pressione qualquer tecla para continuar");
        Console.ReadKey();
        Console.Clear();
        jogar = 0;
    }
}