using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace CoreApp.Persistence.Repository
{
    public class RespondModel
    {
        public HttpStatusCode StatusCode { get; set; }

        public object data { get; set; }

        public string Message { get; set; }
    }
}
