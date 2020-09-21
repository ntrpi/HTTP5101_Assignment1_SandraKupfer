using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment1_SandraKupfer.Controllers
{
    public class SquareController : ApiController
    {
        // GET http://localhost/api/Square/{id}
        public int Get( int id )
        {
            return id * id;
        }
    }
}
