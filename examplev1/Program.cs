using System;

namespace examplev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //yaziyiBas yaziyiBas = goster;
            //for (int i = 0; i < 10; i++)
            //{
            //    yaziyiBas("selam naber");
            //}

            //hesapla hesapla = topla;

            //hesapla(5, 9);
            //hesapla(7, 4);

            //Action<int, int> action=islem;

            //for (int i = 0; i < 10; i++)
            //{
            //    action(i, 7);
            //}

            Func<int, int, int> func = toplaFunc;
            sayiyiBas yaziyiBas = sayiyiYazdir;
            for (int i = 0; i < 10; i++)
            {
                yaziyiBas(func(i, 7));
            }

            Console.ReadKey();
        }

        private static int toplaFunc(int arg1, int arg2)
        {
            return arg1 + arg2;
        }

        private static void islem(int arg1, int arg2)
        {
            Console.WriteLine(arg1 + arg2);
        }

        private static int topla(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
            return sayi1 + sayi2;
        }

        private static void goster(string yazi)
        {
            Console.WriteLine(yazi);
        }
        private static void sayiyiYazdir(int yazi)
        {
            Console.WriteLine(yazi);
        }
    }


    public delegate void yaziyiBas(string yazi);
    public delegate void sayiyiBas(int yazi);
    public delegate int hesapla(int i, int j);



}
