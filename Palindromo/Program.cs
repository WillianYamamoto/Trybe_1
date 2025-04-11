using System;
using System.Collections.Generic;
using System.Linq;
// Ex do Palíndromo (quando uma palavra é lida igual de trás para frente)
//Etapas:
//1 - Pedir para inserir uma palavra (STRING) - OK
//2 - Ler a palavra inserida - OK
//3 - Inverter a palavra - OK 
//4 - Ver se é um palíndromo - OK 
//5 - Melhorar UX/UI - OK
//Detalhes: O programa deve ignorar espaços e considerar maiúsculas e minúsculas como iguais. - OK

// Variáveis 
Console.Clear();
string texto;
string textoinvertido;
string texto_sem_espaco;
var menu = 0;

//Menu para escolher se quer ficar fazendo verificação de palíndromo
while (menu != 2)
{
    Console.WriteLine("Escolha uma opção:\n");
    Console.WriteLine("1: Verificar se é Palíndromo (quando uma palavra é lida igual de trás para frente)\n2:Fechar Programa");

    if (!int.TryParse(Console.ReadLine(), out menu) || menu < 1 || menu > 2) // Caso escolha um número que não seja válido 
    {
        Console.WriteLine("\n Digite um número válido!!!!!\n");
        Console.WriteLine("\nPressione qualquer tecla para continuar");
        Console.ReadKey();
        Console.Clear();
        continue;
    }

    if (menu == 1)
    {
        Console.WriteLine("Digite a palavra a ser verificada como um Palíndromo (quando uma palavra é lida igual de trás para frente)");
        texto = Console.ReadLine();
        texto_sem_espaco = new string(texto.ToUpper().Where(c => !char.IsWhiteSpace(c)).ToArray());
        textoinvertido = new string(texto_sem_espaco.ToUpper().Reverse().ToArray());

        if (texto_sem_espaco == textoinvertido)
            Console.WriteLine($"O texto digitado: {texto} é um Palíndromo");
        else Console.WriteLine($"O texto digitado: {texto} não é um palindromo");
    }
    else if (menu == 2) //Opção de fechar o programa 
    {
        Console.WriteLine("Programa finalizado\n");
    }
    if (menu != 2) // Para deixar a UI/UX melhor
    {
        Console.WriteLine("\nPressione qualquer tecla para continuar");
        Console.ReadKey();
        Console.Clear();
    }
}