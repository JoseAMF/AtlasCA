using Atlas.Application.Common.Mappings;
using Atlas.Domain.Entities.Atlas.Ouvidoria;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atlas.Application.Ouvidoria.Motivos
{
    public class MotivoDTO : IMapFrom<Motivo>
    {
        public int? Id { get; set; }
        public int IdMotivo { get; set; }
        public string Descricao { get; set; }
    }
}
