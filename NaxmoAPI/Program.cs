using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl;

namespace NaxmoAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var url = "https://rest.nexmo.com"
                .AppendPathSegment("sms")
                .SetQueryParam(new {
                 api_key = "my_key",
                 api_secret = "my_secret"
                });
        }
    }
}
