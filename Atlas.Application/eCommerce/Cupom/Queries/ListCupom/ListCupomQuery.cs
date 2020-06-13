using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.eCommerce;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.eCommerce.Cupom.Queries.ListCupom
{
    public class ListCupomQuery : IRequest<List<PrPromocionCuponesDTO>>
    {
        public string Ambiente { get; set; }

        public ListCupomQuery(string ambiente)
        {
            Ambiente = ambiente;
        }
    }

    public class ListCupomQueryHandler : IRequestHandler<ListCupomQuery, List<PrPromocionCuponesDTO>>
    {
        private readonly IeCommerceDbContextService _contextService;
        private readonly IMapper _mapper;
        public ListCupomQueryHandler(IeCommerceDbContextService contextService, IMapper mapper)
        {
            _contextService = contextService;
            _mapper = mapper;
        }
        public async Task<List<PrPromocionCuponesDTO>> Handle(ListCupomQuery request, CancellationToken cancellationToken)
        {
            return await _contextService.GetContextInitials(request.Ambiente)
                .PrPromocionCupones
                .ProjectTo<PrPromocionCuponesDTO>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
