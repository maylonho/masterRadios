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
        frmServicos_Edit F_servicos_Edit;
        public int status = 0;
        public frmServicos()
        {
            InitializeComponent();
        }

        private void frmServicos_Load(object sender, EventArgs e)

        {

            
            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;
            
            System.DateTime dtinicial = new System.DateTime(ano, mes, dia);
            System.DateTime dtfinal = new System.DateTime(2022, 03, 01);
            System.TimeSpan date5 = dtfinal - dtinicial;

            int dateExpira = Int32.Parse(date5.Days.ToString());




            lblDataRestante.Text = dateExpira.ToString();

            lblDataHoje.Text = DateTime.Now.ToString("D");
            dgv_Servicos.DataSource = classBanco.ObterServicos();
            dgv_Servicos.Columns[0].Visible = false;
            dgv_Servicos.Columns[1].Width = (frmServicos.ActiveForm.Width / 100) * 10;
            dgv_Servicos.Columns[2].Width = (frmServicos.ActiveForm.Width / 100) * 6;
            dgv_Servicos.Columns[3].Width = (frmServicos.ActiveForm.Width / 100) * 10;
            dgv_Servicos.Columns[4].Width = (frmServicos.ActiveForm.Width / 100) * 35;
            dgv_Servicos.Columns[5].Width = (frmServicos.ActiveForm.Width / 100) * 50;

            int qtditens = dgv_Servicos.Rows.Count;
            lblContItens.Text = qtditens.ToString();

            if(qtditens >= 400 || dateExpira <= 0)
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
            txtNumeroSerie.Focus();
  
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

        private void dgv_Servicos_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;


            int id = Int32.Parse(dgv.SelectedRows[0].Cells[0].Value.ToString());
            string data = dgv.SelectedRows[0].Cells[1].Value.ToString();
            string modelo = dgv.SelectedRows[0].Cells[2].Value.ToString();
            string numSerie = dgv.SelectedRows[0].Cells[3].Value.ToString();
            string defeito = dgv.SelectedRows[0].Cells[4].Value.ToString();
            string solucao = dgv.SelectedRows[0].Cells[5].Value.ToString();





            frmServicos_Edit edit = new frmServicos_Edit(id, modelo, numSerie, defeito, solucao, this);
            edit.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnVer_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Servicos_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgv_Servicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            cbModelo.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
            txtDefeito.Text = dgv.SelectedRows[0].Cells[4].Value.ToString();
            txtSolucao.Text = dgv.SelectedRows[0].Cells[5].Value.ToString();
            
        }

        private void frmServicos_MaximizedBoundsChanged(object sender, EventArgs e)
        {
            
        }

        private void frmServicos_SizeChanged(object sender, EventArgs e)
        {
            Form currentForm = frmServicos.ActiveForm;

            if (currentForm != null)
            {
                //use currentForm properties
                dgv_Servicos.Width = frmServicos.ActiveForm.Width - 40;
                dgv_Servicos.Height = frmServicos.ActiveForm.Height - 200;
                dgv_Servicos.Columns[1].Width = (frmServicos.ActiveForm.Width / 100) * 10;
                dgv_Servicos.Columns[2].Width = (frmServicos.ActiveForm.Width / 100) * 6;
                dgv_Servicos.Columns[3].Width = (frmServicos.ActiveForm.Width / 100) * 10;
                dgv_Servicos.Columns[4].Width = (frmServicos.ActiveForm.Width / 100) * 35;
                dgv_Servicos.Columns[5].Width = (frmServicos.ActiveForm.Width / 100) * 50;

            }



        }
    }
}
