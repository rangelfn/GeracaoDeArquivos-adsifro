
namespace Informação_de_dados_para_geração_de_arquivos
{
    partial class frmDadosGeraçãoArquivos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNrFuncionarios = new System.Windows.Forms.Label();
            this.txtNrFuncionarios = new System.Windows.Forms.TextBox();
            this.btnCriarLinhasRegistro = new System.Windows.Forms.Button();
            this.btnCriarArquivo = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.sfdGravarArquivo = new System.Windows.Forms.SaveFileDialog();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNrFuncionarios
            // 
            this.lblNrFuncionarios.AutoSize = true;
            this.lblNrFuncionarios.Location = new System.Drawing.Point(1, 9);
            this.lblNrFuncionarios.Name = "lblNrFuncionarios";
            this.lblNrFuncionarios.Size = new System.Drawing.Size(102, 13);
            this.lblNrFuncionarios.TabIndex = 0;
            this.lblNrFuncionarios.Text = "Nr. de Funcionários:";
            // 
            // txtNrFuncionarios
            // 
            this.txtNrFuncionarios.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNrFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNrFuncionarios.Location = new System.Drawing.Point(100, 7);
            this.txtNrFuncionarios.Name = "txtNrFuncionarios";
            this.txtNrFuncionarios.Size = new System.Drawing.Size(56, 20);
            this.txtNrFuncionarios.TabIndex = 1;
            // 
            // btnCriarLinhasRegistro
            // 
            this.btnCriarLinhasRegistro.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCriarLinhasRegistro.Location = new System.Drawing.Point(162, 4);
            this.btnCriarLinhasRegistro.Name = "btnCriarLinhasRegistro";
            this.btnCriarLinhasRegistro.Size = new System.Drawing.Size(160, 23);
            this.btnCriarLinhasRegistro.TabIndex = 2;
            this.btnCriarLinhasRegistro.Text = "Criar linhas para registro";
            this.btnCriarLinhasRegistro.UseVisualStyleBackColor = false;
            this.btnCriarLinhasRegistro.Click += new System.EventHandler(this.btnCriarLinhasRegistro_Click);
            // 
            // btnCriarArquivo
            // 
            this.btnCriarArquivo.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCriarArquivo.Enabled = false;
            this.btnCriarArquivo.Location = new System.Drawing.Point(4, 250);
            this.btnCriarArquivo.Name = "btnCriarArquivo";
            this.btnCriarArquivo.Size = new System.Drawing.Size(196, 23);
            this.btnCriarArquivo.TabIndex = 4;
            this.btnCriarArquivo.Text = "Criar arquivo";
            this.btnCriarArquivo.UseVisualStyleBackColor = false;
            this.btnCriarArquivo.Click += new System.EventHandler(this.btnCriarArquivo_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnReiniciar.Enabled = false;
            this.btnReiniciar.Location = new System.Drawing.Point(206, 250);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(116, 23);
            this.btnReiniciar.TabIndex = 5;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // sfdGravarArquivo
            // 
            this.sfdGravarArquivo.DefaultExt = "*.txt";
            this.sfdGravarArquivo.Filter = "Arquivos textos|*.txt";
            this.sfdGravarArquivo.Title = "Dados para geração de arquivo";
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(4, 33);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.Size = new System.Drawing.Size(312, 211);
            this.dgvFuncionarios.TabIndex = 6;
            // 
            // frmDadosGeraçãoArquivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(328, 277);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnCriarArquivo);
            this.Controls.Add(this.btnCriarLinhasRegistro);
            this.Controls.Add(this.txtNrFuncionarios);
            this.Controls.Add(this.lblNrFuncionarios);
            this.Name = "frmDadosGeraçãoArquivos";
            this.Text = "Dados para geração de arquivos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNrFuncionarios;
        private System.Windows.Forms.TextBox txtNrFuncionarios;
        private System.Windows.Forms.Button btnCriarLinhasRegistro;
        private System.Windows.Forms.Button btnCriarArquivo;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.SaveFileDialog sfdGravarArquivo;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
    }
}

