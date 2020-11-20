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
    public class UpdateMotivoCommand : IRequest<int>
    {
        public UpdateMotivoCommand(MotivoDTO motivo)
        {
            Motivo = motivo;
        }
        public MotivoDTO Motivo { get; }
    }

    public class UpdateMotivoCommandHandler : IRequestHandler<UpdateMotivoCommand, int>
    {
        private readonly IAtlasDbContext context;
        private readonly IMapper mapper;

        public UpdateMotivoCommandHandler(IAtlasDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public async Task<int> Handle(UpdateMotivoCommand request, CancellationToken cancellationToken)
        {
            var motivo = await context.Ouvidoria_Motivos.FindAsync(request.Motivo.Id);

            mapper.Map<MotivoDTO, Motivo>(request.Motivo, motivo);

            return await context.SaveChangesAsync(cancellationToken);
        }
    }
}
