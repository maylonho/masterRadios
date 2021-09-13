
namespace MasterRadios
{
    partial class frmServicos_Edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServicos_Edit));
            this.cbModelo_edit = new System.Windows.Forms.ComboBox();
            this.txtSolucao_edit = new System.Windows.Forms.TextBox();
            this.txtDefeito_edit = new System.Windows.Forms.TextBox();
            this.txtNumeroSerie_edit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar_edit = new System.Windows.Forms.Button();
            this.btnExcluir_edit = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbModelo_edit
            // 
            this.cbModelo_edit.FormattingEnabled = true;
            this.cbModelo_edit.Items.AddRange(new object[] {
            "EP450",
            "DEP450",
            "PRO5150",
            "DGP4150",
            "DGP5050",
            "DGP8050",
            "DGP8050e",
            "DGP8050ex"});
            this.cbModelo_edit.Location = new System.Drawing.Point(106, 32);
            this.cbModelo_edit.Name = "cbModelo_edit";
            this.cbModelo_edit.Size = new System.Drawing.Size(195, 21);
            this.cbModelo_edit.TabIndex = 10;
            // 
            // txtSolucao_edit
            // 
            this.txtSolucao_edit.Location = new System.Drawing.Point(64, 87);
            this.txtSolucao_edit.Name = "txtSolucao_edit";
            this.txtSolucao_edit.Size = new System.Drawing.Size(237, 20);
            this.txtSolucao_edit.TabIndex = 12;
            // 
            // txtDefeito_edit
            // 
            this.txtDefeito_edit.Location = new System.Drawing.Point(59, 58);
            this.txtDefeito_edit.Name = "txtDefeito_edit";
            this.txtDefeito_edit.Size = new System.Drawing.Size(242, 20);
            this.txtDefeito_edit.TabIndex = 9;
            // 
            // txtNumeroSerie_edit
            // 
            this.txtNumeroSerie_edit.Location = new System.Drawing.Point(104, 6);
            this.txtNumeroSerie_edit.Name = "txtNumeroSerie_edit";
            this.txtNumeroSerie_edit.Size = new System.Drawing.Size(197, 20);
            this.txtNumeroSerie_edit.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Solução";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Defeito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Modelo do Rádio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Número de Série";
            // 
            // btnSalvar_edit
            // 
            this.btnSalvar_edit.Location = new System.Drawing.Point(226, 127);
            this.btnSalvar_edit.Name = "btnSalvar_edit";
            this.btnSalvar_edit.Size = new System.Drawing.Size(75, 45);
            this.btnSalvar_edit.TabIndex = 16;
            this.btnSalvar_edit.Text = "Salvar";
            this.btnSalvar_edit.UseVisualStyleBackColor = true;
            this.btnSalvar_edit.Click += new System.EventHandler(this.btnSalvar_edit_Click);
            // 
            // btnExcluir_edit
            // 
            this.btnExcluir_edit.Location = new System.Drawing.Point(145, 127);
            this.btnExcluir_edit.Name = "btnExcluir_edit";
            this.btnExcluir_edit.Size = new System.Drawing.Size(75, 45);
            this.btnExcluir_edit.TabIndex = 17;
            this.btnExcluir_edit.Text = "Excluir";
            this.btnExcluir_edit.UseVisualStyleBackColor = true;
            this.btnExcluir_edit.Click += new System.EventHandler(this.btnExcluir_edit_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(40, 143);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 20);
            this.lblId.TabIndex = 18;
            this.lblId.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "ID:";
            // 
            // frmServicos_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 184);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnExcluir_edit);
            this.Controls.Add(this.btnSalvar_edit);
            this.Controls.Add(this.cbModelo_edit);
            this.Controls.Add(this.txtSolucao_edit);
            this.Controls.Add(this.txtDefeito_edit);
            this.Controls.Add(this.txtNumeroSerie_edit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmServicos_Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmServicos_Edit_FormClosed);
            this.Load += new System.EventHandler(this.frmServicos_Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtNumeroSerie_edit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvar_edit;
        private System.Windows.Forms.Button btnExcluir_edit;
        public System.Windows.Forms.ComboBox cbModelo_edit;
        public System.Windows.Forms.TextBox txtSolucao_edit;
        public System.Windows.Forms.TextBox txtDefeito_edit;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label6;
    }
}