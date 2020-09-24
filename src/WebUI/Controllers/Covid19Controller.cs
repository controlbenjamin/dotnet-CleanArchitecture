using Microsoft.AspNetCore.Mvc;
using sample_ca.Application.Covid19Summary.Queries.GetCovid19Summary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_ca.WebUI.Controllers
{
    public class Covid19Controller : ApiController
    {

        [HttpGet]
        public async Task<Covid19Summary> Get()
        {
            return await Mediator.Send(new GetCovid19Summary());
        }
    }
}
