using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Http;
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
        static async void Download()
        {
            await Network.Download();
            HttpClient client = new HttpClient();
            var data = await client.GetStreamAsync("https://www.gapcanada.ca/?tid=gcps000015&kwid=1&ap=7&gclid=EAIaIQobChMI6ZGOvOOl4QIVj4bACh3KlA2SEAAYASAAEgI4BvD_BwE&gclsrc=aw.ds");
            Console.WriteLine(data);
           
        }
        class  Network
        {
            static public Task Download()
            {
                return Task.Run(() => Thread.Sleep(3000));
            }
        }
    }
}
