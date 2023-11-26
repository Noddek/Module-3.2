namespace VarConstLit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string MyName;
            MyName = "Almaz";
            Console.WriteLine(MyName);
            Console.ReadKey();

            string MyGitUsername = "Noddek";
            Console.WriteLine("\n\nMy Git username is: {0}", MyGitUsername);
        }
    }
}
