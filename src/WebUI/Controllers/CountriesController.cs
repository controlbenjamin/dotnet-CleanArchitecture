using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using sample_ca.Application.Countries.Queries.GetCountries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_ca.WebUI.Controllers
{
    //[Authorize]
    public class CountriesController : ApiController
    {

        [HttpGet]
        public async Task<IEnumerable<Countries>> Get()
        {
            return await Mediator.Send(new GetCountries());
        }
    }
}
