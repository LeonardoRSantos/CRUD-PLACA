using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios
{
    class Inserir
    {  
      
            private Int32 _id_usuario;
            private String _nome_usuario;
            private String _placa;
            private String _endereco;
            private String _telefone;
            private String _login;
            private String _senha;
            private Usuarios.Pessoas cdao;

            public Inserir()
            {

            }

            public Int32 id_usuario
            {
               get { return _id_usuario; } //ler id_usuario
               set { _id_usuario = value; }// e insere no id_usuario
            }
            public String nome_usuario
            {
                get { return _nome_usuario; } // ler o nome_usuario
                set { _nome_usuario = value; }// insere o nome usuario
            }
            public String placa
            {
                get { return _placa; }// ler a placa
                set { _placa = value; }// insere a placa
            }
            public String endereco
            {
                get { return _endereco; }// ler o endereco
                set { _endereco = value; }// insere o endereco
            }
            public String telefone
            {
            get { return _telefone; }// ler o telefone
            set { _telefone = value; }// insere o telefone
            }
            public String login
            {
            get { return _login; }// ler o login
            set { _login = value; }// insere o login
            }
            public String senha
            {
            get { return _senha; }// a senha
            set { _senha = value; }// insere a senha
            }

            public void Inserirdados()// criei o metodo inserir
            {
                cdao = new Usuarios.Pessoas(); // insanceiei a variavel cdao, para acessar os metodos de pessoas das conexao com o banco e poder inserir
                cdao.InserirDados(id_usuario,nome_usuario, placa, endereco, telefone, login,senha); // instancio a variavel e o metodo inserir, e coloco os objetos do get e set  para ler e inserir os campos no banco de dados.
            }
            public void Atualizar()// criei o metodo atualizar ou editar.
            {
                cdao = new Usuarios.Pessoas();// insanceiei a variavel cdao, para acessar os metodos de pessoas das conexao com o banco e poder atualizar ou editar.
                cdao.AtualizarDados(id_usuario,nome_usuario, placa, endereco, telefone, login);// instancio a variavel e o metodo atualizar, e coloco os objetos do get e set  para ler e inserir os campos no banco de dados.
            }
            public void Remover()// criei o metodo remover
            {
                
                cdao = new Usuarios.Pessoas();  // instanciei a variavel cdao, para acessar os metodos de pessoas das conexao com o banco e poder deletar
                cdao.RemoverDados(id_usuario);  // instancio a variavel e o metodo removerdados, e coloco os objetos do get e set  para remover
            }
          
        
    }
}
