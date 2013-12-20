using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using ENTIDADES;

namespace DADOS
{
    public class SetorD
    {
        public static List<SetorE> getAllSetores()
        {
            List<SetorE> setores = new List<SetorE>();
            
            SqlConnection conn = new SqlConnection("SERVER=localhost; INTEGRATED SECURITY = TRUE; INITIAL CATALOG=SCA");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT codigo, setor FROM tb_setor";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int codigo = (int)reader[0];
                string setor = reader[1].ToString();
                setores.Add(new SetorE(codigo,setor));
            }
            if(!reader.IsClosed)
                reader.Close();
            conn.Close();

            return setores;
        }

        public static SetorE getSetorByCodigo(int codigo)
        {
            SetorE esetor = null;

            SqlConnection conn = new SqlConnection("SERVER=localhost; INTEGRATED SECURITY = TRUE; INITIAL CATALOG=SCA");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT codigo, setor FROM tb_setor where codigo = "+codigo;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string setor = reader[1].ToString();
                esetor = new SetorE(codigo, setor);
            }
            if (!reader.IsClosed)
                reader.Close();
            conn.Close();

            return esetor;
        }

        public static void addSetor(string setor)
        {
            SqlConnection conn = new SqlConnection("SERVER=localhost; INTEGRATED SECURITY = TRUE; INITIAL CATALOG=SCA");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into tb_setor (setor) values ('"+setor+"')";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void updateSetor(int codigo, string setor)
        {
            SqlConnection conn = new SqlConnection("SERVER=localhost; INTEGRATED SECURITY = TRUE; INITIAL CATALOG=SCA");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update tb_setor set setor = '" + setor + "' where codigo = "+codigo;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void deleteSetor(int codigo)
        {
            SqlConnection conn = new SqlConnection("SERVER=localhost; INTEGRATED SECURITY = TRUE; INITIAL CATALOG=SCA");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from tb_setor where codigo = " + codigo;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
