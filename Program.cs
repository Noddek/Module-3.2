using System.Net.NetworkInformation;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

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

            Console.WriteLine("\n...Press any key to continue..."); Console.ReadKey();


            Console.WriteLine("\n---------> STUDYING THE SPECIFICS OF FLOATING-POINT TYPES <---------");

            Console.WriteLine("\n1. Trying to calculate the tangent:");
            Console.WriteLine("\tIn math, the tangent of PI/2 is infinity (or undefined). \n\t(PROBLEM: can't print infinity character with copy-paste: ∞ or escape sequence: \u221E).");
            double angle = Math.PI / 2.0;
            double tangent = Math.Tan(angle);
            Console.WriteLine($"\tDouble: PI/2 = {angle}, tan(PI/2) = {tangent}");
            float angle2 = MathF.PI / 2;
            float tangent2 = MathF.Tan(angle2);
            Console.WriteLine($"\tFloat: PI/2 = {angle2}, tan(PI/2) = {tangent2}");
            Console.WriteLine("\tExplanation: the non-representability of PI and PI/2. It is simply not possible for standard floating-point hardware to attempt to compute tan(PI/2), because PI/2 cannot be represented exactly.");

            Console.WriteLine("\n2. Trying to calculate the sine:");
            Console.WriteLine("\tIn math, the sine of PI is zero.");
            double angle3 = Math.PI;
            double sine = Math.Sin(angle3);
            Console.WriteLine($"\tDouble: PI = {angle3}, sin(PI) = {sine}");
            float angle4 = (float)Math.PI;
            double sine2 = Math.Sin(angle4);
            Console.WriteLine($"\tFloat: PI = {angle4}, sin(PI) = {sine2}");
            Console.WriteLine("\tExplanation: the same reason.");

            Console.WriteLine("\n3. Trying to calculate the cosine:");
            Console.WriteLine("\tIn math, the cosine of PI is -1.");
            double cosine = Math.Cos(angle3);
            Console.WriteLine($"\tDouble: PI = {angle3}, cos(PI) = {cosine}");
            float cosine2 = MathF.Cos(angle4);
            Console.WriteLine($"\tFloat: PI = {angle4}, cos(PI) = {cosine2}");
            Console.WriteLine("\tThe result is correct in both cases.");
            Console.WriteLine("\tExplanation: Since the derivative is nearly zero near PI, the effect of the inaccuracy in the argument is far smaller than the spacing of the floating-point numbers around -1, and the rounded result is exact.");
            
            Console.WriteLine("\n4. Checking convertion to integer:");
                /* Conversions to integer are not intuitive: converting (63.0/9.0) to integer yields 7, but converting (0.63/0.09) may yield 6. 
                 * This is because conversions generally truncate rather than round. 
                 * Floor and ceiling functions may produce answers which are off by one from the intuitively expected value. */

            double[] DoubleLiteralsA1 = { 6.3E+01, 6.3E+00, 6.3E-01, 6.3E-02, 6.3E-03, 6.3E-04, 6.3E-05, 6.3E-06, 6.3E-07, 6.3E-08, 6.3E-09, 6.3E-10, 6.3E-11, 6.3E-12, 6.3E-13, 6.3E-14, 6.3E-15, 6.3E-16, 6.3E-17, 6.3E-18, 6.3E-19, 6.3E-20, 6.3E-21, 6.3E-22, 6.3E-23, 6.3E-24, 6.3E-25, 6.3E-26, 6.3E-27, 6.3E-28, 6.3E-29, 6.3E-30, 6.3E-31, 6.3E-32, 6.3E-33, 6.3E-34, 6.3E-35, 6.3E-36, 6.3E-37, 6.3E-38, 6.3E-39, 6.3E-40 };
            double[] DoubleLiteralsA2 = { 9.0E+00, 9.0E-01, 9.0E-02, 9.0E-03, 9.0E-04, 9.0E-05, 9.0E-06, 9.0E-07, 9.0E-08, 9.0E-09, 9.0E-10, 9.0E-11, 9.0E-12, 9.0E-13, 9.0E-14, 9.0E-15, 9.0E-16, 9.0E-17, 9.0E-18, 9.0E-19, 9.0E-20, 9.0E-21, 9.0E-22, 9.0E-23, 9.0E-24, 9.0E-25, 9.0E-26, 9.0E-27, 9.0E-28, 9.0E-29, 9.0E-30, 9.0E-31, 9.0E-32, 9.0E-33, 9.0E-34, 9.0E-35, 9.0E-36, 9.0E-37, 9.0E-38, 9.0E-39, 9.0E-40, 9.0E-41 };
            Console.WriteLine($"\n\tUsing {DoubleLiteralsA1.Length} literals, with Double type:");
            for (int i = 0; i < DoubleLiteralsA1.Length; i++)
            {
                Console.WriteLine($"\ta1 = {DoubleLiteralsA1[i]}, a2 = {DoubleLiteralsA2[i]}, (int)(a1 / a2) = {(int)(DoubleLiteralsA1[i] / DoubleLiteralsA2[i])}");
            }
            
            Console.WriteLine("\n\tUsing cyclic division, with Double type:");
            for (double a1 = 63.0, a2 = 9.0; a1 >= 63.0E-42; a1 /= 10, a2 /= 10)
            {
                Console.WriteLine($"\ta1 = {a1}, a2 = {a2}, (int)(a1 / a2) = {(int)(a1 / a2)}");
            }

            float[] FloatLiteralsA1 = { 6.3E+01f, 6.3E+00f, 6.3E-01f, 6.3E-02f, 6.3E-03f, 6.3E-04f, 6.3E-05f, 6.3E-06f, 6.3E-07f, 6.3E-08f, 6.3E-09f, 6.3E-10f, 6.3E-11f, 6.3E-12f, 6.3E-13f, 6.3E-14f, 6.3E-15f, 6.3E-16f, 6.3E-17f, 6.3E-18f, 6.3E-19f, 6.3E-20f, 6.3E-21f, 6.3E-22f, 6.3E-23f, 6.3E-24f, 6.3E-25f, 6.3E-26f, 6.3E-27f, 6.3E-28f, 6.3E-29f, 6.3E-30f, 6.3E-31f, 6.3E-32f, 6.3E-33f, 6.3E-34f, 6.3E-35f, 6.3E-36f, 6.3E-37f, 6.3E-38f, 6.3E-39f, 6.3E-40f };
            float[] FloatLiteralsA2 = { 9.0E+00f, 9.0E-01f, 9.0E-02f, 9.0E-03f, 9.0E-04f, 9.0E-05f, 9.0E-06f, 9.0E-07f, 9.0E-08f, 9.0E-09f, 9.0E-10f, 9.0E-11f, 9.0E-12f, 9.0E-13f, 9.0E-14f, 9.0E-15f, 9.0E-16f, 9.0E-17f, 9.0E-18f, 9.0E-19f, 9.0E-20f, 9.0E-21f, 9.0E-22f, 9.0E-23f, 9.0E-24f, 9.0E-25f, 9.0E-26f, 9.0E-27f, 9.0E-28f, 9.0E-29f, 9.0E-30f, 9.0E-31f, 9.0E-32f, 9.0E-33f, 9.0E-34f, 9.0E-35f, 9.0E-36f, 9.0E-37f, 9.0E-38f, 9.0E-39f, 9.0E-40f, 9.0E-41f };
            Console.WriteLine($"\n\tUsing {FloatLiteralsA1.Length} literals, with Float type:");
            for (int i = 0; i < FloatLiteralsA1.Length; i++)
            {
                Console.WriteLine($"\ta1 = {FloatLiteralsA1[i]}, a2 = {FloatLiteralsA2[i]}, (int)(a1 / a2) = {(int)(FloatLiteralsA1[i] / FloatLiteralsA2[i])}");
            }
                        
            Console.WriteLine($"\n\tUsing {DoubleLiteralsA1.Length} literals, with cast from Double to Float:");
            for (int i = 0; i < DoubleLiteralsA1.Length; i++)
            {
                Console.WriteLine($"\ta1 = {(float)DoubleLiteralsA1[i]}, a2 = {(float)DoubleLiteralsA2[i]}, (int)(a1 / a2) = {(int)((float)DoubleLiteralsA1[i] / (float)DoubleLiteralsA2[i])}");
            }

            Console.WriteLine("\n\tUsing cyclic division, with Float type:");
            for (float a1 = 63.0f, a2 = 9.0f; a1 >= 63.0E-42f; a1 /= 10, a2 /= 10)
            {
                Console.WriteLine($"\ta1 = {a1}, a2 = {a2}, (int)(a1 / a2) = {(int)(a1 / a2)}");
            }
                        
            Console.WriteLine("\n\tExplanation: This is because conversions generally truncate rather than round. Floor and ceiling functions may produce answers which are off by one from the intuitively expected value.");
            
            Console.WriteLine("\n5. Checking the numerical stability of the algorithm (minimizing the effect of accuracy problems):");
                /* The following algorithm is a direct implementation to compute the function A(x) = (x-1) / (exp(x-1) - 1)
                which is well-conditioned at 1.0, however it can be shown to be numerically unstable and lose up to half
                the significant digits carried by the arithmetic when computed near 1.0. */
            double ADouble (double X)
            {
                double Y, Z;
                Y = X - 1.0;
                Z = Math.Exp(Y);
                if (Z != 1.0)
                    Z = Y / (Z - 1.0);
                return Z;
            }
            // An alternative implementation that solves the problem:
            double ADoubleLog(double X)
            {
                double Y, Z;
                Y = X - 1.0;
                Z = Math.Exp(Y);
                if (Z != 1.0)
                    // A numerical analysis of the algorithm reveals that if the following non-obvious change is made,
                    // then the algorithm becomes numerically stable and can compute to full double precision:
                    Z = Math.Log(Z) / (Z - 1.0);
                return Z;
            }
            // Below you can see the same implementation of this function using float type
            float AFloat(float X)
            {
                float Y, Z;
                Y = X - (float)1.0;
                Z = MathF.Exp(Y);
                if (Z != 1.0)
                    Z = Y / (Z - (float)1.0);
                return Z;
            }
            float AFloatLog(float X)
            {
                float Y, Z;
                Y = X - (float)1.0;
                Z = MathF.Exp(Y);
                if (Z != 1.0)
                    Z = MathF.Log(Z) / (Z - (float)1.0);
                return Z;
            }
            // Below you can see the same implementation of this function using decimal type
            decimal ADecimal(decimal X)
            {
                decimal Y, Z;
                Y = X - (decimal)1.0;
                Z = (decimal)Math.Exp((double)Y); // problem: we have no Math.Exp for decimal type
                if (Z != (decimal)1.0)
                    Z = Y / (Z - (decimal)1.0);
                return Z;
            }
            decimal ADecimalLog(decimal X)
            {
                decimal Y, Z;
                Y = X - (decimal)1.0;
                Z = (decimal)Math.Exp((double)Y); 
                if (Z != (decimal)1.0)
                    Z = (decimal)Math.Log((double)Z) / (Z - (decimal)1.0); // problem: we have no Math.Log for decimal type
                return Z;
            }
            // Below is a loop for calculating the argument x = [0.9; 1.1] by these methods at 0.01 intervals
            for (double i = 0, input; i <= 0.21; i = i + 0.01)
            {
                input = 1.1 - i;
                double A_Double = ADouble(input);
                double A_Double_Log = ADoubleLog(input);
                float A_Float = AFloat((float)input);
                float A_Float_Log = AFloatLog((float)input);
                decimal A_Decimal = ADecimal((decimal)input);
                decimal A_Decimal_Log = ADecimalLog((decimal)input);
                Console.WriteLine($"\tA({input}) = {A_Double} - using Double type");
                Console.WriteLine($"\tA({input}) = {A_Double_Log} - using Double type and Log");
                Console.WriteLine($"\tA({input}) = {A_Float} - using Float type");
                Console.WriteLine($"\tA({input}) = {A_Float_Log} - using Float type and Log");
                Console.WriteLine($"\tA({input}) = {A_Decimal} - using Decimal type");
                Console.WriteLine($"\tA({input}) = {A_Decimal_Log} - using Decimal type and Log");
                Console.WriteLine("\t-----------");
            }

            Console.WriteLine("\n6. Checking the equality test:");
                /* Even simple expressions like 0.6/0.2-3==0 will, on most computers, fail to be true.
                 * In IEEE 754 double precision, for example, 0.6/0.2 - 3 is approximately equal to -4.44089209850063e-16.*/
            double d1 = 0.6, d2 = 0.2, d3 = 3, d4 = 0;
            if (d1 / d2 - d3 == d4)
            { Console.WriteLine($"\t{d1} / {d2} - {d3} == {d4} with Double type - True");}
            else
            { Console.WriteLine($"\t{d1} / {d2} - {d3} == {d4} with Double type - False"); }
            Console.WriteLine($"\tIn fact, with Double type {d1} / {d2} - {d3} = {d1 / d2 - d3}");
            
            float f1 = 0.6f, f2 = 0.2f, f3 = 3f, f4 = 0f;
                // Alternate variable declaration to test:
                // float f1 = (float)0.6, f2 = (float)0.2, f3 = 3, f4 = 0;
            if (f1 / f2 - f3 == f4)
            { Console.WriteLine($"\t{f1} / {f2} - {f3} == {f4} with Float type - True"); }
            else
            { Console.WriteLine($"\t{f1} / {f2} - {f3} == {f4} with Float type - False"); }
            Console.WriteLine($"\tIn fact, with Float type {f1} / {f2} - {f3} = {f1 / f2 - f3}");
            
            decimal m1 = 0.6m, m2 = 0.2m, m3 = 3m, m4 = 0m;
            if (m1 / m2 - m3 == m4)
            { Console.WriteLine($"\t{m1} / {m2} - {m3} == {m4} with Decimal type - True"); }
            else
            { Console.WriteLine($"\t{m1} / {m2} - {m3} == {m4} with Decimal type - False"); }
            Console.WriteLine($"\tIn fact, with Decimal type {m1} / {m2} - {m3} = {m1 / m2 - m3}");
            
            Console.WriteLine("\n6.1. Checking the alternative equality test using practically chosen epsilon > 0:");
                /* Because of the problem mentioned above, equality tests are sometimes replaced with 
                "fuzzy" comparisons like if (abs(x-y) < epsilon) ..., 
                where epsilon is sufficiently small and tailored to the application, such as 1.0E−13.
                The wisdom of doing this varies greatly, and can require numerical analysis to bound epsilon.
                Values derived from the primary data representation and their comparisons should be performed
                in a wider, extended, precision to minimize the risk of such inconsistencies due to round-off errors.
                It is often better to organize the code in such a way that such tests are unnecessary.
                For example, in computational geometry, exact tests of whether a point lies off or on a line or plane
                defined by other points can be performed using adaptive precision or exact arithmetic methods.*/
            double D1 = 0.6, D2 = 0.2, D3 = 3;
            Console.WriteLine($"\tIn fact, with Double type {D1} / {D2} - {D3} = {D1 / D2 - D3}"); // -4,440892098500626E-16
            Console.WriteLine($"\tand Math.Abs({D1} / {D2} - {D3}) = {Math.Abs(D1 / D2 - D3)}"); // 4,440892098500626E-16
            Console.WriteLine($"\tThe expression {D1} / {D2} - {D3} will always be less than any positive epsilon because the result is a negative number.");
            Console.WriteLine($"\tTherefore, below is the example of comparing Math.Abs({D1} / {D2} - {D3}) to epsilon:\n");
            for (double epsilon = 1.0E-13; epsilon >= 1.0E-18; epsilon = epsilon / 10)
            {
                Console.WriteLine($"\tepsilon = {epsilon}");
                if (Math.Abs(D1 / D2 - D3) < epsilon)
                { 
                    Console.WriteLine($"\tMath.Abs({D1} / {D2} - {D3}) < {epsilon} with Double type - True");
                    Console.WriteLine($"\tIf we use this epsilon (or greater) for equality tests, then with Double type {D1} / {D2} - {D3} == 0 is True");
                }
                else
                { 
                    Console.WriteLine($"\tMath.Abs({D1} / {D2} - {D3}) < {epsilon} with Double type - False");
                    Console.WriteLine($"\tIf we use this epsilon (or less) for equality tests, then with Double type {D1} / {D2} - {D3} == 0 is False");
                }
                Console.WriteLine("\t-----------");
            }

            Console.WriteLine("\n---------> END OF STUDYING THE SPECIFICS OF FLOATING-POINT TYPES <---------");
            
            Console.WriteLine("\n...Press any key to continue..."); Console.ReadKey();
            

            Console.WriteLine("\nModule 3.4. Enumerations.");
            DaysOfWeek MyFavoriteDay;
            MyFavoriteDay = DaysOfWeek.Friday;
            Console.WriteLine("\t{0}", MyFavoriteDay);
            // Task 3.4.3. Enumeration Semaphore - is in the end, after class Program

            Console.WriteLine("\n...Press any key to continue..."); Console.ReadKey();

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

            Console.WriteLine("\n...Press any key to continue..."); Console.ReadKey();

            Console.WriteLine("\nModule 3.6. Basic operations C#.");
            double result1 = 5 / 2;
            Console.WriteLine("\t5 / 2 = {0}", result1);
            result1 = 5.0 / 2.0;
            Console.WriteLine("\t5.0 / 2.0 = {0}", result1);
            double result2 = 5.0 % 2.0;
            Console.WriteLine("\t5.0 % 2.0 = {0}", result2);
            int counter = 10;
            Console.WriteLine("\tValue: {0} Prefix increment: {1}", counter, ++counter);
            counter = 10;
            Console.WriteLine("\tValue: {0} Postfix increment: {1}", counter, counter++);
            Console.WriteLine("\tValue: {0} Postfix increment: {1}", counter, counter++);
            Console.WriteLine("\tValue: {0} Postfix increment: {1}", counter, counter++);
            double result3 = 10.0 * 2.0 / 5.0;
            Console.WriteLine("\tOperations are performed from left to right: 10.0 * 2.0 / 5.0 = {0}", result3);
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
            Console.WriteLine("\n...Press any key to continue..."); Console.ReadKey();
            

            Console.WriteLine("\nModule 3.7. Type conversion (type casting).");

            Console.WriteLine("\nExplicit conversion (explicit casting): [commented]");
            int olddata = 6;
            byte data1 = (byte)olddata;
            string data2 = olddata.ToString();
                       
            /*
            Console.Write("\tEnter your age - Convert.ToInt32: ");
            int age2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\tYour age is {0}", age2);
            
            Console.Write("\tEnter your age - int.Parse: ");
            int age3 = int.Parse(Console.ReadLine());
            Console.WriteLine("\tYour age is {0}", age3);

            Console.Write("\tEnter your age - byte.Parse: ");
            byte age13 = byte.Parse(Console.ReadLine());
            Console.WriteLine("\tYour age is {0}", age13);

            Console.Write("\tEnter your age - int.TryParse: ");
            int age4;
            bool is_age4_correct = int.TryParse(Console.ReadLine(), out age4);
            Console.WriteLine("\tYour age is {0}", age4);
            */
            /*
            Console.WriteLine("\nTask 3.7.3. Checking:");
            Console.Write("\tEnter your name: ");
            string Name3 = Console.ReadLine();
            Console.Write("\tEnter your age: ");
            byte age5 = (byte) int.Parse(Console.ReadLine());
            Console.WriteLine("\tYour name is {0} and age is {1}.", Name3, age5);
            */
            /*
            Console.WriteLine("\nStatemnt ' checked ' ");
            Console.Write("\tEnter your name: ");
            string Name4 = Console.ReadLine();
            Console.Write("\tEnter your age: ");
            byte age6 = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("\tYour name is {0} and age is {1}.", Name4, age6);
            */
            
            Console.WriteLine("\nTask 3.7.4. DayOfWeek enumeration: [commented]");
            /*
            Console.Write("\tEnter your name: ");
            string Name5 = Console.ReadLine();
            Console.Write("\tEnter your age: ");
            byte age7 = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("\tYour name is {0} and your age is {1}.", Name5, age7);
            Console.Write("\tWhat is your favorite day of week? ");
            DayOfWeek daynumber1 = (DayOfWeek)int.Parse(Console.ReadLine());
            Console.Write("\tYour favorite day is {0}.", daynumber1);
            */
            
            Console.WriteLine("\nImplicit conversion (implicit casting): [commented]");
            /*
            Console.Write("\tEnter your age: ");
            byte age8 = checked((byte)int.Parse(Console.ReadLine()));
            int intage = age8;
            Console.WriteLine("\tYour age is {0}.", intage);
            */

            Console.WriteLine("\nImplicit typing: [commented]");

            /*
            //Implicit typing requires that the variable be initialized right away.
            Console.Write("\tEnter your age: ");
            var age9 = checked((byte)int.Parse(Console.ReadLine())); 
            Console.WriteLine("\tYour age is {0}.", age9);
            Console.Write("\tWhat is your favorite day of week? ");
            var daynumber2 = (DayOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("\tYour favorite day is {0}", daynumber2);

            Console.Write("\tEnter your age: ");
            var age10 = int.Parse(Console.ReadLine());
            Console.WriteLine("\tYour age is {0}.", age10);
            Console.Write("\tWhat is your favorite day of week? ");
            var daynumber3 = (DayOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("\tYour favorite day is {0}", daynumber3);

            var bodyheight = 162;
            var shoesize = 37.5;
            Console.WriteLine("\n\tYou are {0} sm in height.", bodyheight);
            Console.WriteLine("\tYour shoe size is {0}.", shoesize);
            */

            Console.WriteLine("\nFinal task of Module 3.7: User Questionnaire.");
            Console.Write("\tВведите имя: ");
            var Name6 = Console.ReadLine();
            Console.Write("\tВведите возраст: ");
            var age11 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tВведите дату рождения: ");
            var birthdate = Console.ReadLine();
            Console.WriteLine("\tВаше имя {0}, ваш возраст {1}, ваша дата рождения {2}.", Name6, age11, birthdate);

            Console.WriteLine("\n...End of the Program..."); Console.ReadKey();
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


