using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Negativos
            //Console.WriteLine("quantos valores inteiros você irá introduzir?");
            //int[] n = new int[9];
            //int z = int.Parse(Console.ReadLine());
            //int i = 0;
            //for( i = z ; i > 0; i--)
            //{
            //    Console.WriteLine("Digite os números do vetor");
            //    n[i]= int.Parse(Console.ReadLine());


            //}

            //Console.WriteLine("Números negativos");

            //for (i = z ; i >0; i--)
            //{
            //    if(n[i] < 0)
            //    {
            //        Console.WriteLine(n[i]);
            //    }
            //}

            #endregion

            #region  Soma vetor

            //double[] vet = new  double [9];
            //Console.WriteLine("quantos numeros você vai digitar?");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = num; i > 0; i--)
            //{
            //    Console.WriteLine("Digite um número:");
            //    vet[i] = double.Parse(Console.ReadLine());
            //}

            //for (int i = num; i > 0; i--)
            //{
            //    Console.WriteLine($"Valores: {vet[i]}");

            //}
            //double soma = 0;
            //for(int i = num; i > 0; i--)
            //{
            //    soma = soma + vet [i];
            //}
            //Console.WriteLine($"Soma = {soma}\n");
            //double media = soma / num;
            //Console.WriteLine($"Media = {media}");
            #endregion

            #region Alturas
            //Console.WriteLine("Quantas pessoas participaram?");
            //int n = int.Parse(Console.ReadLine());
            //string[] name = new string[9];
            //int [] idade = new int [9];
            //double[] altura = new double[9];

            //for(int i =n ;i > 0; i--)
            //{
            //    Console.WriteLine($"Dados da {i}º pessoa");
            //    Console.WriteLine("Nome:");
            //    name[i] = Console.ReadLine();
            //    Console.WriteLine("Idade:");
            //    idade[i] = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Altura:");
            //    altura[i] = double.Parse(Console.ReadLine());

            //}
            //double soma = 0;
            //for (int i = n; i > 0; i--)
            //{
            //     soma = soma + altura[i];
            //}
            //double media = soma / n;
            //double menores = 0;
            //Console.WriteLine($"Altura média: {Math.Round(media,2)}");
            //for (int i = n; i > 0; i--)
            //{
            //    if (idade[i] < 16)
            //    {
            //        menores++; 
            //        Console.WriteLine($"Pessoas que tem menos de 18 anos: {name[i]}");
            //    }
            //}
            //double porcentagem = (menores / n) * 100;
            //Console.WriteLine(Math.Round(porcentagem)) ;   
            #endregion

            #region Numeros Pares

            //int[] n = new int[9];
            //Console.WriteLine("Quantos números você vai digitar");
            //int b = int.Parse(Console.ReadLine());
            //int i = 0;
            //for( i = 0; i <b ; i++)
            //{
            //    Console.WriteLine("Digite um número:");
            //    n[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Números Pares:");
            //int quantidade = 0;
            //for (i=0; i < b; i++)
            //{
            //    if (n[i] %2 == 0)
            //    {
            //        quantidade++;
            //        Console.WriteLine(n[i]);
            //    }
            //}

            //Console.WriteLine($"quantidade de números pares foi:{quantidade}");

            #endregion

            #region Maior posição

            //int[] n = new int[9];
            //Console.WriteLine("Quantos números você vai digitar");
            //int b = int.Parse(Console.ReadLine());
            //int i = 0;
            //for (i = 0; i < b; i++)
            //{
            //    Console.WriteLine("Digite um número:");
            //     n[i] = int.Parse(Console.ReadLine());
            //}
            //int maior = n[1];
            //int posMaior = 0;
            //for (i = 1; i < b-1; i++)
            //{
            //    if (n[i]> maior)
            //    {
            //        maior = n[i];
            //        posMaior = i;
            //    }
            //}

            //Console.WriteLine($"O maior valor é: {maior} e a sua posição é: {posMaior}");

            #endregion

            #region Soma vetores
            //int[] a = new int[9];
            //int[] b = new int[9];
            //int[] c = new int[9];
            //Console.WriteLine("Quantos números você vai digitar");
            //int d = int.Parse(Console.ReadLine());
            //int i = 0;
            //for (i = 0; i < d; i++)
            //{
            //    Console.WriteLine("Digite os valores do vetor A:");
            //    a[i] = int.Parse(Console.ReadLine());

            //}
            //for (i = 0; i < d; i++)
            //{
            //    Console.WriteLine("Digite os valores do vetor B:");
            //    b[i] = int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine("Vetores resultantes");
            //for (i = 0; i < d; i++)
            //{
            //    c[i] = a[i] + b[i];
            //    Console.WriteLine(c[i]);
            //}
            #endregion

            #region abaixo da média 

            //double [] n= new double[9];
            //Console.WriteLine("Quantos elementos vai ter o vetor?");
            //int b= int.Parse(Console.ReadLine());
            //double soma = 0;
            //int i = 0;
            //for (i = 0; i < b; i++)
            //{
            //    Console.WriteLine("Digite um numero");
            //    n[i] = double.Parse(Console.ReadLine());
            //    soma= soma + n[i];
            //}
            //double media = soma / b;
            //Console.WriteLine($"Média do vetor: {Math.Round(media,3)}");
            //Console.WriteLine("Elementos abaixo da média:");
            //for (i = 0; i < b; i++)
            //{
            //    if (n[i] < media)
            //    {
            //        Console.WriteLine(n[i]);
            //    }
            //}

            #endregion

            #region media pares

            //int[] n = new int[9];
            //Console.WriteLine("Quantos elementos vai ter o vetor?");
            //int elementos= int.Parse(Console.ReadLine());
            //int i = 0;
            //int soma = 0;
            //int p = 0;
            //for (i = 0; i < elementos; i++)
            //{
            //    Console.WriteLine("Digite um numero:");
            //    n[i]= int.Parse(Console.ReadLine());

            //}
            //for (i = 0; i < elementos; i++)
            //{
            //    if (n[i] % 2 == 0){
            //        soma = soma + n[i];
            //        p = p + 1;
            //    }

            //}
            //if (p != 0)
            //{
            //    double media = soma / p;
            //    Console.WriteLine($"Media dos pares: {media}");

            //}
            //else
            //{
            //    Console.WriteLine("Nenhum número par!");
            //}
            #endregion

            #region Mais velho

            //int[] idade = new int[9];
            //string[] name = new string [9];
            //Console.WriteLine("quantas pessoas serão digitadas?");
            //int d = int.Parse(Console.ReadLine());
            //int i=0;
            //for(i = 0; i < d; i++)
            //{
            //    Console.WriteLine($"Dados da {i}º pessoa:\n Nome:");
            //    name[i] = Console.ReadLine();
            //    Console.WriteLine("Idade:");
            //    idade[i] = int.Parse(Console.ReadLine());

            //}
            //int idoso = idade[0];
            //int pessoaidosa = 0;
            //for (i = 0; i < d; i++)
            //{
            //    if (idoso < idade[i])
            //    {
            //        idoso= idade[i];
            //        pessoaidosa = i;
            //    }

            //}
            //Console.WriteLine($"A pessoa mais velha é {name[pessoaidosa]}");

            #endregion

            #region Aprovados

            //string[] names = new string[9];
            //double[] notas1 = new double[9];
            //double[] notas2 = new double[9];
            //Console.WriteLine("Quantos alunos serao digitados?");
            //int d = int.Parse(Console.ReadLine());
            //int i = 0;
            //for (i=0; i<d; i++)
            //{
            //    Console.WriteLine("Digite o nome do aluno:");
            //    names[i] = Console.ReadLine();
            //    Console.WriteLine("Digite a primeira e a segunda nota:");
            //    notas1[i] = double.Parse(Console.ReadLine());
            //    notas2[i] = double.Parse(Console.ReadLine());
            //}
            //double[] soma = new double[9];
            //for (i = 0; i < d; i++)
            //{
            //    soma[i] = notas1[i] + notas2[i];
            //    if (soma[i]/2 >= 6)
            //    {
            //        Console.WriteLine($"Alunos Aprovados: {names[i]}");
            //    }
            //}


            #endregion

            #region Dados pessoas

            //Console.WriteLine("Quantas pessoas serão digitadas");
            //int d= int.Parse(Console.ReadLine());
            //double[] altura = new double[9];
            //string[] genero = new string [9];
            //int i = 0;
            //for (i = 0; i < d; i++)
            //{
            //    Console.WriteLine($"Altura da {i}º Pessoa");
            //    altura[i] = double.Parse(Console.ReadLine());
            //    Console.WriteLine($"Genero da {i}º Pessoa");
            //    genero [i] = Console.ReadLine();
            //}
            //double maiorAltura= altura [0];
            //double menorAltura = altura[0];
            //for (i = 0; i < d; i++)
            //{
            //    if(altura[i] > maiorAltura)
            //    {
            //        maiorAltura = altura[i];
            //    }
            //    if (altura[i] < menorAltura)
            //    {
            //        menorAltura = altura[i];
            //    }
            //}

            //Console.WriteLine($"Maior Altura = {Math.Round(maiorAltura,2)} \nMenor Altura = {Math.Round(menorAltura,2)}");
            //double mulher = 0;
            //int m = 0;
            //int homem = 0;
            //for (i = 0; i < d; i++)
            //{
            //    if (genero[i] == "F")
            //    {
            //        mulher = mulher + altura[i];
            //        m++;
            //    }
            //    else
            //    {
            //        homem++;
            //    }
            //}
            //double media = mulher / m;
            //Console.WriteLine($"Media das alturas das Mulheres:{Math.Round(media,2)}");
            //Console.WriteLine($"O numero de homens: {homem}");
            #endregion

            #region Comerciante
            //Console.WriteLine("Serão digitados dados de quantos produtos?");
            //int d = int.Parse(Console.ReadLine());
            //string[] produto = new string[9];
            //double[] preco = new double[9];
            //double[] venda = new double[9];
         
            //int i = 0;
            //for (i = 0; i < d; i++)
            //{
            //    Console.WriteLine($"Produto {i}:\n Nome:");
            //    produto[i] = Console.ReadLine();
            //    Console.WriteLine("Preço de compra:");
            //    preco[i] = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Preço de venda:");
            //    venda[i] = double.Parse(Console.ReadLine());

            //}
            //double[] lucro= new double[9];
            //double[] porcentagem = new double[9];
            //int lA = 0, lE = 0, lAcima = 0;
            //double lucroT = 0,valorTC = 0, valorTV = 0; 
            //for (i = 0; i < d; i++)
            //{
            //    valorTC= valorTC+ preco[i];
            //    valorTV= valorTV+ venda[i];
            //    lucro[i] = venda[i]- preco[i];
            //    lucroT = lucroT + lucro[i];
            //    porcentagem[i] = (lucro[i] / venda[i]) * 100;
            //    if (porcentagem[i] < 10)
            //    {
            //        lA++;
            //    }
            //    else if (porcentagem[i]>=10 && porcentagem[i] < 20)
            //    {
            //        lE++;
            //    }
            //    else
            //    {
            //        lAcima++;
            //    }

            //}
            //Console.WriteLine($"RELATÓRIO:\nLucro abaixo de 10%: {lA} \nLucro entre 10% a 20%: {lE}\nLucro acima de 20%: {lAcima}\nValor total de compra: {valorTC}\nValor total de venda: {valorTV}\nLucro total:{lucroT}");

                #endregion

                Console.ReadKey();
        }
    }
}
