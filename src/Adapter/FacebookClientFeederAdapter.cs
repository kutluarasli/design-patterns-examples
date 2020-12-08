namespace DesignPatternExamples.Adapter
{
    public class FacebookClientFeederAdapter : IFeeder
    {
        private readonly ThirdPartyFacebookClient _adaptedObject;

        public FacebookClientFeederAdapter(ThirdPartyFacebookClient adaptedObject)
        {
            _adaptedObject = adaptedObject;
        }

        public void Feed(int profileId, string message)
        {
            // Do some stuff
            _adaptedObject.SendPagePost(null, null, null);
        }
    }
}