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
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source=C:\\Users\\maste\\Desktop\\masterRadios\\MasterRadios\\banco\\banco_master.db");
            conexao.Open();
            return conexao;

        }

        public static DataTable ObterServicosNumeroSerie(string numSeriePesquisa)
        {
            
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT D_data_servico as 'Data', S_modelo as 'Modelo', S_numero_serie as 'Número de Série', S_defeito as 'Defeito', S_solucao as 'Solução' FROM servicos WHERE S_numero_serie LIKE '" + numSeriePesquisa+ "%' ORDER BY D_data_servico DESC";
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

        public static DataTable ObterServicos()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT D_data_servico as 'Data', S_modelo as 'Modelo', S_numero_serie as 'Número de Série', S_defeito as 'Defeito', S_solucao as 'Solução' FROM servicos ORDER BY D_data_servico DESC";
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
            var dtAtual = DateTime.Now.ToString("yyyy-MM-dd");
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
    }
}
