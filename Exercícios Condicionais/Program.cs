using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Notas 

            //float nota1, nota2, notaFinal;
            //Console.WriteLine("Digite a nota do primeiro semestre");
            //nota1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a nota do segundo semestre");

            //nota2 = float.Parse(Console.ReadLine());
            //notaFinal= nota1 + nota2;
            //if (notaFinal >= 60)
            //{
            //    Console.WriteLine($"Sua nota foi {notaFinal}, APROVADO!");

            //}

            //else Console.WriteLine($" A Nota obtida foi {notaFinal}, REPROVADO!");

            #endregion

            #region Baskara 

            //double a, b, c, x1, x2, delta;
            //Console.WriteLine("escreva o coeficiente a");
            //a = double.Parse(Console.ReadLine());
            //Console.WriteLine("escreva o coeficiente b");
            //b = double.Parse(Console.ReadLine());
            //Console.WriteLine("escreva o coeficiente c");
            //c = double.Parse(Console.ReadLine());

            //delta = Math.Pow(b, 2.0) - 4 * a * c;

            //x1 = (-b + Math.Sqrt(delta)) / (2 * a);

            //x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            //if (delta>=0)
            //{
            //    Console.WriteLine($"Coeficiente a: {a}\n Coeficiente b: {b}\n coeficiente c: {c}\n x1: {x1}\n x2: {x2}");
            //}
            //else Console.WriteLine("Esta equação não possui raizes reais");

            #endregion

            #region menor de três
            //int i = 0;
            //while (i!=1)
            //{
            //    int a, b, c;
            //    Console.WriteLine("Primeiro valor:");
            //    a=int.Parse(Console.ReadLine());
            //    Console.WriteLine("Segundo valor:");
            //    b=int.Parse(Console.ReadLine());
            //    Console.WriteLine("Terceiro valor");
            //    c = int.Parse(Console.ReadLine());

            //    if (a >= b && c>=b)
            //    {
            //        Console.WriteLine($"O menor número é {b}");
            //    }
            //    else if (a >= c && b>=c)
            //    {
            //        Console.WriteLine($"O menor número é {c}");
            //    }
            //    else Console.WriteLine($"O menor número é {a}");

            //}

            #endregion

            #region Operadora

            //Console.WriteLine("Digite a quantidade de minutos gastos pelo consumidor");
            //int minutos = int.Parse(Console.ReadLine());

            //if(minutos <= 100)
            //{
            //    Console.WriteLine("O valor a pagar é R$ 50,00!");
            //}
            //else
            //{
            //    int taxa = minutos - 100;
            //    int valorExcedido =(taxa * 2) + 50;
            //    Console.WriteLine($"O valor a pagar é R$ {valorExcedido},00");

            //}

            #endregion

            #region Troco Verificado

            //double preco, quantidade, dinheiroRecebido, verificacao,troco;
            //Console.WriteLine("Qual o preço do produto");
            //preco = double.Parse(Console.ReadLine());
            //Console.WriteLine("Qual a quantidade de produtos comprada");
            //quantidade = double.Parse(Console.ReadLine());
            //Console.WriteLine("Quantidade de dinheiro recebido");
            //dinheiroRecebido = double.Parse(Console.ReadLine());
            //verificacao = (preco * quantidade);
            //if(verificacao <= dinheiroRecebido)
            //{
            //    troco = dinheiroRecebido- verificacao ;
            //    Console.WriteLine($"O troco sera de R${troco}");
            //}
            //else
            //{
            //    troco = dinheiroRecebido - verificacao;
            //    troco = troco * -1;
            //    Console.WriteLine($"Dinheiro insuficiente, faltam R${troco}");
            //}

            #endregion

            #region Glicose

            //Console.WriteLine("Qual a medida da glicose?");
            //double glicose = double.Parse(Console.ReadLine());

            //if(glicose <=100)
            //{
            //    Console.WriteLine("Classificação: Normal");
            //}
            //else if (glicose>100 && glicose<=140)
            //{
            //    Console.WriteLine("Classificação: Elevado");
            //}
            //else Console.WriteLine("Classificação: Diabetes");

            #endregion

            #region Dardo

            //double d1, d2, d3;
            //Console.WriteLine("Digite as três distancias");
            //d1 = double.Parse(Console.ReadLine());
            //d2 = double.Parse(Console.ReadLine());
            //d3 = double.Parse(Console.ReadLine());

            //if (d1 > d2 && d1 > d3)
            //{
            //    Console.WriteLine($"Maior distancia:{d1}");
            //}
            //else if(d2>d3 && d2 > d1)
            //{
            //    Console.WriteLine($"Maior distancia:{d2}");
            //}
            //else Console.WriteLine($"Maior distancia:{d3}");

            #endregion

            #region temperatura
            //Console.WriteLine("Você deseja qual escala ? ");
            //char temperatura = char.Parse(Console.ReadLine());
            //;


            //if (temperatura == 'C')
            //{
            //    Console.WriteLine("Digite a temperatura em Celsius?");
            //    float conversao = float.Parse(Console.ReadLine());
            //    float resultado = ((conversao * 9) / 5) + 32;
            //    Console.WriteLine($"A temperatura equivale a {resultado} ºF");
            //}
            //else
            //{
            //    Console.WriteLine("Digite a temperatura em Fahrenheit?");
            //    float conversao = float.Parse(Console.ReadLine());
            //    float resultado =((conversao - 32)*5)/9;
            //    Console.WriteLine($"A temperatura equivale a {resultado} ºC");
            //}

            #endregion

            #region Lanchonete

            //double produto, valor;
            //Console.WriteLine("Digite o codigo do produto comprado");
            //produto = double.Parse(Console.ReadLine());
            //Console.WriteLine("Quantidade de produtos compradas");
            //float quantidade = float.Parse(Console.ReadLine());
            //if (produto == 1)
            //{
            //    valor = quantidade * 5;
            //    Console.WriteLine($"Valor a pagar: R${valor}");
            //}
            //else if (produto == 2)
            //{
            //    valor = quantidade * 3.5;
            //    Console.WriteLine($"Valor a pagar: R${valor}");
            //}
            //else if(produto == 3)
            //{
            //    valor = quantidade * 4.8;
            //    Console.WriteLine($"Valor a pagar: R${valor}");
            //}
            //else if(produto == 4)
            //{
            //    valor = quantidade * 8.9;
            //    Console.WriteLine($"Valor a pagar: R${valor}");
            //}
            //else
            //{
            //    valor = quantidade * 7.32;
            //    Console.WriteLine($"Valor a pagar: R${valor}");
            //}

            #endregion

            #region Multiplos

            //Console.WriteLine("Digite dois números inteiros");
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int multiplos = num1 % num2;
            //int multiplos2 = num2 % num1;
            //if (multiplos == 0 || multiplos2==0)
            //{
            //    Console.WriteLine("São Multiplos");
            //}
            //else Console.WriteLine("Não são Multiplos");


            #endregion

            #region Aumento

            //double salario, novoSalario, aumento;
            //int porcentagem;
            //Console.WriteLine("Digite o Salario da pessoa");
            //salario = double.Parse(Console.ReadLine());
            //if(salario <= 1000)
            //{
            //   aumento = (salario * 20) / 100;
            //   novoSalario = salario+ aumento;
            //    porcentagem = 20;
            //    Console.WriteLine($" Novo salario: R${novoSalario}\n Aumento: R${aumento}\n Porcentagem:{porcentagem}%");
            //}
            //else if (salario>1000 && salario <= 3000)
            //{
            //    aumento = (salario * 15) / 100;
            //    novoSalario = salario + aumento;
            //    porcentagem = 15;
            //    Console.WriteLine($" Novo salario: R${novoSalario}\n Aumento: R${aumento}\n Porcentagem:{porcentagem}%");
            //}
            //else if ( salario > 3000 && salario <=8000)
            //{
            //    aumento = (salario * 10) / 100;
            //    novoSalario = salario + aumento;
            //    porcentagem = 10;
            //    Console.WriteLine($" Novo salario: R${novoSalario}\n Aumento: R${aumento}\n Porcentagem:{porcentagem}%");
            //}
            //else
            //{
            //    aumento = (salario * 5) / 100;
            //    novoSalario = salario + aumento;
            //    porcentagem = 5;
            //    Console.WriteLine($" Novo salario: R${novoSalario}\n Aumento: R${aumento}\n Porcentagem:{porcentagem}%");
            //}

            #endregion

            #region tempo de jogo

            //int horaInicial, horaFinal,duracao;
            //Console.WriteLine("Escreva a hora inicial");
            //horaInicial = int.Parse(Console.ReadLine());
            //Console.WriteLine("Escreva a hora final");
            //horaFinal = int.Parse(Console.ReadLine());
            //if (horaInicial<horaFinal)
            //{
            //    duracao = horaFinal - horaInicial;
            //    Console.WriteLine($"A duração do jogo foi de {duracao} horas");
            //}
            //else
            //{
            //    duracao = (24 - horaInicial) + horaFinal;
            //    Console.WriteLine($"A duração do jogo foi de {duracao} horas");
            //}

            #endregion

            #region Coordenadas

            float x, y;
            Console.WriteLine("Informe o valor da coordenada de x");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da coordenada de y");
            y = float.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("As coordenadas x e y se encontram no primeiro quadrante");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("As coordenadas x e y se encontram no terceiro quadrante");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("As coordenadas x e y se encontram no quarto quadrante");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("As coordenadas x e y se encontram no segundo quadrante");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("As coordenadas x e y se encontram na Origem");
            }
            else if (x==0 && y!=0)
            {
                Console.WriteLine("As coordenadas se encontram no Eixo Y");
            }
            else
            {
                Console.WriteLine("As coordenadas se encontram no eixo X");
            }

            #endregion

            Console.ReadKey();
        }
    }
}
