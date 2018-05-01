using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");

            //string text = "A class is the most powerful data type in C#. Like a structure, " +
            //           "a class defines the data and behavior of the data type. ";
            ////File.WriteAllText(@"C:\Users\nbarkus\Desktop\WriteText.csv", text);
            //string fileText = File.ReadAllText(@"C:\Users\nbarkus\Desktop\WriteText.txt");
            //Console.WriteLine(fileText);


            WebClient client = new WebClient();
            string reply = client.DownloadString("http://msdn.microsoft.com");

            Console.WriteLine(reply);
            File.WriteAllText(@"C:\Users\nbarkus\Desktop\WriteText.txt", reply);
            Console.ReadLine();

            
        }

        //public static void DownloadString(string address)
        //{
        //    WebClient client = new WebClient();
        //    string reply = client.DownloadString(address);

        //    Console.WriteLine(reply);
        //}
    }
}
