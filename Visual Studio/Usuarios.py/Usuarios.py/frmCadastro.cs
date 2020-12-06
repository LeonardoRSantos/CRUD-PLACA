using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using Usuarios.Py;
using Usuarios.Py.bancoDataSetTableAdapters;

namespace Usuarios
{

    public partial class frmCadastro : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id = root; database=banco;PWD=Leonardo19951985");

        private Usuarios.Conexao db; //instancio a classe de conexao, onde há a configuração para conexao com banco de dados
        private Usuarios.Inserir cruds; // instancio a classe inserir onde há os metodos de inserir,atualizar,remover,buscar
        private Int32 catchRowIndex; // crio uma variavel privado do tipo int de 32 bytes para datagird.

        public frmCadastro()
        {
            InitializeComponent();
        }

        private void carregaDados()
        {
            db = new Usuarios.Conexao(); //instancio o variavel db e crio uma nova conexao
            dgvDados.DataSource = null; //instancio o datagrid do meu form e instancio o datasource objeto e digo que quero limpar o datagird.
            dgvDados.Rows.Clear();  //instacio o datagrid e instancio um rows para percorrer as linhas e para limpar
            dgvDados.Refresh(); //e atualizo datagird
            
            string connectionString = db.getConnectionString();// crio uma string instanciando a connection de conexao, depois instancio o db que retorna o valor dessa coleção que está associado ao nome da cadeia de conexão.
            string query = "SELECT * FROM usuario"; // instancio uma string query especificando que quero fazer uma consulta no banco de dados.
            using (MySqlConnection conn = new MySqlConnection(connectionString)) // e uso using, um alias para para instanciar a classe de conexao do mysql, criando uma nova conexao e referenciando a string da classe conexão.
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn)) // e uso using, um alias para criar um objeto adapter da classe dataadapter, é um objeto que recupera dados da fonte de dados
                {
                    try// try catch tratamentos de erros.
                    {
                        DataTable dataTable = new DataTable(); //criei um DataTable para armazenar dados em memória e realizar operações para incluir, alterar e excluir
                        adapter.Fill(dataTable); // instancio a variavel adapter, e o objeto fill para atualizar linhas em intervalo especifico no Dataset
                        for (int i = 0; i < dataTable.Rows.Count; i++)// para int i começa com 0 até i ser menor que as linhas o datatable contando as linhas, i ++ 1 por 1
                        {
                            //instancio o datagrid, e obtenho as linhas do datagrid, adiciona elas a datagrid.
                            dgvDados.Rows.Add(Convert.ToInt32(dataTable.Rows[i][0]), dataTable.Rows[i][1], dataTable.Rows[i][2], dataTable.Rows[i][3], dataTable.Rows[i][4], dataTable.Rows[i][5], dataTable.Rows[i][4]).ToString();
                        }


                    }
                    catch (Exception ex) // se  algo der errado vai dar exception, e entrar nesse bloco
                    {
                        MessageBox.Show("Error" + ex);
                    }
                }
            } // end using
        }



        private void frmCadastro_Load(object sender, EventArgs e)
        {

            carregaDados();// instancio o metodo carregar dados no form.
        }

      

        private void tsbtnVoltar_Click(object sender, EventArgs e)
        {

            this.Close();// faço com o que o form assim que clicado em voltar, feche.

        }

        private void tsbtnEditar_Click(object sender, EventArgs e) // click botão editar.
        {
            catchRowIndex = dgvDados.SelectedCells[0].RowIndex; // isntancio a variavel rowindex, e instancio o datagrid, e ele vai obter a colecao de celulas que começa 0,Quando a RowIndex propriedade retorna-1, a célula é um cabeçalho de coluna ou a linha da célula é compartilhada.
            foreach (DataGridViewRow row in dgvDados.SelectedRows) // declarei um codigo foreach para percorrer linha por linha;
            {
                txtID.Text = row.Cells[0].Value.ToString(); // instanciei o txt do campo do form, dizendo que ele vai receber o valor da celula 0, com o objeto value ele vai obter o valor associado a essa celula,e  vai retornar em uma cadeia de caracters que representa o txt.
                txtNome.Text = row.Cells[1].Value.ToString();
                txtPlaca.Text = row.Cells[2].Value.ToString();
                txtEndereco.Text = row.Cells[3].Value.ToString();
                mtbTelefone.Text = row.Cells[4].Value.ToString();
                txtLogin.Text = row.Cells[5].Value.ToString();



            }
            tsbtnGravar.Enabled = false; //  o botão ficará desabilitado caso o usuario clique em editar.
        }



        private void tsbtnCancelar_Click(object sender, EventArgs e)
        {   // faço uma condição que ao clicar no botão cancela apereça uma mensagem, com um questionamento e se o resultado for sim.
            if (MessageBox.Show("Você tem certeza que deseja voltar e cancelar o cadastro?", "Mensagem do Sistema",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();    // a aplicação fechará
            }
        }

        private void tsbtnGravar_Click(object sender, EventArgs e)
        {
            try// try catch tratamentos de erros.
            {
                
                cruds = new Usuarios.Inserir(); // instancio a variavel cruds, e crio uma novo insercao a instanciar o inserir.
                cruds.id_usuario = Convert.ToInt32(txtID.Text); // instanciando o cruds para inserir o txtID  no campo id_usuario, convertendo string e int 32 bytes
                cruds.nome_usuario = txtNome.Text; //instanciando o cruds para inserir o txtnome no campo nome_usuario .
                cruds.placa = txtPlaca.Text; //instanciando o cruds para inserir o txtplaca  no campo placa.
                cruds.endereco = txtEndereco.Text; //instanciando o cruds para inserir o txtendereco no campo endereco.
                cruds.telefone = mtbTelefone.Text; //instanciando o cruds para inserir o masked text box telefone no campo telefone .
                cruds.login = txtLogin.Text;    //instanciando o cruds para inserir o txtlogin  no campo login.
                cruds.senha = txtSenha.Text;    //instanciando o cruds para inserir o txtsenha no campo senha .
                cruds.Inserirdados();           //instancio a variavel cruds, para instanciar o metodo inserirdados que está na class Pessoa.
                //instancio o datarid, obtendo todas as linhas datagrid, e adicionando uma nova linha a cada campo
                dgvDados.Rows.Add(txtID.Text, txtNome.Text, txtPlaca.Text, txtEndereco.Text, mtbTelefone.Text, txtLogin.Text, txtSenha.Text);
                txtID.Clear();//limpa o campo txtid
                txtNome.Clear();//limpa o campo txtnome
                txtPlaca.Clear();// limpa o campo txtplaca
                txtEndereco.Clear();// limpa o campo txtendereco
                mtbTelefone.Clear(); // limpa o campo mtbtelefone
                txtLogin.Clear();   //limpa o campo txtlogin
                txtSenha.Clear();   // limpa o campo txtsenha
            }
            catch (Exception)
            {
                // se  algo der errado vai dar exception, e entrar nesse bloco
                MessageBox.Show("Ocorreu um erro ao realizar a operação", "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbtnSair_Click(object sender, EventArgs e)
        {
            // faço uma condição que ao clicar no botão sair apereça uma mensagem, com um questionamento e se o resultado for sim.
            if (MessageBox.Show("Você tem certeza que deseja sair do sistema?", "Mensagem do Sistema",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();// a aplicação fechará
            }
        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            catchRowIndex = dgvDados.SelectedCells[0].RowIndex; // isntancio a variavel rowindex, e instancio o datagrid, e ele vai obter a colecao de celulas que começa 0,Quando a RowIndex propriedade retorna-1, a célula é um cabeçalho de coluna ou a linha da célula é compartilhada.
            foreach (DataGridViewRow row in dgvDados.SelectedRows)// declarei um codigo foreach para percorrer linha por linha;
            {
                txtID.Text = row.Cells[0].Value.ToString();// instanciei o txt do campo do form, dizendo que ele vai receber o valor da celula 0, com o objeto value ele vai obter o valor associado a essa celula,e  vai retornar em uma cadeia de caracters que representa o txt.
                txtNome.Text = row.Cells[1].Value.ToString();
                txtPlaca.Text = row.Cells[2].Value.ToString();
                txtEndereco.Text = row.Cells[3].Value.ToString();
                mtbTelefone.Text = row.Cells[4].Value.ToString();
                txtLogin.Text = row.Cells[5].Value.ToString();
                
                

            }

             tsbtnGravar.Enabled = false; //o botão ficará desabilitado caso o usuario clique no datagrid.

        }
       




        private void btnProcurar_Click(object sender, EventArgs e)
        {
            
            conn.Open(); // instancio variavel conn da classe mysqlconnection, para abrir a conexao;
            MySqlCommand cmd = conn.CreateCommand(); // crio uma variavel da classe mysqlcommand.
            cmd.CommandType = CommandType.Text; //instancia a variavel cmd  e adiquiri ou define um valor que indica como a propriedade CommandText deve ser interpretada.
            cmd.CommandText = "select * from usuario where placa like '" + txtProcurar.Text + "%'";
            
            cmd.ExecuteNonQuery(); //Executa uma instrução Transact-SQL na conexão e retorna o número de linhas afetadas.
            DataTable dt = new DataTable(); ////criei um DataTable para armazenar dados em memória e realizar operações para consultar.
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);// criar um objeto adapter da classe mysqldataadapter, é um objeto que recupera dados da fonte de dados
            da.Fill(dt); // Adiciona ou atualiza linhas no DataTable para corresponder àquelas na fonte de dados
            dgvDados.DataSource = dt; //instancio o datagrid do meu form e instancio o datasource objeto e digo que quero consultar dados.
            conn.Close();// fecho a conexao


        }

        private void tsbtnDeletar_Click(object sender, EventArgs e)
        {
            cruds = new Usuarios.Inserir();// instancio a variavel cruds, e crio uma novo insercao a instanciar o inserir.
            try
            {

                cruds.id_usuario = Convert.ToInt32(txtID.Text);// instanciando o cruds para excluir o txtID  no campo id_usuario, convertendo string e int 32 bytes
                cruds.Remover(); // instancio o cruds para ter aceeso ao metodo remover, e excluir registros.
                dgvDados.Rows.RemoveAt(catchRowIndex);
                txtID.Clear();//limpa o campo txtid
                txtNome.Clear();//limpa o campo txtnome
                txtPlaca.Clear();// limpa o campo txtplaca
                txtEndereco.Clear();// limpa o campo txtendereco
                mtbTelefone.Clear(); // limpa o campo mtbtelefone
                txtLogin.Clear();   //limpa o campo txtlogin
                txtSenha.Clear();   // limpa o campo txtsenha
                // exibe uma mensagem de registro excluido com sucesso.
                MessageBox.Show("Registro excluído com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                // caso der algo errado aparecera uma mensagem de erro
                MessageBox.Show("Ocorreu um erro ao realizar a operação", "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbtnAtualizar_Click(object sender, EventArgs e)// ao clicar atualizar, para atualizar os dados.
        {
            cruds = new Usuarios.Inserir();// instancio a variavel cruds, e crio uma novo insercao a instanciar o inserir.

            try
            {
                cruds.id_usuario = Convert.ToInt32(txtID.Text); //// instanciando o cruds para atualizar o txtID  no campo id_usuario, convertendo string e int 32 bytes
                cruds.nome_usuario = txtNome.Text;//instanciando o cruds para atualizar o txtnome no campo nome_usuario .
                cruds.placa = txtPlaca.Text; //instanciando o cruds para excluir o txtplaca  no campo placa.
                cruds.endereco = txtEndereco.Text;//instanciando o cruds para excluir o txtendereco  no campo endereco.
                cruds.telefone = mtbTelefone.Text;//instanciando o cruds para excluir o txttelefone  no campo telefone.
                cruds.login = txtLogin.Text;//instanciando o cruds para excluir o txtlogin  no campo login.
                cruds.Atualizar(); //instancio a variavel cruds, para instanciar o metodo atualizar, para alterar os dados.
                dgvDados[0, catchRowIndex].Value = txtID.Text; //instancio o datagrid,e instancio catchrowindex, e ele vai obter a colecao de celulas que começa 0,Quando a RowIndex propriedade retorna-1, a célula é um cabeçalho de coluna ou a linha da célula é compartilhada. Do txtID
                dgvDados[1, catchRowIndex].Value = txtNome.Text;//instancio o datagrid,e instancio catchrowindex, e ele vai obter a colecao de celulas que começa 1,Quando a RowIndex propriedade retorna-1, a célula é um cabeçalho de coluna ou a linha da célula é compartilhada. Do txtnome
                dgvDados[2, catchRowIndex].Value = txtPlaca.Text;
                dgvDados[3, catchRowIndex].Value = txtEndereco.Text;
                dgvDados[4, catchRowIndex].Value = mtbTelefone.Text;
                dgvDados[5, catchRowIndex].Value = txtLogin.Text;


                txtID.Clear();//limpa o campo txtid
                txtNome.Clear();//limpa o campo txtnome
                txtPlaca.Clear();// limpa o campo txtplaca
                txtEndereco.Clear();// limpa o campo txtendereco
                mtbTelefone.Clear(); // limpa o campo mtbtelefone
                txtLogin.Clear();   //limpa o campo txtlogin
                txtSenha.Clear();   // limpa o campo txtsenha
            }
            catch (Exception)
            {
                // caso der algo errado aparecera uma mensagem de erro
                MessageBox.Show("Ocorreu um erro ao realizar a operação", "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Apenas_texto(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNome.Text, @"^[a-zA-Z á]*$")) //parametro que só aceita letras.
            {
                //ao terminar de cadastrar ele limpa o campo txtnome
                txtNome.Clear();
            }
        }

        private void enter_tab(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

       

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            carregaDados();// instancio o metodo carregadados, para exibir todos os dados.
        }
    }


}   


