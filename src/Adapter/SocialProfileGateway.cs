namespace DesignPatternExamples.Adapter
{
    public class SocialProfileGateway
    {
        public void ShareNews(long userId, string news)
        {
            //Load my social profile
            var profileId = 1;
            //Create associated social profile adapter
            var facebookClient = new ThirdPartyFacebookClient();
            var adapter = new FacebookClientFeederAdapter(facebookClient);
            //Send the feed
            //Sample 
            adapter.Feed(profileId, news);
        }
    }
}