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
    public partial class frmServicos : Form
    {
        public frmServicos()
        {
            InitializeComponent();
        }

        private void frmServicos_Load(object sender, EventArgs e)
        {
            dgv_Servicos.DataSource = classBanco.ObterServicos();
            dgv_Servicos.Columns[0].Width = 90;
            dgv_Servicos.Columns[1].Width = 80;
            dgv_Servicos.Columns[2].Width = 90;
            dgv_Servicos.Columns[3].Width = 330;
            dgv_Servicos.Columns[4].Width = 430;

            int qtditens = dgv_Servicos.Rows.Count;
            lblContItens.Text = qtditens.ToString();

            if(qtditens >= 100)
            {
                MessageBox.Show("Sua Licença expirou, procure o desenvolovedor para obter a licença\nCopyrigth 2021 - Maylon");
                txtDefeito.Enabled = false;
                txtNumeroSerie.Enabled = false;
                txtSolucao.Enabled = false;
                cbModelo.Enabled = false;
                btnCadastrar.Enabled = false;
                btnLimpar.Enabled = false;
                btnPesquisar.Enabled = false;
                lblLicenca.Visible = true;
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumeroSerie.Clear();
            txtDefeito.Clear();
            txtSolucao.Clear();
            cbModelo.Text = "";
            txtNumeroSerie.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            classServicos cs = new classServicos();

            cs.numSerie = txtNumeroSerie.Text.ToUpper();
            cs.modeloRadio = cbModelo.Text;
            cs.solucao = txtSolucao.Text;
            cs.defeito = txtDefeito.Text;

            classBanco.CadastrarServico(cs);
            dgv_Servicos.DataSource = classBanco.ObterServicos();
  
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgv_Servicos.DataSource = classBanco.ObterServicosNumeroSerie(txtNumeroSerie.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void txtNumeroSerie_TextChanged(object sender, EventArgs e)
        {
            dgv_Servicos.DataSource = classBanco.ObterServicosNumeroSerie(txtNumeroSerie.Text);
            int qtditens = dgv_Servicos.Rows.Count;
            lblContItens.Text = qtditens.ToString();
        }
    }
}
