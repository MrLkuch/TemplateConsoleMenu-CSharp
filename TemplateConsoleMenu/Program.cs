bool exit = false;

while (!exit)
{
    ShowMenu();
    int choice = ReadNumericInput(1, 4);

    switch (choice)
    {
        case 1:
            Option1();
            break;
        case 2:
            Option2();
            break;
        case 3:
            Option3();
            break;
        case 4:
            exit = true;
            Console.WriteLine("Exit...");
            break;
        default:
            Console.WriteLine("Option invalid. Choose again.");
            break;
    }

    if (!exit)
    {
        Console.WriteLine("\nPress a key to continue...");
        Console.ReadKey();
        Console.Clear();
    }
}


static void ShowMenu()
{
    Console.WriteLine("=== Main Menu ===");
    Console.WriteLine("1. Option 1");
    Console.WriteLine("2. Option 2");
    Console.WriteLine("3. Option 3");
    Console.WriteLine("4. Exit");
    
}

static int ReadNumericInput(int min, int max)
{
    int resultat = 0;
    string input;
    bool estValide;

    do
    {
        Console.Write($"Your choice ({min}-{max}) : ");
        input = Console.ReadLine();

        // Vérifier si l'input est vide ou ne contient que des espaces
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("The input cannot be empty");
            estValide = false;
            continue;
        }

        // Essayer de convertir l'input en int
        if (!int.TryParse(input, out resultat))
        {
            Console.WriteLine("Input a valid number");
            estValide = false;
            continue;
        }

        // Vérifier si le nombre est dans la plage valide
        if (resultat < min || resultat > max)
        {
            Console.WriteLine($"The input must be between {min} and {max}.");
            estValide = false;
            continue;
        }

        estValide = true;

    } while (!estValide);

    return resultat;
}

static void Option1()
{
    Console.WriteLine("option 1");
    // Ajoutez ici le code pour l'option 1
}

static void Option2()
{
    Console.WriteLine("option 2");
    // Ajoutez ici le code pour l'option 2
}

static void Option3()
{
    Console.WriteLine("option 3");
    // Ajoutez ici le code pour l'option 3
}