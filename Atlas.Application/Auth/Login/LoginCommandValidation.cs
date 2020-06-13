using Atlas.Application.Common.Interfaces;
using Atlas.Application.Common.Utils;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Auth.Login
{
    public class LoginCommandValidation : AbstractValidator<LoginCommand>
    {
       private readonly IAtlasDbContext _context;

        public LoginCommandValidation(IAtlasDbContext context)
        {
            _context = context;

            RuleFor(l => l.Username)
                .NotEmpty();

            RuleFor(l => l.Password)
                .NotEmpty();

            RuleFor(l => l)
                .MustAsync(ValidateUser).WithMessage("Usuário ou Senha incorretos.");
        }

        private async Task<bool> ValidateUser(LoginCommand login, CancellationToken cancellationToken)
        {
            var user = await _context.Usuarios.FindAsync(login.Username.ToUpper());
            if (user == null)
            {
                return false;
            }

            if (user.Password != Hash.hashPassword(login.Password))
            {
                return false;
            }

            return true;
        }
    }
}
