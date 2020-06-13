using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class EmailContactoClientes
    {
        public int IdContaco { get; set; }
        public string NombreCompleto { get; set; }
        public string Email { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Sexo { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Celular { get; set; }
        public string Asunto { get; set; }
        public string RecibirInfoEmail { get; set; }
        public string RecibirInfoCelular { get; set; }
    }
}
