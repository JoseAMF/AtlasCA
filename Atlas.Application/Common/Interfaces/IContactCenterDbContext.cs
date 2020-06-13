using Atlas.Domain.Entities.ContactCenter;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atlas.Application.Common.Interfaces
{
    interface IContactCenterDbContext
    {
        DbSet<VwOuvidoria> VwOuvidoria { get; set; }

    }
}
