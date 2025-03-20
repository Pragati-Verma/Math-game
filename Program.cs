int sumPoints = 0, diffPoints = 0, productPoints = 0, divisionPoints = 0;
List<string> list = new List<string>();
// DateTime dateTime = new DateTime();
bool flag = false;

do
{
    Console.WriteLine("Enter your choice:\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division" +
        "\n5. History\n6. Quit\n");
    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine("ADDITION: ");
            sumPoints = Addition();
            list.Add($"{DateTime.Now}\tAddition: {sumPoints} points");
            break;

        case 5:
            Console.WriteLine("PREVIOUS CALCULATIONS:\n");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            break;

        default:
            Console.WriteLine("Try again!");
            break;
    }
}while (flag == false);

static int Addition()
{
    Random random = new Random();
    int num1, num2, userInput, sum = 0, points = 0;
    for (int i = 0; i < 2; i++)
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
    }
    return points;
}
