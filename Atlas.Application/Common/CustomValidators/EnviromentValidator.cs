using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Application.Common.CustomValidators
{
    public static class EnviromentValidator
    {
        public static string EnviromentInitialsValidationErrorMessage = "Ambiente inválido, use 'FT' para Flytour, 'OS' para regulados ou 'PA' para não regulados.";
        public static string VoucherNumberValidationErrorMessage = "Numero de bilhete inválido.";
        public static bool ValidateEnviromentInitials(string Initials)
        {
            if (Initials.Equals("FT") || Initials.Equals("OS") || Initials.Equals("PA")) return true;

            return false;
        }

        public static bool ValidateVoucherNumber(string NrVoucher)
        {
            foreach(var @char in NrVoucher)
            {
                if (!char.IsDigit(@char)) return false;
            }

            return true;
        }
    }
}
