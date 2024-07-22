// Exercicio 23---------------------

// String controle = "s";
// while (controle == "s") {
//     Console.WriteLine("Digite um numero: ");
//     Double num1 = double.Parse(Console.ReadLine());

//     Console.WriteLine("Digite outro numero: ");
//     Double num2 = double.Parse(Console.ReadLine());

//     if (num1 == 0 || num2 == 0) {
//         Console.WriteLine("O numero 0 não pode ser inserido!!");
//         continue;
//     }

//     Console.WriteLine("Deseja fazer qual tipo de conta?");
//     Console.WriteLine("[1] ADIÇÃO");
//     Console.WriteLine("[2] SUBTRAÇÃo");
//     Console.WriteLine("[3] MULTIPLICAÇÃO");
//     Console.WriteLine("[4] DIVISÃO");
//     int escolha = int.Parse(Console.ReadLine());

//     Console.WriteLine("Calculando...");
//     Thread.Sleep(2000);

//     if (escolha >= 5 || escolha == 0) {
//         Console.WriteLine("É um numero de 1 a 4!!");
//         continue;
//     }

//     else {

//         switch (escolha) {
//        case 1:
//        Console.WriteLine($"A soma de {num1} + {num2} é igual {num1 + num2}");
//        break;
       
//        case 2:
//        Console.WriteLine($"A subtração de {num1} - {num2} é igual {num1 - num2}");
//        break;

//        case 3:
//        Console.WriteLine($"A multiplicação de {num1} x {num2} é igual {num1 * num2}");
//        break;

//        case 4:
//        Console.WriteLine($"A divisão de {num1} / {num2} é igual {num1 / num2}");
//        break;
//     }

//     Thread.Sleep(1000);
//     Console.WriteLine("Deseja continuar? (s/n)");

//     controle = Console.ReadLine().ToLower();
//     if (controle != "s") {

//         Console.WriteLine("Terminado!!");
//         break;
//     }
//     }
    

// }

//Exercicio 24-----------------------

// int controle = 0;
// while (controle != 4 ) {

// Console.WriteLine("Digite um numero: ");
// int num1 = int.Parse(Console.ReadLine());
//  Thread.Sleep(1000);

// Console.WriteLine("Digite outro numero: ");
// int num2 = int.Parse(Console.ReadLine());
// Thread.Sleep(1500);

// Console.WriteLine("O que deseja fazer?");
// Console.WriteLine("[1] Verificar se um dos números lidos é ou não múltiplo do outro");
// Console.WriteLine("[2] Verificar se os dois números lidos são pares");
// Console.WriteLine("[3] Verificar se a média dos dois números é maior ou igual a 7");
// Console.WriteLine("[4] Sair");
// int escolha = int.Parse(Console.ReadLine());

//     if (escolha <= 0 || escolha >= 5) {
//         Console.WriteLine("Digite um numero de 1 a 4!!");
//         continue;
//     }

//     else {

//         Console.WriteLine("Espere....");
//          Thread.Sleep(2500);


//         switch (escolha) {
//             case 1:
//                 if (num1 % num2 == 0 && num2 % num1 == 0) {
//                     Console.WriteLine($"Um dos numeros são multiplos um do outro");
//                 }

//                 else{
//                     Console.WriteLine($"Os numeros NÃO são multiplos um do outro");
//                 }
//                 break;

//             case 2:
//                 if (num1 % 2 == 0 && num2 % 2 == 0){
//                     Console.WriteLine("Os dois são pares");
//                 }
//                 else if (num1 % 2 == 0 || num2 % 2 == 0){
//                     Console.WriteLine("Um dos numeros é par");
//                 }
//                 else{
//                     Console.WriteLine("Nenhum é par!");
//                 }
//                 break;
            
//             case 3:
//                 if ((num1 + num2) / 2 > 7){
//                     Console.WriteLine($"A media é maior que 7! media: {(num1 + num2) / 2}");
//                 }

//                 else if ((num1 + num2) / 2 == 7){
//                     Console.WriteLine("A media é igual a 7");
//                 }

//                 else{
//                     Console.WriteLine($"A media não é maior que 7, media: {(num1 + num2) / 2}"); 
//                 }
//                 break;

//             case 4:
//             Console.WriteLine("Saida concluida!!");
//             controle = 4;
//             break ;
//         }
//     }


// }

//Exercicio 25--------------------------------------------

// String controle = "s";
// while (controle == "s") {

//     Console.WriteLine("Qual é sua altura?: ");
//     Double h = double.Parse(Console.ReadLine());

//     Console.WriteLine("Digite seu sexo de nacimento(M - Maculino | F - Femenino): ");
//     String sexo = Console.ReadLine().ToLower();
    

//     if (sexo == "m" || sexo == "masculino") {
//         Console.WriteLine($"Seu peso ideal é de {(72.7 * h) - 58}");
        
//     }

//     else if (sexo == "f" || sexo == "femenino") {
//         Console.WriteLine($"Seu peso ideal é de {(62.1 * h) - 44.7}Kg");
//     }

//     else {
//         Console.WriteLine("Digite M para masculino ou F para feminino!!");
//         continue;
//     }

//     Console.WriteLine("Deseja saber outro pesso ideal? (s/n)");
//     controle = Console.ReadLine().ToLower();

//     if (controle != "s") {
//         Console.WriteLine("Encerrado!");
//         break;
//     }
//     }
        



