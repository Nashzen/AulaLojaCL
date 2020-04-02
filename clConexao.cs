using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LojaCL
{
    class clConexao
    {
        //Conectar ao SQL express, pela string de conexão
        private static string str = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\leo-s\\Desktop\\LojaCL\\DbLoja.mdf;Integrated Security = True;MultipleActiveResultSets=True; Connect Timeout = 30";
        //Representa a conexão com o banco
        private static SqlConnection con = null;
        //Método que obtém a conexão com o banco
        public static SqlConnection obterConexao()
        {
            con = new SqlConnection(str);
            //verificar conexão
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            try
            {
                con.Open();
            }
            catch (SqlException sqle)
            {
                con = null;
            }
            return con;
        }
        public static void fecharConexao()
        {
            //Se não receber conexão nula, ele fecha a conexão
            if (con != null)
            {
                con.Close();
            }
        }
    }
}
