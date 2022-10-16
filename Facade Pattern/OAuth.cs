using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    public class OAuth
    {
        public string GetRequestToken(String appKey, String appSecret)
        {
            Console.WriteLine("Get a request token");
            return "requestToken";
        }

        public string GetAccessToken(String requestToken)
        {
            Console.WriteLine("Get an access token");
            return "accessToken";
        }
    }
}
