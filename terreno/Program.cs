using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terreno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a Largura do seu terreno: ");
            float largura = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Comprimento do seu terreno: ");
            float comprimento = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do metro quadrado: ");
            float valorMetroQuadrado = float.Parse(Console.ReadLine());

            double areaDoTerreno = largura * comprimento;
            Console.WriteLine($"A área do terreno corresponde a {areaDoTerreno} m² ");

            double precoDoTerreno = areaDoTerreno * valorMetroQuadrado;
            Console.WriteLine($"O preço do terreno é {precoDoTerreno} R$");
            Console.ReadKey();




        }
    }
}
