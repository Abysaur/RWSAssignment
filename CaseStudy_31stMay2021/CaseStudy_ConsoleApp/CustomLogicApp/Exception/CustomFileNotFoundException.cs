using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLogicApp.Exception
{
    class CustomFileNotFoundException:ApplicationException
    {

    public CustomFileNotFoundException()
        {

            if (!Directory.Exists(Environment.CurrentDirectory + "\\Log"))
            {
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\Log");
            }
        }

        /**
         * Logs all the error to the log file   
         */
        public CustomFileNotFoundException(string message) : base(message)
        {
            string[] start = { DateTime.Now + ": Error : \n" };
            File.AppendAllLines(Environment.CurrentDirectory + "\\Log\\log.txt", start);

        }
    }
}
