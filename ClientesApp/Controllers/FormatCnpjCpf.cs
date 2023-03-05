using ClientesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace ClientesApp.Controllers
{
    class Format
    {
        public static string FormatCPF(string sender)
        {
            string response = sender.Trim();
            if (response.Length == 11)
            {
                response = response.Insert(9, "-");
                response = response.Insert(6, ".");
                response = response.Insert(3, ".");
            }
            return response;
        }

        public static string FormatTelefone(string telefone)
        {
            return Regex.Replace(telefone, @"(\d{2})(\d{4})(\d{4})", "($1) $2-$3");
        }

        public static string SemFormatacao(string Codigo)
        {
            return Codigo.Replace(".", string.Empty).Replace("(", string.Empty).Replace(")", string.Empty).Replace("-", string.Empty).Replace("/", string.Empty);
        }
    }
}
