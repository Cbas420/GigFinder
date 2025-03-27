using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GigFinder.Entities
{
    public static class Encrypt
    {
        public static string EncryptSHA256(string text)
        {
            // Crear una instancia de SHA256
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convertir el texto a un arreglo de bytes
                byte[] bytes = Encoding.UTF8.GetBytes(text);

                // Obtener el hash
                byte[] hashBytes = sha256.ComputeHash(bytes);

                // Convertir el hash a una cadena hexadecimal
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }
    }
}
