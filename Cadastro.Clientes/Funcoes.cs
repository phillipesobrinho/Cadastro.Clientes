using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cadastro.Clientes
{
    class Funcoes
    {
        public static void MsgErro(string Msg)
        {
            MessageBox.Show(Msg, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public static void MsgAlerta(string Msg)
        {
            MessageBox.Show(Msg, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public static void MsgOK(string Msg)
        {
            MessageBox.Show(Msg, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public static bool Pergunta(string Msg)
        {
            if (MessageBox.Show(Msg, "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                return true;
            else

                return false;
        }



        private static bool _isUpdatingText = false;
        public static void TabelaMaiuscula(Control ctr)
        {
            if (_isUpdatingText) return;

            try
            {
                _isUpdatingText = true;

                // movimento do cursor e direção do cursor

                //textBox8.Text = textBox8.Text.ToUpper();
                // Primeira letra de cada palavra em Upper
                TextInfo textInfo = new CultureInfo("pt-BR", false).TextInfo;
                string t = ctr.Text;
                t = textInfo.ToTitleCase(t);

                t = t.Replace(" Das ", " das ")
                     .Replace(" Da ", " da ")
                     .Replace(" Dos ", " dos ")
                     .Replace(" Do ", " do ")
                     .Replace(" De ", " de ");


                ctr.Text = t;

                if (ctr is TextBox txt)
                {
                    txt.SelectionStart = txt.Text.Length;
                }
                else if (ctr is ComboBox cb)
                {
                    cb.SelectionStart = cb.Text.Length;
                }
            }
            finally
            {
                _isUpdatingText = false;
            }
        }
        public static DataTable BuscaSql(string ComandoSql)
        {

            DataTable dt = new DataTable();


            using (MySqlConnection conexao = new MySqlConnection("server=127.0.0.1;database=base_clientes;user=root;password=Asc25.23;"))

            {
                conexao.Open();

                using (MySqlCommand cmd = conexao.CreateCommand())
                {

                    cmd.CommandText = ComandoSql;


                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd)) // Essa classe que traz os dados do banco de dados
                    {
                        da.Fill(dt); // Preencher o DataTable


                    }

                }

            }

            return dt;
        }


        public static void CarregarComboBox(ComboBox cb, string tabela, string campo)
        {

            cb.DataSource = Funcoes.BuscaSql("SELECT DISTINCT " + campo + " FROM  " + tabela + " WHERE " + campo + " IS NOT NULL AND endereco <> '' ");
            cb.DisplayMember = "campo";
            cb.SelectedIndex = -1;

            //comboBoxCidade.DisplayMember = "cidade";
        }
        
        // função para salvar a imagem no banco mais primeiro na tabela

       /*
        public static void SalvarImagemPequena(String ArquivoOriginal, string NovaFoto, int Largura, int Altura, bool onlyResizefWider)
        {
            Image TamanhoImagem = Image.FromFile(ArquivoOriginal);

            TamanhoImagem.RotateFlip(RotateFlipType.Rotate180FlipNone);
            TamanhoImagem.RotateFlip(RotateFlipType.Rotate180FlipNone);

            if (onlyResizefWider)
            {
                if (TamanhoImagem.Width <= Largura)

                {
                    Largura = TamanhoImagem.Width;
                }
            }
            int newHeight = TamanhoImagem.Height * Largura / TamanhoImagem.Width;
            if (newHeight < Altura)
            {
                Largura = TamanhoImagem.Width * Altura / TamanhoImagem.Height;
                newHeight = Altura;
            }
            Image NovaImagem = TamanhoImagem.GetThumbnailImage(Largura, newHeight, null, IntPtr.Zero);

            TamanhoImagem.Dispose();

            NovaImagem.Save(NovaFoto);*/


        }
    }


            
          







