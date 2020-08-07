using Atlas.Application.Common.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.Motivos.Commands.CreateMotivo
{
    public class CreateMotivoCommandValidation : AbstractValidator<CreateMotivoCommand>
    {
        private readonly IAtlasDbContext context;

        public CreateMotivoCommandValidation(IAtlasDbContext context)
        {
            this.context = context;

            RuleFor(m => m.Motivo)
                .NotNull();

            RuleFor(m => m.Motivo.Descricao)
                .NotEmpty();

        }
    }
}
