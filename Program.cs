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
            string Name1 = "Jane";
            Console.WriteLine("\tMy name is " + Name1 + ".");
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

            Console.WriteLine("\nModule 3.5. Console input and output.");
            Console.WriteLine("\nTask 3.5.2. Response:");
            Console.WriteLine("\n\tПривет,\n мир!");
            Console.WriteLine("\n\tOperator:\n\tConsole.WriteLine(\"\\n\\tПривет,\\n мир!\");");

            Console.WriteLine("\nTrying ways to output to the screen:\n");
            string Name2 = "Евгения";
            Console.WriteLine("\tПривет, мир");
            Console.WriteLine();
            Console.WriteLine("\tКонкатенация: Меня зовут " + Name2);
            Console.WriteLine($"\tИнтерполяция: Меня зовут {Name2}");

            Console.WriteLine("\nTask 3.5.3. Response:");
            byte age1 = 100;
            Console.WriteLine($"\tМой возраст {age1}");

            Console.WriteLine("\n3rd way to output to the screen:\n");
            Console.WriteLine("\tМеня зовут {0}", Name2);
            Console.WriteLine("\tМеня зовут {0}", "Маша");
            byte weight = 100;
            Console.WriteLine("\tМой возраст {0}, мой вес {1}", age1, weight);

            Console.WriteLine("\nTask 3.5.4. Response:");
            string favcolor = "black";
            Console.WriteLine("{0}\n {1}\n {2}", Name1, age1, favcolor);

            Console.WriteLine("\nReading console input:");
            Console.WriteLine("\tHello!");
            Console.WriteLine("\tMy name is {0}", Name1);
            Console.WriteLine("\tAnd what is your name?");
            // string YourName = Console.ReadLine();
            // Console.WriteLine("\tGreat to see you, {0}!", YourName);

            Console.WriteLine("\nTask 3.5.5. Response:");
            // string str = Console.ReadLine();

            Console.WriteLine("\nModule 3.6. Basic operations C#.");
            double result1 = 5.0 / 2.0;
            Console.WriteLine("\t 5 / 2 = {0}", result1);
            double result2 = 5.0 % 2.0;
            Console.WriteLine("\t 5 % 2 = {0}", result2);
            int counter = 10;
            Console.WriteLine("\t Value: {0} Prefix increment: {1}", counter, ++counter);
            counter = 10;
            Console.WriteLine("\t Value: {0} Postfix increment: {1}", counter, counter++);
            Console.WriteLine("\t Value: {0} Postfix increment: {1}", counter, counter++);
            Console.WriteLine("\t Value: {0} Postfix increment: {1}", counter, counter++);
            double result3 = 10.0 * 2.0 / 5.0;
            Console.WriteLine("Value: {0}", result3);

            Console.WriteLine("\nTask 3.6.3. Response:");
            double result4 = 5.0 / 2.0 * 3.0;
            Console.WriteLine("\tValue: {0}", result4);

            Console.WriteLine("\nAssignment operations:");
            int check = 670;
            Console.WriteLine("\tint check = 670;\tcheck = {0}", check);
            check += 330;
            Console.WriteLine("\tcheck += 330;\tcheck = {0}", check);
            check -= 500;
            Console.WriteLine("\tcheck -= 500;\tcheck = {0}", check);
            check *= 3;
            Console.WriteLine("\tcheck *= 3;\tcheck = {0}", check);
            check /= 5;
            Console.WriteLine("\tcheck /= 5;\tcheck = {0}", check);
            check %= 7;
            Console.WriteLine("\tcheck %= 7;\tcheck = {0}", check);

            Console.WriteLine("\nTask 3.6.7. Response:");
            double result5 = 10 % 3;
            Console.WriteLine("\tValue: {0}", result5);

            
            Console.WriteLine("\nModule 3.7. Type conversion (type casting).");
            int olddata = 6;
            byte data1 = (byte)olddata;
            string data2 = olddata.ToString();
            
            Console.Write("\tEnter your age: ");
            int age2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\tYour age is {0}", age2);
            
            Console.Write("\tEnter your age: ");
            int age3 = int.Parse(Console.ReadLine());
            Console.WriteLine("\tYour age is {0}", age3);
            
            Console.Write("\tEnter your age: ");
            int age4;
            bool is_age4_correct = int.TryParse(Console.ReadLine(), out age4);
            Console.WriteLine("\tYour age is {0}", age4);

            Console.WriteLine("\nTask 3.7.3. Checking:");
            Console.Write("\tEnter your name: ");
            string Name3 = Console.ReadLine();
            Console.Write("\tEnter your age: ");
            byte age5 = (byte) int.Parse(Console.ReadLine());
            Console.WriteLine("\tYour name is {0} and age is {1}.", Name3, age5);
            
            
            
            
            
            

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


