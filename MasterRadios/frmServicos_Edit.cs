using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterRadios
{
    public partial class frmServicos_Edit : Form
    {
        frmServicos fp;
        public frmServicos_Edit(int id, string modelo, string numSerie, string defeito, string solucao, frmServicos f)
        {
            InitializeComponent();
            lblId.Text = id.ToString();
            cbModelo_edit.Text = modelo;
            txtNumeroSerie_edit.Text = numSerie;
            txtDefeito_edit.Text = defeito;
            txtSolucao_edit.Text = solucao;

            fp = f;
            
        }

        private void frmServicos_Edit_Load(object sender, EventArgs e)
        {


        }

        private void btnExcluir_edit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusão?", "Excluir", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                classBanco.DeletarServico(lblId.Text);
                string sql = "SELECT I_id_servico as 'ID', D_data_servico as 'Data', S_modelo as 'Modelo', S_numero_serie as 'Número de Série', S_defeito as 'Defeito', S_solucao as 'Solução' FROM servicos ORDER BY D_data_servico DESC LIMIT 100";
                fp.dgv_Servicos.DataSource = classBanco.ObterServicos(sql);
                Close();
            }

        }

        private void btnSalvar_edit_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Confirma as alterações?", "Alterações", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                classServicos u = new classServicos();
                u.id = Int32.Parse(lblId.Text);
                u.modeloRadio = cbModelo_edit.Text;
                u.numSerie = txtNumeroSerie_edit.Text;
                u.defeito = txtDefeito_edit.Text;
                u.solucao = txtSolucao_edit.Text;

                classBanco.AtualizarUsuario(u);
                string sql = "SELECT I_id_servico as 'ID', D_data_servico as 'Data', S_modelo as 'Modelo', S_numero_serie as 'Número de Série', S_defeito as 'Defeito', S_solucao as 'Solução' FROM servicos ORDER BY D_data_servico DESC LIMIT 100";
                fp.dgv_Servicos.DataSource = classBanco.ObterServicos(sql);
                Close();
            }



        }

        private void frmServicos_Edit_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
