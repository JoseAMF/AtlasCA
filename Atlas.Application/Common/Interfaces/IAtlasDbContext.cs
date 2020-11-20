using Atlas.Domain.Entities.Atlas;
using Atlas.Domain.Entities.Atlas.LGPD;
using Atlas.Domain.Entities.Atlas.Ouvidoria;
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
        DbSet<Assunto> Ouvidoria_Assuntos { get; set; }
        DbSet<CanalReclamacao> Ouvidoria_CanaisReclamacoes { get; set; }
        DbSet<CanalVenda> Ouvidoria_CanaisVenda { get; set; }
        DbSet<Motivo> Ouvidoria_Motivos { get; set; }
        DbSet<Status> Ouvidoria_Status { get; set; }
        DbSet<LGPDExterno> LGPDExternos { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
