using Atlas.Application.Common.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.Assuntos.Commands.CanaisReclamacao.Queries.ListCanalReclamacao
{
    public class ListCanalReclamacao : IRequest<List<CanalReclamacaoDTO>>
    {
    }


    public class ListCanalReclamacaoHandler : IRequestHandler<ListCanalReclamacao, List<CanalReclamacaoDTO>>
    {
        private readonly IAtlasDbContext _context;
        private readonly IMapper _mapper;

        public ListCanalReclamacaoHandler(IAtlasDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<List<CanalReclamacaoDTO>> Handle(ListCanalReclamacao request, CancellationToken cancellationToken)
        {
            return await _context.Ouvidoria_CanaisReclamacoes
                .ProjectTo<CanalReclamacaoDTO>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }

}
