using Atlas.Application.Common.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atlas.Application.Ouvidoria.CanaisVenda.Commands.CreateCanalVenda
{
    public class CreateCanalVendaCommandValidation : AbstractValidator<CreateCanalVendaCommand>
    {
        public CreateCanalVendaCommandValidation()
        {
            RuleFor(cv => cv.CanalVenda)
                .NotEmpty();
            RuleFor(cv => cv.CanalVenda.Descricao)
                .NotEmpty();
        }
    }
}
