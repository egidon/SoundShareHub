
using Microsoft.Extensions.Configuration;

namespace SoundShareHub
{
    public class ConnectionStringProvider
    {
        private readonly IConfiguration _configuration;

        public ConnectionStringProvider(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetLocalConnectionString()
        {
            return _configuration.GetConnectionString("LocalConnection");
        }
    }

}
