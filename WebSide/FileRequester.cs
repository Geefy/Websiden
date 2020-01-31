using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSide
{
    class FileRequester : IRequestAble
    {
        public string RequestData(string data)
        {
            string response;
            using (StreamReader reader = new StreamReader(data))
            {
                // Read the content.  
                response = reader.ReadToEnd();
            }
            return response;
        }
    }
}
