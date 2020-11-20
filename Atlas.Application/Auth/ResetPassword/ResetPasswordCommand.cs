using Atlas.Application.Common.Interfaces;
using Atlas.Application.Common.Utils;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Auth.ResetPassword
{
    public class ResetPasswordCommand :IRequest
    {
        public ResetPasswordCommand(string username)
        {
            Username = username;
        }
        public string Username { get; set; }
    }

    public class ResetPasswordCommandHandler : IRequestHandler<ResetPasswordCommand>
    {
        private readonly IAtlasDbContext _context;

        public ResetPasswordCommandHandler(IAtlasDbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(ResetPasswordCommand request, CancellationToken cancellationToken)
        {
            var user = await _context.Usuarios.FindAsync(request.Username);

            user.Password = Hash.hashPassword("AtlasOmint");

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
