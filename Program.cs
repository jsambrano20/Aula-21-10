using System;

namespace Aula21_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //estruturas condicionais
            // criar if, else if, if dentro if
            /* Switch case -->Estruturas seletivas -> selecionar->menu -> menus e comparações mais "simples"
             Só compara inteiros e caracteres -> não poderemos comparar strings (existem funções, pontos flutuantes 
             */

            //int n , x;Console.Write("Digite um numero: ");
            //n = int.Parse(Console.ReadLine());

            //switch (n) //variável de controle será N, ou seja, as comparações erá nela
            //{
            //    case 0:
            //        Console.WriteLine("o n vale 0");
            //        x = 11;
            //        Console.WriteLine("Oi");
            //        break; // finalizar o case
            //    case 10:
            //        Console.WriteLine("o N vale 10");
            //        x = 11;
            //        Console.WriteLine("o N vale 11 "+ x);
            //        x = x * 2;
            //        Console.WriteLine("o N vale 11" + x);
            //        break;
            //    default:
            //        Console.WriteLine("Default");
            //        break;
            //}



            //char letra;
            //Console.WriteLine("Digite uma letra ou caractere : ");
            //letra = char.Parse(Console.ReadLine());
            //switch(letra)
            //{
            //    case 'r':
            //        Console.WriteLine("A letra digitada foi r");
            //        break;
            //    case ':':
            //        Console.WriteLine("Foi digitado :");
            //        break;
            //    default:
            //        Console.WriteLine("nada");
            //        break;
            //}


            //EXERCICIo 1 
            //int n;
            //Console.WriteLine("Digite um mês de 1 á 12: ");
            //n = int.Parse(Console.ReadLine());

            //switch(n)
            //{
            //    case 1:
            //        Console.WriteLine("Janeiro");
            //        break;
            //    case 2:
            //        Console.WriteLine("Fevereiro");
            //        break;
            //    case 3:
            //        Console.WriteLine("março");
            //        break;
            //    case 4:
            //        Console.WriteLine("abril");
            //        break;
            //    case 5:
            //        Console.WriteLine("maio");
            //        break;
            //    case 6:
            //        Console.WriteLine("junho");
            //        break;
            //    case 7:
            //        Console.WriteLine("julho");
            //        break;
            //    case 8:
            //        Console.WriteLine("agosto");
            //        break;
            //    case 9:
            //        Console.WriteLine("setembro");
            //        break;
            //    case 10:
            //        Console.WriteLine("outubro");
            //        break;
            //    case 11:
            //        Console.WriteLine("novembro");
            //        break;
            //    case 12:
            //        Console.WriteLine("dezembro");
            //        break;
            //    default:
            //        Console.WriteLine("INEXISTENTE");
            //        break;
            //}


            //EXERCICIO 2 

            //int n1, n2;
            //char o;

            //Console.WriteLine("digite dois numero: ");
            //n1 = int.Parse(Console.ReadLine());
            //n2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("digite um operador: (\n+ soma \n- subtração \n* multiplicação \n/ divisão");
            //o = char.Parse(Console.ReadLine());

            //switch (o)
            //{
            //    case '+':
            //        Console.WriteLine("Soma = " + (n1 + n2));
            //        break;
            //    case '*':
            //        Console.WriteLine("Multiplicação = " + (n1 * n2));
            //        break;
            //    case '-':
            //        Console.WriteLine("Subtração = " + (n1 - n2));
            //        break;
            //    case '/':
            //        Console.WriteLine("Divisão = " + (n1 / n2));
            //        break;
            //    default:
            //        Console.WriteLine("Inválido");
            //        Console.WriteLine("Divisão = " + (n1 / n2) + "Subtração = " + (n1 - n2) + "Multiplicação = " + (n1 * n2) + "Soma = " + (n1 + n2));
            //        break;
            //}

            //EXERCICIO 3 

            //int f;
            //double n;

            //Console.WriteLine("Codigo do consumidor: ");
            //f = int.Parse(Console.ReadLine());
            //Console.WriteLine("Informe valor: ");
            //n = double.Parse(Console.ReadLine());

            //switch (f)
            //{
            //    case 1:
            //        Console.WriteLine("Cliente comuns " + n);
            //        break;
            //    case 2:
            //        Console.WriteLine("Funcionários " + (n - n * 0.1));
            //        break;
            //    case 3:
            //        Console.WriteLine("Vips " + (n  - n * 0.05) );
            //        break;
            //}

            ///* operador ternário -> tudo que o ternário faz , o if faz...              * forma simplicada da estrutura if-else -> não é muito usual             * operador ternário "?"             * condição ? instrução1 : instrução 2 */
            //int i;
            //char x;
            //Console.WriteLine("Digite um valor: ");
            //i = int.Parse(Console.ReadLine());
            //// Se o numero digitado for par, eu quero mostrar "p" e se for impar "i" na tela            x = (i % 2 == 0) ? x = 'p' : x = 'i';
            //Console.WriteLine("Resultado do operador ternário: " + x);

            //int i;
            //char x;
            //Console.WriteLine("Digite um valor: ");
            //i = int.Parse(Console.ReadLine());

            ////Se o numero digitado for par, eu quero mostrar "p" e se for impar "i" na tela
            //i = (i % 2 == 0) ? i : i + 1;
            //Console.WriteLine("Resultado do operador ternário : " + x);


            //int i;
            //for (i = 0; i <4; i++) //Valor iniciar; condição; incremento ou decremento
            //   {
            //    Console.WriteLine("i vale " + i);
            //    }

            //EXERCICIO 4
            //int i;
            //for (i = 0; i <=10; i++)
            //   {
            //    Console.WriteLine("i vale " + i);
            //    }

            //EXERCICIO 5
            //int i;
            //for (i = 20; i >= 5; i--)
            //{
            //    Console.WriteLine("i vale " + i);
            //}

            //EXERCICIO 6

            //int i, inicio, fim;
            //Console.WriteLine("digite o inicio: ");
            //inicio = int.Parse(Console.ReadLine());
            //Console.WriteLine("digite o fim: ");
            //fim = int.Parse(Console.ReadLine());

            //if (fim > inicio)
            //{
            //    for (i = inicio; i < fim; i++)
            //    {
            //        Console.WriteLine("Valor de i = " + i);
            //    }
            //}
            //else if (fim < inicio)
            //{
            //    for (i = inicio; i < fim; i++)
            //    {
            //        Console.WriteLine("Valor de i = " + i);
            //    }

            //}


            //EXERCIO 7
            
            //int i, x;
            //Console.WriteLine("Valor de X: ");
            //x = int.Parse(Console.ReadLine());

            //for (i = 0; i <= 100; i=i+x)
            //{
            //    Console.WriteLine("i = " + i);
            //}
        }
    }
}
