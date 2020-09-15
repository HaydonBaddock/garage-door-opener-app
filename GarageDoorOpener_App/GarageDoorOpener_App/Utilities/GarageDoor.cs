using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace GarageDoorOpener_App.Utilities
{
    public class GarageDoor
    {
        private const string PiAddress = "http://192.168.1.100:2000/open-sesame";

        private readonly HttpClient _client;

        public GarageDoor()
        {
            _client = new HttpClient();
        }

        public async Task<bool> Open()
        {
            try
            {
                await _client.GetAsync(PiAddress);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
