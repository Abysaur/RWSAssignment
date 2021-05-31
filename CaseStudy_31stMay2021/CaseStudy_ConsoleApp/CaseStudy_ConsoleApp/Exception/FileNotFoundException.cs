using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_ConsoleApp.Exception
{
    class FileNotFoundException:ApplicationException
    {
        public FileNotFoundException()
        {

        }
        public FileNotFoundException(string message):base(message)
        {

        }
    }
}
