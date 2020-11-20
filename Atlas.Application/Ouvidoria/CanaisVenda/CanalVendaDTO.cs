using Atlas.Application.Common.Mappings;
using Atlas.Domain.Entities.Atlas.Ouvidoria;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atlas.Application.Ouvidoria.CanaisVenda
{
    public class CanalVendaDTO : IMapFrom<CanalVenda>
    {
        public int? Id  { get; set; }
        public int IdCanalVenda  { get; set; }
        public string Descricao { get; set; }
    }
}
