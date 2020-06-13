using Atlas.Application.eCommerce.Cupom;
using Atlas.Application.eCommerce.Cupom.Commands;
using Atlas.Application.eCommerce.Cupom.Queries.GetCupom;
using Atlas.Application.eCommerce.Cupom.Queries.GetCupomCode;
using Atlas.Application.eCommerce.Cupom.Queries.ListCupom;
using Atlas.Domain.Entities.eCommerce;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Atlas.Api.Controllers
{
    public class eCommerceController : ApiController
    {
        [HttpGet("Cupom/{ambiente}/{id}")]
        [Authorize(Roles = "Cupom_Leitura, Cupom_escrita, Cupom_Admin")]
        public async Task<ActionResult<PrPromocionCuponesDTO>> GetCupom(string ambiente, int id)
        {
            return await Mediator.Send(new GetCupomQuery(ambiente, id));
        }

        [HttpGet("Cupons/{ambiente}")]
        [Authorize(Roles = "Cupom_Leitura, Cupom_escrita, Cupom_Admin")]
        public async Task<ActionResult<List<PrPromocionCuponesDTO>>> ListCupom(string ambiente)
        {
            return await Mediator.Send(new ListCupomQuery(ambiente));
        }

        [HttpGet("Cupons/{ambiente}/{codigo}")]
        [Authorize(Roles = "Cupom_Leitura, Cupom_escrita, Cupom_Admin")]
        public async Task<ActionResult<List<PrPromocionCuponesDTO>>> ListCupomCode(string ambiente, string codigo)
        {
            return await Mediator.Send(new ListCupomCodeQuery(ambiente, codigo));
        }

        [HttpPut("Cupom")]
        [Authorize(Roles = "Cupom_Leitura, Cupom_escrita, Cupom_Admin")]
        public async Task<ActionResult> UpdateCupom(AtualizaCupomCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
    }
}
