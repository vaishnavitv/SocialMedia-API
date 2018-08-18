using CoreTweet;
using System.Configuration;

namespace SocialMedia_API
{
    class Twitter : SocialMediaGenerator
    {
        public void SendMessage(string message)
        {
            string oAuthConsumerKey = ConfigurationManager.AppSettings["consumerKey"];
            string oAuthConsumerSecret = ConfigurationManager.AppSettings["consumerKeySecret"];
            string accessToken = ConfigurationManager.AppSettings["accessToken"];
            string accessTokenSecret = ConfigurationManager.AppSettings["accessTokenSecret"];
            var tokens = Tokens.Create(oAuthConsumerKey, oAuthConsumerSecret, accessToken, accessTokenSecret);
            tokens.Statuses.Update(status => message);
        }
    }
}

