
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;
using Google.Protobuf;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using ZstdSharp.Unsafe;

namespace Cadastro.Clientes
{
    public partial class FrmCardCliente : Form
    {
        public FrmCardCliente()
        {
            InitializeComponent();
        }

        string connectionString = "server=127.0.0.1;database=base_clientes;user=root;password=Asc25.23;";
        string fotos = AppDomain.CurrentDomain.BaseDirectory + "/fotos/";

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            Funcoes.TabelaMaiuscula(textBox8);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (ButtonRg.Checked == true)
                {

                    maskedTextBox1.Mask = "00,000,000-0";
                    maskedTextBox1.Focus();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            // essa primeira linha substitui as 3 de baixo que estao com  comentario( usando funcoes)
            Funcoes.CarregarComboBox(comboBoxEndereço, "Clientes", "endereco");



            Funcoes.CarregarComboBox(comboBoxBairro, "Clientes", "bairro");
            Funcoes.CarregarComboBox(comboBoxCidade, "Clientes", "cidade");

            if (Id.Text == "")
                return;

            btSalvar.Text = "Atualizar";

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                conexao.Open();

                using (MySqlCommand cmd = conexao.CreateCommand())
                {
                    cmd.CommandText = "SELECT id, nome, genero, rg, estado_civil, nascimento, cep, endereco, numero, bairro, cidade, celular, email, obs, situacao, documento FROM Clientes WHERE id = " + Id.Text;

                    DataTable dt = new DataTable();

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        try
                        {
                            da.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                textBox8.Text = dt.Rows[0]["nome"].ToString();
                                groupBoxMain.Text = dt.Rows[0]["genero"].ToString();
                                textBoxRg.Text = dt.Rows[0]["rg"].ToString();
                                comboBoxEstadoCivil.Text = dt.Rows[0]["estado_civil"].ToString();
                                maskedTextBoxNascimento.Text = dt.Rows[0]["nascimento"].ToString();
                                maskedTextBoxCep.Text = dt.Rows[0]["cep"].ToString();
                                comboBoxEndereço.Text = dt.Rows[0]["endereco"].ToString();
                                textBoxNumero.Text = dt.Rows[0]["numero"].ToString();
                                comboBoxBairro.Text = dt.Rows[0]["bairro"].ToString();
                                comboBoxCidade.Text = dt.Rows[0]["cidade"].ToString();
                                maskedTextBoxCelular.Text = dt.Rows[0]["celular"].ToString();
                                textBoxEmail.Text = dt.Rows[0]["email"].ToString();
                                textBoxObs.Text = dt.Rows[0]["obs"].ToString();

                                if (dt.Rows[0]["documento"].ToString().Length == 11)
                                {
                                    ButtonCpf.Checked = true;
                                }
                                else
                                {
                                    ButtonRg.Checked = true;
                                }

                                maskedTextBox1.Text = dt.Rows[0]["documento"].ToString();

                                switch (dt.Rows[0]["genero"].ToString())
                                {
                                    case "Masculino":
                                        radioButtonSexoM.Checked = true;
                                        break;
                                    case "Feminino":
                                        radioButtonSexoF.Checked = true;
                                        break;
                                    default:
                                        radioButtonOutros.Checked = true;
                                        break;
                                }

                                // Ajuste para o checkbox de situação
                                if (dt.Rows[0]["situacao"].ToString() == "Ativo")
                                {
                                    checkBoxSituacao.Checked = true;
                                }
                                else if (dt.Rows[0]["situacao"].ToString() == "Inativo")
                                {
                                    checkBoxSituacao.Checked = false;
                                }
                                else
                                {
                                    checkBoxSituacao.Checked = false;
                                }

                                // Carregar a foto do cliente
                                if (File.Exists(fotos + Id.Text + ".png"))
                                {
                                    pictureBox1.LoadAsync(fotos + Id.Text + ".png");
                                }
                                else
                                {
                                    pictureBox1.Image = Properties.Resources.avatar_2092113_640;
                                }
                            }
                            else
                            {
                                checkBoxSituacao.Checked = false;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao carregar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }


        private void FrmCardCliente_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());
            if (e.KeyCode == Keys.Enter)

            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;

            }
        }





        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {


        }


        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (Validacoes() == true)
                return;

            SalvarClienteMySQL();

        }

        private bool Validacoes()
        {
            // Validacoes


            //Validar campo nome
            if (textBox8.Text == "")
            {
                Funcoes.MsgErro("Campo nome é obrigatório");
                textBox8.Focus();
                return true;

            }

            //Validar se marcou CPF ou RG
            if (ButtonCpf.Checked == false && ButtonRg.Checked == false)
            {

                Funcoes.MsgAlerta("Marque o \r CPF OU RG ");
                return true;

            }

            //Validar campo Documento


            if (maskedTextBox1.Text == "")
            {
                if (ButtonCpf.Checked == true)
                    Funcoes.MsgErro("Digite o CPF");

                else
                    Funcoes.MsgErro("Digite o RG");
                maskedTextBox1.Focus();

                return true;

            }


            if (radioButtonSexoM.Checked == false && radioButtonSexoF.Checked == false && radioButtonOutros.Checked == false)
            {

                Funcoes.MsgAlerta("Selecione o genero");
                return true;
            }

            //Validar se data é valida
            if (maskedTextBoxNascimento.Text != "  /  /")
                try
                {
                    Convert.ToDateTime(maskedTextBoxNascimento.Text);
                }
                catch (Exception)
                {
                    Funcoes.MsgErro("Data de Nascimento Não é valida");



                    //cod sem a class funcoes 
                    //  Message.Show("Data de Nascimento Não é valida", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }



            return false;
        }



        private void SalvarClienteMySQL()

        {

            string connectionString = "server=127.0.0.1;database=base_clientes;user=root;password=Asc25.23;";

            using (MySqlConnection Conexao = new MySqlConnection(connectionString))
            {
                try
                {
                    Conexao.Open();

                    using (MySqlCommand cmd = Conexao.CreateCommand())
                    {
                        // Validacao se é um ID novo ou Atual
                        if (Id.Text == "")
                        {
                            cmd.CommandText = "INSERT INTO Clientes (nome, documento, genero, rg, estado_civil,nascimento, cep, endereco, numero, bairro, cidade, celular, email, obs, situacao) VALUES(@nome, @documento, @genero, @rg, @estado_civil, @nascimento, @cep, @endereco, @numero, @bairro, @cidade, @celular, @email, @obs, @situacao)";
                        }
                        else
                        {         // SET= DEFINIR
                                  // QUASE SEMPRE QUE ULTILIZAR UM UPDATE TEM QUE SE ULTLIZAR   WHERE id =
                            cmd.CommandText = "UPDATE Clientes SET nome = @nome, documento = @documento, genero = @genero, rg = @rg, estado_civil = @estado_civil, nascimento = @nascimento, cep =  @cep, endereco = @endereco, numero = @numero, bairro = @bairro, cidade = @cidade, celular = @celular, email = @email, obs = @obs, situacao = @situacao  WHERE id = " + Id.Text;
                            cmd.Parameters.AddWithValue("@id", Id.Text);
                        }


                        cmd.Parameters.AddWithValue("@nome", textBox8.Text);
                        cmd.Parameters.AddWithValue("@documento", maskedTextBox1.Text);

                        if (radioButtonSexoM.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@genero", "Masculino");
                        }
                        else if (radioButtonSexoF.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@genero", "Feminina");
                        }
                        else if (radioButtonOutros.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@genero", "Outros");
                        }

                        else
                        {
                            Funcoes.MsgAlerta("Por favor, selecione o gênero.");
                            return;
                        }

                        cmd.Parameters.AddWithValue("@rg", textBoxRg.Text);
                        cmd.Parameters.AddWithValue("@estado_civil", comboBoxEstadoCivil.Text);

                        if (maskedTextBoxNascimento.Text == "  /  /")
                            cmd.Parameters.AddWithValue("@nascimento", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@nascimento", Convert.ToDateTime(maskedTextBoxNascimento.Text));

                        cmd.Parameters.AddWithValue("@cep", maskedTextBoxCep.Text);
                        cmd.Parameters.AddWithValue("@endereco", comboBoxEndereço.Text);
                        cmd.Parameters.AddWithValue("@numero", textBoxNumero.Text);
                        cmd.Parameters.AddWithValue("@bairro", comboBoxBairro.Text);
                        cmd.Parameters.AddWithValue("@cidade", comboBoxCidade.Text);
                        cmd.Parameters.AddWithValue("@celular", maskedTextBoxCelular.Text);
                        cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
                        cmd.Parameters.AddWithValue("@obs", textBoxObs.Text);


                        cmd.Parameters.AddWithValue("@situacao", checkBoxSituacao.Checked ? "Ativo" : "Inativo");
                        cmd.ExecuteNonQuery();


                        // Comando relacionado ao ID

                        if (Id.Text == "")// == "" nao tem registro ainda
                                          // comanda a especificar o Id com objetivo de ver se já exsite ou nao
                        {
                            cmd.CommandText = "SELECT LAST_INSERT_ID()";
                            Id.Text = cmd.ExecuteScalar().ToString();
                        }
                    }

                    Funcoes.MsgOK("Dados inseridos com sucesso!");
                }
                catch (Exception ex)
                {
                    Funcoes.MsgErro("Erro ao acessar o banco de dados");
                }
            }


        }



        private void ButtonCpf_CheckedChanged(object sender, EventArgs e)
        {
            if (ButtonCpf.Checked == true)
            {
                maskedTextBox1.Mask = "000,000,000-00";
                maskedTextBox1.Focus();
            }
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            if (Funcoes.Pergunta("Deseja de fato Limpar todos os Campos?") == false)
                return;

            //cod antes de usar a funcao
            // if (MessageBox.Show("Deseja de fato Limpar todos os Campos?", "Cadastro", MessageBoxButtons.YesNo) == DialogResult.No)
            //   return;

            Id.Text = "";
            textBox8.Text = "";
            textBoxRg.Text = "";
            textBoxEmail.Text = "";
            textBoxNumero.Text = "";
            textBoxObs.Text = "";
            comboBoxEndereço.Text = "";
            comboBoxEstado.Text = "";
            comboBoxBairro.Text = "";
            comboBoxCidade.Text = "";
            comboBoxEstadoCivil.Text = "";
            maskedTextBoxNascimento.Text = "";



            // Limpando MaskedTextBoxes
            maskedTextBox1.Clear();
            maskedTextBoxNascimento.Clear();
            maskedTextBoxCep.Clear();
            maskedTextBoxCelular.Clear();


            // Limpando campos de rádio e checkbox
            ButtonCpf.Checked = false;
            ButtonRg.Checked = false;
            radioButtonOutros.Checked = false;
            radioButtonSexoM.Checked = false;
            radioButtonSexoF.Checked = false;
            checkBoxSituacao.Checked = false;



            // Resetando ComboBoxes
            comboBoxEstado.SelectedIndex = -1;
            comboBoxEstado.Text = "";

            comboBoxEndereço.SelectedIndex = -1;
            comboBoxEndereço.Text = "";

            comboBoxBairro.SelectedIndex = -1;
            comboBoxBairro.Text = "";

            comboBoxCidade.SelectedIndex = -1;
            comboBoxCidade.Text = "";

            comboBoxEstadoCivil.SelectedIndex = -1;
            comboBoxEstadoCivil.Text = "";


            // Se necessário, redefina também qualquer propriedade Enabled ou outros estados específicos
            comboBoxEstado.Enabled = true;
            comboBoxEstadoCivil.Enabled = true;
            textBoxEmail.Enabled = true;

            // update botao salvar

            btSalvar.Text = "Salvar";
            pictureBox1.Image = Properties.Resources.avatar_2092113_640;



        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButtonSexoF_CheckedChanged(object sender, EventArgs e)
        {
            textBoxRg.Focus();
        }

        private void groupBoxMain_Enter(object sender, EventArgs e)
        {

        }

        private void radioButtonOutros_CheckedChanged(object sender, EventArgs e)
        {
            {
                textBoxRg.Focus();
            }
        }

        private void maskedTextBoxNascimento_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // VOU CANCELAR SUA SAIDA
            //e.Cancel = true;
            if (maskedTextBoxNascimento.Text == "  / /")
                return;

            try
            {
                maskedTextBoxNascimento.Text = Convert.ToDateTime(maskedTextBoxNascimento.Text).ToString();

            }
            catch (Exception)
            {
                Funcoes.MsgErro("Saída Invalida");
                e.Cancel = true;
            }
        }
        // Validanting se escrever algo diferente da lista volta um erro
        private void comboBoxEstadoCivil_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (comboBoxEstadoCivil.Text == "")
                return;


            //  o item pertence a lista se não -1
            if (comboBoxEstadoCivil.SelectedIndex == -1)
            {
                Funcoes.MsgAlerta("Selecione um item na lista");
                e.Cancel = true;
            }
        }

        private void comboBoxEstado_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            {
                if (comboBoxEstado.Text == "")
                    return;


                //  o item pertence a lista se não -1
                if (comboBoxEstado.SelectedIndex == -1)
                {
                    Funcoes.MsgAlerta("Selecione um item na lista");
                    e.Cancel = true;
                }
            }
        }

        private void maskedTextBoxCep_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {    // VERIFICAR
             // MessageBox.Show(maskedTextBoxCep.Text.Length.ToString());

            if (maskedTextBoxCep.Text.Replace(" ", "").Length < 8)
            {
                Funcoes.MsgErro("Informação incompleta");
                e.Cancel = true;
                return;
            }

            labelAviso.Visible = true;  //  aparecer barra de loading
            Application.DoEvents();  //  atualizar a tela em tempo real

            comboBoxEndereço.Text = string.Empty;
            comboBoxBairro.Text = string.Empty;
            comboBoxCidade.Text = string.Empty;
            comboBoxEstado.Text = string.Empty;

            //  pegar o CEP pela internet
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string cep = maskedTextBoxCep.Text.Replace("-", "").Replace(" ", "");
                    HttpResponseMessage resposta = client.GetAsync($"https://viacep.com.br/ws/{cep}/json/").Result;
                    string conteudoResposta = resposta.Content.ReadAsStringAsync().Result;

                    dynamic json = JsonConvert.DeserializeObject(conteudoResposta);

                    if (json.erro == null)
                    {
                        comboBoxEndereço.Text = json.logradouro.ToString();
                        comboBoxBairro.Text = json.bairro.ToString();
                        comboBoxCidade.Text = json.localidade.ToString();
                        comboBoxEstado.Text = json.uf.ToString();

                        foreach (var item in comboBoxEstado.Items)
                        {
                            if (item.ToString().Contains($"({comboBoxEstado.Text})"))
                            {
                                comboBoxEstado.Text = item.ToString();
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cep não Localizado....");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Não foi possivel realizar a consulta\r Verifique sua conexão com a Internet.\nErro: {ex.Message}");
                }
                finally
                {
                    labelAviso.Visible = false;
                }
            }

        }
        private void textBoxRg_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (maskedTextBox1.Text == "")
                return;

            if (ButtonCpf.Checked == true && maskedTextBox1.Text.Replace(" ", " ").Length < 11)

            {
                Funcoes.MsgErro("Informação incompleta");
                e.Cancel = true;


            }

            if (ButtonRg.Checked == true && maskedTextBox1.Text.Replace(" ", " ").Length < 9)

            {
                Funcoes.MsgErro("Informação incompleta");
                e.Cancel = true;
            }
        }

        private void maskedTextBoxCelular_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (maskedTextBoxCelular.Text.Replace(" ", " ").Length < 0)
                return;
            if (maskedTextBoxCelular.Text.Replace(" ", "  ").Length != 11)
            {
                Funcoes.MsgErro("Informe os 11 digítos");
                e.Cancel = true;
            }

        }

        private void textBoxRg_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBoxRg.Text.Replace(" ", " ").Length < 0)
                return;
            if (textBoxRg.Text.Replace(" ", "  ").Length != 9)
            {
                Funcoes.MsgErro("Informe os 9 digítos");
                e.Cancel = true;
            }
        }

        private void maskedTextBoxCelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBoxEndereço_TextChanged(object sender, EventArgs e)
        {
            Funcoes.TabelaMaiuscula(comboBoxEndereço);
        }

        private void comboBoxBairro_TextChanged(object sender, EventArgs e)
        {
            Funcoes.TabelaMaiuscula(comboBoxBairro);
        }

        private void comboBoxCidade_TextChanged(object sender, EventArgs e)
        {
            Funcoes.TabelaMaiuscula(comboBoxCidade);
        }




        private void buttonphoto_Click(object sender, EventArgs e)
        {
            //  salvar os dados do cliente antes de salvar as fotos
            if (Id.Text == "")
            {
                Funcoes.MsgErro("Salve os Dados do cliente primeiro");
                return;
            }


            //  abre o wind para procurar fotos 
            OpenFileDialog caixa = new OpenFileDialog();

            {
                caixa.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp;*.gift";
            }

            if (caixa.ShowDialog() == DialogResult.OK)

            {
                //carregar foto na memoria do c# 
                using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(caixa.FileName)))


                //   pictureBox1.Image = Image.FromFile(caixa.FileName);  // o foto fica cm uma ponta em aberto

                // assim qunado vou excluir diz q esta em uso, preciso usar o LoadAsync
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }

                File.Copy(caixa.FileName, fotos + Id.Text + ".png", true);



                //adicionar foto ao banco de dados






                //linha que copia o arquivo fisico da foto
                // File.Copy(caixa.FileName, fotos + Id.Text + ".png");
                // Mostrar msg em um caixa de msg Funcoes.MsgOK(caixa.FileName);








                // salvar img no banco  diminuindo a img automaticamente para o tamanho da box
                /*uncoes.SalvarImagemPequena(caixa.FileName, AppDomain.CurrentDomain.BaseDirectory + "/fotosTemp.png", pictureBox1.Width, pictureBox1.Height, false);

                pictureBox1.LoadAsync(AppDomain.CurrentDomain.BaseDirectory + "/fotosTemp.png");
                imgByte = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory + "/fotosTemp.png");
                //readallbytes    faça uma leitua completa dos bytes*/





                /* using (MySqlConnection conexao = new MySqlConnection(connectionString))
                 {
                     conexao.Open();

                     using (MySqlCommand cmd = conexao.CreateCommand())
                     {
                         cmd.CommandText = "UPDATE Clientes SET foto = @foto WHERE id = @id";
                         //  sempre que usar UPDATE TEM QUE USAR WHERE 


                         cmd.Parameters.AddWithValue("@foto", imgByte);
                         cmd.Parameters.AddWithValue("@id", Id.Text); */


                btSalvar.Text = "Atualizar";

            }
        }


        private void buttonRemovePhoto_Click(object sender, EventArgs e)
        {
            if (Id.Text == "")
            {
                Funcoes.MsgErro("Não há foto para ser removida");
                return;

            }
            if (File.Exists(fotos + Id.Text + ".png") == false)

            {
                Funcoes.MsgErro("Não há foto para remover");
                return;

            }

            if (Funcoes.Pergunta("Deseja de fato remover essa foto?") == false)
                return;

            pictureBox1.Image = Properties.Resources.avatar_2092113_640;


            //  erro ao excluir a foto
            File.Delete(fotos + Id.Text + ".png");
        }

        private void comboBoxEndereço_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxSituacao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxRg(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (maskedRG.Text.Length != 9 || maskedRG.Text.Contains(" "))
            {
                Funcoes.MsgErro("Informe os 9 dígitos");
                e.Cancel = true;
            }
        }
    }
}
    



















