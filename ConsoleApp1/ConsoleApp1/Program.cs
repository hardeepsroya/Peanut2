using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Download();
            Console.ReadLine();
        }
        static void Download()
        {
            //Thread.Sleep(3000);
            Console.WriteLine("Download complt 1");
            Task Run() => ()
                {
                Thread.Sleep(3000);
                Console.WriteLine("commit 1");
            }
            );
        }
    }
}
