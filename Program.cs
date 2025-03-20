// See https://aka.ms/new-console-template for more information

bool flag = false;
List<string> list = new List<string>();
int num1 = 0, num2 = 0;
string listItem;
int choice=0;

do
{
    try
    {
        Console.WriteLine("------------------\nEnter your choice:\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division" +
            "\n5. Display history of calculations\n6. Exit\n------------------\n");
        choice = Convert.ToInt32(Console.ReadLine());
    }
    catch(FormatException ex)
    {
        Console.WriteLine(ex.Message);
    }
    Console.WriteLine();

    if (choice == 6)
    {
        flag = true;
    }

    if (choice >= 1 && choice <= 4)
    {
        try
        {
            Console.WriteLine("Enter 1st number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number:");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
        catch(FormatException ex)
        {
            Console.WriteLine(ex.Message);
            choice = 7;
        }
        Console.WriteLine();
    }

    //int count = 1;

    switch (choice)
    {
        case 1:
            int sum = Add(num1, num2);
            listItem = $"{num1} + {num2} = {sum}";
            list.Add(listItem);
            Console.WriteLine(listItem);
            break;

        case 2:
            int difference = Subtract(num1, num2);
            listItem = $"{num1} - {num2} = {difference}";
            list.Add(listItem);
            Console.WriteLine(listItem);
            break;

        case 3:
            int multiply = Product(num1, num2);
            listItem = $"{num1} * {num2} = {multiply}";
            list.Add(listItem);
            Console.WriteLine(listItem);
            break;

        case 4:
            try
            {
                int divide = Divide(num1, num2);
                listItem = $"{num1} / {num2} = {divide}";
                list.Add(listItem);
                Console.WriteLine(listItem);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;

        case 5:
            Console.WriteLine("\nPREVIOUS CALCULATIONS: ");
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            break;


        case 6:
            Console.WriteLine("****QUITTING****");
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Try again!!!!");
            break;
    }
    Console.WriteLine();
} while (flag == false);

//Console.ReadKey();

static int Add(int number1, int number2)
{
    return number1 + number2;
}

static int Subtract(int number1, int number2)
{
    return number1 - number2;
}

static int Product(int number1, int number2)
{
    return number1 * number2;
}
static int Divide(int number1, int number2)
{
    return number1 / number2;
}