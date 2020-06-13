using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.eCommerce;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
namespace Atlas.Application.eCommerce.Pareport.Queries
{
    public class GetPareportQuery : IRequest<List<PareportAtlas>>
    {
        public GetPareportQuery(IEnumerable<string> ambientes, string inicio, string fim, int? page, int? pageSize)
        {
            Ambientes = ambientes;
            Inicio = inicio;
            Fim = fim;
            Page = page;
            PageSize = pageSize;
        }

        public IEnumerable<string> Ambientes { get; }
        public string Inicio { get; }
        public string Fim { get; }
        public int? Page { get; }
        public int? PageSize { get; }
    }

    public class GetPareportQueryHandler : IRequestHandler<GetPareportQuery, List<PareportAtlas>>
    {
        private readonly IeCommerceDbContextService contextService;

        public GetPareportQueryHandler(IeCommerceDbContextService _contextService)
        {
            contextService = _contextService;
        }
        public async Task<List<PareportAtlas>> Handle(GetPareportQuery request, CancellationToken cancellationToken)
        {
            var where = (request.Inicio == request.Fim ? null : " Where ") + (request.Inicio == null ? null : "Dt_Emissao >= '" + request.Inicio + "' ") + (request.Inicio != null && request.Fim != null ? "AND " : null) + (request.Fim == null ? null : "Dt_Emissao < '" + request.Fim + "'");
            List<PareportAtlas> resultado = new List<PareportAtlas>();
            foreach (var ambiente in request.Ambientes)
            {
                var pagination = "";
                if (request.Page.HasValue && request.PageSize.HasValue)
                {
                    if (resultado.Count >= request.PageSize.Value) break;

                    pagination = " Order by Dt_Emissao OFFSET " + request.PageSize.Value * (request.Page.Value - 1) + " ROWS FETCH NEXT " + (request.PageSize.Value - resultado.Count) + " ROWS ONLY";
                }
                var context = contextService.GetContextInitials(ambiente);

                var retorno = await context.PareportAtlas.FromSqlRaw("Select * from dbo.PareportAtlas" + where + pagination).ToListAsync();

                resultado.AddRange(retorno);

            }
            return resultado;
        }
    }
}
