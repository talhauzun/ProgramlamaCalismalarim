using System;

namespace EventKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Program bl = new Program();
            bl.ProcessCompleted += bl_ProcessCompleted; // register with an event
            bl.StartProcess();



            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        public static void bl_ProcessCompleted()
        {
            Console.WriteLine("Process Completed!");
        }


        public event Notify ProcessCompleted; // event

        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            // some code here..
            OnProcessCompleted();
        }

        protected virtual void OnProcessCompleted() //protected virtual method
        {
            //if ProcessCompleted is not null then call delegate
            ProcessCompleted?.Invoke();
        }
    }

    public delegate void Notify();

}
