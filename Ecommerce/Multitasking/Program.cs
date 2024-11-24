using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multitasking
{
   internal class Program
    {
        public static void Process1()
        {
            int count = 45;
            while (true)
            {
                Console.WriteLine("Process1 function caller :" + Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine("doing something important");
                Thread.Sleep(1000);

            }
        }
        public static void Process2()
        {
            int count = 45;
            while(true)
            {
                Console.WriteLine("doing something important" );
                Console.WriteLine();
                Thread.Sleep(1000);

            }
        }
    

       public static void Main(string[] args)
        {
            Thread thread1 = new Thread(Process1);
            Thread thread2 = new Thread(Process2);
            thread1.Start();    
            thread2.Start();

            while(true)
            {
                Console.WriteLine("Hello World") ;
                Thread.Sleep(1000);
                Console.WriteLine("Main function caller"+ Thread.CurrentThread.ManagedThreadId);    
            }

            

        }
        }
    
}
