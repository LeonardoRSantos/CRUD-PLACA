using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Usuarios
{
    
    public class Pessoas
    {
        
        private Usuarios.Conexao db;
        private MySqlConnection con;

        public Pessoas()
        {

        }
        public void InserirDados(Int32 id_usuario, String nome_usuario, string placa, string endereco, string telefone, string login, string senha)
        {
            con = new MySqlConnection();
            db = new Usuarios.Conexao();
            con.ConnectionString = db.getConnectionString();
            String query = "INSERT INTO usuario (id_usuario, nome_usuario, placa, endereco, telefone, login, senha) VALUES";
            query += "(?id_usuario, ?nome_usuario, ?placa, ?endereco, ?telefone, ?login, ?senha)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?id_usuario", id_usuario);
                cmd.Parameters.AddWithValue("?nome_usuario", nome_usuario);
                cmd.Parameters.AddWithValue("?placa", placa);
                cmd.Parameters.AddWithValue("?endereco", endereco);
                cmd.Parameters.AddWithValue("?telefone", telefone);
                cmd.Parameters.AddWithValue("?login", login);
                cmd.Parameters.AddWithValue("?senha", senha);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }

        }
        public void AtualizarDados(Int32 id_usuario, String nome_usuario, string placa, string endereco, string telefone, string login)
        {
            con = new MySqlConnection();
            db = new Usuarios.Conexao();
            con.ConnectionString = db.getConnectionString();
            String query = "UPDATE usuario SET  nome_usuario = ?nome_usuario, placa= ?placa,  endereco = ?endereco, telefone = ?telefone, login = ?login";
            query += " WHERE id_usuario = ?id_usuario ";
            //"UPDATE clientes SET saldo = " + novoSaldo + "WHERE IDcli = " + id;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?id_usuario", id_usuario);
                cmd.Parameters.AddWithValue("?nome_usuario", nome_usuario);
                cmd.Parameters.AddWithValue("?placa", placa);
                cmd.Parameters.AddWithValue("?endereco", endereco);
                cmd.Parameters.AddWithValue("?telefone", telefone);
                cmd.Parameters.AddWithValue("?login", login);                
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }


        }
        public void RemoverDados(Int32 id_usuario)
        {
            con = new MySqlConnection();
            db = new Usuarios.Conexao();
            con.ConnectionString = db.getConnectionString();
            String query = "DELETE FROM usuario ";
            query += "WHERE id_usuario = ?id_usuario";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);                
                cmd.Parameters.AddWithValue("?id_usuario", id_usuario);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        

        

    }
}