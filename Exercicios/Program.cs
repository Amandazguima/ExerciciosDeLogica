using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Trapézion 
            //Console.WriteLine("Qual a Altura do seu trapezio? ");
            //int h = int.Parse(Console.ReadLine());
            //Console.WriteLine("Qual a área da Base menor do seu trapezio? ");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Qual a área da Base Maior do seu trapezio? ");
            //int c = int.Parse(Console.ReadLine());
            //int d = (c + b) * h / 2;

            //Console.WriteLine($"A área do trapezio é {d}  cm");
            #endregion

            #region Terreno

            //Console.WriteLine("Digite a Largura do seu terreno: ");
            //float largura = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o Comprimento do seu terreno: ");
            //float comprimento = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor do metro quadrado: ");
            //float valorMetroQuadrado = float.Parse(Console.ReadLine());

            //double areaDoTerreno = largura * comprimento;
            //Console.WriteLine($"A área do terreno corresponde a {areaDoTerreno} m² ");

            //double precoDoTerreno = areaDoTerreno * valorMetroQuadrado;
            //Console.WriteLine($"O preço do terreno é {precoDoTerreno} R$");
            #endregion

            #region Retangulo
            //Console.WriteLine("Qual a área da base do retangulo?");
            //float baseDoRetangulo = float.Parse(Console.ReadLine());  
            //Console.WriteLine("Qual a altura do retangulo?");
            //float alturaDoRetangulo = float.Parse(Console.ReadLine());
            //double diagonal = Math.Pow(baseDoRetangulo, 2.0) + Math.Pow (alturaDoRetangulo, 2.0);

            //double areaDoRetangulo = baseDoRetangulo * alturaDoRetangulo;
            //Console.WriteLine($"A área do retandulo é {areaDoRetangulo} cm²");
            //Console.WriteLine($"O perimetro do retangulo é {2 * (alturaDoRetangulo+baseDoRetangulo)} cm² ");
            //Console.WriteLine($" A diagonal do retangulo é {Math.Sqrt (diagonal)}");
            #endregion

            #region Troco
            //Console.WriteLine("Preço do Produto");
            //float precoProduto = float.Parse(Console.ReadLine());
            //Console.WriteLine("Quantidade de produtos compradas");
            //float quantidadeProduto = float.Parse(Console.ReadLine());
            //Console.WriteLine("Dinheiro recebido");
            //float dinheiroRecebido = float.Parse(Console.ReadLine());

            //float troco = (precoProduto * quantidadeProduto) - dinheiroRecebido;
            //Console.WriteLine($"O troco recebido será de R${troco}");

            #endregion

            #region Idade ( quero complicar isso aqui prox cap. )



            #endregion

            #region Soma
            //Console.WriteLine("Digite o valor 1:");
            //int z = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor 2:");
            //int x = int.Parse(Console.ReadLine());
            //int soma = z + x;
            //Console.WriteLine($"A soma dos valores é {soma}");
            #endregion

            #region Circulo
            //Console.WriteLine("Digite o valor do raio da circunferência");
            //float r = float.Parse(Console.ReadLine());
            //double areaDaCircunferencia =  Math.PI *(Math.Pow(r,2.0));
            //Console.WriteLine($"A área da Circunferência é {areaDaCircunferencia} cm²");
            #endregion

            #region Consumo
            //Console.WriteLine("Escreva a Distância percorrida em km");
            //float distancia = float.Parse(Console.ReadLine());
            //Console.WriteLine("Escreva o combustível gasto");
            //float combustivel = float.Parse(Console.ReadLine());
            //double consumoMedio = distancia/combustivel;
            //Console.WriteLine($"A média de consumo foi :{consumoMedio} Km/L");

            #endregion

            #region Pagamento
            //Console.WriteLine("Nome do funcionário");
            //string nome = Console.ReadLine();
            //Console.WriteLine("Valor por hora do funcionário");
            //float valorPorHora = float.Parse(Console.ReadLine());
            //Console.WriteLine("Horas trabalhadas");
            //float horasTrabalhadas = float.Parse(Console.ReadLine());
            //double receber = valorPorHora * horasTrabalhadas;
            //Console.WriteLine($"O pagamento para {nome} deve ser de R$ {receber}");
            #endregion


            #region Duração 
            //Console.WriteLine("Digite a duração em segundos");
            //int duracao = int.Parse(Console.ReadLine());
            //int tempo = duracao/ 3600;
            //int resto = duracao % 3600;
            //int minutos = resto / 60;
            //int resto2 = resto % 60;
            //Console.WriteLine($"O tempo foi de {tempo}:{minutos}:{resto2}");
            #endregion

            #region Medidas

            //Console.WriteLine("Digite um valor para A");
            //float a = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite um valor para B");
            //float b = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite um valor para C");
            //float c = float.Parse(Console.ReadLine());

            //Console.WriteLine($"A área do quadrado é {a*a}");
            //Console.WriteLine($"A área do triângulo Retangulo de base {a} e altura {b} é {(a*b)/2}");
            //Console.WriteLine($"A área do trapézio que tem base maior {a} base menor {b} e altura {c} é {(a+b)*c/2}");
            #endregion

            Console.ReadKey();

        }
    }

    
}

