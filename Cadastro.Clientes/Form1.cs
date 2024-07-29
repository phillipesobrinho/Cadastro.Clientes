using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Cadastro.Clientes
{
    public partial class FrmCardCliente : Form
    {
        public FrmCardCliente()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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



        private void button6_Click(object sender, EventArgs e)
        {
            // Ajuste a string de conexão com as informações do seu banco de dados MySQL
            string connectionString = "server=127.0.0.1;database=base_clientes;user=root;password=Asc25.23;";

            using (MySqlConnection Conexao = new MySqlConnection(connectionString))
            {
                try
                {
                    Conexao.Open();

                    using (MySqlCommand cmd = Conexao.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO Clientes(nome, documento, genero, rg, estado_civil,nascimento, cep, endereco, numero, bairro, cidade, celular, email, obs, situacao) VALUES(@nome, @documento, @genero, @rg, @estado_civil, @nascimento, @cep, @endereco, @numero, @bairro, @cidade, @celular, @email, @obs, @situacao)";
                        cmd.Parameters.AddWithValue("@nome", BoxCliente.Text);
                        cmd.Parameters.AddWithValue("@documento", maskedTextBox1.Text);

                        cmd.Parameters.AddWithValue("@genero", "genero");


                        cmd.Parameters.AddWithValue("@rg", textBoxRg.Text);
                        cmd.Parameters.AddWithValue("@estado_civil", comboBoxEstadoCivil.Text);
                        cmd.Parameters.AddWithValue("@nascimento", maskedTextBoxNascimento.Text);
                        cmd.Parameters.AddWithValue("@cep", maskedTextBoxCep.Text);
                        cmd.Parameters.AddWithValue("@endereco", comboBoxEndereço.Text);
                        cmd.Parameters.AddWithValue("@numero", textBoxNumero.Text);
                        cmd.Parameters.AddWithValue("@bairro", comboBoxBairro.Text);
                        cmd.Parameters.AddWithValue("@cidade", comboBoxCidade.Text);
                        cmd.Parameters.AddWithValue("@celular", maskedTextBoxCelular.Text);
                        cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
                        cmd.Parameters.AddWithValue("@obs", textBoxObs.Text);
                        cmd.Parameters.AddWithValue("@situacao", checkBoxCadastro.Text);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Dados inseridos com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
                }
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
            if (BoxCliente.Text == "")
            {
                MessageBox.Show("Campo nome é obrigatório");
                BoxCliente.Focus();
                return true;

            }

            //Validar se marcou CPF ou RG
            if (ButtonCpf.Checked == false && ButtonRg.Checked == false)
            {

                MessageBox.Show("Marque o \r CPF OU RG ");
                return true;

            }

            //Validar campo Documento


            if (maskedTextBox1.Text == "")
            {
                if (ButtonCpf.Checked == true)
                    MessageBox.Show("Digite o CPF");

                else
                    MessageBox.Show("Digite o RG");
                maskedTextBox1.Focus();
                return true;

            }


            if (radioButtonSexoM.Checked == false && radioButtonSexoF.Checked == false && radioButtonOutros.Checked == false)
            {

                MessageBox.Show("Selecione o genero");
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
                        cmd.CommandText = "INSERT INTO Clientes(nome, documento, genero, rg, estado_civil,nascimento, cep, endereco, numero, bairro, cidade, celular, email, obs, situacao) VALUES(@nome, @documento, @genero, @rg, @estado_civil, @nascimento, @cep, @endereco, @numero, @bairro, @cidade, @celular, @email, @obs, @situacao)";
                        cmd.Parameters.AddWithValue("@nome", BoxCliente.Text);
                        cmd.Parameters.AddWithValue("@documento", maskedTextBox1.Text);
                        string genero = "";
                        if (radioButtonSexoM.Checked)
                        {
                            genero = "Masculino";
                        }
                        else if (radioButtonSexoF.Checked)
                        {
                            genero = "Feminino";
                        }
                        else
                        {
                            MessageBox.Show("Por favor, selecione o gênero.");
                            return; // Saia da função se o gênero não for selecionado
                        }
                        cmd.Parameters.AddWithValue("@rg", textBoxRg.Text);
                        cmd.Parameters.AddWithValue("@estado_civil", comboBoxEstadoCivil.Text);
                        DateTime dataNascimento;
                        if (DateTime.TryParse(maskedTextBoxNascimento.Text, out dataNascimento))
                        {
                            cmd.Parameters.AddWithValue("@nascimento", dataNascimento.ToString("yyyy-MM-dd"));
                        }
                        else
                        {
                            MessageBox.Show("Data de nascimento inválida.");
                            return; // Saia da função se a data for inválida
                        }
                        cmd.Parameters.AddWithValue("@cep", maskedTextBoxCep.Text);
                        cmd.Parameters.AddWithValue("@endereco", comboBoxEndereço.Text);
                        cmd.Parameters.AddWithValue("@numero", textBoxNumero.Text);
                        cmd.Parameters.AddWithValue("@bairro", comboBoxBairro.Text);
                        cmd.Parameters.AddWithValue("@cidade", comboBoxCidade.Text);
                        cmd.Parameters.AddWithValue("@celular", maskedTextBoxCelular.Text);
                        cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
                        cmd.Parameters.AddWithValue("@obs", textBoxObs.Text);
                        cmd.Parameters.AddWithValue("@situacao", checkBoxCadastro.Checked ? "ATIVO" : "Cancelado");


                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Dados inseridos com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
                }
            }

            
        }


    }
}



