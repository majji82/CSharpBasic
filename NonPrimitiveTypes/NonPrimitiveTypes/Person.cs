namespace NonPrimitiveTypes
{
    public class Person
    {
        public String firstName;
        public String lastName;

        public void Introduce()
        {
            Console.WriteLine("My name is {0} {1}", firstName, lastName);
        }
    }
}