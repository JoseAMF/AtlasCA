using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class BsNotificacion
    {
        public int IdNotificacion { get; set; }
        public string NomeDoDisparo { get; set; }
        public bool? Diario { get; set; }
        public int? DiaDoSemana { get; set; }
        public int? DiaDoMes { get; set; }
        public TimeSpan? HorarioDeEnvio { get; set; }
        public string Mensagem { get; set; }
        public string UrldoEmail { get; set; }
        public int? ModuleId { get; set; }
        public string ListaDeDestino { get; set; }
        public string TipoNotificacion { get; set; }
        public string Codigo { get; set; }
    }
}
