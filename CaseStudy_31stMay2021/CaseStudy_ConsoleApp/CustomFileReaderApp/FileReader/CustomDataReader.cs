using System;
using System.IO;
using System.Xml.Linq;

namespace CustomFileReaderApp.FileReader
{
    public class CustomDataReader
    {
        public XDocument document = null;

        public void GetResult(string[] fileArrray)
        {
            try
            {
                foreach (var itemFile in fileArrray)
                {
                    document = XDocument.Load(itemFile);
                    document.Save("save.xml");
                    if (!File.Exists("sav.bak")
                        {
                        document.Save("sav.bak");
                    }

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
            catch (FileNotFoundException fnfe)
            {
                //Log file 
                Console.WriteLine(fnfe.Message);
            }
            document.Save("ModifiedSample.xml");
        }
    }
}
