using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication.Controllers
{
    public class DataController : ApiController
    {
        string data = "Success status from API";
        
        [HttpGet]
        public string index()
        {
            return data;
        }
    }
}
