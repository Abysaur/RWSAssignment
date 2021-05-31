using CustomLogicApp.Exception;
using System;
<<<<<<< HEAD
using System.Collections.Generic;
=======
>>>>>>> ed99ae3362f9842e137f2b4d3103c393af7966cc
using System.Linq;
using System.Xml.Linq;

namespace CustomLogicApp.FileReader
{
    public class CustomDataReader
    {
        public XDocument document = null;

<<<<<<< HEAD
        /** 
         * This method iterates through the files in the directory in case of an array
         * saves the files as .bak first and then starts processing the file and then saves it as modified xml
         */
        public string GetResult(string[] fileArrray)
        {
            try  
            {

                foreach (var itemFile in fileArrray)
                {
                    document = XDocument.Load(itemFile);
                    document.Save("save.xml");
                    document.Save("sav.bak");
                    var query = from item in document.Elements("company")
                                select item;
                    foreach (var docElement in query)
                    {
                        docElement.Element("title").Value = "SDL TriSoft";
                        var employeedeatils = docElement.Element("employees").Elements();

                        foreach (var item in employeedeatils)
                        {

                            if (item.Element("title").Attribute("name").Value == "Trisoft")
                            {
                                item.Element("title").Attribute("name").Value = "SDL TriSoft";
                            }
                        }
                    }

                }
            }
            catch (CustomFileNotFoundException fnfe)
            {
                //Log file 
                Console.WriteLine(fnfe.Message);
            }
            document.Save("ModifiedSample.xml");
            return "success";
        }


        /** 
         * This method iterates through the files in the directory in case of a enumerabke string
         * saves the files as bak first and then starts processing the file and then saves it as modified xml
         */
        public string GetResult(IEnumerable<string> files)
        {
            try
            {

                foreach (var itemFile in files)
=======
        public string GetResult(string[] fileArrray)
        {
            try
            {
                foreach (var itemFile in fileArrray)
>>>>>>> ed99ae3362f9842e137f2b4d3103c393af7966cc
                {
                    document = XDocument.Load(itemFile);
                    document.Save("save.xml");
                    document.Save("sav.bak");
                    var query = from item in document.Elements("company")
                                select item;
                    foreach (var docElement in query)
                    {
                        docElement.Element("title").Value = "SDL TriSoft";
                        var employeedeatils = docElement.Element("employees").Elements();

                        foreach (var item in employeedeatils)
                        {

                            if (item.Element("title").Attribute("name").Value == "Trisoft")
                            {
                                item.Element("title").Attribute("name").Value = "SDL TriSoft";
                            }
                        }
                    }

                }
            }
            catch (CustomFileNotFoundException fnfe)
            {
                //Log file 
                Console.WriteLine(fnfe.Message);
            }
<<<<<<< HEAD
            //The original file is saved as ModifiedSample in case the replacements have happened
=======
>>>>>>> ed99ae3362f9842e137f2b4d3103c393af7966cc
            document.Save("ModifiedSample.xml");
            return "success";
        }
    }
}
