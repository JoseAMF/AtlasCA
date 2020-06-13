namespace Atlas.Domain.Entities.Atlas
{
        public enum Tabelas {
        Bilhete,
        Pessoa,
        DocumentoPessoa,
        DomicilioPessoa,
    }
    public class Table
    {
        public Tabelas Id { get; set; }

        public string Nome { get; set; }
    }
}