

namespace Senac.Exercicio.Domain.Entities
{
    public class EnderecoEntity
    {
      

        public int Id { get; private set; }
            public int IdPessoa { get; private set; }
            public string Logradouro { get; private set; }
            public string Numero { get; private set; }
            public string Complemento { get; private set; }
            public string Bairro { get; private set; }

        public  EnderecoEntity()
        { 
        }
        public EnderecoEntity(int id, int idPessoa, string logradouro, string numero, string complemento, string bairro)
        {
            Id = id;
            IdPessoa = idPessoa;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
        }
    }

    
}
