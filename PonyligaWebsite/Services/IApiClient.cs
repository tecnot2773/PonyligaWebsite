using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Refit;

namespace PonyligaWebsite.Services
{
    [Headers("APIKey: df5b0f08-a3ae-4bbc-a26f-42b199de266e")]
    public interface IApiClient
    {
        [Get("/api/result/summary")]
        Task<Models.Team[]> GetResultSummary();
    }
}
