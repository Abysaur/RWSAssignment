using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.IO;
=======
>>>>>>> ed99ae3362f9842e137f2b4d3103c393af7966cc
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLogicApp.Exception
{
    class CustomFileNotFoundException:ApplicationException
    {
<<<<<<< HEAD

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
=======
        public CustomFileNotFoundException()
        {

        }
        public CustomFileNotFoundException(string message) : base(message)
        {
>>>>>>> ed99ae3362f9842e137f2b4d3103c393af7966cc

        }
    }
}
