static void ifElse()
{
    int hour = 15;
    if (hour > 0 && hour < 12)
        Console.WriteLine("It is morning");
    else if (hour >= 12 && hour < 18)
        Console.WriteLine("Afternoon");
    else
        Console.WriteLine("Good Evening");
}


static void custom()
{
    bool isGoldenCustomer = true;

    float price;
    if (isGoldenCustomer)
    {
        price = 19.95f;
    }
    else
    {
        price = 29.95f;
    }
    Console.WriteLine(price);

    // Using conditional Operator

    isGoldenCustomer = false;
    price = isGoldenCustomer ? 19.95f : 29.95f;
    Console.WriteLine(price);
}

static void switchCases()
{
    var season = Season.Autumn;
    switch (season)
    {
        case Season.Autumn:
            Console.WriteLine("It is autumn and it is a beautiful season");
            break;
        case Season.Spring:
            Console.WriteLine("It is spring");
            break;
        default:
            Console.WriteLine("Go to mars");
            break;
    }
}

static void forLoop()
{
    for (int i = 1; i <= 10; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
    }

    for (int i = 10; i >= 0; i--)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
    }
}

static void forEachLoop()
{
    string Name = "Janardhan";
    //for(int i=0; i<Name.Length; i++)
    //{
    //    Console.WriteLine(Name[i]);
    //}

    var numArray = new int[3] { 1, 2, 3 };

    foreach (var character in Name) Console.WriteLine(character); // No need a counter, condition and all that stuff
    foreach (var num in numArray) Console.WriteLine(num);
}

static void whileLoop()
{
    int i = 1;
    while (i <= 10)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
        i++;
    }
}

static void whileExample()
{
    while(true)
    {
        Console.Write("Type your name: ");
        var input = Console.ReadLine();

        if(!string.IsNullOrEmpty(input))
        {
            Console.WriteLine(input);
            continue;
        }
        break;
    }
}

static void randomClass()
{
    var random = new Random();
    const int size = 10;

    var buffer = new char[size];
    for (int i = 0; i < size; i++)
    {
       buffer[i] = ((char)('a' + random.Next(0,26)));
    }

    var password = new string(buffer);
    Console.WriteLine(password);
}

//switchCases();
//custom();
//ifElse();
//forLoop();
//forEachLoop();
//whileLoop();
//whileExample();
randomClass();