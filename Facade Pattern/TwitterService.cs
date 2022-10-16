using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    public class TwitterService
    {
        private readonly string _requestToken;
        private readonly OAuth _oauth;
        private readonly TwitterClient _twitterClient;

        //We initialize our properties
        public TwitterService()
        {
            _oauth = new OAuth();
            _twitterClient = new TwitterClient();
            _requestToken = _oauth.GetRequestToken("appKey", "appSecret");
        }

        public List<Tweet> GetRecentTweets()
        {
            
            var accessToken = _oauth.GetAccessToken(_requestToken);

            return _twitterClient.GetRecentTweets(accessToken);
        }
    }
}
