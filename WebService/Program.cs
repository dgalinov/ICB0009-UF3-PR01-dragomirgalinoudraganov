using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Xml;
using System.Threading;

namespace WebService
{
    class Program
    {
        static void Main(string[] args)
        {                        
            var web = new HttpListener();
            //Prefixes conté la URI del nostre servidor web. 
            web.Prefixes.Add("http://localhost:3000/");
            Console.WriteLine("Listening.."); 
            web.Start();
            Console.ReadKey();               
        }

    }
}
