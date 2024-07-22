//Exercicio 12------------------------------

// Console.WriteLine("Digite um num: ");
// int num = int.Parse(Console.ReadLine());

// int modulo;

// if (num >= 0){
//     modulo = num;
// }
// else {
//     modulo =- num;
// }

// Console.WriteLine("O modulo do num é: " + modulo);

//Exercicio 13------------------------------

// int[] nums = new int[3];

// for (int i = 0; i < 3; i++){
//     Console.WriteLine($"Digite o {1 + i} num: " );
//     nums[i] = int.Parse(Console.ReadLine());
// }

// Array.Sort(nums);
// Array.Reverse(nums);

// Console.WriteLine("Números digitados em ordem decrecente: ");
// foreach (int num in nums){
//     Console.WriteLine(num);
// }

//Exercicio 14----------------------------------

// Console.WriteLine("Digite um num: ");
// int num1= int.Parse(Console.ReadLine());

// Console.WriteLine("Digite um num: ");
// int num2 = int.Parse(Console.ReadLine());

// int diferenca = Math.Abs (num1 - num2);
// Console.WriteLine($"A diferença do maior para o menor é {diferenca}");

//Exercicio 15-----------------------------------

//  DateTime now = DateTime.Now;

// Double[] notas = new Double[4];
// Double soma = 0;

// for (int i = 0; i < 4; i++){
//     Console.WriteLine($"Digite a {1 + i} nota: " );
//     notas[i] = double.Parse(Console.ReadLine());
//     soma += notas[i];
// }
// Double media = soma / 4;

//  Console.WriteLine("Calculando as notas...");
//         Thread.Sleep(3000);

// if (media < 7){

//     Console.WriteLine("Você Ficou de recuperação!!");
//     Console.WriteLine("Digite a nota da recuperação: ");

//     Double recu = Double.Parse(Console.ReadLine());
//     media = recu + media;

//     if (recu >= 7){
//         Console.WriteLine($"Passou na risca em, sua media foi {media}, Parabéns!");
//     }

//     else{
//         Console.WriteLine("Reprovado! :(");
//     }

// }

// else{
//     Console.WriteLine($"Parabéns Sua media foi {media}, Aprovado!!");
// }


//Exercicio 16---------------------------------------

// Console.WriteLine("Digite o Primeiro numéro: ");
// Double num1 = double.Parse(Console.ReadLine());
// Console.WriteLine("Digite o Segundo numéro: ");
// Double num2 = double.Parse(Console.ReadLine());

// if (num1 > num2){
//     Console.WriteLine($"O maior num é {num1} e o menor é {num2}");
// }

// else if (num2 > num1){
//     Console.WriteLine($"O maior num é {num2} e o menor é {num1}");
// }

// else {
//     Console.WriteLine("Os dois valores são iguais");
// }

//Exercicio 17------------------------------------------

// Console.WriteLine("Digite um numéro: ");
// int num = int.Parse(Console.ReadLine());

// if (num <= 9){
//     Console.WriteLine("Valor válido");
// }

// else{
//     Console.WriteLine("Valor inválido");
// }

//Exercicio 18------------------------------------------

// Console.WriteLine("Digite um numéro: ");
// int codigo = int.Parse(Console.ReadLine());
//  switch (codigo){
//     case 1: Console.WriteLine("um"); 
//         break;

//     case 2: Console.WriteLine("dois");
//         break;

//     case 3: Console.WriteLine("tres");
//         break;

//     default: Console.WriteLine("Código inválido!");
//         break;

//  }

//Exercicio 19------------------------------------------

// Console.Write("Digite o valor do lado A: ");
// double A = double.Parse(Console.ReadLine());

// Console.Write("Digite o valor do lado B: ");
// double B = double.Parse(Console.ReadLine());

// Console.Write("Digite o valor do lado C: ");
// double C = double.Parse(Console.ReadLine());


// if (A < B + C && B < A + C && C < A + B){


//     if (A == B && B == C){
//         Console.WriteLine("O triângulo é eqüilátero.");
//         }

//     else if (A == B || A == C || B == C){
//         Console.WriteLine("O triângulo é isósceles.");
//         }

//     else{
//         Console.WriteLine("O triângulo é escaleno.");
//         }
// }
//  else{
//  Console.WriteLine("Os valores fornecidos não formam um triângulo.");
//  }

//Exercicio 20-------------------------------

// DateTime now = DateTime.Now;
// int a, b, c;

// do {
//     Console.WriteLine("Digite o valor de A (Que seja maior que zero): ");
//     a = int.Parse(Console.ReadLine());

//     Thread.Sleep(1500);

//     if (a <= 0){
//         Console.WriteLine("Valor invalido! Tem que ser maior que ZERO!!");
//     }

// }
// while (a <= 0);
// do{
//     Console.WriteLine("Digite o valor de B (Que seja maior que zero):");
//     b = int.Parse(Console.ReadLine());

//     Thread.Sleep(1500);

//     if (b <= 0){
//         Console.WriteLine("Valor invalido! Tem que ser maior que ZERO!!");
//     }
// }
// while (b <= 0);

// do {
// Console.WriteLine("Digite o valor de C (Que seja maior que zero):");
//     c = int.Parse(Console.ReadLine());

//     Thread.Sleep(1500); 

//     if (c <= 0){
//         Console.WriteLine("Valor invalido! Tem que ser maior que ZERO!!");
// }
// }

// while (c <= 0);
// int maior = Math.Max(Math.Max(a, b), c);
// int menor = Math.Min(Math.Min(a, b), c);

// Console.WriteLine($"Menor valor multiplicado pelo maior: {menor * maior}");
// Thread.Sleep(2000);
// Console.WriteLine($"Maior valor dividido pelo menor valor: {maior / menor}");

// Exercicio 21-------------------------------

// DateTime now = DateTime.Now;
// var controle = 's';

// while (controle == 's'){
//     Console.WriteLine("Informe um num inteiro: ");
//     int num = int.Parse(Console.ReadLine());

//     Console.WriteLine("procesando...");
//     Thread.Sleep(1500);

//     if (num == 0){
//         Console.WriteLine("Esse num é neutro!");

//     }

//     else if (num > 0){
//         Console.WriteLine("Esse é um num positivo!");

//     }

//     else {
//         Console.WriteLine("Esse é um num negativo!");
//     }

//     Console.WriteLine($"\n Deseja continuar? (s/n) ");
//     controle = char.Parse(Console.ReadLine()!.ToLower());

//     Thread.Sleep(1000);
//     Console.Clear();
// }

// Console.WriteLine("Fim programa!");

//Exercicio 22---------------------------------------

// List<int> A = new List<int>();
// List<int> B = new List<int>();
//      while (true){

//         Console.WriteLine("Digite um número inteiro: ");
//         string entrada = Console.ReadLine();
//         try{
//             int num = int.Parse(entrada);
//             if (num > 0){
//                 A.Add(num);
//             }
//             else if (num < 0){
//                 B.Add(num);
//             }
//             else{
//                 Console.WriteLine("Zero não será armazenado em nenhuma lista.");
//             }
//         }
//         catch (FormatException){
        
//             Console.WriteLine("Por favor, digite um número inteiro válido.");
//             continue; 
//             }

//         Console.WriteLine("Deseja continuar? (s/n): ");
//         string controle = Console.ReadLine().ToLower();
//         if (controle != "s"){
        
//             Console.WriteLine("Encerrando o programa...");
//             break;
//       }
//       }
//       Console.WriteLine("\nResumo dos números armazenados:");
//       Console.WriteLine("\nPositivos (A):");
//       if (A.Count > 0){
//           Console.WriteLine(string.Join(", ", A));
//       }

//       else{
//           Console.WriteLine("Nenhum número positivo foi armazenado.");
//       }

//       Console.WriteLine("\nNegativos (B):");

//       if (B.Count > 0){
//        Console.WriteLine(string.Join(", ", B));
//       }
//       else{
//       Console.WriteLine("Nenhum número negativo foi armazenado.");
//       }