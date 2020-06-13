using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.Atlas;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Auth.Login
{
    public class LoginCommand : IRequest<string>
    {
        public string Username { get; set; }
        public string Password { get; set; }

    }

    public class LoginCommandHandler : IRequestHandler<LoginCommand, string>
    {
        private readonly IAtlasDbContext _context;
        private readonly IConfiguration _config;
        public LoginCommandHandler(IAtlasDbContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }
        public async Task<string> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            return GenerateJsonWebToken(await _context.Usuarios.FindAsync(request.Username.ToUpper()));
        }

        private string GenerateJsonWebToken(User userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            List<Claim> claims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Sub, userInfo.Username),
                new Claim(JwtRegisteredClaimNames.Email, userInfo.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            foreach (var permission in _context.UsuariosPermissoes.Where(x => x.UserUsername == userInfo.Username))
            {
                claims.Add(new Claim(ClaimTypes.Role, permission.PermissionId.ToString()));
            }

            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Issuer"],
                claims,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credentials);

            var encodeToken = new JwtSecurityTokenHandler().WriteToken(token);
            return encodeToken;
        }
    }
}
