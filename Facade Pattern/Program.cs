namespace Facade_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //We instantiate our twitter service.
            var twitterService = new TwitterService();

            //Now TwitterService is like a facade to our complex services
            var recentTweets = twitterService.GetRecentTweets();
        }
    }
}