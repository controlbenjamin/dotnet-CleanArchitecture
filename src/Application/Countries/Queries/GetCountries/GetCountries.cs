using MediatR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace sample_ca.Application.Countries.Queries.GetCountries
{
    public class GetCountries : IRequest<IEnumerable<Countries>>
    {

    }

    public class GetCountriesHandler : IRequestHandler<GetCountries, IEnumerable<Countries>>
    {
        public async Task<IEnumerable<Countries>> Handle(GetCountries request, CancellationToken cancellationToken)
        {
            var countriesList = new List<Countries>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://api.covid19api.com/countries"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    countriesList = JsonConvert.DeserializeObject<List<Countries>>(apiResponse);

                }
            }
            return countriesList;
        }
    }
}
