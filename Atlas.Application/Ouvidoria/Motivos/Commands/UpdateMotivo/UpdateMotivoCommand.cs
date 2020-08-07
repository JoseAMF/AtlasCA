using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.Atlas.Ouvidoria;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.Motivos.Commands.UpdateMotivo
{
    public class UpdateMotivoCommand : IRequest
    {
        public UpdateMotivoCommand(int id, MotivoDTO motivo)
        {
            Motivo = motivo;
        }
        public MotivoDTO Motivo { get; }
    }

    public class UpdateMotivoCommandHandler : IRequestHandler<UpdateMotivoCommand>
    {
        private readonly IAtlasDbContext context;
        private readonly IMapper mapper;

        public UpdateMotivoCommandHandler(IAtlasDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateMotivoCommand request, CancellationToken cancellationToken)
        {
            context.Ouvidoria_Motivos.Update(mapper.Map<Motivo>(request.Motivo));

            await context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
