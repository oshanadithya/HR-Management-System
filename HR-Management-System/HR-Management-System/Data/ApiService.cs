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

namespace SupremeCourt.Data
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

    }

}
