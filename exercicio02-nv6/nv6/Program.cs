// Exercicio 60

// Console.Write("Digite o valor de x: ");
//         int x = int.Parse(Console.ReadLine());

//         Console.Write("Digite o valor de y: ");
//         int y = int.Parse(Console.ReadLine());

//         int quadrante = VerificaQuadrante(x, y);

//         Console.WriteLine($"O ponto ({x}, {y}) está no quadrante: {quadrante}");
//     static int VerificaQuadrante(int x, int y)
//     {
//         if (x > 0 && y > 0)
//         {
//             return 1;
//         }
//         else if (x < 0 && y > 0)
//         {
//             return 2;
//         }
//         else if (x < 0 && y < 0)
//         {
//             return 3;
//         }
//         else if (x > 0 && y < 0)
//         {
//             return 4;
//         }
//         else
//         {
//             return 0;
//         }
//     }

// Exercicio 61---------------------------------

//   Console.Write("Digite o valor do salário atual: ");
//         double salario = double.Parse(Console.ReadLine());

//         Console.Write("Digite o índice de reajuste (em percentual, por exemplo 10 para 10%): ");
//         double indiceReajuste = double.Parse(Console.ReadLine());

//         double salarioAtualizado = Reajuste(salario, indiceReajuste);

//         Console.WriteLine($"O salário atualizado é: R$ {salarioAtualizado:F2}");
    

//     static double Reajuste(double salario, double indiceReajuste)
//     {
//         return salario * (1 + indiceReajuste / 100);
//     }

// Exercico 62 ---------------------------------------------------

//   Console.Write("Digite o valor da base do triângulo: ");
//         double baseTriangulo = double.Parse(Console.ReadLine());

//         Console.Write("Digite o valor da altura do triângulo: ");
//         double alturaTriangulo = double.Parse(Console.ReadLine());

//         double hipotenusa = Hipotenusa(baseTriangulo, alturaTriangulo);

//         Console.WriteLine($"O valor da hipotenusa é: {hipotenusa:F2}");
    

//     static double Hipotenusa(double baseTriangulo, double alturaTriangulo)
//     {
//         return Math.Sqrt(baseTriangulo * baseTriangulo + alturaTriangulo * alturaTriangulo);
//     }

//Exercicio 63 ----------------------------------

//    Console.Write("Digite um número inteiro: ");
//         int numero = int.Parse(Console.ReadLine());

//         string resultado = Verifica(numero);

//         Console.WriteLine($"O número {numero} é: {resultado}");

// static string Verifica(int n)
//     {
//         if (n % 2 == 0)
//         {
//             return "PAR";
//         }
//         else
//         {
//             return "ÍMPAR";
//         }
//     }

// Exercicio 64 -----------------------------------------


// int opcao;
//         do
//         {
//             Console.WriteLine("Escolha uma opção:");
//             Console.WriteLine("1 - Carregar Vetor");
//             Console.WriteLine("2 - Listar Vetor");
//             Console.WriteLine("3 - Exibir apenas os números pares do vetor");
//             Console.WriteLine("4 - Exibir apenas os números ímpares do vetor");
//             Console.WriteLine("5 - Exibir a quantidade de números pares nas posições ímpares do vetor");
//             Console.WriteLine("6 - Exibir a quantidade de números ímpares nas posições pares do vetor");
//             Console.WriteLine("7 - Sair");
//             Console.Write("Opção: ");
//             opcao = int.Parse(Console.ReadLine());

//             switch (opcao)
//             {
//                 case 1:
//                     CarregarVetor();
//                     break;
//                 case 2:
//                     ListarVetor();
//                     break;
//                 case 3:
//                     ExibirPares();
//                     break;
//                 case 4:
//                     ExibirImpares();
//                     break;
//                 case 5:
//                     QuantidadeParesNasPosicoesImpares();
//                     break;
//                 case 6:
//                     QuantidadeImparesNasPosicoesPares();
//                     break;
//                 case 7:
//                     Console.WriteLine("Saindo...");
//                     break;
//                 default:
//                     Console.WriteLine("Opção inválida.");
//                     break;
//             }
//         } while (opcao != 7);
    

//     static void CarregarVetor()
//     {
//         Console.Write("Digite o tamanho do vetor: ");
//         int tamanho = int.Parse(Console.ReadLine());
//         vetor = new int[tamanho];

//         for (int i = 0; i < tamanho; i++)
//         {
//             Console.Write($"Digite o valor para a posição {i}: ");
//             vetor[i] = int.Parse(Console.ReadLine());
//         }
//     }

//     static void ListarVetor()
//     {
//         if (vetor == null)
//         {
//             Console.WriteLine("O vetor não foi carregado.");
//             return;
//         }

//         Console.WriteLine("Conteúdo do vetor:");
//         foreach (int valor in vetor)
//         {
//             Console.Write(valor + " ");
//         }
//         Console.WriteLine();
//     }

//     static void ExibirPares()
//     {
//         if (vetor == null)
//         {
//             Console.WriteLine("O vetor não foi carregado.");
//             return;
//         }

//         Console.WriteLine("Números pares no vetor:");
//         foreach (int valor in vetor)
//         {
//             if (valor % 2 == 0)
//             {
//                 Console.Write(valor + " ");
//             }
//         }
//         Console.WriteLine();
//     }

//     static void ExibirImpares()
//     {
//         if (vetor == null)
//         {
//             Console.WriteLine("O vetor não foi carregado.");
//             return;
//         }

//         Console.WriteLine("Números ímpares no vetor:");
//         foreach (int valor in vetor)
//         {
//             if (valor % 2 != 0)
//             {
//                 Console.Write(valor + " ");
//             }
//         }
//         Console.WriteLine();
//     }

//     static void QuantidadeParesNasPosicoesImpares()
//     {
//         if (vetor == null)
//         {
//             Console.WriteLine("O vetor não foi carregado.");
//             return;
//         }

//         int contagem = 0;
//         for (int i = 1; i < vetor.Length; i += 2)
//         {
//             if (vetor[i] % 2 == 0)
//             {
//                 contagem++;
//             }
//         }

//         Console.WriteLine($"Quantidade de números pares nas posições ímpares: {contagem}");
//     }

//     static void QuantidadeImparesNasPosicoesPares()
//     {
//         if (vetor == null)
//         {
//             Console.WriteLine("O vetor não foi carregado.");
//             return;
//         }

//         int contagem = 0;
//         for (int i = 0; i < vetor.Length; i += 2)
//         {
//             if (vetor[i] % 2 != 0)
//             {
//                 contagem++;
//             }
//         }

//         Console.WriteLine($"Quantidade de números ímpares nas posições pares: {contagem}");
//     }
