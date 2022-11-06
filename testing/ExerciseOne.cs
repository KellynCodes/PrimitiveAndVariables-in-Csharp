using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace testing.lesson1
{
    internal class ExerciseOne
    {
        public static void Main(string[] args)

        {
            float floatPI = 3.14f;
            Console.WriteLine(floatPI); // 3.14
            double doublePI = 3.14;
            Console.WriteLine(doublePI); // 3.14
            double nan = Double.NaN;
            Console.WriteLine(nan); // NaN
            double infinity = Double.PositiveInfinity;
            Console.WriteLine(infinity); // Infinity


                int a = 5;
                int b = 3;
                if (a + b > 10)
                    Console.WriteLine("The answer is greater than 10");
                else
                    Console.WriteLine("The answer is not greater than 10");

                if (a + b > 10)
                {
                    Console.WriteLine("The answer is greater than 10");
                }
                else
                {
                    Console.WriteLine("The answer is not greater than 10");
                }


                int _fiveInt = 5;
                int thirdInt = 3;
                int fouthInt = 4;
                if ((_fiveInt + thirdInt + fouthInt > 10) || (_fiveInt == thirdInt))
                {
                    Console.WriteLine("The answer is greater than 10");
                    Console.WriteLine("Or the first number is equal to the second");
                }
                else
                {
                    Console.WriteLine("The answer is not greater than 10");
                    Console.WriteLine("And the first number is not equal to the second");
                }
            // Declare a variable
            char ch = 'a';
            // Print the results on the console
            Console.WriteLine(
            "The code of '" + ch + "' is: " + (int)ch);
            ch = 'b';
            Console.WriteLine(
            "The code of '" + ch + "' is: " + (int)ch);
            ch = 'A';
            Console.WriteLine(
            "The code of '" + ch + "' is: " + (int)ch);

            int i = 5;
            int? ni = i;
            Console.WriteLine(ni); // 5
                                   // i = ni; // this will fail to compile
            Console.WriteLine(ni.HasValue); // True
            i = ni.Value;
            Console.WriteLine(i); // 5
            ni = null;
            Console.WriteLine(ni.HasValue); // False
                                            //i = ni.Value; // System.InvalidOperationException
            i = ni.GetValueOrDefault();
            Console.WriteLine(i); // 0

            //Escaping Sequences – Examples
// An ordinary character
char character = 'a';
            Console.WriteLine(character);
            // Unicode character code in a hexadecimal format
            character = '\u003A';
            Console.WriteLine(character);
            // Assigning the single quotiation character (escaped as \')
            character = '\'';
            Console.WriteLine(character);
            // Assigning the backslash character (escaped as \\)
            character = '\\';
            Console.WriteLine(character);
            // Console output:
            // a
            // :
            // '
            // \

            //String Literals – Examples
//Here are few examples for string literals usage:
string quotation = "\"Hello, Jude\", he said.";
            Console.WriteLine(quotation);

            decimal[] decimals = { Decimal.MaxValue, 12.45M, 0M, -19.69M,
                       Decimal.MinValue };
            foreach (decimal value in decimals)
                Console.WriteLine($"Abs({value}) = {Math.Abs(value)}");

            // The example displays the following output:
            //       Abs(79228162514264337593543950335) = 79228162514264337593543950335
            //       Abs(12.45) = 12.45
            //       Abs(0) = 0
            //       Abs(-19.69) = 19.69
            //       Abs(-79228162514264337593543950335) = 79228162514264337593543950335
            Console.WriteLine(Decimal.MaxValue);

            //          Exercises
            //1.Declare several variables by selecting for each one of them the most
            //appropriate of the types sbyte, byte, short, ushort, int, uint, long
            //and ulong in order to assign them the following values: 52, 130; -115;
            //4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000;
            //1990; 123456789123456;

            sbyte TheSbyte = -115;
            byte theByte = 224;
            short TheShort = -10000;
            ushort TheUShort = 20000;
            int ThInt = -1000000;
            uint TheUint = 4825932;
            long TheLong = 970700000;
            ulong TheULong = 123456789123456789;
            short ThSecShort = 1990;
            sbyte TheSecSByte = -44;
            byte TheSecByte = 52;
            byte ThirdByte = 130;
            byte TheThirdByte = 112;
            int SecInt = 97;
            //Done with the first exercise;

            //Exercise Two;
           // 2.Which of the following values can be assigned to variables of type float,
//double and decimal: 5, -5.01, 34.567839023; 12.345; 8923.1234857;
  //3456.091124875956542151256683467 ?
           decimal DoubleNum = 12.345m;
            decimal FirstDecimal = -5.01m;
            decimal SecDecimalNum = 34.567839023m;
            float ThirdFloatNum = 8923.1234857f;
            float FloatNum = 3456.091124875956542151256683467f;
            double FourthDouble = 5;
            //Second Exercise Done;


            // 3.Write a program, which compares correctly two real numbers with
            //accuracy at least 0.000001.
            bool equal = Math.Abs(5.43421 - 5.434205) < 0.000001;
            Console.WriteLine(equal);

          //  4.Initialize a variable of type int with a value of 256 in
//hexadecimal format(256 is 100 in a numeral system with base 16
        int num = 250;
            int hexNum = 0x100;
            if (num == hexNum)
            {
                Console.WriteLine("Yes");
                //Yes is printed 
            }
            else
            {
                Console.WriteLine("no");
            };


            //          5.Declare a variable of type char and assign it as a value the character,
            //which has Unicode code, 72(use the Windows calculator in order to find
            //hexadecimal representation of 72).
            char Charact = '\u0048';
            Console.WriteLine(Charact);
            if(Charact == 72)
            {
                Console.WriteLine($"Yes {Charact} is Equal 72");
                //This will be printed on the console;
            }
            else
            {
                Console.WriteLine($"NO {Charact} is not Equal 72");
            }
            //Number five Not Done;

            // 6.Declare a variable isMale of type bool and assign a value to it depending
            //on your gender.

            //SOLUTION
            bool isMale = true;
            Console.WriteLine("My Gender is \"Male\""+ " " + isMale);
            //number 6 done;


            // 7.Declare two variables of type string with values "Hello" and "World".
            //Declare a variable of type object.Assign the value obtained of
            //concatenation of the two string variables(add space if necessary) to this
            //variable.Print the variable of type object.
            string StrOne = "Hello";
            string StrTwo = "World";
            object ConcatStrs = StrOne + " " + StrTwo;
            Console.WriteLine(ConcatStrs);
            //Number 7 Done;

            //8.Declare two variables of type string and give them values "Hello" and
            //"World".Assign the value obtained by the concatenation of the two
            //variables of type string(do not miss the space in the middle) to a
            //variable of type object.Declare a third variable of type string and
            //initialize it with the value of the variable of type object(you should use
            //type casting);
            string StrLeft;
            string StrRight;
            object ObjectConcatenation;
            string StringValue;

            StrLeft = "Hello";
            StrRight = "World";
            ObjectConcatenation = StrLeft + " " + StrRight;
            StringValue = (string)ObjectConcatenation;
            //Done with 8;

            // 9.Declare two variables of type string and assign them a value “The
            //"use" of quotations causes difficulties.” (without the outer quotes).
            //In one of the variables use quoted string and in the other do not use it.
            string Str9 = "The \"use\" of quotations causes difficulties";
            string Str9One = @"The ""use"" of quotations causes difficulties";
            Console.WriteLine("{0}\n{1}", Str9, Str9One);
            //Number 9 Done;

            //10.Write a program to print a figure in the shape of a heart by the sign "o"
            char o = 'o';
            Console.WriteLine("  " + o + o + o + "   " + o + o + o);
            Console.WriteLine(" " + o + "   " + o + " " + o + "   " + o);
            Console.WriteLine(o + "     " + o + "     " + o);
            Console.WriteLine(o + "     " + " " + "     " + o);
            Console.WriteLine(o + "     " + " " + "     " + o);
            Console.WriteLine(" " + o + "    " + "     " + o);
            Console.WriteLine("  " + o + "   " + "    " + o);
            Console.WriteLine("   " + o + "  " + "   " + o);
            Console.WriteLine("    " + o + "  " + " " + o);
            Console.WriteLine("     " + o + " " + o);
            Console.WriteLine("      " + o);
            //Number 10 Done;
            //11. Write a program that prints on the console isosceles triangle which
            //sides consist of the copyright character "©".;
            //SOLUTION TO NUMBER 11;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("   \u00A9   ");
            Console.WriteLine("  \u00A9 \u00A9  ");
            Console.WriteLine(" \u00A9   \u00A9 ");
            Console.WriteLine("\u00A9 \u00A9 \u00A9 \u00A9");
            //Number 11 done;


            //12.A company dealing with marketing wants to keep a data record of its
            //employees.Each record should have the following characteristic – first
            //name, last name, age, gender(‘m’ or ‘f’) and unique employee number
            //(27560000 to 27569999). Declare appropriate variables needed to
            //maintain the information for an employee by using the appropriate data
            //types and attribute names.;
            string FirstName;
            string LastName;
            byte Age;
            char Gender;
            int EmployeeNumber;

            FirstName = "Kelechi";
            LastName = "Amos Omeh";
            Age = 20;
            Gender = 'm';
            EmployeeNumber = 27569999;
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}", FirstName, LastName, Age, Gender, EmployeeNumber);
            //Done with number 12;

            // 13.Declare two variables of type int.Assign to them values 5 and 10
            //respectively.Exchange(swap) their values and print them;
            int Five;
            int Ten;
            Five = 5;
            Ten = 10;
            Console.WriteLine("{0}\n{1}", Five, Ten);

            Five = Five + Ten; // 5 + 10 = 15;
            Ten = Five - Ten; // 15 - 10 = 5;
            Five = Five - Ten; // 1
            Console.WriteLine("{0}\n{1}", Five, Ten);
            //Number 13 Done;
             
        }
    }
}
