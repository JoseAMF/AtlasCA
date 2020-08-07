using Atlas.Application.Common.Mappings;
using Atlas.Domain.Entities.Atlas.Ouvidoria;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atlas.Application.Ouvidoria.Assuntos.Commands.CanaisReclamacao
{
    public class CanalReclamacaoDTO : IMapFrom<CanalReclamacao>
    {
        public int IdCanalReclamacao { get; set; }
        public string Descricao { get; set; }
    }
}
