using ClientesApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientesApp.Controllers
{
    class Conexao{
        public static SqlConnection con = new SqlConnection("Data Source=LAPTOP-JSMSE3VB;Initial Catalog=master;Integrated Security=True");
    }
}
