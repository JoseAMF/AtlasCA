using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.Premium;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Premium.Proposta.Queries.ListProposta
{
    public class ListProposta  : IRequest<List<TbProposta>>
    {
    }


    public class ListPropostaHandler : IRequestHandler<ListProposta, List<TbProposta>>
    {
        private readonly IPremiumDbContext _context;
        private readonly IMapper _mapper;

        public ListPropostaHandler(IPremiumDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<List<TbProposta>> Handle(ListProposta request, CancellationToken cancellationToken)
        {
            return await _context.TbProposta.ToListAsync();
        }
    }

}
