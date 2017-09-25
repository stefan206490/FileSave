using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readfromtextfile
{
    class Program
    {
        static void Main(string[] args)
        {
            // The files used in this example are created in the topic
            // How to: Write to a Text File. You can change the path and
            // file name to substitute text files of your own.
            Console.WriteLine("Wat wil je bijvoegen in een file?");
            string text = Console.ReadLine();
            System.IO.File.WriteAllText(@"D:\test.txt", text);

            // Example #1
            // Read the file as one string.
            //string text = System.IO.File.ReadAllText(@"D:\test.txt");
            //Console.WriteLine(text);

            // Display the file contents to the console. Variable text is a string.
            //System.Console.WriteLine("Contents of test.txt = {0}", text);

            // Example #2
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"D:\test.txt");
            foreach (string write in lines)
            {
                Console.WriteLine(write);
            }//

            // Display the file contents by using a foreach loop.
            /*
            System.Console.WriteLine("Contents of test.txt = ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }
            */
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
