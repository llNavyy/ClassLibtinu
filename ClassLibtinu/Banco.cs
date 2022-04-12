using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClassLibtinu
{
    public static class Banco
    {
        //Propriedade de conexão - String
        public static string StrConexao { get; set; }

        //Método abrir conexão
        public static MySqlCommand Abrir()
        {
            MySqlCommand cmd = new MySqlCommand();
            StrConexao = @"server=127.0.0.1;database=comercialdb0191;user id=root;password=;port=3306";
            MySqlConnection cn = new MySqlConnection(StrConexao);
            try
            {
                cn.Open();
            }
            catch (Exception)
            {
                throw;
            }

            
            cmd.Connection = cn;
            return cmd;
        }
    }
}