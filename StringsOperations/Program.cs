using System;
using System.Linq;

namespace StringsOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program asks the user for a string and: 1. Replaces all lowercase to uppercase and vice-versa (use of for loop), 2. Replaces all spaces with underscores (use Replace method), 3. Removes all spaces(use of LINQ)");

            Console.WriteLine("Add a string: ");
            string s1 = Console.ReadLine();

            int i;
            int lengthS1 = s1.Length;
            char sign;
            char [] arrayS1 = s1.ToCharArray(0,lengthS1);

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Case 1");
            for (i=0; i<lengthS1; i++)
            {
                sign = arrayS1[i];
                if (Char.IsLower(sign))
                {
                    Console.WriteLine(Char.ToUpper(sign));
                }
                else
                {
                    Console.WriteLine(Char.ToLower(sign));
                }
            }

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Case 2");
            string withUnderscores = s1.Replace(" ", "_");

            Console.WriteLine(withUnderscores);

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Case 3");
            var withoutAdditionalSpaces = arrayS1.Where(c => !char.IsWhiteSpace(c)).ToArray();

            Console.WriteLine(withoutAdditionalSpaces);

            Console.ReadKey();
        }
    }
}
