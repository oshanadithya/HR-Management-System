using HR_Management_System.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management_System.Data
{
    public class ApiService : IApiService
    {
        [Inject]
        IConfiguration Configuration { get; set; }
        string testApi = "";
        string liveApi = "";
        string apiType = "";
        private readonly HttpClient httpClient;
        private readonly IOptions<AppSettingsApi> options;

        public ApiService(HttpClient httpClient, IOptions<AppSettingsApi> options)
        {
            this.httpClient = httpClient;
            testApi = options.Value.test;
            liveApi = options.Value.live;
            apiType = options.Value.type;
        }

        public HttpClient GetHttpClient()
        {
            return httpClient;
        }

        public string GetAPI()
        {
            if (apiType == "live")
                return liveApi;
            else
                return testApi;
        }

        /*public async Task<IEnumerable<User>> GetUserById(int UserId)
        {
            return await httpClient.GetFromJsonAsync<User[]>("/api/v1/ GetUser/{UserId}/" + UserId);
        }*/
    }
}
