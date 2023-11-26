namespace VarConstLit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string MyName;
            MyName = "Almaz";
            Console.WriteLine("\nMy name is {0}.", MyName);
            Console.ReadKey();

            const string MyGitUsername = "Noddek";
            Console.WriteLine("\n\nMy Git username is {0}.", MyGitUsername);

            Console.WriteLine("\nI'm taking a Skillfactory course.");

        }
    }
}
