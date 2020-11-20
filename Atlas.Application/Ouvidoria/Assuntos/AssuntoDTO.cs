using Atlas.Application.Common.Mappings;
using Atlas.Domain.Entities.Atlas.Ouvidoria;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atlas.Application.Ouvidoria.Assuntos
{
    public class AssuntoDTO : IMapFrom<Assunto>
    {
        public int? Id { get; set; }
        public int IdAssunto { get; set; }
        public string Descricao { get; set; }
    }
}
