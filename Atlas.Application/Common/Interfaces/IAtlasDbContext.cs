using Atlas.Domain.Entities.Atlas;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Common.Interfaces
{
    public interface IAtlasDbContext
    {
        DbSet<User> Usuarios { get; set; }
        DbSet<Permission> Permissoes { get; set; }
        DbSet<UserPermission> UsuariosPermissoes { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
