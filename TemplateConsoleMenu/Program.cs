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
    int result = 0;
    string input;
    bool isValid;

    do
    {
        Console.Write($"Your choice ({min}-{max}) : ");
        input = Console.ReadLine();

        // Verify if the input is empty or only space
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("The input cannot be empty");
            isValid = false;
            continue;
        }

        // Try to convert to int
        if (!int.TryParse(input, out result))
        {
            Console.WriteLine("Input a valid number");
            isValid = false;
            continue;
        }

        // Verify if number is in the valid range
        if (result < min || result > max)
        {
            Console.WriteLine($"The input must be between {min} and {max}.");
            isValid = false;
            continue;
        }

        isValid = true;

    } while (!isValid);

    return result;
}

static void Option1()
{
    Console.WriteLine("option 1");
    // code for option 1
}

static void Option2()
{
    Console.WriteLine("option 2");
    // code for option 2
}

static void Option3()
{
    Console.WriteLine("option 3");
    // code for option 3
}