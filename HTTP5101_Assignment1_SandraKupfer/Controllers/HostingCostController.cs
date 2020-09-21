using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment1_SandraKupfer.Controllers
{
    public class HostingCostController : ApiController
    {
        private static readonly decimal baseCost = 5.50m;
        private static readonly string moneyFormatString = "{0:.00}";
        private static readonly string zeroString = "0";
        private static readonly string emptyString = "";

        private static readonly string fortnightsSingleMiddle = " fortnight at $" + String.Format(moneyFormatString, baseCost) + "/FN = $";
        private static readonly string fortnightsMiddle = " fortnights at $" + String.Format( moneyFormatString, baseCost ) + "/FN = $";
        private static readonly string hstPrefix = "HST 13% = $";
        private static readonly string totalPrefix = "Total = $";
        private static readonly string currencyString = " CAD";

        private readonly string[] hostingCostStrings = new string[3];

        // GET http://localhost/api/HostingCost/{id}
        public string[] Get( int id )
        {
            int numFortnights = id / 14;
            decimal subTotal = numFortnights * baseCost + baseCost;
            decimal hst = subTotal * 0.13m;
            decimal total = subTotal + hst;

            hostingCostStrings[0] = numFortnights.ToString() 
                + (numFortnights == 1 ? fortnightsSingleMiddle : fortnightsMiddle ) 
                + String.Format( moneyFormatString, subTotal ) 
                + currencyString;
            // TODO: look into composite formatting or something else to get rid of this tertiary statement.
            // Maybe try ToString with some different format strings.
            hostingCostStrings[1] = hstPrefix 
                + (numFortnights == 0 ? zeroString : emptyString) 
                + String.Format(moneyFormatString, hst ) 
                + currencyString;
            hostingCostStrings[2] = totalPrefix + String.Format(moneyFormatString, total );

            return hostingCostStrings;
        }
    }
}
