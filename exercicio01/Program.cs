
// Double idadeAnos = 23;
// idadeAnos = idadeAnos + 5;

// if (idadeAnos < 22) {
//     Console.WriteLine("Esta iniciando com c#?");
// }

// else{
//     Console.WriteLine("já conhece c#? ");
//  }

// Console.WriteLine("" + idadeAnos);

// Console.WriteLine("Hello, World!");



// __________________________________________________________________________________________
// #exercicio 1 / 2 ---------

// Console.WriteLine("Digite seu salario: ");
// float salario = float.Parse(Console.ReadLine());


// Console.WriteLine("Digite porcentagem de aumento: ");
// float valorCaulculo = float.Parse(Console.ReadLine());

// salario = salario * valorCaulculo + salario;

// Console.WriteLine("Novo salario: ");
// Console.WriteLine(salario);



// _______________________________________________________________________________________
// #exercicio 03 -------

// Console.WriteLine("Em que ano estamos?");
// Double anoAtual = Double.Parse(Console.ReadLine());

// Console.WriteLine("Qual seu ano de nascimento?");
// Double anoNascimento = Double.Parse(Console.ReadLine());

// Double idadeAnos = anoAtual - anoNascimento;
// Console.WriteLine("Você tem " + idadeAnos + " Anos");

// Double idadeMesses = idadeAnos * 12;
// Console.WriteLine("Você tem " + idadeMesses +" Messes vivendo na terra"); 

// Double idadeDias = idadeAnos * 365;
// Console.WriteLine("E tem " + idadeDias + " Dias nessa terra");

// if (idadeAnos > 50){
//     Console.WriteLine("Já ta bem vivido em ");
// }
// else{
//     Console.WriteLine(" ");
// }

// _______________________________________________________________________________________
// # exercicio 04 ------
// Console.WriteLine("Digite o peso do saco de ração me KG:");
// Double pesoRacao = double.Parse(Console.ReadLine());
// pesoRacao = pesoRacao * 1000;

// Console.WriteLine("Digite a quantidade fornecida de ração para os animais (em g):");
// Double racaoFornecida = double.Parse(Console.ReadLine());

// Console.WriteLine("Qunatos animais tem no total? ");
// Double quantidadeAnimais = double.Parse(Console.ReadLine());

// Double racaoDiaria = racaoFornecida * quantidadeAnimais;
// Console.WriteLine(racaoDiaria + " racao diaria");

// Double racao5dias = racaoDiaria * 5;
// Console.WriteLine(racao5dias + " racao 5 d");

// Double restante = pesoRacao - racao5dias;
// Console.WriteLine(restante + " restante");

// Console.WriteLine("Após 5 dias restarão " + restante + "G de ração.");
// ________________________________________________________________________________________________

// #Exercicio 5 ------

// Console.Write("Valor de A: ");
// Double valorA = Double.Parse(Console.ReadLine());

// Console.Write("Valor de B: ");
// Double valorB = Double.Parse(Console.ReadLine());
// Double troca = valorA;
// valorA = valorB;
// valorB = troca;

// Console.WriteLine("Valor A: " + valorA);
// Console.WriteLine("Valor B: " + valorB);

// _________________________________________________________________________________________________

// #exercicio 6 --------

// Console.WriteLine("CAULCULANDO VOLUME DA CAIXA RETANGULAR");

// Console.Write("Comprimento: ");
// Double Comprimento = double.Parse (Console.ReadLine());

// Console.Write("Largura: ");
// Double Largura = double.Parse (Console.ReadLine());

// Console.Write("Altura: ");
// Double Altura = double.Parse (Console.ReadLine());

// Double volume = Comprimento * Largura * Altura;

// Console.WriteLine("O volume da dessa caixa é: " + volume);

// ________________________________________________________________________________________

// #Exercicio 7 ------

// Console.Write("Valor A: ");
// Double valorA = Double.Parse(Console.ReadLine());

// Console.Write("Valor B: ");
// Double valorB = Double.Parse(Console.ReadLine());

// Double x = (valorA - valorB);
// Double resultado = x * x;
// Console.Write("O quadrado da diferença é : " + resultado);

//____________________________________________________________________________________________

// # Exercicio 8 ---------

// Console.Write("Digite o valor (DOL):$ ");
// Double Dol = double.Parse(Console.ReadLine());

// Double conversao = Dol * 5.50;

// Console.WriteLine("Em reais esse valor fica em torno de : R$" + conversao + " (Cotação do dia 27/06/2024)");

//_______________________________________________________________________________________________

// EXercicio 9 -----------

// Console.Write("Valor A: ");
// Double A = Double.Parse(Console.ReadLine());

// Console.Write("Valor B: ");
// Double B = Double.Parse(Console.ReadLine());

// Console.Write("Valor C: ");
// Double C = Double.Parse(Console.ReadLine());

// Double soma = A + B + C;
// Double quadrado = soma * soma;
// Console.Write("O valor do quadrado da soma dos três valores é: " + quadrado);
//________________________________________________________________________________________
//#Exercicio 10 -----------

// Console.Write("Valor de A: ");
// Double A = Double.Parse(Console.ReadLine());

// Console.Write("Valor de B: ");
// Double B = Double.Parse(Console.ReadLine());

// Double divisao = A / B;
// Double soma = A + B;   
// Double subtracao = A - B;
// Double mult = A * B;

// if (B == 0) {
//     Console.WriteLine("======Operações basicas======= ");

//     Console.WriteLine("Soma: " + A + " + " + B + " = " + soma );

//     Console.WriteLine("Subtração: " + A + " - " + B + " = " + subtracao );

//     Console.WriteLine(" Não pode dividir por 0");

//     Console.WriteLine("Multiplicação: " + A + " x " + B + " = " + mult );
// }

// else {
//     Console.WriteLine("======Operações basicas======= ");

//     Console.WriteLine("Soma: " + A + " + " + B + " = " + soma );

//     Console.WriteLine("Subtração: " + A + " - " + B + " = " + subtracao );

//     Console.WriteLine("Divisão: " + A + " / " + B + " = " + divisao );

//     Console.WriteLine("Multiplicação: " + A + " x " + B + " = " + mult );
// }
//__________________________________________________________________________________________________
// #Exercicio 11 ------------

// Console.WriteLine("====Calcular o volume de uma esfera====");

// Console.Write("Digite o valor do raio: ");
// Double Raio = Double.Parse(Console.ReadLine());

// Double volume = (4.0 / 3.0) * Math.PI * Math.Pow(Raio, 3);

// Console.WriteLine("O volume da esfera com raio: " + Raio + " é igual a: " + volume);

//__________________________________________________________________________________________
// # Exercicio 12 -------------

// Console.Write("Digite um numéro inteiro: ");
// int Num = int.Parse(Console.ReadLine());

// int antes = Num - 1;
// int depois = Num + 1; 

// Console.WriteLine("O antecessor de " + Num + ", é " + antes + " e o sucessor é " +  depois);
//____________________________________________________________________________________________

//#Exercicio 13 -----------

//  double A = 2;
//  double B = 3;
//  double C = 4;
//  double dif = - 5;
//  double soma = A + B + C + dif;
//  dif = soma * soma;
//  soma = Math.Sqrt(dif);
//  A = C;
//  B = -3;

//  Console.WriteLine("A = " + A + " | B = " + B + " | C = " + C + " | Dif = " + dif  + " | Soma = " + soma);
//  Console.WriteLine("FIM!");

//  Console.WriteLine("==========================");

//  int X = 25;
//  int Y = 52;
//  int resto = Y % X;
//  int quociente = Y / X;
//  X = resto;
//  Y = quociente;
//  resto = X % Y;
//  quociente = X / Y;

//  Console.WriteLine("Resto: " + resto + " | Quociente " + quociente);
//  Console.WriteLine("FIM!");