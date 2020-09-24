using MediatR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sample_ca.Application.Covid19Summary.Queries.GetCovid19Summary
{
    public class GetCovid19Summary : IRequest<Covid19Summary>
    {
    }

    public class GetCovid19SummaryHandler : IRequestHandler<GetCovid19Summary, Covid19Summary>
    {
        public async Task<Covid19Summary> Handle(GetCovid19Summary request, CancellationToken cancellationToken)
        {
            var summary = new Covid19Summary();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://api.covid19api.com/summary"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    summary = JsonConvert.DeserializeObject<Covid19Summary>(apiResponse);

                }
            }
            return summary;
        }
    }
}
