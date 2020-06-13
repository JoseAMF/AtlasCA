namespace Atlas.Domain.Entities.I4Pro
{
    public class QPViagemPrecoCoberturaBasicaImportacao
    {
        public string CodigoProduto { get; set; }
        public int Dias { get; set; }
        public int EdadDesde { get; set; }
        public int EdadHasta { get; set; }
        public string CodigoMoeda { get; set; }
        public string Importe { get; set; }
        public string CNPJ { get; set; }
    }
}