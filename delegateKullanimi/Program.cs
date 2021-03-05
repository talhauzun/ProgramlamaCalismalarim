using System;
using System.Collections.Generic;

namespace delegateKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //ilkDelegetim ilk = new ilkDelegetim(myMetot);
            //ilk += new ilkDelegetim(topla);


            ///*    ilkDelegetim ilk = (test) => { Console.WriteLine(test); };
            //    ilk += (test) => { Console.WriteLine(test); };
            //    ilk += (test) => { Console.WriteLine(test); };*/

            //Console.WriteLine(ilk.Method.Name);
            //ilk(10);




            List<String> names = new List<String>();
            names.Add("Bruce");
            names.Add("Alfred");
            names.Add("Tim");
            names.Add("Richard");

            // Display the contents of the list using the Print method.
            names.ForEach(Print);

            // The following demonstrates the anonymous method feature of C#
            // to display the contents of the list to the console.
            names.ForEach(delegate (String name)
            {
                Console.WriteLine(name);
            });


            Console.ReadKey();
        }



        static void Print(string s)
        {
            Console.WriteLine(s);
        }



























        static void myMetot(int sayi)
        {
            Console.WriteLine(sayi + "--------------");
        }
        static void topla(int sayi)
        {
            Console.WriteLine(sayi + "-++++++++++++++++++++");
        }


        public delegate void MyDelegate(string msg);

        public delegate void ilkDelegetim(int sayi);

        public delegate void Action<in T>(T obj);
    }



}
