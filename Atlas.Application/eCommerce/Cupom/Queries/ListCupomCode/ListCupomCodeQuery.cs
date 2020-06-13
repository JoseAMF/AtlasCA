using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.eCommerce;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.eCommerce.Cupom.Queries.GetCupomCode
{
    public class ListCupomCodeQuery : IRequest<List<PrPromocionCuponesDTO>>
    {
        public ListCupomCodeQuery(string ambiente, string codigo)
        {
            Ambiente = ambiente;
            Codigo = codigo;
        }
        public string Ambiente { get; set; }
        public string Codigo { get; set; }
    }

    public class ListCupomCodeQueryHandler : IRequestHandler<ListCupomCodeQuery, List<PrPromocionCuponesDTO>>
    {
        private readonly IeCommerceDbContextService _contextService;
        private readonly IMapper _mapper;
        public ListCupomCodeQueryHandler(IeCommerceDbContextService contextService, IMapper mapper)
        {
            _contextService = contextService;
            _mapper = mapper;
        }
        public async Task<List<PrPromocionCuponesDTO>> Handle(ListCupomCodeQuery request, CancellationToken cancellationToken)
        {
            return await _contextService.GetContextInitials(request.Ambiente)
                .PrPromocionCupones
                .Where(c => c.CodigoCupon.Contains(request.Codigo))
                .ProjectTo<PrPromocionCuponesDTO>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
