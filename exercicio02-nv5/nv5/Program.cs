// Exercicio 45---------------------------------

//  Console.Write("Informe o número de elementos no vetor: ");
//         int n;
//         while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
//         {
//             Console.Write("Valor inválido. Por favor, informe um número inteiro positivo: ");
//         }

//         int[] vetor = new int[n];

        
//         for (int i = 0; i < n; i++)
//         {
//             Console.Write($"Informe o elemento {i + 1}: ");
//             while (!int.TryParse(Console.ReadLine(), out vetor[i]))
//             {
//                 Console.Write("Valor inválido. Por favor, informe um número inteiro: ");
//             }
//         }

       
//         Console.WriteLine("A sequência na ordem inversa é:");
//         for (int i = n - 1; i >= 0; i--)
//         {
//             Console.Write(vetor[i] + " ");
//         }

//         Console.WriteLine(); 

// Exercicio 46 -------------------------------------------------

        // Console.Write("Informe o número de elementos em cada vetor: ");
        // int n;
        // while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        // {
        //     Console.Write("Valor inválido. Por favor, informe um número inteiro positivo: ");
        // }

        // int[] x = new int[n];
        // int[] y = new int[n];

        
        // Console.WriteLine("Informe os elementos do vetor x:");
        // for (int i = 0; i < n; i++)
        // {
        //     Console.Write($"x[{i}] = ");
        //     while (!int.TryParse(Console.ReadLine(), out x[i]))
        //     {
        //         Console.Write("Valor inválido. Por favor, informe um número inteiro: ");
        //     }
        // }

        
        // Console.WriteLine("Informe os elementos do vetor y:");
        // for (int i = 0; i < n; i++)
        // {
        //     Console.Write($"y[{i}] = ");
        //     while (!int.TryParse(Console.ReadLine(), out y[i]))
        //     {
        //         Console.Write("Valor inválido. Por favor, informe um número inteiro: ");
        //     }
        // }

        
        // int produtoEscalar = 0;
        // for (int i = 0; i < n; i++)
        // {
        //     produtoEscalar += x[i] * y[i];
        // }

        
        // Console.WriteLine($"O produto escalar dos vetores x e y é: {produtoEscalar}");

// Exercicio 47-------------------------------------------------

//  const int tamanho = 10;
//         int[] vetor = new int[tamanho];

//         Console.WriteLine("Informe 10 números inteiros positivos maiores que zero:");

//         for (int i = 0; i < tamanho; i++)
//         {
//             Console.Write($"Elemento {i + 1}: ");
//             while (!int.TryParse(Console.ReadLine(), out vetor[i]) || vetor[i] <= 0)
//             {
//                 Console.Write("Valor inválido. Informe um número inteiro positivo maior que zero: ");
//             }
//         }

//         Console.Write("Informe um número inteiro positivo maior que zero (X): ");
//         int x;
//         while (!int.TryParse(Console.ReadLine(), out x) || x <= 0)
//         {
//             Console.Write("Valor inválido. Informe um número inteiro positivo maior que zero: ");
//         }

//         int maioresQueX = 0;
//         int menoresQueX = 0;
//         int iguaisAX = 0;

//         for (int i = 0; i < tamanho; i++)
//         {
//             if (vetor[i] > x)
//             {
//                 maioresQueX++;
//             }
//             else if (vetor[i] < x)
//             {
//                 menoresQueX++;
//             }
//             else
//             {
//                 iguaisAX++;
//             }
//         }

//         Console.WriteLine($"Número de elementos maiores que {x}: {maioresQueX}");
//         Console.WriteLine($"Número de elementos menores que {x}: {menoresQueX}");
//         Console.WriteLine($"Número de elementos iguais a {x}: {iguaisAX}");

// Exercicio 48 ---------------------------------------------------

//   const int maxSize = 50;

//         Console.Write("Informe o número de elementos em cada vetor (máximo 50): ");
//         int n;
//         while (!int.TryParse(Console.ReadLine(), out n) || n <= 0 || n > maxSize)
//         {
//             Console.Write("Valor inválido. Informe um número inteiro positivo até 50: ");
//         }

//         int[] V1 = new int[n];
//         int[] V2 = new int[n];

//         Console.WriteLine("Informe os elementos do vetor V1:");

//         for (int i = 0; i < n; i++)
//         {
//             Console.Write($"V1[{i}] = ");
//             while (!int.TryParse(Console.ReadLine(), out V1[i]))
//             {
//                 Console.Write("Valor inválido. Informe um número inteiro: ");
//             }
//         }

//         Console.WriteLine("Informe os elementos do vetor V2:");

//         for (int i = 0; i < n; i++)
//         {
//             Console.Write($"V2[{i}] = ");
//             while (!int.TryParse(Console.ReadLine(), out V2[i]))
//             {
//                 Console.Write("Valor inválido. Informe um número inteiro: ");
//             }
//         }

//         int contagemIdenticos = 0;

//         for (int i = 0; i < n; i++)
//         {
//             if (V1[i] == V2[i])
//             {
//                 contagemIdenticos++;
//             }
//         }

//         Console.WriteLine($"Número de posições com valores idênticos: {contagemIdenticos}");

// Exercicio 50 ------------------------------------------------

//    Random random = new Random();
//         int numeroSorteado = random.Next(0, 101);
//         int tentativa;
//         int numeroTentativas = 0;

//         Console.WriteLine("Tente adivinhar o número sorteado entre 0 e 100.");

//         do
//         {
//             Console.Write("Digite sua tentativa: ");
//             while (!int.TryParse(Console.ReadLine(), out tentativa) || tentativa < 0 || tentativa > 100)
//             {
//                 Console.Write("Valor inválido. Informe um número entre 0 e 100: ");
//             }

//             numeroTentativas++;

//             if (tentativa < numeroSorteado)
//             {
//                 Console.WriteLine("O número sorteado é maior que sua tentativa.");
//             }
//             else if (tentativa > numeroSorteado)
//             {
//                 Console.WriteLine("O número sorteado é menor que sua tentativa.");
//             }
//             else
//             {
//                 Console.WriteLine($"Parabéns! Você acertou o número em {numeroTentativas} tentativas.");
//             }
//         }
//         while (tentativa != numeroSorteado);

// Exercicio 51- -------------------------------------------------


//  Console.Write("Informe o número de alunos: ");
//         int N;
//         while (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
//         {
//             Console.Write("Valor inválido. Informe um número inteiro positivo: ");
//         }

//         double somaNotas = 0;
//         int alunosAcimaDe7 = 0;
//         bool algumAlunoAcimaDe5 = false;

//         for (int i = 0; i < N; i++)
//         {
//             Console.Write($"Informe a nota do aluno {i + 1}: ");
//             double nota;
//             while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10)
//             {
//                 Console.Write("Nota inválida. Informe uma nota entre 0 e 10: ");
//             }

//             somaNotas += nota;

//             if (nota > 7)
//             {
//                 alunosAcimaDe7++;
//             }

//             if (nota > 5)
//             {
//                 algumAlunoAcimaDe5 = true;
//             }
//         }

//         double mediaNotas = somaNotas / N;

//         Console.WriteLine($"A média das notas é: {mediaNotas:F2}");
//         Console.WriteLine($"Número de alunos com nota acima de 7.0: {alunosAcimaDe7}");

//         if (!algumAlunoAcimaDe5)
//         {
//             Console.WriteLine("Não há nenhum aluno com nota acima de 5.");
//         }

// Exercicio 52 ------------------------------------------------

// const int maxTamanho = 100;
//         int[] vetor = new int[maxTamanho];
//         int tamanho = 0;

//         Console.WriteLine("Digite os números (inteiros positivos) para o vetor. Digite -1 para encerrar.");

//         while (tamanho < maxTamanho)
//         {
//             Console.Write($"Digite o número {tamanho + 1}: ");
//             int valor;
//             if (!int.TryParse(Console.ReadLine(), out valor))
//             {
//                 Console.WriteLine("Valor inválido. Informe um número inteiro.");
//                 continue;
//             }

//             if (valor == -1)
//             {
//                 break;
//             }

//             if (valor >= 0)
//             {
//                 vetor[tamanho] = valor;
//                 tamanho++;
//             }
//             else
//             {
//                 Console.WriteLine("Digite apenas números inteiros positivos ou -1 para encerrar.");
//             }
//         }

//         int contagem1 = 0;
//         int contagem3 = 0;
//         int contagem4 = 0;

//         for (int i = 0; i < tamanho; i++)
//         {
//             if (vetor[i] == 1)
//             {
//                 contagem1++;
//             }
//             else if (vetor[i] == 3)
//             {
//                 contagem3++;
//             }
//             else if (vetor[i] == 4)
//             {
//                 contagem4++;
//             }
//         }

//         Console.WriteLine($"Número de vezes que o 1 aparece: {contagem1}");
//         Console.WriteLine($"Número de vezes que o 3 aparece: {contagem3}");
//         Console.WriteLine($"Número de vezes que o 4 aparece: {contagem4}");

// Exercicio 53 -----------------------------------------

//  Console.Write("Informe o número de voltas: ");
        // int N;
        // while (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
        // {
        //     Console.Write("Valor inválido. Informe um número inteiro positivo: ");
        // }

        // double[] tempos = new double[N];

        // Console.WriteLine("Digite os tempos das voltas em segundos:");

        // for (int i = 0; i < N; i++)
        // {
        //     Console.Write($"Volta {i + 1}: ");
        //     while (!double.TryParse(Console.ReadLine(), out tempos[i]) || tempos[i] < 0)
        //     {
        //         Console.Write("Valor inválido. Informe um tempo positivo em segundos: ");
        //     }
        // }

        // double melhorTempo = tempos[0];
        // int voltaMelhorTempo = 1;
        // double somaTempos = 0;

        // for (int i = 0; i < N; i++)
        // {
        //     somaTempos += tempos[i];
        //     if (tempos[i] < melhorTempo)
        //     {
        //         melhorTempo = tempos[i];
        //         voltaMelhorTempo = i + 1;
        //     }
        // }

        // double mediaTempos = somaTempos / N;

        // Console.WriteLine($"Melhor tempo: {melhorTempo:F2} segundos");
        // Console.WriteLine($"Volta com o melhor tempo: {voltaMelhorTempo}");
        // Console.WriteLine($"Tempo médio das {N} voltas: {mediaTempos:F2} segundos");

//Exercico 54 ------------------------------------------------


//  int[] A = new int[5];
//         int[] B = new int[8];

//         Console.WriteLine("Informe os 5 elementos do vetor A:");
//         for (int i = 0; i < 5; i++)
//         {
//             Console.Write($"A[{i}] = ");
//             A[i] = int.Parse(Console.ReadLine());
//         }

//         Console.WriteLine("Informe os 8 elementos do vetor B:");
//         for (int i = 0; i < 8; i++)
//         {
//             Console.Write($"B[{i}] = ");
//             B[i] = int.Parse(Console.ReadLine());
//         }

//         Console.WriteLine("Elementos comuns aos dois vetores:");
//         bool encontrou = false;

//         for (int i = 0; i < 5; i++)
//         {
//             for (int j = 0; j < 8; j++)
//             {
//                 if (A[i] == B[j])
//                 {
//                     Console.Write($"{A[i]} ");
//                     encontrou = true;
//                     break;
//                 }
//             }
//         }

//         if (!encontrou)
//         {
//             Console.WriteLine("Nenhum elemento comum encontrado.");
//         }

//         Console.WriteLine();

// Exercicio 55 ------------------------------------------------------

//  Console.Write("Digite uma frase de até 50 caracteres: ");
//         string frase = Console.ReadLine();

//         if (frase.Length > 50)
//         {
//             Console.WriteLine("A frase excede o limite de 50 caracteres.");
//             return;
//         }

//         int quantidadeEspacos = 0;
//         string fraseSemEspacos = "";

//         foreach (char c in frase)
//         {
//             if (c == ' ')
//             {
//                 quantidadeEspacos++;
//             }
//             else
//             {
//                 fraseSemEspacos += c;
//             }
//         }

//         Console.WriteLine($"Frase sem espaços: {fraseSemEspacos}");
//         Console.WriteLine($"Quantidade de espaços em branco: {quantidadeEspacos}");

// Exercicio 56 ----------------------------------------------------

    //  Console.Write("Digite uma frase: ");
    //     string frase = Console.ReadLine();

    //     string vogais = "";

    //     foreach (char c in frase)
    //     {
    //         if ("aeiouAEIOU".IndexOf(c) >= 0)
    //         {
    //             vogais += c;
    //         }
    //     }

    //     Console.WriteLine($"Vogais na frase: {vogais}");

// Exercicio 57 --------------------------------------------------------

//  Console.Write("Digite a quantidade de números que deseja informar: ");
//         int quantidade;
//         while (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade <= 0)
//         {
//             Console.Write("Valor inválido. Informe um número inteiro positivo: ");
//         }

//         int[] numeros = new int[quantidade];
//         int soma = 0;
//         int maior = int.MinValue;

//         Console.WriteLine("Digite os números inteiros e positivos:");

//         for (int i = 0; i < quantidade; i++)
//         {
//             Console.Write($"Número {i + 1}: ");
//             int numero;
//             while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
//             {
//                 Console.Write("Valor inválido. Informe um número inteiro positivo: ");
//             }

//             numeros[i] = numero;
//             soma += numero;

//             if (numero > maior)
//             {
//                 maior = numero;
//             }
//         }

//         double media = (double)soma / quantidade;

//         Console.WriteLine($"A média dos números é: {media:F2}");
//         Console.WriteLine($"O maior número é: {maior}");

// Exercicio 59 ------------------------------------------------------

//  Console.Write("Digite o primeiro caractere (de A a Z): ");
//         char caractere1 = Console.ReadKey().KeyChar;
//         Console.WriteLine();

//         Console.Write("Digite o segundo caractere (de A a Z): ");
//         char caractere2 = Console.ReadKey().KeyChar;
//         Console.WriteLine();

//         if (!char.IsLetter(caractere1) || !char.IsLetter(caractere2) ||
//             !char.IsUpper(caractere1) || !char.IsUpper(caractere2) ||
//             caractere1 >= caractere2)
//         {
//             Console.WriteLine("Erro: Os caracteres devem ser letras maiúsculas e o primeiro deve ser antes do segundo na ordem alfabética.");
//             return;
//         }

//         int numeroDeCaracteres = caractere2 - caractere1 - 1;

//         Console.WriteLine($"O número de caracteres entre {caractere1} e {caractere2} é: {numeroDeCaracteres}");
