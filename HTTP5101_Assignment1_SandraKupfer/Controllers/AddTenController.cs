using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment1_SandraKupfer.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Assignment 1.1
        /// GET http://localhost/api/AddTen/{id}
        /// </summary>
        /// <param name="id">Integer value to which to add 10.</param>
        /// <returns>Integer value 10 greater than the input.</returns>
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
