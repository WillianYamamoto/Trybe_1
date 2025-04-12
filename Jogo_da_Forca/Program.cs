//Ex Jogo da forca
//1 - O usuário digitar somente uma letra (limitar o input para somente 1 letra)
//2 - O programa deve mostrar a palavra como underscores (como uma palavra secreta) - em andamento
// 3 - Deve revelar as letras conforme vai acertando
// 4 - O usuário tem um número limitado de tentativas, logo deve ser mostrado ao usuário a quantidade de vidas dele 
//6 - Melhorar programa - OK
//7 - Melhorar UI/UX - OK 

using System;
using System.Collections.Generic;
using System.Linq;

string palavra_secreta = "MOTTU";
int palavra_underscore = palavra_secreta.Length;

Console.WriteLine($"A palavra secreta tem:{palavra_underscore} letras");