using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class MiCasosBup
    {
        public MiCasosBup()
        {
            MiCasosCursosBup = new HashSet<MiCasosCursosBup>();
        }

        public int IdCaso { get; set; }
        public int NroCaso { get; set; }
        public string NroCasoExterno { get; set; }
        public int? TipoDocumento { get; set; }
        public string NroDocumento { get; set; }
        public string NroSocio { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Edad { get; set; }
        public DateTime? FechaInicio { get; set; }
        public string HoraInicio { get; set; }
        public DateTime? FechaSalida { get; set; }
        public string EventosProximos { get; set; }
        public DateTime? FechaRetorno { get; set; }
        public DateTime? FechaFin { get; set; }
        public string Empresa { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Estado { get; set; }
        public string CreadoPor { get; set; }
        public DateTime? FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public string Observaciones { get; set; }
        public int? IdPais { get; set; }
        public DateTime? FecNac { get; set; }
        public int? IdEmpresa { get; set; }
        public int? IdCorresponsal { get; set; }
        public string NumeroVoucher { get; set; }
        public int? IdBeneficiario { get; set; }
        public string Ciudad { get; set; }

        public virtual ICollection<MiCasosCursosBup> MiCasosCursosBup { get; set; }
    }
}
