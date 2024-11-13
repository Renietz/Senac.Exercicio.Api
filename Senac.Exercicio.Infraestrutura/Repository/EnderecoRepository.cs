

using Senac.Exercicio.Domain.Entities;
using Senac.Exercicio.Infraestrutura.Data;

namespace Senac.Exercicio.Infraestrutura.Repository
{
    public class EnderecoRepository
    {
        public bool Gravar(EnderecoEntity objeto)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(@"insert into Endereco(IdPessoa, Logradouro, Numero, Complemento, Bairro) Values (@idPessoa, @logradouro, @numero, @complemento, @bairro)",
                "@idPessoa", objeto.IdPessoa, "@logradouro", objeto.Logradouro, "@numero", objeto.Numero, "@complemento", objeto.Complemento, "@bairro", objeto.Bairro);
            }
        }

    }


}
