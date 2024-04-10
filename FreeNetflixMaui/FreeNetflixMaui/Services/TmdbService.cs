using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;


namespace Services
{
    public partial class TmdbService
    {
        private const string ApiKey = "738b6d8d99b51339705b1037c981a488"; // generate it from tmdb website
        public const string TmdbHttpClientName = "TmdbClient";

        private readonly IHttpClientFactory _httpClientFactory;

        public TmdbService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        private HttpClient HttpClient => _httpClientFactory.CreateClient(TmdbHttpClientName);



    }
}