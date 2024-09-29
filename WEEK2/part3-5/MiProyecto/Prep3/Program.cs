using System;

class Program
{
    static void Main(string[] args)
    {
        string? yes = "yes";
        while (yes != "no")
        {
            Random randomGenerator = new Random();
            int numero = randomGenerator.Next(1, 101);

            int nNumero = 0;
            bool esNumeroValido = false;
            bool again = true;

            int track = 0;

            while (!esNumeroValido || nNumero != numero)
            {
                Console.Write("What is your guess? ");
                string? input = Console.ReadLine();

                esNumeroValido = int.TryParse(input, out nNumero);

                if (!esNumeroValido)
                {
                    Console.WriteLine("Please enter a valid number.");
                }
                else if (nNumero > numero)
                {
                    Console.WriteLine("Lower");
                }
                else if (nNumero < numero)
                {
                    Console.WriteLine("Higher");
                }
                track++;
            }

            Console.WriteLine("You guessed it!");
            Console.WriteLine("track: " + track);



            while(again){
                Console.Write("Do you want to play again? ");
                yes = Console.ReadLine()?.ToLower(); // Maneja la entrada nula y convierte a minúsculas.
                if(yes == "no" || yes == "yes"){
                    again = false;
                }else{
                    again = true;
                }
            }
        }
    }
}
