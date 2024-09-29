// See https://aka.ms/new-console-template for more information

static void DisplayWelcome(){
    Console.WriteLine("Welcome to the program!");
}
DisplayWelcome();

static string PromptUserName(){
    Console.Write("Please enter your name: ");
    string? name = Console.ReadLine();
    return name;
}
string? name = PromptUserName();

static int PromptUserNumber(){
    int numb = 0;  // Declara la variable numb
    bool again = false;
    while(!again){
        Console.Write("Please enter your favorite number: ");
        string? input = Console.ReadLine();
        again = int.TryParse(input, out numb);

        if (!again)
        {
            Console.WriteLine("Por favor ingresa un número válido.");
        }

    }
    return numb;
}


int numero = PromptUserNumber();

static int SquareNumber(int num){
    return num * num;
}

static void DisplayResult(string name, int numero){
    
    Console.Write(name + ", " + "the square of your number is " + SquareNumber(numero));
}

DisplayResult(name, numero);