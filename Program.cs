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
            

            const string MyGitUsername = "Noddek";
            Console.WriteLine("\nMy Git username is {0}.", MyGitUsername);

            Console.WriteLine("\nI'm taking a Skillfactory course.");
            Console.WriteLine("\nThe current module is:\n\n\tModule 3.2");

            Console.WriteLine("\nTask 3.2.8. Output the # character of the ASCII table to the screen. \n\n\tResponse: \x23");

            Console.ReadKey();
        }
    }
}
