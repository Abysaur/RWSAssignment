using CustomLogicApp.FileReader;
using System;
using System.IO;

namespace CaseStudy_ConsoleApp
{
    class Program
    {
        readonly string rootDir = "";

        public Program()
        {
            var mydirectory = Environment.CurrentDirectory;
            int indexofmyvar = mydirectory.IndexOf("bin");
            rootDir= mydirectory.Substring(0, indexofmyvar);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            CustomDataReader customDataReader = new CustomDataReader();
            Console.WriteLine("Welcome to Trisoft--->SDL TriSoft Case Study App!!");
            string[] fileArray = Directory.GetFiles(Environment.CurrentDirectory, "*.xml", SearchOption.AllDirectories);
            Console.WriteLine(customDataReader.GetResult(fileArray));
        }
        
    }
}
