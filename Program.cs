int sumPoints = 0, diffPoints = 0, productPoints = 0, divisionPoints = 0;
List<string> list = new List<string>();
// DateTime dateTime = new DateTime();
bool flag = false;

do
{
    Console.WriteLine("Enter your choice:\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division" +
        "\n5. History\n6. Quit\n");
    int choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    switch (choice)
    {
        case 1:
            Console.WriteLine("ADDITION: ");
            sumPoints = Addition();
            list.Add($"{DateTime.Now}\tAddition: {sumPoints} points");
            break;

        case 2:
            Console.WriteLine("SUBTRACTION: ");
            diffPoints = Subtraction();
            list.Add($"{DateTime.Now}\tSubtraction: {diffPoints} points");
            break;

        case 3:
            Console.WriteLine("MULTIPLICATION: ");
            productPoints = Multiplication();
            list.Add($"{DateTime.Now}\tMultiplication: {productPoints} points");
            break;

        case 4:
            Console.WriteLine("DIVISION: ");
            divisionPoints = Division();
            list.Add($"{DateTime.Now}\tMultiplication: {divisionPoints} points");
            break;

        case 5:
            Console.WriteLine("PREVIOUS CALCULATIONS:\n");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            break;

        case 6:
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Try again!");
            break;
    }
    Console.WriteLine();
}while (flag == false);

static int Addition()
{
    Random random = new Random();
    int num1, num2, userInput, sum = 0, points = 0;
    for (int i = 0; i < 5; i++)
    {
        num1 = random.Next(0, 9);
        num2 = random.Next(0, 9);
        sum = num1 + num2;
        Console.Write($"{num1} + {num2} = ");
        userInput = Convert.ToInt32(Console.ReadLine());
        if (sum == userInput)
        {
            Console.Write("Correct! ");
            points++;
        }
        else
        {
            Console.Write("Wrong! ");
        }
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.WriteLine();
    }
    return points;
}

static int Subtraction()
{
    Random random = new Random();
    int num1, num2, userInput, diff = 0, points = 0;
    for (int i = 0; i < 5; i++)
    {
        num1 = random.Next(0, 9);
        num2 = random.Next(0, 9);
        diff = num1 - num2;
        Console.Write($"{num1} - {num2} = ");
        userInput = Convert.ToInt32(Console.ReadLine());
        if (diff == userInput)
        {
            Console.Write("Correct! ");
            points++;
        }
        else
        {
            Console.Write("Wrong! ");
        }
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.WriteLine();
    }
    return points;
}

static int Multiplication()
{
    Random random = new Random();
    int num1, num2, userInput, multi = 0, points = 0;
    for (int i = 0; i < 5; i++)
    {
        num1 = random.Next(0, 9);
        num2 = random.Next(0, 9);
        multi = num1 * num2;
        Console.Write($"{num1} X {num2} = ");
        userInput = Convert.ToInt32(Console.ReadLine());
        if (multi == userInput)
        {
            Console.Write("Correct! ");
            points++;
        }
        else
        {
            Console.Write("Wrong! ");
        }
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.WriteLine();
    }
    return points;
}

static int Division()
{
    Random random = new Random();
    int num1, num2, userInput, divide = 0, points = 0;
    for (int i = 0; i < 5; i++)
    {
        num1 = random.Next(0, 9);
        num2 = random.Next(0, 9);
        divide = num1 / num2;
        Console.Write($"{num1} / {num2} = ");
        userInput = Convert.ToInt32(Console.ReadLine());
        if (divide == userInput)
        {
            Console.Write("Correct! ");
            points++;
        }
        else
        {
            Console.Write("Wrong! ");
        }
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.WriteLine();
    }
    return points;
}