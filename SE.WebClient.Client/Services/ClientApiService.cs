using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SE.WebClient.Client.Services
{
    public class ClientApiService
    {
        private HttpClient httpClient;
        public ClientApiService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
    }
}
