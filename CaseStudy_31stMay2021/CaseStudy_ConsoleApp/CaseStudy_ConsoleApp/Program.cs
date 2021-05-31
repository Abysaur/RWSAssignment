using CustomLogicApp.FileReader;
using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace CaseStudy_ConsoleApp
{
    class Program
    {
        readonly string rootDir = "";

        /**
         * This is the main method - Get the current directory here and then get the root directory from it
         * 
         */
        public Program()
        {
            //Checking path of the current directory
            var mydirectory = Environment.CurrentDirectory;
            int indexofmyvar = mydirectory.IndexOf("bin");
            rootDir= mydirectory.Substring(0, indexofmyvar);
        }
        static void Main(string[] args)
        {

            Program program = new Program();   
            //custom class to read files
            CustomDataReader customDataReader = new CustomDataReader();
            Console.WriteLine("Welcome to Trisoft--->SDL TriSoft Case Study App!!");

            /**
             * There are multiple approaches to get the files
             */

            //Get files in an array and then pass  the array to the custom reader class to process
            //string[] fileArray = Directory.GetFiles(Environment.CurrentDirectory, "*.xml", SearchOption.AllDirectories);

            //if using IEnumerable
            //var files = Directory.GetFiles(Environment.CurrentDirectory, "*.*", SearchOption.AllDirectories).Where(s => s.EndsWith(".xml") || s.EndsWith(".xsl") || s.EndsWith(".xslt"));

            //if using Regular expressions
            var files = Directory.GetFiles(Environment.CurrentDirectory).Where(file => Regex.IsMatch(file, @"^.+\.(xml|xslt|xsl)$"));
            Console.WriteLine(customDataReader.GetResult(files));
        }
        
    }
}
