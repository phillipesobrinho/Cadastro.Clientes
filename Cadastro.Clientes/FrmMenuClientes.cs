using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;
using static System.Windows.Forms.LinkLabel;

namespace Cadastro.Clientes
{
    public partial class FrmMenuClientes : Form
    {
        public FrmMenuClientes()
        {
            InitializeComponent();
        }

        string fotos = AppDomain.CurrentDomain.BaseDirectory + "/fotos/";



        private void button1_Click(object sender, EventArgs e)
        {
            FrmCardCliente frm = new FrmCardCliente();
            frm.ShowDialog();
        }

        private void btFicha_Click(object sender, EventArgs e)
        {

        }

        private void FrmMenuClientes_Load(object sender, EventArgs e)
        {
            BuscarClientes();
        }
        private void dgLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgLista_Sorted(object sender, EventArgs e)
        {
            ReorganizarDataGridView();
        }

        private void ReorganizarDataGridView()
        {
            foreach (DataGridViewRow lin in dgLista.Rows)
            {

                // vai passar em todas as colunas e a coluna q estiver cancelado fica em vermelho
                if (lin.Cells["situacao"].Value.ToString() == "Inativo")
                    lin.DefaultCellStyle.ForeColor = Color.Red;

                else if (lin.Cells["situacao"].Value.ToString() == "Ativo")
                    lin.DefaultCellStyle.ForeColor = Color.Black;

                //MessageBox.Show(lin.Cells["nome"].Value.ToString());  chamar linha por linha




                // Mudei o cod para mouseenter/mouse leave
                // se existir foto carrega se nao carrega a foto por default
                /*if (File.Exists(fotos + lin.Cells["id"].Value.ToString() + ".png"))
                {
                    lin.Cells["foto"].Value = Image.FromFile(fotos + lin.Cells["id"].Value.ToString() + ".png");
                }
                else
                {

                    lin.Cells["foto"].Value = Properties.Resources.avatar_2092113_640;*/
            }
            dgLista.ClearSelection();
            btEdit.Enabled = false;  // se nao selecionar fica fosco
        }




        private void dgLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btEdit.Enabled = true;  // se selecionar fica On
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            FrmCardCliente frm = new FrmCardCliente();

            //  trazer o formulario escolhido com tds as informacoes
            frm.Id.Text = dgLista.CurrentRow.Cells["id"].Value.ToString();

            frm.ShowDialog();

            BuscarClientes();
        }

        private void BuscarClientes()
        {


            dgLista.DataSource = Funcoes.BuscaSql("SELECT * FROM clientes WHERE 1 " + GerarCriterios());

            // limpar para que nao abre o form ja com uma linha selecionada

            ReorganizarDataGridView();

            //controlar pagina nao encontra
            if ((dgLista.RowCount * 30) + 50 > 690)
                dgLista.Height = 690;
            else
                dgLista.Height = (dgLista.RowCount * 30) + 50;

            Rodape();


            // aviso  nada encontrado e depois limpa
            if (dgLista.RowCount == 0)
                labelAviso.Visible = true;
            else
                labelAviso.Visible = false;

        }
        private void textCod_TextChanged(object sender, EventArgs e)
        {
            BuscarClientes();
        }

        private string GerarCriterios()

        {
            string c = "";
            if (textCod.Text != string.Empty)
            {

                c += "AND id = " + textCod.Text;
            }

            // pesq esta diferente de vazio
            if (PesqNome.Text != string.Empty)
            {
                // ele  e tb onde o campo nome concatena
                // buscar as informacoes no banco
                c += $" AND (nome LIKE '%{PesqNome.Text}%' OR documento LIKE '%{PesqNome.Text}%')";
            }

            if (PesqGenero.Text != string.Empty)
            {

                c += $" AND genero = '{PesqGenero.Text}'";
            }

            if (PestEstCivil.Text != string.Empty)
            {

                c += $" AND estado_civil = '{PestEstCivil.Text}'";
            }
            if (PesqEnderecos.Text != string.Empty)
            {
                string e = PesqEnderecos.Text;
                c += $" AND (cep LIKE '%{e}%' OR endereco LIKE '%{e}%' OR numero LIKE '%{e}%' OR bairro LIKE '%{e}%' OR cidade LIKE '%{e}%')";
            }

            if (PescAtivo.Checked == true)
            {
                c += "AND situacao = 'ATIVO' ";
            }
            else if (PescInativo.Checked == true)
            {
                c += "AND situacao = 'Inativo' ";

            }
            return c;

        }

        private void PesqNome_TextChanged(object sender, EventArgs e)
        {
            BuscarClientes();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PescTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (PescTodos.Checked == true)
            {
                BuscarClientes();
            }
        }

        private void PescAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (PescAtivo.Checked == true)
            {
                BuscarClientes();
            }
        }

        private void PescInativo_CheckedChanged(object sender, EventArgs e)

        {
            if (PescInativo.Checked == true)
            {
                BuscarClientes();
            }
        }
        private void Rodape()
        {
            LbTotalLocalizado.Text = "Total Localizado:" + dgLista.RowCount;
            //RowCount;  quantidade de linhas



            // usando contador
            int contador = 0;
            foreach (DataGridViewRow lin in dgLista.Rows)
            {
                if (lin.Cells["situacao"].Value.ToString() == "Inativo")
                    contador = contador + 1;
            }

            LbTotalInativo.Text = "Total Inativo:" + contador.ToString();
            LbTotalAtivo.Text = "Total Ativos:" + (dgLista.RowCount - contador).ToString();
        }



        private void LbTotalAtivo_Click(object sender, EventArgs e)
        {

        }

        private void dgLista_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            // evitar o erro quando se passa o mouse nas colunas fora da tabela por serem com valor -1
            if (e.RowIndex == -1)
                return;

            DataGridViewRow lin = dgLista.Rows[e.RowIndex];

            // MUDAR A COR QUANDO PASSAR O MOUSE POR CIMA
            lin.DefaultCellStyle.BackColor = Color.SkyBlue;

            if (File.Exists(fotos + lin.Cells["id"].Value.ToString() + ".png"))
            {
                //if (lin.Cells["situacao"].Value.ToString() == "Inativo")
                //  lin.DefaultCellStyle.ForeColor = Color.Red;



                using (FileStream temp = new FileStream(fotos + lin.Cells["id"].Value.ToString() + ".png", FileMode.Open, FileAccess.Read))
                // imagem fica na memoria do c# assim nao tem erro sempre a usar o filestream

                // MessageBox.Show(lin.Cells["nome"].Value.ToString()); // chamar linha por linha

                // se existir foto carrega se nao carrega a foto por default

                /*

                if (lin.Cells["fotoBD"].Value == DBNull.Value) //  FOTOBD VEM DO BANCO
                    lin.Cells["foto"].Value = Properties.Resources.avatar_2092113_640;
                else
                    lin.Cells["foto"].Value = lin.Cells["fotoBD"].Value;*/


                // carregar foto da pasta fisica

                //carregamento atravez do arquivo original  erro ao apagar a foto
                //lin.Cells["foto"].Value = Image.FromFile(fotos + lin.Cells["id"].Value.ToString() + ".png");
                {


                    Image img = Image.FromStream(temp);  // FROMSTREAM PARA FICAR NA MEMORIA DO C#
                    lin.Cells["foto"].Value = img;
                }
            }
            else
            {

                lin.Cells["foto"].Value = Properties.Resources.avatar_2092113_640;
            }
        }
            
        
        private void dgLista_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {//Voltar a cor normal quando se tira o mouse


            if (e.RowIndex == -1)
                return;

            dgLista.Rows[e.RowIndex].DefaultCellStyle.BackColor =
            (e.RowIndex % 2 == 0 ? Color.White : Color.AliceBlue);
            //  indice da linha com o resto da divisao por dois é par  ao contrario blue
            // if ternario



            dgLista.Rows[e.RowIndex].Cells["foto"].Value = null;
            // deixar a foto null quando tira o mouse
        }

        private void LbTotalInativo_Click(object sender, EventArgs e)
        {

        }

        private void labelAviso_MouseEnter(object sender, EventArgs e)
        {

        }

        private void PesqCod_Enter(object sender, EventArgs e)
        {

        }













        /*obs para saber a largura das colunas

         string texto = "";
          // foreach (var item in collection) ;
          foreach (DataGridViewColumn col in dgLista.Columns)
          {
              //ultimas linhas covertidas em uma linha

              texto = texto + "\r" + col.Name + ":" + col.Width.ToString();
              MessageBox.Show(texto);

              MessageBox.Show(col.Name);
              MessageBox.Show(col.Width.ToString());
               Width numero e show precisa de caracteres tem que converter .ToString */





    }
}