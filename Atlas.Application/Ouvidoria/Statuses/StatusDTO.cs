using Atlas.Application.Common.Mappings;
using Atlas.Domain.Entities.Atlas.Ouvidoria;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atlas.Application.Ouvidoria.Statuses
{
    public class StatusDTO : IMapFrom<Status>
    {
        public int Id{ get; set; }
        public int IdStatus { get; set; }
        public string Descricao { get; set; }
    }
}
