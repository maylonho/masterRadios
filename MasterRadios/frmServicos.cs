﻿using System;
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
            
            DateTime dtinicial = new DateTime(ano, mes, dia);
            DateTime dtfinal = new DateTime(2021, 12, 01);


            lblDataInicial.Text = dtinicial.ToString();
            lblDataFinal.Text = dtfinal.ToString();

            lblDataRestante.Text = DateTime.Compare(dtfinal, dtinicial).ToString();

            lblDataHoje.Text = DateTime.Now.ToString("D");
            dgv_Servicos.DataSource = classBanco.ObterServicos();
            dgv_Servicos.Columns[0].Visible = false;
            dgv_Servicos.Columns[0].Width = 30;
            dgv_Servicos.Columns[1].Width = 110;
            dgv_Servicos.Columns[2].Width = 80;
            dgv_Servicos.Columns[3].Width = 90;
            dgv_Servicos.Columns[4].Width = 330;
            dgv_Servicos.Columns[5].Width = 430;

            int qtditens = dgv_Servicos.Rows.Count;
            lblContItens.Text = qtditens.ToString();

            if(qtditens >= 200)
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
    }
}
