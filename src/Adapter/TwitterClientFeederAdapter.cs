namespace DesignPatternExamples.Adapter
{
    public class TwitterClientFeederAdapter : IFeeder
    {
        private readonly ThirdPartyTwitterClient _adaptedObject;

        public TwitterClientFeederAdapter(ThirdPartyTwitterClient adaptedObject)
        {
            _adaptedObject = adaptedObject;
        }

        public void Feed(int profileId, string message)
        {
            //Do some stuff
            _adaptedObject.Tweet(null, null);
        }
    }
}