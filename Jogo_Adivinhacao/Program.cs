﻿// Jodo da adivinhação com dicas precisa 
// 1 - o usuário deve chutar um número de 1 a 1000
// 2 - após cada tentativa deve retornar se o número misterioso é maior ou menor que o chute 
// 3 - Também deve informar se ele está muito distante (diferença>100), distante (diferença >50) ou perto (diferença <= 50)   
// detalhes: Não tem um número exato de tentativas que ele deve ter
//5 - Melhorar programa 
//6 - Melhorar UI/UX  


Random random = new Random();
int num_secreto = random.Next(1,1001);// Sorte um número entre 1 e 1000

Console.WriteLine($"O número secreto é: {num_secreto}");