using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
namespace MasterRadios
{
    class classBanco
    {
        public static string caminho = System.Environment.CurrentDirectory;
        public static string nomeBanco = "banco_master.db";
        public static string caminhoBanco = caminho + @"\banco\";

        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source=" + caminhoBanco + nomeBanco);
            //conexao = new SQLiteConnection("Data Source=C:\\Users\\maste\\Desktop\\masterRadios\\MasterRadios\\banco\\banco_master.db");
            conexao.Open(); 
            
            return conexao;

        }

        

        public static DataTable ObterServicos(string sql_query)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql_query;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static void CadastrarServico(classServicos cs)
        {
            var dtAtual = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            try
            {
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "INSERT INTO servicos (D_data_servico, S_modelo, S_numero_serie, S_defeito, S_solucao) VALUES (@data_servico, @modelo, @numero_serie, @defeito, @solucao)";
                cmd.Parameters.AddWithValue("@data_servico", dtAtual);
                cmd.Parameters.AddWithValue("@modelo", cs.modeloRadio);
                cmd.Parameters.AddWithValue("@numero_serie", cs.numSerie);
                cmd.Parameters.AddWithValue("@defeito", cs.defeito);
                cmd.Parameters.AddWithValue("@solucao", cs.solucao);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso!");
                ConexaoBanco().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("ERRO");
                ConexaoBanco().Close();
            }
        }

        public static DataTable consultaServicos(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static void DeletarServico(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "DELETE FROM servicos WHERE I_id_servico=" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
                MessageBox.Show("Exclusão bem sucedida!");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void AtualizarUsuario(classServicos u)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "UPDATE servicos SET S_modelo='" + u.modeloRadio + "', S_numero_serie='" + u.numSerie + "', S_defeito='" + u.defeito + "', S_solucao='" + u.solucao + "' WHERE I_id_servico=" + u.id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
                MessageBox.Show("Atualização concluida!");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
