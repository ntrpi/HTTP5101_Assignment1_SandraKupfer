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
        /// <summary>
        /// Assignment 1.2
        /// GET http://localhost/api/Square/{id}
        /// </summary>
        /// <param name="id">Integer of which to return the square.</param>
        /// <returns>The square of the input value.</returns>
        public int Get( int id )
        {
            return id * id;
        }
    }
}
