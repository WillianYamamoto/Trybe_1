using System;
using System.Collections.Generic;
using System.Linq;
// Ex do Palíndromo (quando uma palavra é lida igual de trás para frente)
//Etapas:
//1 - Pedir para inserir uma palavra (STRING) - OK
//2 - Ler a palavra inserida - OK
//3 - Inverter a palavra
//4 - Ver se é um palíndromo 
//5 - Melhorar UX/UI
//Detalhes: O programa deve ignorar espaços e considerar maiúsculas e minúsculas como iguais.


Console.Clear();
string texto;
string textoinvertido;

Console.WriteLine("Digite a palavra a ser verificada como um Palíndromo (quando uma palavra é lida igual de trás para frente)");
 texto = Console.ReadLine();

textoinvertido = new string(texto.Reverse().ToArray());
Console.WriteLine($"\nA palavra digitada é: {texto}");
Console.WriteLine($"\nA palavra invertida é: {textoinvertido}");
