using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLogicApp.Exception
{
    class CustomFileNotFoundException:ApplicationException
    {
        public CustomFileNotFoundException()
        {

        }
        public CustomFileNotFoundException(string message) : base(message)
        {

        }
    }
}
