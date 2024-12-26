namespace ReferenceValueExample
{
    public class Person
    {
        public int Age;
    }
    public class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            Increment(num);
            Console.WriteLine(num);

            Person p = new Person() { Age = 10 };
            IncrementAge(p); 
            Console.WriteLine(p.Age);

        }

        public static void Increment(int val)
        {
            val += 10;
        }

        public static void IncrementAge(Person p)
        {
            p.Age += 10;
        }
    }
}