using System;
using System.Collections.Generic;
using System.Linq;
// Ex do Palíndromo (quando uma palavra é lida igual de trás para frente)
//Etapas:
//1 - Pedir para inserir uma palavra (STRING) - OK
//2 - Ler a palavra inserida
//3 - Ver se é um palíndromo 
//4 - Melhorar UX/UI
//Detalhes: O programa deve ignorar espaços e considerar maiúsculas e minúsculas como iguais.


Console.Clear();
string palavra;
Console.WriteLine("Digite a palavra a ser verificada como um Palíndromo (quando uma palavra é lida igual de trás para frente)");
 palavra = Console.ReadLine();

Console.WriteLine($"\nA palavra digitada é: {palavra}");
