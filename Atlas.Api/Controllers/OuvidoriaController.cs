using Atlas.Application.Ouvidoria.Assuntos;
using Atlas.Application.Ouvidoria.Assuntos.Commands.CanaisReclamacao;
using Atlas.Application.Ouvidoria.Assuntos.Commands.CanaisReclamacao.Commands.DeleteCanalReclamacao;
using Atlas.Application.Ouvidoria.Assuntos.Commands.CanaisReclamacao.Commands.UpdateCanalReclamacao;
using Atlas.Application.Ouvidoria.Assuntos.Commands.CanaisReclamacao.Queries.GetCanalReclamacao;
using Atlas.Application.Ouvidoria.Assuntos.Commands.CanaisReclamacao.Queries.ListCanalReclamacao;
using Atlas.Application.Ouvidoria.Assuntos.Commands.CreateAssunto;
using Atlas.Application.Ouvidoria.Assuntos.Commands.DeleteAssunto;
using Atlas.Application.Ouvidoria.Assuntos.Commands.UpdateAssunto;
using Atlas.Application.Ouvidoria.Assuntos.Queries.GetAssunto;
using Atlas.Application.Ouvidoria.Assuntos.Queries.ListAssunto;
using Atlas.Application.Ouvidoria.CanaisReclamacao.Commands.PostCanalReclamacao;
using Atlas.Application.Ouvidoria.CanaisVenda;
using Atlas.Application.Ouvidoria.CanaisVenda.Commands.CreateCanalVenda;
using Atlas.Application.Ouvidoria.CanaisVenda.Commands.DeleteCanalVenda;
using Atlas.Application.Ouvidoria.CanaisVenda.Commands.UpdateCanalVenda;
using Atlas.Application.Ouvidoria.CanaisVenda.Queries.GetCanalVenda;
using Atlas.Application.Ouvidoria.CanaisVenda.Queries.ListCanalVenda;
using Atlas.Application.Ouvidoria.Motivos;
using Atlas.Application.Ouvidoria.Motivos.Commands.CreateMotivo;
using Atlas.Application.Ouvidoria.Motivos.Commands.DeleteMotivo;
using Atlas.Application.Ouvidoria.Motivos.Commands.UpdateMotivo;
using Atlas.Application.Ouvidoria.Motivos.Queries.GetMotivo;
using Atlas.Application.Ouvidoria.Motivos.Queries.ListMotivo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atlas.Api.Controllers
{
    public class OuvidoriaController : ApiController
    {
        #region Motivo
        [HttpGet]
        [Authorize(Roles = "Ouvidoria")]
        [Route("Motivo")]
        public async Task<ActionResult<List<MotivoDTO>>> ListMotivo()
        {
            return Ok(await Mediator.Send(new ListMotivoQuery()));
        }

        [HttpGet]
        [Authorize(Roles = "Ouvidoria")]
        [Route("Motivo/{id}")]
        public async Task<ActionResult<MotivoDTO>> GetMotivo(int id)
        {
            return Ok(await Mediator.Send(new GetMotivoQuery(id)));
        }

        [HttpPut]
        [Authorize(Roles = "Ouvidoria")]
        [Route("Motivo")]
        public async Task<ActionResult> PutMotivo(MotivoDTO motivo)
        {
            return Ok(await Mediator.Send(new UpdateMotivoCommand(motivo)));
        }

        [HttpPost]
        [Authorize(Roles = "Ouvidoria")]
        [Route("Motivo")]
        public async Task<ActionResult<int>> PostMotivo(MotivoDTO motivo)
        {
            return Ok(await Mediator.Send(new CreateMotivoCommand(motivo)));
        }

        [HttpDelete]
        [Authorize(Roles = "Ouvidoria")]
        [Route("Motivo/{id}")]
        public async Task<ActionResult> DeleteMotivo(int id)
        {
            return Ok(await Mediator.Send(new DeleteMotivoCommand(id)));
        }
        #endregion

        #region CanalVenda
        [HttpGet]
        [Authorize(Roles = "Ouvidoria")]
        [Route("CanalVenda")]
        public async Task<ActionResult<List<CanalVendaDTO>>> ListCanalVenda()
        {
            return Ok(await Mediator.Send(new ListCanalVendaQuery()));
        }

        [HttpGet]
        [Authorize(Roles = "Ouvidoria")]
        [Route("CanalVenda/{id}")]
        public async Task<ActionResult<CanalVendaDTO>> GetCanalVenda(int id)
        {
            return Ok(await Mediator.Send(new GetCanalVendaQuery(id)));
        }


        [HttpPut]
        [Authorize(Roles = "Ouvidoria")]
        [Route("CanalVenda")]
        public async Task<ActionResult> PutCanalVenda(CanalVendaDTO canalVenda)
        {
            return Ok(await Mediator.Send(new UpdateCanalVendaCommand(canalVenda)));
        }

        [HttpPost]
        [Authorize(Roles = "Ouvidoria")]
        [Route("CanalVenda")]
        public async Task<ActionResult> PostCanalVenda(CanalVendaDTO canalVenda)
        {
            return Ok(await Mediator.Send(new CreateCanalVendaCommand(canalVenda)));
        }

        [HttpDelete]
        [Authorize(Roles = "Ouvidoria")]
        [Route("CanalVenda/{id}")]
        public async Task<ActionResult<CanalVendaDTO>> DeleteCanalVenda(int id)
        {
            return Ok(await Mediator.Send(new DeleteCanalVendaCommand(id)));
        }
        #endregion

        #region Assunto
        [HttpGet]
        [Authorize(Roles = "Ouvidoria")]
        [Route("Assunto")]
        public async Task<ActionResult<List<AssuntoDTO>>> ListAssunto()
        {
            return Ok(await Mediator.Send(new ListAssuntoQuery()));
        }

        [HttpGet]
        [Authorize(Roles = "Ouvidoria")]
        [Route("Assunto/{id}")]
        public async Task<ActionResult<AssuntoDTO>> GetAssunto(int id)
        {
            return Ok(await Mediator.Send(new GetAssuntoQuery(id)));
        }

        [HttpPut]
        [Authorize(Roles = "Ouvidoria")]
        [Route("Assunto")]
        public async Task<ActionResult> PutAssunto(AssuntoDTO assunto)
        {
            return Ok(await Mediator.Send(new UpdateAssuntoCommand(assunto)));
        }

        [HttpPost]
        [Authorize(Roles = "Ouvidoria")]
        [Route("Assunto")]
        public async Task<ActionResult> PostAssunto(AssuntoDTO assunto)
        {
            return Ok(await Mediator.Send(new CreateAssuntoCommand(assunto)));
        }

        [HttpDelete]
        [Authorize(Roles = "Ouvidoria")]
        [Route("Assunto/{id}")]
        public async Task<ActionResult<AssuntoDTO>> DeleteAssunto(int id)
        {
            return Ok(await Mediator.Send(new DeleteAssuntoCommand(id)));
        }
        #endregion

        #region CanalReclamacao
        [HttpGet]
        [Authorize(Roles = "Ouvidoria")]
        [Route("CanalReclamacao")]
        public async Task<ActionResult<List<CanalReclamacaoDTO>>> ListCanalReclamacao()
        {
            return Ok(await Mediator.Send(new ListCanalReclamacaoQuery()));
        }

        [HttpGet]
        [Authorize(Roles = "Ouvidoria")]
        [Route("CanalReclamacao/{id}")]
        public async Task<ActionResult<CanalReclamacaoDTO>> GetCanalReclamacao(int id)
        {
            return Ok(await Mediator.Send(new GetCanalReclamacaoQuery(id)));
        }

        [HttpDelete]
        [Authorize(Roles = "Ouvidoria")]
        [Route("CanalReclamacao/{id}")]
        public async Task<ActionResult> DeleteCanalReclamacao(int id)
        {
            return Ok(await Mediator.Send(new DeleteCanalReclamacaoCommand(id)));
        }

        [HttpPut]
        [Authorize(Roles = "Ouvidoria")]
        [Route("CanalReclamacao")]
        public async Task<ActionResult> PutCanalReclamacao(CanalReclamacaoDTO canalReclamacao)
        {
            return Ok(await Mediator.Send(new UpdateCanalReclamacaoCommand(canalReclamacao)));
        }

        [HttpPost]
        [Authorize(Roles = "Ouvidoria")]
        [Route("CanalReclamacao")]
        public async Task<ActionResult<int>> PostCanalReclamacao(CanalReclamacaoDTO canalReclamacao)
        {
            return Ok(await Mediator.Send(new PostCanalReclamacaoCommand(canalReclamacao)));
        }
        #endregion
    }
}
