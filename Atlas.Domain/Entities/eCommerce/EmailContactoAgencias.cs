using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class EmailContactoAgencias
    {
        public int IdContacto { get; set; }
        public string RazonSocial { get; set; }
        public string NombreFantasia { get; set; }
        public string Cnpj { get; set; }
        public string IncripcionEstatal { get; set; }
        public string NumeroFuncionarios { get; set; }
        public string Cep { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Barrio { get; set; }
        public string Telefono { get; set; }
        public string Banco { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string Fax { get; set; }
        public string Agencia { get; set; }
        public string Cuenta { get; set; }
        public string NombreCompleto { get; set; }
        public string Cpf { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Cargo { get; set; }
        public string Departamento { get; set; }
        public string Email { get; set; }
        public string ConfEmail { get; set; }
        public string RecibirInfoEmail { get; set; }
        public string RecibirInfoCelular { get; set; }
    }
}
