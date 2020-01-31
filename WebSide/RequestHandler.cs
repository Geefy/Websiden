using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSide
{
    class RequestHandler
    {
        IRequestAble iRequest;

        public RequestHandler(IRequestAble request)
        {
            this.iRequest = request;
        }

        public string RequestData(string path)
        {

            return iRequest.RequestData(path);
        }
    }
}
