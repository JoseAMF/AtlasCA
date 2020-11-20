using Atlas.Application.Premium.Proposta.Queries.GetProposta;
using Atlas.Domain.Entities.Premium;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atlas.Api.Controllers
{
    public class PremiumController : ApiController
    {
        [HttpGet]
        [Route("Proposta/{id}")]
        public async Task<ActionResult<TbProposta>> GetProposta(string id)
        {
            return await Mediator.Send(new GetProposta(id));
        }

    }
}
