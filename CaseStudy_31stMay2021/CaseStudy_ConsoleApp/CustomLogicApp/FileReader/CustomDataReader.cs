using CustomLogicApp.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace CustomLogicApp.FileReader
{
    public class CustomDataReader
    {
        public XDocument document = null;

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
            //The original file is saved as ModifiedSample in case the replacements have happened
            document.Save("ModifiedSample.xml");
            return "success";
        }
    }
}
