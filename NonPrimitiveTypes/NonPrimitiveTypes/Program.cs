using NonPrimitiveTypes.Math;

namespace NonPrimitiveTypes
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person();
            p.firstName = "Majji";
            p.lastName = "Janardhan";
            p.Introduce();

            Console.WriteLine(Calculator.Add(3, 4));
            Console.WriteLine(Calculator.Add(5, 6));

            //Array();
            //Strings();

            var method = ShippingMethod.RegisteredAirMail;
            Console.WriteLine((int)method);

            var methodNumber = 3;
            Console.WriteLine((ShippingMethod)methodNumber);

            Console.WriteLine(method); // cw automatically calls toString() method
            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
        }

        public static void Array()
        {
            var numbers = new int[5];

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var names = new string[3] { "Majji", "Janardhan", "Tillu" };
        }

        public static void Strings()
        {
            var firstName = "Majji";
            // primitive => structures, strings => classes
            string lastName = "Janardhan";
            string[] names = new string[3] { "Janardhan", "Tillu", "RamNandan" };

            Console.WriteLine("My name is {0} {1}", firstName, lastName);
            Console.WriteLine("My name is " + firstName + " " + lastName);
            string formattedNames = string.Join(", ", names);
            Console.WriteLine(formattedNames);

            var text = "Hi John\nLook into the following path\nc:\\folder1\\folder2\\folder3";
            Console.WriteLine(text);

            // Verbatium string
            var formattedText = @"Hi John
Look into the following path
c:\folder1\folder2\folder3";
            Console.WriteLine(formattedText);
        }
    }
}