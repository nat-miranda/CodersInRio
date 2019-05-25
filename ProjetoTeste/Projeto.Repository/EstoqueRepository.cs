using Projeto.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Repository
{
    public class EstoqueRepository : Conexao
    {

        public void Inserir(Estoque estoque)
        {

            string query = "insert into Estoque(Nome) values(@Nome)";

            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@Nome", estoque.Nome);
            Command.ExecuteNonQuery(); //finaliza e executa
        }
        public void Atualizar(Estoque estoque)
        {

            string query = "update Estoque set Nome = @Nome "
            + " where IdEstoque = @IdEstoque";
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@IdEstoque", estoque.IdEstoque);
            Command.Parameters.AddWithValue("@Nome", estoque.Nome);
            Command.ExecuteNonQuery();
        }

        public void Excluir(int idEstoque)
        {
            string query = "delete from Estoque where IdEstoque = @IdEstoque";
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@IdEstoque", idEstoque);
            Command.ExecuteNonQuery();
        }
        //método para retornar todos os estoques cadastrados no banco
        public List<Estoque> ObterTodos()
        {
            string query = " select* from Estoque";
            Command = new SqlCommand(query, Connection);
            DataReader = Command.ExecuteReader();

            List <Estoque> lista = new List<Estoque> ();
            while (DataReader.Read())
            {
                Estoque estoque = new Estoque();
                estoque.IdEstoque = Convert.ToInt32(DataReader["IdEstoque"]);
                estoque.Nome = Convert.ToString(DataReader["Nome"]);
                lista.Add(estoque);
            }
            //retornando a lista
            return lista;
        }
        public Estoque ObterPorId(int idEstoque)
        {
            string query = "select* from Estoque where IdEstoque = @IdEstoque";
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@IdEstoque", idEstoque);
            DataReader = Command.ExecuteReader();
            Estoque estoque = null; 
            if (DataReader.Read())
            {
                estoque = new Estoque(); //instanciando
                estoque.IdEstoque = Convert.ToInt32(DataReader["IdEstoque"]);
                estoque.Nome = Convert.ToString(DataReader["Nome"]);
            }
            //retornando o objeto..
            return estoque;
        }
    }
}
