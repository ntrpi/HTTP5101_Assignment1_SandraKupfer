using System.Web.Http;

namespace HTTP5101_Assignment1_SandraKupfer.Controllers
{
    public class GreetingController : ApiController
    {
        string greetingPrefix = "Greetings to ";
        string greetingSuffixSingular = " person!";
        string greetingSuffix = " people!";

        /// <summary>
        /// Assignment 1.3
        /// POST http://localhost/api/Greeting
        /// </summary>
        /// <returns>The string "Hello World!"</returns>
        public string Post()
        {
            return "Hello World!";
        }

        /// <summary>
        /// Assignment 1.4
        /// GET http://localhost/api/Greeting/{id}
        /// </summary>
        /// <param name="id">Integer value indicating the number of people to greet.</param>
        /// <returns>Returns the string “Greetings to {id} people!” where id is an integer value.</returns>
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
