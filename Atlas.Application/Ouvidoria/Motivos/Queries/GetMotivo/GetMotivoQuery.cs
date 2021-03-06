﻿using Atlas.Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.Motivos.Queries.GetMotivo
{
    public class GetMotivoQuery : IRequest<MotivoDTO>
    {
        public GetMotivoQuery(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }

    public class GetMotivoHandler : IRequestHandler<GetMotivoQuery, MotivoDTO>
    {
        private readonly IAtlasDbContext context;
        private readonly IMapper mapper;

        public GetMotivoHandler(IAtlasDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public async Task<MotivoDTO> Handle(GetMotivoQuery request, CancellationToken cancellationToken)
        {
            return mapper.Map<MotivoDTO>(await context.Ouvidoria_Motivos.FindAsync(request.Id));
        }
    }
}
