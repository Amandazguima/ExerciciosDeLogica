using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region diagonal negativos

            //Console.WriteLine("Quantas linhas vai ter a matriz?");
            //int l = int.Parse(Console.ReadLine());
            //Console.WriteLine("Quantas colunas vão ter a matriz?");
            //int c = int.Parse(Console.ReadLine());
            //int[,] x = new int[9, 9];

            //for (int i = 0; i < l; i++)
            //{
            //    for (int j = 0; j < c; j++)
            //    {
            //        Console.WriteLine($"Elemento [{i},{j}]:");
            //        x[i, j] = int.Parse(Console.ReadLine());

            //    }
            //}
            //Console.WriteLine("Matriz Digitada:");
            //int soma = 0;

            //for (int i = 0; i < l; i++)
            //{
            //    for (int j = 0; j < c; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write($"{x[i, j]} ");
            //        }
            //        if (x[i, j] < 0)
            //        {
            //            soma++;
            //        }

            //    }
            //}
            //Console.WriteLine($"\n Quantidade de negativos= {soma}");
            #endregion

            #region Soma linhas

            //Console.WriteLine("Qual a quantidade de linhas da matriz?");
            //int l = int.Parse(Console.ReadLine());
            //Console.WriteLine("Qual a quantidade de colunas da matriz?");
            //int c = int.Parse(Console.ReadLine());
            //int[,] x = new int[9, 9];
            //int[] soma = new int[9];

            //for (int i = 0; i < l; i++)
            //{
            //    Console.WriteLine($"Digite os Elementos da {i}ª linha:");
            //    for (int j = 0; j < c; j++)
            //    {
            //        x[i, j] = int.Parse(Console.ReadLine());
            //        soma[i] = soma[i] + x[i, j];
            //    }

            //}


            //Console.WriteLine("Vetor Gerado");

            //for (int i = 0; i < l; i++)
            //{

            //    Console.WriteLine(soma[i]);

            //}

            #endregion

            #region Negativos matriz

            //Console.WriteLine("Quantidade de linhas da matriz?");
            //int l = int.Parse(Console.ReadLine());
            //Console.WriteLine("Quantidade de colunas da matriz?");
            //int c = int.Parse(Console.ReadLine());
            //int[,] x = new int[9, 9];
            //for (int i = 0; i < l; i++)
            //{
            //    for(int j = 0; j < c; j++)
            //    {
            //        Console.WriteLine($"Elementos [{i},{j}]");
            //        x[i, j] = int.Parse(Console.ReadLine());
            //    }

            //}
            //Console.WriteLine("Valores Negativos:");
            //for (int i = 0; i < l; i++)
            //{
            //    for (int j = 0; j < c; j++)
            //    {
            //        if(x[i, j] < 0)
            //        {
            //            Console.WriteLine(x[i, j]);
            //        }
            //    }

            //}

            #endregion

            #region Cada Linha

            //Console.WriteLine("Qual a ordem da matriz?");
            //int d = int.Parse(Console.ReadLine());
            //int[,] x = new int[9, 9];
            //for (int i = 0; i < d ; i++)
            //{
            //    for(int j = 0; j < d; j++)
            //    {
            //        Console.WriteLine($"Elemento [{i},{j}]");
            //        x[i,j] = int.Parse(Console.ReadLine());

            //    }
            //}

            //Console.WriteLine("Maior elemento de cada linha");

            //for (int i = 0; i < d; i++)
            //{
            //    int valorJ = x[i, 0];

            //    for (int j = 0; j < d; j++)
            //    {
            //        if (x[i,j] > valorJ)
            //        {
            //           valorJ = x[i, j];

            //        }

            //    }
            //    Console.WriteLine(valorJ);
            //}

            #endregion

            #region Soma matrizes

            //Console.WriteLine("Qual a quantidade de linhas da matriz?");
            //int l = int.Parse(Console.ReadLine());
            //Console.WriteLine("Qual a quantidade de colunas da matriz?");
            //int c = int.Parse(Console.ReadLine());
            //int[,] x = new int[9, 9];
            //int[,] y = new int[9,9];
            //int[,] z = new int[9, 9];      
            //Console.WriteLine($"Digite os valores da matriz A");
            //for (int i = 0; i < l; i++)
            //{

            //    for (int j = 0; j < c; j++)
            //    {
            //        Console.WriteLine($"Elemento[{i},{j}]");
            //        x[i, j] = int.Parse(Console.ReadLine());

            //    }

            //}
            //Console.WriteLine($"Digite os valores da matriz B");
            //for (int i = 0; i < l; i++)
            //{

            //    for (int j = 0; j < c; j++)
            //    {
            //        Console.WriteLine($"Elemento[{i},{j}]");
            //        y[i, j] = int.Parse(Console.ReadLine());

            //    }

            //}


            //Console.WriteLine("Matriz soma:");
            //for (int i = 0; i < l; i++)
            //{

            //    for (int j = 0; j < c; j++)
            //    {
            //        z[i, j] = x[i, j] + y[i, j];
            //        Console.Write(z[i, j]+ " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Acima diagonal

            //Console.WriteLine("Qual a ordem da matriz?");
            //int d = int.Parse(Console.ReadLine());
            //int[,] x = new int[9, 9];
            //for (int i = 0; i < d; i++)
            //{
            //    for (int j = 0; j < d; j++)
            //    {
            //        Console.WriteLine($"Elemento [{i},{j}]");
            //        x[i, j] = int.Parse(Console.ReadLine());

            //    }
            //}
            //Console.WriteLine("Soma dos elementos acima da diagonal principal = ");
            //int soma = 0;
            //for (int i = 0; i < d; i++)
            //{
            //    for (int j = 0; j < d; j++)
            //    {
            //       if( i < j )
            //       {
            //            soma = soma + x[i, j];
            //       }

            //    }
            //}
            //Console.WriteLine(soma);

            #endregion

            #region matriz geral

            Console.WriteLine("Qual a ordem da matriz?");
            int d = int.Parse(Console.ReadLine());
            double[,] x = new double[9, 9];
            double soma = 0;
            for (int i = 0; i < d; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    Console.WriteLine($"Elemento [{i},{j}]");
                    x[i, j] = int.Parse(Console.ReadLine());

                }
            }
            for (int i = 0; i < d; i++)
            {
                for (int j = 0; j < d; j++)
                {
                   if(x[i, j] > 0)
                   {
                        soma = soma + x[i, j];
                   }

                }
            }
           
            Console.WriteLine($"Soma dos positivos:{soma}");
            Console.WriteLine("Escolha uma linha:");
            int escolhaL = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < d; i++)
            {
                
                for (int j = 0; j < d; j++)
                {
                    if (i == escolhaL)
                    {
                        Console.Write(x[i, j] + "\n");
                    }
   
                }
            }
            Console.WriteLine("Escolha uma coluna:");
            int escolhaC = int.Parse(Console.ReadLine());
            for (int i = 0; i < d; i++)
            {

                for (int j = 0; j < d; j++)
                {
                    if(j == escolhaC)
                    {
                        Console.Write(x[i, j] + "\n");
                    }

                }
            }
            Console.WriteLine("Diagonal Principal:");
            for (int i = 0; i < d; i++)
            {

                for (int j = 0; j < d; j++)
                {
                    if (i==j)
                    {
                        Console.Write(x[i, j] + "\n");
                    }

                }
            }
            Console.WriteLine("Matriz alterada:");
            for (int i = 0; i < d; i++)
            {

                for (int j = 0; j < d; j++)
                {
                    if (x[i,j] < 0)
                    {
                        
                        x[i,j] = Math.Pow(x[i, j], 2);

                    }
                    Console.Write(x[i, j]+" ");
                }
                Console.WriteLine();
            }


            #endregion

            Console.ReadKey();

        }
    }
}
