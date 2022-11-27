namespace CustomNullException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text or empty to test for Exception");
            string? text = Console.ReadLine();

            if (string.IsNullOrEmpty(text))
            {
                throw new CustomNullException("This is a Null Exception");
            }
            else
            {
                Console.WriteLine("You entered: {0}, a Custom Exception.", text);
            }
            Console.ReadLine();
        }
    }
}
