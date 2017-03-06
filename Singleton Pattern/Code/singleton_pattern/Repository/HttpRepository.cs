using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using singleton_pattern.Models;

namespace singleton_pattern.Repository
{
    public class HttpRepository
    {
        HttpClient Client = HttpClientSingleton.Instance();
        public PipelineStatusModel HttpGetPipelineStatus(string PipelineName)
        {
            Task<string> Response = Client.GetStringAsync(string.Format("http://localhost:8153/go/api/pipelines/{0}/status", PipelineName));
            PipelineStatusModel PipelineStatusObject = JsonConvert.DeserializeObject<PipelineStatusModel>(Response.Result);
            return PipelineStatusObject;
        }
    }
}
