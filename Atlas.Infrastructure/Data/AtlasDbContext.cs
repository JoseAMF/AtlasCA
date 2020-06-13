using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Common;
using Atlas.Domain.Entities.Atlas;
using Atlas.Domain.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Infrastructure.Data
{
    public class AtlasDbContext : DbContext, IAtlasDbContext
    {
        private readonly ICurrentUserService _currentUserService;
        public AtlasDbContext(DbContextOptions<AtlasDbContext> options ,ICurrentUserService currentUserService ) : base(options)
        {
            _currentUserService = currentUserService;
        }
        public DbSet<User> Usuarios { get ; set ; }
        public DbSet<Permission> Permissoes { get ; set ; }
        public DbSet<UserPermission> UsuariosPermissoes { get; set; }


        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = _currentUserService.Username;
                        entry.Entity.Created = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedBy = _currentUserService.Username;
                        entry.Entity.LastModified = DateTime.Now;
                        break;
                }
            }


            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
