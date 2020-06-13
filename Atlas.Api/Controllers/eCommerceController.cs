using Atlas.Application.eCommerce.Bilhete;
using Atlas.Application.eCommerce.Bilhete.CancelVoucherRetroactSales;
using Atlas.Application.eCommerce.Bilhete.Commands.CancelSale;
using Atlas.Application.eCommerce.Bilhete.Commands.CancelVoucher;
using Atlas.Application.eCommerce.Bilhete.Commands.CancelVoucherRetroact;
using Atlas.Application.eCommerce.Bilhete.Queries.GetBilhete;
using Atlas.Application.eCommerce.CadastroDePessoa.Commands;
using Atlas.Application.eCommerce.CadastroDePessoa.Queries;
using Atlas.Application.eCommerce.Cupom;
using Atlas.Application.eCommerce.Cupom.Commands;
using Atlas.Application.eCommerce.Cupom.Queries.GetCupom;
using Atlas.Application.eCommerce.Cupom.Queries.GetCupomCode;
using Atlas.Application.eCommerce.Cupom.Queries.ListCupom;
using Atlas.Application.eCommerce.Pareport.Queries;
using Atlas.Domain.Entities.eCommerce;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Atlas.Api.Controllers
{
    public class eCommerceController : ApiController
    {
        #region Cupom
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

        [HttpPut("Cupom")]
        [Authorize(Roles = "Cupom_Leitura, Cupom_escrita, Cupom_Admin")]
        public async Task<ActionResult> UpdateCupom(CreateCupomCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpPost("Cupom/{ambiente}")]
        [Authorize(Roles = "Cupom_escrita, Cupom_Admin")]
        public async Task<ActionResult<PrPromocionCupones>> CreateCupom(CreateCupomCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
#endregion

        #region Pareport
        [HttpGet("Pareport")]
        [Authorize(Roles = "Pareport")]
        public async Task<ActionResult<IEnumerable<PareportAtlas>>> getPareport(string Ambientes = null, string inicio = null, string fim = null, int? page = null, int? pageSize = null)
        {
            return await Mediator.Send(new GetPareportQuery(Ambientes.Split(','), inicio, fim, page, pageSize));
        }
        #endregion

        #region CadastroDePessoa
        [HttpGet("CadastroPessoa/{bilhete}")]
        [Authorize(Roles = "CadastroPessoa_Leitura, CadastroPessoa_Escrita, CadastroPessoa_Admin")]
        public async Task<ActionResult<PePersonaFisica>> GetCadastroPessoa(string bilhete)
        {
            return Ok(await Mediator.Send(new GetCadastroPessoaQuery(bilhete)));
        }

        [HttpPut("CadastroPessoa/{bilhete}")]
        [Authorize(Roles = "CadastroPessoa_Escrita, CadastroPessoa_Admin")]
        public async Task<IActionResult> UpdateCadastroPessoa(UpdateCadastroPessoaCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
        #endregion

        #region Bilhete

        [HttpGet("Bilhete/{nrVoucher}")]
        public async Task<ActionResult<BilheteDTO>> GetBilhete(string nrVoucher)
        {
            return await Mediator.Send(new GetBilheteQuery(nrVoucher));
        }

        [HttpDelete("CancelarBilhete/{nrVoucher}")]
        [Authorize(Roles = "CancelamentoBilhete_escrita, CancelamentoBilhete_Admin")]
        public async Task<ActionResult> CancelVoucher(string nrVoucher)
        {
            return Ok (await Mediator.Send(new CancelVoucherCommand(nrVoucher)));
        }

        [HttpGet("CancelarBilheteRetroativo/{nrVoucher}/{data}")]
        [Authorize(Roles = "CancelamentoBilhete_Admin")]
        public async Task<ActionResult> CancelVoucherRetroact(string nrVoucher, string data)
        {
            return Ok(await Mediator.Send(new CancelVoucherRetroactCommand(nrVoucher, data)));
        }

        [HttpGet("CancelarVendaRetroativo/{nrVoucher}/{data}")]
        [Authorize(Roles = "CancelamentoBilhete_Admin")]
        public async Task<ActionResult> CancelVoucherRetroactSales(string nrVoucher, string data)
        {
            return Ok(await Mediator.Send(new CancelVoucherRetroactSalesCommand(nrVoucher,data)));
        }
        [HttpGet("CancelarVenda/{nrVoucher}/")]
        [Authorize(Roles = "CancelamentoBilhete_escrita, CancelamentoBilhete_Admin")]
        public async Task<ActionResult> CancelSale(string nrVoucher)
        {
            return Ok(await Mediator.Send(new CancelSaleCommand(nrVoucher)));
        }
            #endregion
        }
}
