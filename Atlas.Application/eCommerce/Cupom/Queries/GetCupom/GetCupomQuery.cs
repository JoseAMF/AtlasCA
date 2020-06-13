using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.eCommerce;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.eCommerce.Cupom.Queries.GetCupom
{
    public class GetCupomQuery : IRequest<PrPromocionCuponesDTO>
    {
        public GetCupomQuery(string ambiente, int id)
        {
            Id = id;
            Ambiente = ambiente;
        }
        public int Id{ get; set; }
        public string Ambiente { get; set; }
    }

    public class GetCupomQueryHandler : IRequestHandler<GetCupomQuery, PrPromocionCuponesDTO>
    {
        private readonly IeCommerceDbContextService _contextService;
        private readonly IMapper _mapper;
        public GetCupomQueryHandler(IeCommerceDbContextService contextService, IMapper mapper)
        {
            _contextService = contextService;
            _mapper = mapper;
        }
        public async Task<PrPromocionCuponesDTO> Handle(GetCupomQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<PrPromocionCuponesDTO>( await _contextService.GetContextInitials(request.Ambiente).PrPromocionCupones
                .FindAsync(request.Id));
        }
    }
}
