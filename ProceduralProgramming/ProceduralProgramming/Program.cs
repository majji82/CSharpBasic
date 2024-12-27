namespace ProceduralProgramming
{
    class Program
    {
        // Getting input from the user and displaying the output...
        static void Main(string[] args)
        {
            Console.Write("What's your name? ");
            var name = Console.ReadLine();

            Console.WriteLine("Reversed name: " + ReverseString(name));
        }


        // This is for reversing a string
        public static string ReverseString(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
            {
                array[name.Length - i] = name[i - 1];
            }

            var reversed = new string(array);
            return reversed;
        }
    }
}