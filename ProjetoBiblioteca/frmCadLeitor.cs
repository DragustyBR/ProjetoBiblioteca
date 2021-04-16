using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBiblioteca
{
    public partial class frmCadLeitor : Form
    {
        bool tirarFoto = true;


        public frmCadLeitor()
        {
            InitializeComponent();
            ConectaWebcam.pcbFoto = pcbWebcam;
        }

        public void LocalizarCEP()
        {
            using (var ws = new WSCEP.AtendeClienteClient())
            {
                try
                {
                    var resultado = ws.consultaCEP(mskCEP.Text);
                    cmbEstado.Text = resultado.uf;
                    cmbCidade.Text = resultado.cidade;
                    txtRua.Text = resultado.end;
                    txtBairro.Text = resultado.bairro;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro:" + ex.Message);
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mskCEP_Leave(object sender, EventArgs e)
        {
            LocalizarCEP();
        }

        private void frmCadLeitor_Load(object sender, EventArgs e)
        {
            mskDataCadastro.Text = DateTime.Now.ToShortDateString();
        }

        private void btnWebcam_Click(object sender, EventArgs e)
        {
            try
            {
                if (tirarFoto)
                {
                    btnWebcam.Text = "Tirar foto";
                    tirarFoto = false;
                    // Procurar webcam
                    ConectaWebcam.ProcurarDispositivo();
                    //Ligar webcam
                    ConectaWebcam.VerificaWebCamLigada();
                }
                else
                {
                    btnWebcam.Text = "Ligar Webcam";
                    tirarFoto = true;
                    //Código para tirar a foto
                    ConectaWebcam.TiraFotoSalvaBanco();

                    //ConectaWebcam.VerificaWebCamLigada();
                }
            }
            catch (Exception ex )
            {

                MessageBox.Show("Erro: " + ex.Message);
            }

        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtNome, "Preencha o campo nome");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtNome, "");
            }
            if (mskCelular.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(mskCelular, "Preencha o campo nome");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(mskCelular, "");
            }
            if (mskCEP.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(mskCEP, "Preencha o campo nome");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(mskCEP, "");
            }
            if (cmbEstado.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(cmbEstado, "Preencha o campo nome");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(cmbEstado, "");
            }
            if (cmbCidade.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(cmbCidade, "Preencha o campo nome");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(cmbCidade, "");
            }
            if (txtRua.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtRua, "Preencha o campo nome");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtRua, "");
            }
            if (txtNumero.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtNumero, "Preencha o campo nome");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtNumero, "");
            }
            if (txtBairro.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtBairro, "Preencha o campo nome");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtBairro, "");
            }
            try
            {
                Conexao.Conectar();
                string sql = @"INSERT INTO LEITORES VALUES (@nome, @email,
            @telefone, @celular, @profissao, @cep, @estado, @cidade, @rua,
            @numero, @complemento, @bairro, @foto, @data)";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("nome", txtNome.Text);
                cmd.Parameters.AddWithValue("email", txtEmail.Text);
                cmd.Parameters.AddWithValue("telefone", mskResidencial.Text);
                cmd.Parameters.AddWithValue("celular", mskCelular.Text);
                cmd.Parameters.AddWithValue("profissao", txtProfissao.Text);
                cmd.Parameters.AddWithValue("cep", mskCEP.Text);
                cmd.Parameters.AddWithValue("estado", cmbEstado.Text);
                cmd.Parameters.AddWithValue("cidade", cmbCidade.Text);
                cmd.Parameters.AddWithValue("rua", txtRua.Text);
                cmd.Parameters.AddWithValue("numero", txtNumero.Text);
                cmd.Parameters.AddWithValue("complemento", txtComplemento.Text);
                cmd.Parameters.AddWithValue("bairro", txtBairro.Text);
                //Adicionar imagem NULL ao banco de dados
                SqlParameter fotoParam = new SqlParameter("foto", SqlDbType.Image);
                if (ConectaWebcam.imagem != null)
                {
                    fotoParam.Value = ConectaWebcam.imagem;
                }
                else
                {
                    fotoParam.Value = DBNull.Value;
                }
                cmd.Parameters.Add(fotoParam);
                cmd.Parameters.AddWithValue("data", mskDataCadastro.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Leitor cadastrado!");
                Util.LimparCampos(this);
                txtNome.Focus();

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

            Leitores.codigo = "";
            frmPesquisaLeitor pesq = new frmPesquisaLeitor();
            pesq.ShowDialog();
            if (Leitores.codigo !="")
            {
                txtNome.Text = Leitores.nome;
                txtEmail.Text = Leitores.email;
                mskResidencial.Text = Leitores.telefone;
                mskCelular.Text = Leitores.celular;
                txtProfissao.Text = Leitores.profissao;
                mskCEP.Text = Leitores.cep;
                cmbEstado.Text = Leitores.estado;
                cmbCidade.Text = Leitores.cidade;
                txtRua.Text = Leitores.rua;
                txtNumero.Text = Leitores.numero;
                txtComplemento.Text = Leitores.complemento;
                txtBairro.Text = Leitores.complemento;
                if (Leitores.foto != null)
                { 
                MemoryStream ms = new MemoryStream(Leitores.foto);
                Image img = Image.FromStream(ms);
                pcbWebcam.Image = img;
                }
                else
                {
                    pcbWebcam.Image = Properties.Resources.loki;
                }



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
                string sql = @"DELETE FROM LEITORES
                        WHERE CODIGO = @codigo";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("codigo", Leitores.codigo);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Leitor excluído com sucesso!");
                Util.LimparCampos(this);
                mskDataCadastro.Text = DateTime.Now.ToShortDateString();
                txtNome.Focus();

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
            if (txtNome.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtNome, "Preencha o campo nome");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtNome, "");
            }
            if (mskCelular.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(mskCelular, "Preencha o campo nome");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(mskCelular, "");
            }
            if (mskCEP.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(mskCEP, "Preencha o campo nome");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(mskCEP, "");
            }
            if (cmbEstado.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(cmbEstado, "Preencha o campo nome");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(cmbEstado, "");
            }
            if (cmbCidade.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(cmbCidade, "Preencha o campo nome");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(cmbCidade, "");
            }
            if (txtRua.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtRua, "Preencha o campo nome");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtRua, "");
            }
            if (txtNumero.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtNumero, "Preencha o campo nome");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtNumero, "");
            }
            if (txtBairro.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtBairro, "Preencha o campo nome");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtBairro, "");
            }
            try
            {
                Conexao.Conectar();
                string sql = @"UPDATE LEITORES SET NOME = @NOME,
                        EMAIL = @EMAIL, TELEFONE = @TELEFONE, CELULAR = @CELULAR,
                        PROFISSAO = @PROFISSAO, CEP = @CEP, ESTADO = @ESTADO,
                        CIDADE = @CIDADE, RUA = @RUA, NUMERO = @NUMERO, COMPLEMENTO = @COMPLEMENTO,
                        BAIRRO = @BAIRRO, FOTO = @FOTO WHERE CODIGO = @CODIGO";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                
                cmd.Parameters.AddWithValue("nome", txtNome.Text);
                cmd.Parameters.AddWithValue("email", txtEmail.Text);
                cmd.Parameters.AddWithValue("telefone", mskResidencial.Text);
                cmd.Parameters.AddWithValue("celular", mskCelular.Text);
                cmd.Parameters.AddWithValue("profissao", txtProfissao.Text);
                cmd.Parameters.AddWithValue("cep", mskCEP.Text);
                cmd.Parameters.AddWithValue("estado", cmbEstado.Text);
                cmd.Parameters.AddWithValue("cidade", cmbCidade.Text);
                cmd.Parameters.AddWithValue("rua", txtRua.Text);
                cmd.Parameters.AddWithValue("numero", txtNumero.Text);
                cmd.Parameters.AddWithValue("complemento", txtComplemento.Text);
                cmd.Parameters.AddWithValue("bairro", txtBairro.Text);
                //Adicionar imagem NULL ao banco de dados
                SqlParameter fotoParam = new SqlParameter("foto", SqlDbType.Image);
                if (ConectaWebcam.imagem != null)
                {
                    fotoParam.Value = ConectaWebcam.imagem;
                }
                else
                {
                    fotoParam.Value = DBNull.Value;
                }
                cmd.Parameters.Add(fotoParam);
                cmd.Parameters.AddWithValue("CODIGO", Leitores.codigo);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Alterado com sucesso!");
                Util.LimparCampos(this);
                txtNome.Focus();

                mskDataCadastro.Text = DateTime.Now.ToShortDateString();
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
    }
}
