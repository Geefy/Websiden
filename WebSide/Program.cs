using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebSide
{
    class Program
    {
        static void Main(string[] args)
        {
            IRequestAble requester = new WebRequester();
            RequestHandler handler = new RequestHandler(requester);
            string filePath = @"C:\Users\rene2756\Documents\Hello.txt";
            string webPath = "https://www.youtube.com/watch?v=i1IKnWDecwA&list=RDMMN7VCLNBNJQs&index=3";
           

            //Console.WriteLine(handler.RequestData(filePath));
            Console.WriteLine(handler.RequestData(webPath));
            Console.Read();
        }
    }
}
