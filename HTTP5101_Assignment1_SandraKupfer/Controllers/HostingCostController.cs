using System.Collections.Generic;
using System.Web.Http;

namespace HTTP5101_Assignment1_SandraKupfer.Controllers
{
    public class HostingCostController : ApiController
    {
        private static readonly decimal baseCost = 5.5m;

        private static readonly string baseCostString = baseCost.ToString("C");
        private static readonly string fortnightsSingleMiddle = " fortnight at " + baseCostString + "/FN = ";
        private static readonly string fortnightsMiddle = " fortnights at " + baseCostString + "/FN = ";
        private static readonly string hstPrefix = "HST 13% = ";
        private static readonly string totalPrefix = "Total = ";
        private static readonly string currencyString = " CAD";

        private readonly string[] hostingCostStrings = new string[3];

        /// <summary>
        /// Assignment 1.bonus
        /// GET http://localhost/api/HostingCost/{id}
        /// Calculates the hosting cost for the input number of days and return a set of strings summarizing the cost.
        /// </summary>
        /// <param name="id">Number of nights hosted.</param>
        /// <returns>Three strings that describe the base hosting cost, tax, and total.</returns>
        public IEnumerable<string> Get( int id )
        {
            int numFortnights = id / 14;
            decimal subTotal = numFortnights * baseCost + baseCost;
            decimal hst = subTotal * 0.13m;
            decimal total = subTotal + hst;

            hostingCostStrings[0] = numFortnights.ToString()
                + (numFortnights == 1 ? fortnightsSingleMiddle : fortnightsMiddle)
                + subTotal.ToString("C")                
                + currencyString;
            hostingCostStrings[1] = hstPrefix 
                + hst.ToString("C") 
                + currencyString;
            hostingCostStrings[2] = totalPrefix 
                + total.ToString("C")
                + currencyString;

            return hostingCostStrings;
        }
    }
}
