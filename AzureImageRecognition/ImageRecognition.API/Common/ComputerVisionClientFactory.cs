using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;

namespace ImageRecognition.API.Common
{
    public static class ComputerVisionClientFactory
    {

        /*
         * AUTHENTICATE
         * Creates a Computer Vision client used by each example.
         */
        public static ComputerVisionClient Authenticate(string endpoint, string key)
        {
            ComputerVisionClient client =
              new ComputerVisionClient(new ApiKeyServiceClientCredentials(key))
              { Endpoint = endpoint };
            return client;
        }
    }
}
