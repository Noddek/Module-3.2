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

            Console.WriteLine("\nBoolean literals \'true\' and \'false\':");
            Console.WriteLine("\t{0}\n\t{1}", true, false);

            Console.WriteLine("\nInteger literals:");
            Console.WriteLine("\t{0}", 5);
            Console.WriteLine("\t{0}", 100);
            Console.WriteLine("\t0b0101 in binary number system is equal to {0} in decimal number system", 0b0101);
            Console.WriteLine("\t0xAF in hexadecimal number system is equal to {0} in decimal number system", 0xAF);

            Console.WriteLine("\nReal literals:");
            Console.WriteLine("\t{0}", 5.5);
            Console.WriteLine("\t-100.0 is displayed on the screen as {0}", -100.0);

            Console.WriteLine("\nTask 3.3.2. Example of a questionnaire.");
            string Name = "Jane";
            Console.WriteLine("\tMy name is " + Name + ".");
            byte Age = 27;
            Console.WriteLine("\tMy age is " + Age + ".");
            bool DoIHaveAPet = true;
            Console.WriteLine("\tDo I have a pet? " + DoIHaveAPet + ".");
            double ShoeSize = 37.5;
            Console.WriteLine("\tMy shoe size is " + ShoeSize + ".");

            Console.ReadKey();
        }
    }
}
