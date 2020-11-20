using Atlas.Application.Common.Interfaces;
using Atlas.Application.Common.Utils;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Auth.UpdatePassword
{
    public class UpdatePasswordCommand : IRequest
    {
        private string _username { get; set; }
        public String Username
        {
            get
            {
                return this._username.ToUpper();
            }

            set
            {
                this._username = value;
            }
        }
        public string Password { get; set; }
        public string NewPassword { get; set; }
    }

    public class UpdatePasswordCommandHandler : IRequestHandler<UpdatePasswordCommand>
    {
        private readonly IAtlasDbContext _context;

        public UpdatePasswordCommandHandler(IAtlasDbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(UpdatePasswordCommand request, CancellationToken cancellationToken)
        {
            var user = await _context.Usuarios.FindAsync(request.Username);

            user.Password = Hash.hashPassword(request.NewPassword);

              await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
