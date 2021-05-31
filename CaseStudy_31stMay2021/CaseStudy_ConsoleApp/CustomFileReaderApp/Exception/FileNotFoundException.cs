using System;
using System.Collections.Generic;
using System.Text;

namespace CustomFileReaderApp.Exception
{
    class FileNotFoundException:ApplicationException
    {
        public FileNotFoundException()
        {

        }
        public FileNotFoundException(string message) : base(message)
        {

        }
    }
}
