using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.Atlas.Ouvidoria;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.Motivos.Commands.CreateMotivo
{
    public class CreateMotivoCommand : IRequest<int>
    {
        public CreateMotivoCommand(MotivoDTO motivo)
        {
            Motivo = motivo;
        }

        public MotivoDTO Motivo { get; }
    }

    public class CreateMotivoCommandHandler : IRequestHandler<CreateMotivoCommand, int>
    {
        private readonly IAtlasDbContext context;
        private readonly IMapper mapper;

        public CreateMotivoCommandHandler(IAtlasDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<int> Handle(CreateMotivoCommand request, CancellationToken cancellationToken)
        {
            context.Ouvidoria_Motivos.Add(mapper.Map<Motivo>(request.Motivo));

            return await context.SaveChangesAsync(cancellationToken);
        }
    }
}
