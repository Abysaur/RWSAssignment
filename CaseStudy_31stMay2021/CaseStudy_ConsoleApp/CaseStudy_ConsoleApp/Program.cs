using CustomLogicApp.FileReader;
using System;
using System.IO;
<<<<<<< HEAD
using System.Linq;
using System.Text.RegularExpressions;
=======
>>>>>>> ed99ae3362f9842e137f2b4d3103c393af7966cc

namespace CaseStudy_ConsoleApp
{
    class Program
    {
        readonly string rootDir = "";

<<<<<<< HEAD
        /**
         * This is the main method - Get the current directory here and then get the root directory from it
         * 
         */
        public Program()
        {
            //Checking path of the current directory
=======
        public Program()
        {
>>>>>>> ed99ae3362f9842e137f2b4d3103c393af7966cc
            var mydirectory = Environment.CurrentDirectory;
            int indexofmyvar = mydirectory.IndexOf("bin");
            rootDir= mydirectory.Substring(0, indexofmyvar);
        }
        static void Main(string[] args)
        {
<<<<<<< HEAD

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
=======
            Program program = new Program();
            CustomDataReader customDataReader = new CustomDataReader();
            Console.WriteLine("Welcome to Trisoft--->SDL TriSoft Case Study App!!");
            string[] fileArray = Directory.GetFiles(Environment.CurrentDirectory, "*.xml", SearchOption.AllDirectories);
            Console.WriteLine(customDataReader.GetResult(fileArray));
>>>>>>> ed99ae3362f9842e137f2b4d3103c393af7966cc
        }
        
    }
}
