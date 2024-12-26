namespace PrimitiveDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //DataTypes();
            //FormatString();
            //ImplicitTypeConversion();
            //ExplicitTypeConversion();
            //NonCompatibleTypes();
            Operators();
        }

        static void DataTypes()
        {
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f; // By default real numbers are treated as double...so use suffix "f"
            char character = 'A';
            string firstName = "Majji";
            bool isWorking = false;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            // var keyWord demo

            var isHelping = true;
            Console.WriteLine(isHelping);
            isHelping = false;
            Console.WriteLine(isHelping);

            // const keyWord
            const float PI = 3.14f;
            Console.WriteLine(PI);
        }

        static void FormatString()
        {
            // Format string
            Console.WriteLine("My firstName is {0} and lastName is {1}", "Majji", "Janardhan");
            Console.WriteLine("Byte minimumvalue is {0} and maxValue is {1}", byte.MinValue, byte.MaxValue);
        }

        static void ImplicitTypeConversion()
        {
            byte b = 5;
            int i = b;

            Console.WriteLine(b);
            Console.WriteLine(i); // There is no dataLoss when a byte is converted to int..

            int integer = 1;
            float f = integer;
            Console.WriteLine(f);

            int num1 = 2;
            //byte b1 = num1; // This won't compile...There can be a chance of dataloss
            byte b1 = (byte)num1;
            Console.WriteLine(b1);
        }

        static void ExplicitTypeConversion()
        {
            int num1 = 40;
            byte b1 = (byte)num1;

            Console.WriteLine(b1);
        }

        static void NonCompatibleTypes()
        {
            try
            {
                string wordNum = "1032";
                byte number = Convert.ToByte(wordNum);
                Console.WriteLine(number);
            }
            catch (Exception)
            {
                Console.WriteLine("The number couldnot be converted to a byte");
            }
        }

        static void Operators()
        {
            var a = 10;
            var b = 3;
            Console.WriteLine((float)a/b);

            var x = 1;
            var y = 2;
            var z = 3;

            Console.WriteLine(x+y*z);

            Console.WriteLine(z>x || y>z);
        }
    }
}