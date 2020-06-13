using Atlas.Application.Common.Interfaces;
using Atlas.Application.Common.Utils;
using Atlas.Domain.Entities.Atlas;
using MediatR;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Auth.Register
{
    public class RegisterUserCommand : IRequest<string>
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

    }

    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, string>
    {
        private readonly IAtlasDbContext _context;

        public RegisterUserCommandHandler(IAtlasDbContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var entity = new User
            {
                Username = request.Username.ToUpper(),
                Password =  Hash.hashPassword(request.Password),
                Email = request.Email,
                Ativo = 'A'
            };

            _context.Usuarios.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.Username;
        }

    }
}
