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

            Console.WriteLine("\nMin and Max values of numeric data types and character type:");
            Console.Write("\tbyte");
            Console.Write("\tMin = {0}", byte.MinValue);
            Console.Write("\tMax = {0}\n", byte.MaxValue);
            Console.Write("\tsbyte");
            Console.Write("\tMin = {0}", sbyte.MinValue);
            Console.Write("\tMax = {0}\n", sbyte.MaxValue);
            Console.Write("\tshort");
            Console.Write("\tMin = {0}", short.MinValue);
            Console.Write("\tMax = {0}\n", short.MaxValue);
            Console.Write("\tushort");
            Console.Write("\tMin = {0}", ushort.MinValue);
            Console.Write("\tMax = {0}\n", ushort.MaxValue);
            Console.Write("\tint");
            Console.Write("\tMin = {0}", int.MinValue);
            Console.Write("\tMax = {0}\n", int.MaxValue);
            Console.Write("\tuint");
            Console.Write("\tMin = {0}", uint.MinValue);
            Console.Write("\tMax = {0}\n", uint.MaxValue);
            Console.Write("\tlong");
            Console.Write("\tMin = {0}", long.MinValue);
            Console.Write("\tMax = {0}\n", long.MaxValue);
            Console.Write("\tulong");
            Console.Write("\tMin = {0}", ulong.MinValue);
            Console.Write("\tMax = {0}\n", ulong.MaxValue);
            Console.Write("\tfloat");
            Console.Write("\tMin = {0}", float.MinValue);
            Console.Write("\tMax = {0}\n", float.MaxValue);
            Console.Write("\tdouble");
            Console.Write("\tMin = {0}", double.MinValue);
            Console.Write("\tMax = {0}\n", double.MaxValue);
            Console.Write("\tdecimal");
            Console.Write("\tMin = {0}", decimal.MinValue);
            Console.Write("\tMax = {0}\n", decimal.MaxValue);
            Console.Write("\tchar");
            Console.Write("\tMin = {0}", char.MinValue);
            Console.Write("\tMax = {0}\n", char.MaxValue);

            Console.WriteLine("\nModule 3.4. Enumerations.");
            DaysOfWeek MyFavoriteDay;
            MyFavoriteDay = DaysOfWeek.Friday;
            Console.WriteLine("\t{0}", MyFavoriteDay);

            Console.ReadKey();
        }
    }

    enum DaysOfWeek : byte
    {
        Tuesday,
        Monday,
        Wednesday,
        Friday
    }

    // Task 3.4.3. Enumeration Semaphore:
    enum Semaphore
    {
        Red = 100,
        Yellow = 200,
        Green = 300
    }


}


