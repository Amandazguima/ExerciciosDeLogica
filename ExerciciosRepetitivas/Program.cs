using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosRepetitivas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estrutura while

            #region Crescente 

            //int x, y;
            //Console.WriteLine("Digite o valor de x");
            //x = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor de y");
            //y = int.Parse(Console.ReadLine());
            //while (x!=y)
            //{

            //    if (x > y)
            //    {
            //        Console.WriteLine("Decrescente");

            //    }
            //    else
            //    {
            //        Console.WriteLine("Crescente");

            //    }
            //    Console.WriteLine("Digite o valor de x:");
            //    x=int.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite o valor de y:");
            //    y =int.Parse(Console.ReadLine());

            //}

            //Console.WriteLine("Aperte enter para encerrar o programa");

            #endregion

            #region media idades

            //Console.WriteLine("Digite as idades:");
            //int idade, soma,count;
            //float media ;
            //soma = 0;
            //count = 0;
            //idade = int.Parse(Console.ReadLine());
            //while (idade >= 0)
            //{
            //    soma = soma + idade;
            //    count = count + 1;
            //    idade = int.Parse(Console.ReadLine());
            //}

            //if (count == 0)
            //{
            //    Console.WriteLine("Impossivel calcular");
            //}
            //else
            //{
            //    media = soma / count;
            //    Console.WriteLine(media);
            //}

            #endregion

            #region Senha Fixa
            //Console.WriteLine("Digite a senha de Login:");
            //int senha = int.Parse(Console.ReadLine());


            //while (senha != 2002)
            //{
            //    Console.WriteLine("Senha Invalida! tente novamente:");

            //    senha = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Acesso Permitido!");

            #endregion

            #region quadrante
            //float x, y;
            //Console.WriteLine("Digite o valor da coordenada x:");
            //x= float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor da coordenada y:");
            //y = float.Parse(Console.ReadLine());

            //while(x!=0 && y != 0)
            //{
            //    if (x > 0 && y > 0)
            //    {
            //        Console.WriteLine("As coordenadas x e y se encontram no primeiro quadrante");
            //    }
            //    else if (x < 0 && y < 0)
            //    {
            //        Console.WriteLine("As coordenadas x e y se encontram no terceiro quadrante");
            //    }
            //    else if (x > 0 && y < 0)
            //    {
            //        Console.WriteLine("As coordenadas x e y se encontram no quarto quadrante");
            //    }
            //    else 
            //    {
            //        Console.WriteLine("As coordenadas x e y se encontram no segundo quadrante");
            //    }
            //    Console.WriteLine("Digite o valor da coordenada x:");
            //    x = float.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite o valor da coordenada y:");
            //    y = float.Parse(Console.ReadLine());


            #endregion

            #region Validação de nota
            //Console.WriteLine("Digite a primeira nota");
            //float nota1, nota2,media;
            //nota1= float.Parse(Console.ReadLine());
            //while(nota1<0 || nota1>10)
            //{
            //    Console.WriteLine("Valor Invalido! Tente Novamente:");
            //    nota1 = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Digite a segunda nota:");
            //nota2 = float.Parse(Console.ReadLine());
            //while (nota2<0 || nota2 > 10)
            //{
            //    Console.WriteLine("Valor Invalido! Tente Novamente:");
            //    nota2 = int.Parse(Console.ReadLine());

            //}
            //media = (nota1 + nota2) / 2;
            //Console.WriteLine($"Sua media foi : {media}");

            #endregion

            #region combustivel 
            //int alcool = 0;
            //int gasolina = 0;
            //int diesel = 0;
            //Console.WriteLine("Informe um código: \n Digite 1 para alcool. \n Digite 2 para gasolina \n Digite 3 para diesel \n Digite 4 para encerar a aplicação.");
            //int codigo = int.Parse(Console.ReadLine());
            //while (codigo != 4)
            //{
            //    if (codigo == 1)
            //    {
            //        alcool++;
            //    }
            //    else if (codigo == 2)
            //    {
            //        gasolina++;
            //    }
            //    else
            //    {
            //        diesel++;
            //    }

            //    Console.WriteLine("Informe um código: \n Digite 1 para alcool. \n Digite 2 para gasolina \n Digite 3 para diesel \n Digite 4 para encerar a aplicação.");
            //    codigo = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Muito Obrigada por participar da nossa pesquisa!");
            //Console.WriteLine($"Votações: Alcool: {alcool}\n Gasolina: {gasolina} \n Diesel: {diesel}");
            #endregion

            #region Pares Consecutivos

            //Console.WriteLine("Digite um numero inteiro");
            //int x = int.Parse(Console.ReadLine());
            //while (x != 0) 
            //{
            //    if (x % 2 == 0)
            //    {
            //        int x1 = x + 2;
            //        int x2 = x1 + 2;
            //        int x3 = x2 + 2;
            //        int x4 = x3 + 2;


            //        Console.WriteLine($"Soma = {x+x1+x2+x3+x4}");

            //    }
            //    else
            //    {
            //        x = x + 1;
            //        int x1 = x + 2;
            //        int x2 = x1 + 2;
            //        int x3 = x2 + 2;
            //        int x4 = x3 + 2;


            //        Console.WriteLine($"Soma = {x+ x1 + x2 + x3 + x4}");

            //    }
            //    Console.WriteLine("Digite um numero inteiro");
            //    x = int.Parse(Console.ReadLine());
            //}

            #endregion

            // Estrutura de repetição for

            #region tabuada
            //Console.WriteLine("Deseja a tabuada para qual valor ?");
            //int x = int.Parse(Console.ReadLine());
            //for(int i =1; i<=10; i++)
            //{
            //    int j = i * x;
            //    Console.WriteLine(j);
            //}

            #endregion

            #region Soma impares

            Console.WriteLine("Digite dois números");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int troca = 0;
            if (x > y)
            {
                troca = x;
                x = y;
                y = troca;
                
            }
            int soma = 0;
            for (int i =x+1; i< y; i++  )
            {
                if( i%2 != 0)
                {
                    soma = soma + i;
                }
            }
            Console.WriteLine($"Soma dos impares: {soma}");
            #endregion

            #region Sequencia impares 
            //Console.WriteLine("Digite o valor de X");
            //for (int x = int.Parse(Console.ReadLine()); x > 0; x--)
            //{
            //    if(x % 2 != 0)
            //    { 
            //        Console.WriteLine(x); 
            //    }

            //}

            //* Correção

            //int x, i;
            //x = int.Parse(Console.ReadLine());
            //for (i = 0; i <= x; i++)
            //{
            //    if (i%2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion

            #region dentro e fora
            //int x,n ;
            //int j = 0;
            //int k = 0;
            //Console.WriteLine("Quantos números você vai digitar ?");
            //for ( n=int.Parse(Console.ReadLine());  n>0; n--)
            //{
            //    Console.WriteLine("Digite um número:");
            //    x = int.Parse(Console.ReadLine());
            //    if (x >= 10 && x <= 20)
            //    {
            //        j++;
            //    }
            //    else
            //    {
            //        k++;
            //    }
            //}
            //Console.WriteLine($"Dentro {j}");
            //Console.WriteLine($"Fora {k}");

            #endregion

            #region Par impar

            //Console.WriteLine("Quantos números você vai digitar?");
            //for (int i= int.Parse(Console.ReadLine()); i > 0; i--)
            //{
            //    Console.WriteLine("Digite um número");
            //    int y = int.Parse(Console.ReadLine());
            //    if (y > 0 && y % 2 == 0)
            //    {
            //        Console.WriteLine("O número inserido é Par e também é Positivo");
            //    }
            //    else if (y > 0 && y % 2 != 0)
            //    {
            //        Console.WriteLine("O número inserido é Impar e também é Positivo ");
            //    }
            //    else if (y < 0 && y % 2 != 0)
            //    {
            //        Console.WriteLine("O número inserido é Impar e também é Negativo");
            //    }
            //    else if  (y<0 && y%2 ==0)
            //    {
            //        Console.WriteLine("O número inserido é Par e também é Negativo");
            //    }
            //    else
            //    {
            //        Console.WriteLine(" O número inserido é Nulo");
            //    }
            //}
            #endregion

            #region Media Ponderada

            //Console.WriteLine("Quantos casos você vai digitar?");
            //for(int i = int.Parse(Console.ReadLine()); i > 0; i--)
            //{
            //    Console.WriteLine("Digite três números");
            //    float x= float.Parse(Console.ReadLine());
            //    float y = float.Parse(Console.ReadLine());
            //    float z = float.Parse(Console.ReadLine());
            //    float media =( (x * 2) + (y * 3) + (z * 5) )/ 10;
            //    Console.WriteLine($"A média Ponderada = {media}");

            //}

            #endregion

            #region divisao

            //Console.WriteLine("Quantos casos você vai digitar?");
            //for(int i = int.Parse(Console.ReadLine()); i > 0; i--)
            //{
            //    Console.WriteLine("Entre com o Numerador:");
            //    float n = float.Parse(Console.ReadLine());
            //    Console.WriteLine("Entre com o Denominador");
            //    float m = float.Parse(Console.ReadLine());
            //    if (m == 0)
            //    {
            //        Console.WriteLine("Divisão impossivel! ");
            //    }
            //    else
            //    {
            //        float z = n / m;
            //        Console.WriteLine($"Resultado: {z}");
            //    }
            //}

            #endregion

            #region fatorial
            //Console.WriteLine("Digite o valor do número fatorial:");
            //int j = 1;
            //int n = int.Parse(Console.ReadLine());
            //for(int i = 1; i<=n; i++)
            //{
            //   j = j * i;
            //}
            //Console.WriteLine($"Fatorial = {j}");

            #endregion

            #region experiencias
            // double coelhos = 0;
            // double ratos = 0;
            // double sapos = 0;
            // Console.WriteLine("Quantos casos de teste foram realizados?");
            // for(int i = int.Parse(Console.ReadLine()); i > 0; i--)
            // {
            //     Console.WriteLine("Tipo de cobaia:");
            //     char cobaia = char.Parse(Console.ReadLine());
            //     Console.WriteLine("quantidade de cobaia");
            //     double quantidadeCobaias = double.Parse(Console.ReadLine());
            //     if (cobaia == 'C')
            //     {
            //          coelhos = coelhos + quantidadeCobaias;
            //     }
            //     else if(cobaia == 'S')
            //     {
            //         sapos= sapos + quantidadeCobaias;
            //     }
            //     else
            //     {
            //         ratos= ratos + quantidadeCobaias;
            //     }

            // }

            //double totaldeCoabaias = ratos + sapos + coelhos;
            // double perCoelhos = (coelhos / totaldeCoabaias) * 100;
            // double perRatos = (ratos / (totaldeCoabaias)) * 100;
            // double perSapos = (sapos / totaldeCoabaias) * 100;

            // Console.WriteLine($"Relatório Final:\n Total de cobaias: {totaldeCoabaias}\n Total de Coelhos:{coelhos}\n Total de Sapos:{sapos} \n Total de Ratos: {ratos}");
            // Console.WriteLine($"Percentual de Coelhos: {perCoelhos}% \n Percentual de Sapos:{perSapos}%\n Percentual de Ratos: {perRatos}% ");

            #endregion

            Console.ReadKey();
        }
    }
}
