using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Atlas.Application.Common.Utils
{
    public static class Hash
    {
        public static string hashPassword(string password)
        {
            using (SHA256 sHA256Hash = SHA256.Create())
            {
                byte[] bytes = sHA256Hash.ComputeHash(Encoding.ASCII.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}
