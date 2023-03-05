using System.Data.SqlClient;
using System.Data;
using System.Linq;
using ClientesApp.Controllers;
using ClientesApp.Models;
using System.Diagnostics;

namespace ClientesApp.Repository
{
    class ClienteRepository {

        private static SqlConnection con = Conexao.con;

        /*
         * Seleciona todos os registros da tabela
         */
        public static DataSet selectAll() {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from clientes", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "clientes");
            con.Close();
            return ds;
        }

        /*
         * Valida SQLInjection basico
         * Se cliente tem id faz update se não faz o insert
         * Recebe Cliente e retorna inteiro
         */
        public static int insert(Cliente cliente) {
            string[] array = new string[] { cliente.nome, cliente.email, cliente.cpf, cliente.telefone };
            if (Security.checkSQLInjectionArray(array) == true) return 0;
            int i = 0;
            SqlCommand cmd;
           
            con.Open();
            if (cliente.id == null) {
                cmd = new SqlCommand("insert into clientes(nome,email,CPF,telefone) values('" + cliente.nome + "','" + cliente.email + "','" + cliente.cpf + "','" + cliente.telefone + "')", con);
            } else {
                cmd = new SqlCommand("update clientes set nome='" + cliente.nome + "',email='" + cliente.email + "',CPF='" + cliente.cpf + "',telefone='" + cliente.telefone + "' where id='" + cliente.id + "' ", con);         
            }
            i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        /*
         * Deleta cliente
         * Recebe id e retorna inteiro
         */
        public static int deletar(int id) {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from clientes where id=" + id + "", con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        /*
         * Campo de Pesquisa
         * Pesquisa todos os campos
         */
        public static DataSet select(string text)
        {
            con.Open();
            string sql;
            string[] array = new string[] { text };
            Debug.WriteLine(Security.checkSQLInjectionArray(array));
            if (Security.checkSQLInjectionArray(array) == true) 
                sql = "select * from clientes";
             else if (IsNumeric(text))
                sql = "select DISTINCT * from  clientes where id='" + text + "' or nome like '%" + text + "%' or email like '%" + text + "%' or CPF like '%" + text + "%' or telefone like '%" + text + "%'";
            else
                sql = "select DISTINCT * from  clientes where nome like '%" + text + "%' or email like '%" + text + "%' or CPF like '%" + text + "%' or telefone like '%" + text + "%'";
            
            SqlDataAdapter da = new SqlDataAdapter(sql,con);
            DataSet ds = new DataSet();
            da.Fill(ds, "clientes");
            con.Close();
            return ds;
        }

        public static bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

    }
}
