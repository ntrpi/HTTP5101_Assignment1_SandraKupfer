using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment1_SandraKupfer.Controllers
{
    public class GreetingController : ApiController
    {
        string greetingPrefix = "Greetings to ";
        string greetingSuffixSingular = " person!";
        string greetingSuffix = " people!";

        // Check video for post requests
        //POST http://localhost/api/Greeting
        public string Post()
        {
            return "Hello World!";
        }

        // GET http://localhost/api/Greeting/{id}
        public string Get( int id )
        {
            string greeting = greetingPrefix + id.ToString();
            if( id == 1 )
            {
                return greeting + greetingSuffixSingular;
            } else
            {
                return greeting + greetingSuffix;
            }
        }
    }
}
