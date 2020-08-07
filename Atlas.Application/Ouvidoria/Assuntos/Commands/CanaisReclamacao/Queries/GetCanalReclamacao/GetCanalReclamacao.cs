﻿using Atlas.Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.Assuntos.Commands.CanaisReclamacao.Queries.GetCanalReclamacao
{
    public class GetCanalReclamacao  : IRequest<CanalReclamacaoDTO>
    {
        public GetCanalReclamacao(int Id)
        {
            this.Id = Id;
        }

        public int Id { get; }
    }


    public class GetCanalReclamacaoHandler : IRequestHandler<GetCanalReclamacao, CanalReclamacaoDTO>
    {
        private readonly IAtlasDbContext _context;
        private readonly IMapper _mapper;

        public GetCanalReclamacaoHandler(IAtlasDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<CanalReclamacaoDTO> Handle(GetCanalReclamacao request, CancellationToken cancellationToken)
        {
            return _mapper.Map< CanalReclamacaoDTO >( await _context.Ouvidoria_CanaisReclamacoes.FindAsync(request.Id));
        }
    }

}
