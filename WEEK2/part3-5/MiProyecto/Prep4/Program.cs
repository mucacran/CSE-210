using System;
using System.Collections.Generic;
using System.Linq; // Necesario para usar Where y Min

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int numero;
        int numb = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do{
            bool again = false;
            while(!again){
                Console.Write("Enter number: ");
                string? input = Console.ReadLine();
                again = int.TryParse(input, out numb);

                if (!again)
                {
                    Console.WriteLine("Por favor ingresa un número válido.");
                }

            }
            numero = numb;
            if (numero != 0) // Evita agregar el 0 a la lista
            {
                numbers.Add(numero);
            }

        }while(numero != 0);

        Console.WriteLine("The sum is: " + numbers.Sum());
        Console.WriteLine("The average is: " + ((double)numbers.Sum()/numbers.Count));
        Console.WriteLine("The largest number is: " + numbers.Max());

        // Número positivo más pequeño
        if (numbers.Any(n => n > 0)) {
            int menorPositivo = numbers.Where(n => n > 0).Min();
            Console.WriteLine("The smallest positive number is: " + menorPositivo);
        } else {
            Console.WriteLine("No positive numbers were entered.");
        }

        // Lista ordenada
        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

    }
}