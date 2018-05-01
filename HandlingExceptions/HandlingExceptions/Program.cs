using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\Users\nbarkus\Desktop\Exampl.txt");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Make sure the name of the file is named correctly: Example.txt");
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine(@"Make sure the name of the directory is correct: C:\Users\nbarkus\Desktop");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //Code to finalize
                //Setting objects to null
                //Closing database connections
                Console.WriteLine("Closing Application now..." );
            }
            
            
           
        }
    }
}
