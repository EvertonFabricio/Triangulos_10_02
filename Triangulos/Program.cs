using System;

namespace Triangulos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a medida de um dos lados de um triangulo qualquer: ");
			float a = float.Parse(Console.ReadLine());

			Console.WriteLine("\nDigite a medida de outro lado desse triangulo: ");
			float b = float.Parse(Console.ReadLine());

			Console.WriteLine("\nDigite a medida do ultimo lado desse triangulo: ");
			float c = float.Parse(Console.ReadLine());

			if (a == b & a == c)
				Console.WriteLine("Os 3 lados desse triangulo são iguais, portanto é um triangulo equilatero");
			else if (a == b || a == c || a == c)
				Console.WriteLine("2 lados desse triangulo são iguais e o terceiro é diferente, portando é um triangulo isoceles.");
			else
				Console.WriteLine("Os 3 lados desse triangulo são diferentes, portando é um triangulo escaleno");
	
			
		}
    }
}
