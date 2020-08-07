using Atlas.Application.Common.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atlas.Application.Ouvidoria.CanaisVenda.Commands.CreateCanalVenda
{
    public class CreateCanalVendaValidation : AbstractValidator<CreateCanalVenda>
    {
        public CreateCanalVendaValidation()
        {
            RuleFor(cv => cv.CanalVenda)
                .NotEmpty();
            RuleFor(cv => cv.CanalVenda.Descricao)
                .NotEmpty();
        }
    }
}
