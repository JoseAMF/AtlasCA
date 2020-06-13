using Atlas.Application.Common.Interfaces;
using FluentValidation;
using System.Threading;
using System.Threading.Tasks;
using Atlas.Application.Common.Utils;

namespace Atlas.Application.Auth.UpdatePassword
{
    public class UpdatePasswordCommandValidation : AbstractValidator<UpdatePasswordCommand>
    {
        private readonly IAtlasDbContext _context;
        private readonly ICurrentUserService _currentUserService;
        public UpdatePasswordCommandValidation(IAtlasDbContext context, ICurrentUserService currentUserService)
        {
            _context = context;
            _currentUserService = currentUserService;

            RuleFor(u => u.Password)
                .NotEmpty()
                .MinimumLength(8);

            RuleFor(u => u)
                .MustAsync(Authorize).WithMessage("Operação não autorizada.");
        }

        private async Task<bool> Authorize(UpdatePasswordCommand update, CancellationToken cancellationToken)
        {
            if (update.Username != _currentUserService.Username) return false;

            var user = await _context.Usuarios.FindAsync(update.Username.ToUpper());
            if (user == null) return false;

            if (!user.Password.Equals(Hash.hashPassword(update.Password))) return false;
            return true;
        }
    }
}
