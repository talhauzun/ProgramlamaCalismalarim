using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FuncKullanimi
{
    class Program
    {




        delegate string ConvertMetod(string a);

        static void Main(string[] args)
        {

            /////------------------------------------------------------------------------------------------
            Func<string, string> selector = str => str.ToUpper();


            string[] words = { "orange", "apple", "Article", "elephant" };
            IEnumerable<String> aWords = words.Select(selector);
            // Output the results to the console.
            foreach (String word in aWords)
                Console.WriteLine(word);

            /////------------------------------------------------------------------------------------------
            Console.WriteLine("----------------------------");
            ConvertMetod convertMetod = UpperCaseString;
            foreach (String word in aWords)
                Console.WriteLine(convertMetod(word));



            //-----------------------------------------------------------------------------------------------
            Console.WriteLine("----------------------------");
            Func<int, int, int> p = (x, y) =>  x + y;
            Console.WriteLine(p(5,6));

            //-----------------------------------------------------------------------------------------------
            Console.WriteLine("----------------------------");
            Func<string, int, IEnumerable> func = BolucuMetot;
            

            foreach (var item in func("selam talha bugün nasılsın", 7))
            {
                Console.WriteLine(item);
            }

            //-----------------------------------------------------------------------------------------------
            Console.WriteLine("----------------------------");
           //func = BolucuMetot;


            //foreach (var item in func("selam talha bugün nasılsın", 7))
            //{
            //    Console.WriteLine(item);
            //}




            Console.ReadKey();
        }

        private static IEnumerable BolucuMetot(string test, int size)
        {

            return test.Substring(0, size).ToCharArray().ToList().AsEnumerable();
        }

        private static Func<string, int, IEnumerable> BolucuMetot(string test, int size)
        {

            return test.Substring(0, size).ToCharArray().ToList().AsEnumerable();
        }
        private static string UpperCaseString(string text) {

            return text.ToLower();
        
        }
    }
}
