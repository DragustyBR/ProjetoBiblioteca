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
    public partial class frmPesquisaLivros : Form
    {
        public frmPesquisaLivros()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DataGridViewRow linha;
            linha = dgvLivros.CurrentRow;

            Livros.codigo = linha.Cells["CODIGO"].Value.ToString();
            Livros.tombo = linha.Cells["TOMBO"].Value.ToString();
            Livros.titulo = linha.Cells["TITULO"].Value.ToString();
            Livros.autor = linha.Cells["AUTOR"].Value.ToString();
            Livros.data_cadastro = linha.Cells["DATA_CADASTRO"].Value.ToString();
            Livros.editora = linha.Cells["EDITORA"].Value.ToString();
            Livros.exemplar = linha.Cells["EXEMPLAR"].Value.ToString();
            Livros.ano_lancamento = linha.Cells["ANO_LANCAMENTO"].Value.ToString();
            Livros.cod_barras = linha.Cells["COD_BARRAS"].Value.ToString();

            Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtLivro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();

                string sql = @"SELECT * FROM LIVROS
                    WHERE TOMBO LIKE '" + txtLivros.Text + "%'";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvLivros.DataSource = dt;
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

        private void dgvLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
