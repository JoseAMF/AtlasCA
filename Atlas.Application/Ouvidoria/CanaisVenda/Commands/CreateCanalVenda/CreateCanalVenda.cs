﻿using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.Atlas.Ouvidoria;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.CanaisVenda.Commands.CreateCanalVenda
{
    public class CreateCanalVenda  : IRequest<int>
    {
        public CreateCanalVenda(CanalVendaDTO CanalVenda)
        {
            this.CanalVenda = CanalVenda;
        }

        public CanalVendaDTO CanalVenda { get; }
    }


    public class CreateCanalVendaHandler : IRequestHandler<CreateCanalVenda, int>
    {
        private readonly IAtlasDbContext _context;
        private readonly IMapper _mapper;

        public CreateCanalVendaHandler(IAtlasDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<int> Handle(CreateCanalVenda request, CancellationToken cancellationToken)
        {
            _context.Ouvidoria_CanaisVenda.Add(_mapper.Map<CanalVenda>(request.CanalVenda));

           return await _context.SaveChangesAsync(cancellationToken);
        }
    }

}
