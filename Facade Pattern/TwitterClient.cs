using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    public class TwitterClient
    {
        public List<Tweet> GetRecentTweets(string accessToken)
        {
            Console.WriteLine("Getting recent tweets");

            return new List<Tweet>();
        }
    }
}
