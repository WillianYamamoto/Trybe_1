//Ex Jogo da forca
//1 - O usuário digitar somente uma letra (limitar o input para somente 1 letra) - OK 
//2 - O programa deve mostrar a palavra como underscores (como uma palavra secreta) - OK
// 3 - Deve revelar as letras conforme vai acertando - OK
// 4 - O usuário tem um número limitado de tentativas, logo deve ser mostrado ao usuário a quantidade de vidas dele - OK
//5 - Melhorar programa  - OK
//6 - Melhorar UI/UX  - OK

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

int jogar = 0;


while (jogar == 0) // Menu de jogar ou sair
{
    int vidas = 0;
    int dificuldade = 0;
    bool ganhou = false;
    Random random = new Random();
    string palavra_secreta = banco_palavras[random.Next(banco_palavras.Count)];//Para sortear uma palavra do banco de palavras

    char[] letras_underscore = new char[palavra_secreta.Length];
    Console.WriteLine("Selecione a opção:\n1 - Jogar o jogo da forca\n2 - Sair do programa");
    string opcaoMenu = Console.ReadLine();

    if (int.TryParse(opcaoMenu, out jogar))// transforma a string opcaomenu em um int jogar e validar se está sendo digitado um número
    {
        if (jogar == 1)// opção para jogar forca
        {
            while (vidas == 0) // Menu de dificuldade
            {
                Console.Clear();
                Console.WriteLine("Antes de iniciar escolha o nível de dificuldade:\n1 - Fácil (10 tentativas)\n2 - Médio (8 tentativas)\n3 - Difícil (6 tentativas)");
                string opcaoDificuldade = Console.ReadLine();

                if (int.TryParse(opcaoDificuldade, out dificuldade))// transforma a string opcaodificuldde em um int jogar e validar se está sendo digitado um número
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
                    else// caso não seja nenhuma das opções realiza o easter egg
                    {
                        Console.WriteLine("Você acha que isso só é um jogo e não consegue fazer algo fácil como escolher a dificuldade,então engraçadinho bem vindo ao modo EXTREMO, onde você só tem 1 tentativa!!!!");
                        Console.ReadKey();
                        vidas = 1;
                    }
                }
                else // caso ele coloque uma opção inválida 
                {
                    Console.WriteLine("Erro encontrado: Digite um número válido!");
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            for (int i = 0; i < palavra_secreta.Length; i++) // para transformar a palavra em _
            {
                letras_underscore[i] = '_';
            }

            while (vidas > 0 && !ganhou) // repetição enquanto ele tem vidas e ainda não ganhou
            {
                Console.Clear();
                Console.WriteLine($"\nA palavra secreta tem: {palavra_secreta.Length} letras");
                Console.WriteLine("\n" + string.Join(" ", letras_underscore));
                Console.WriteLine($"Tentativas restantes: {vidas}");

                char chute;
                while (true)// enquanto o programa não for inputado o break
                {
                    Console.WriteLine("Digite uma letra:");
                    string letra = Console.ReadLine()?.Trim().ToUpper();

                    if (string.IsNullOrEmpty(letra))// se não colocar nada 
                    {
                        Console.WriteLine("Erro encontrado: Nenhuma letra foi digitada!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    else if (letra.Length > 1)// Se colocar mais de uma letra
                    {
                        Console.WriteLine("Erro encontrado: Digite apenas UMA letra!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    else if (!char.IsLetter(letra[0]))// Se não for letra
                    {
                        Console.WriteLine("Erro encontrado: Digite apenas LETRAS!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }

                    chute = letra[0];
                    break;
                }

                bool letraEncontrada = false;// condição para indicar que a letra não se encontra na palavra misteriosa
                for (int i = 0; i < palavra_secreta.Length; i++)//Verificar se a letra está na palavra em cada letra
                {
                    if (palavra_secreta[i] == chute)
                    {
                        letras_underscore[i] = chute;
                        letraEncontrada = true;
                    }
                }

                if (!letraEncontrada)//caso não tenha a letra 
                {
                    vidas--;// perde uma vida 
                    Console.WriteLine($"A letra '{chute}' não está na palavra!");
                    Console.ReadKey();
                }

                if (!letras_underscore.Contains('_'))//Condição de vitória, caso não tenha mais _
                {
                    ganhou = true;
                }
            }

            Console.Clear();
            Console.WriteLine("\n" + string.Join(" ", letras_underscore));

            if (ganhou)//Como a condição de vitoria ganhou - true ele escreve a mensagem 
            {
                Console.WriteLine("Parabéns! Você acertou a palavra!\n");
                jogar = 0;
                Console.ReadKey();
                Console.Clear();
            }
            else// se ele perder
            {
                Console.WriteLine($"Você perdeu! A palavra era: {palavra_secreta}\n");
                jogar = 0;
                Console.ReadKey();
                Console.Clear();
            }
        }
        else if (jogar == 2)// opção para sair do jogo, lá pelo primeiro menu
        {
            Console.WriteLine("\nSaindo do jogo\n");
            break;
        }
        else// quando digita um número que não está no menu de inicio do jogo
        {
            Console.WriteLine("Erro encontrado: Digite 1 para jogar ou 2 para sair.");
            Console.ReadKey();
            Console.Clear();
            jogar = 0;
        }
    }
    else// quando digita uma string que não seja 1 ou 2 
    {
        Console.WriteLine("Erro encontrado: Digite um número válido!");
        Console.WriteLine("Pressione qualquer tecla para continuar");
        Console.ReadKey();
        Console.Clear();
        jogar = 0;
    }
}