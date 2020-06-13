using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class MiCuestionarioQuality
    {
        public int IdCuestionario { get; set; }
        public int TiempoDeContacto { get; set; }
        public int TiempoDeRespuesta { get; set; }
        public int SeguimientoInstrucciones { get; set; }
        public int Frecuencia { get; set; }
        public int CalidadBrindada { get; set; }
        public int CapacidadSolucion { get; set; }
        public int CalidadProveedor { get; set; }
        public int CostosServicios { get; set; }
        public int Actitud { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string CreadoPor { get; set; }
        public int? Idcaso { get; set; }
    }
}
