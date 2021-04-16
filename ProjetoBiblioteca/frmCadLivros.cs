using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBiblioteca
{
    public partial class frmCadLivros : Form
    {
        public frmCadLivros()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtTombo.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtTombo, "Preencha o campo");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtTombo, "");
            }
            if (mskDataCadastro.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(mskDataCadastro, "Preencha o campo");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(mskDataCadastro, "");
            }
            if (mskLancamento.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(mskLancamento, "Preencha o campo");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(mskLancamento, "");
            }
            if (txtTitulo.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtTitulo, "Preencha o campo");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtTitulo, "");
            }
            if (txtAutor.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtAutor, "Preencha o campo");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtAutor, "");
            }
            if (txtEditora.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtEditora, "Preencha o campo");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtEditora, "");
            }
            if (txtExemplar.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtExemplar, "Preencha o campo");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtExemplar, "");
            }
            if (txtCodigoBarras.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtCodigoBarras, "Preencha o campo");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtCodigoBarras, "");
            }
            try
            {
                Conexao.Conectar();
                string sql = @"INSERT INTO LIVROS VALUES (@tombo, @titulo,
            @autor, @data_cadastro, @editora, @exemplar, @ano_lancamento, @cod_barras)";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("tombo", txtTombo.Text);
                cmd.Parameters.AddWithValue("titulo", txtTitulo.Text);
                cmd.Parameters.AddWithValue("autor", txtAutor.Text);
                cmd.Parameters.AddWithValue("data_cadastro", mskDataCadastro.Text);
                cmd.Parameters.AddWithValue("editora", txtEditora.Text);
                cmd.Parameters.AddWithValue("exemplar", txtExemplar.Text);
                cmd.Parameters.AddWithValue("ano_lancamento", mskLancamento.Text);
                cmd.Parameters.AddWithValue("cod_barras", txtCodigoBarras.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Livro cadastrado!");
                Util.LimparCampos(this);
                txtTombo.Focus();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                Conexao.Desconectar();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Livros.codigo = "";
            frmPesquisaLivros pesq = new frmPesquisaLivros();
            pesq.ShowDialog();
            if (Livros.codigo != "")
            {
                txtTombo.Text = Livros.tombo;
                txtTitulo.Text = Livros.titulo;
                txtAutor.Text = Livros.autor;
                mskDataCadastro.Text = Livros.data_cadastro;
                txtEditora.Text = Livros.editora;
                txtExemplar.Text = Livros.exemplar;
                mskLancamento.Text = Livros.ano_lancamento;
                txtCodigoBarras.Text = Livros.cod_barras;

                //habilitar botoes
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                //Desabilitar botao cadastrar
                btnCadastrar.Enabled = false;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = @"DELETE FROM LIVROS
                        WHERE CODIGO = @codigo";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("codigo", Livros.codigo);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Livro excluído com sucesso!");
                Util.LimparCampos(this);
                txtTombo.Focus();

                btnCadastrar.Enabled = true;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                Conexao.Desconectar();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtTombo.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtTombo, "Preencha o campo");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtTombo, "");
            }
            if (mskDataCadastro.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(mskDataCadastro, "Preencha o campo");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(mskDataCadastro, "");
            }
            if (mskLancamento.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(mskLancamento, "Preencha o campo");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(mskLancamento, "");
            }
            if (txtTitulo.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtTitulo, "Preencha o campo");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtTitulo, "");
            }
            if (txtAutor.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtAutor, "Preencha o campo");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtAutor, "");
            }
            if (txtEditora.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtEditora, "Preencha o campo");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtEditora, "");
            }
            if (txtExemplar.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtExemplar, "Preencha o campo");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtExemplar, "");
            }
            if (txtCodigoBarras.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtCodigoBarras, "Preencha o campo");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtCodigoBarras, "");
            }
            try
            {
                Conexao.Conectar();
                string sql = @"UPDATE LIVROS SET TOMBO = @TOMBO,
                        TITULO = @TITULO, AUTOR = @AUTOR, DATA_CADASTRO = @DATA_CADASTRO,
                        EDITORA = @EDITORA, EXEMPLAR = @EXEMPLAR, 
                        ANO_LANCAMENTO = @ANO_LANCAMENTO, COD_BARRAS = @COD_BARRAS
                        WHERE CODIGO = @CODIGO";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("codigo", Livros.codigo);
                cmd.Parameters.AddWithValue("tombo", txtTombo.Text);
                cmd.Parameters.AddWithValue("titulo", txtTitulo.Text);
                cmd.Parameters.AddWithValue("autor", txtAutor.Text);
                cmd.Parameters.AddWithValue("data_cadastro", mskDataCadastro.Text);
                cmd.Parameters.AddWithValue("editora", txtEditora.Text);
                cmd.Parameters.AddWithValue("exemplar", txtExemplar.Text);
                cmd.Parameters.AddWithValue("ano_lancamento", mskLancamento.Text);
                cmd.Parameters.AddWithValue("cod_barras", txtCodigoBarras.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Livro cadastrado!");
                Util.LimparCampos(this);
                txtTombo.Focus();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                Conexao.Desconectar();
            }
        }
    }
}
