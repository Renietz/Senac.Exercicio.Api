

using Senac.Exercicio.Domain.DTO;
using Senac.Exercicio.Domain.Entities;
using Senac.Exercicio.Infraestrutura.Repository;

namespace Senac.Exercicio.Service
{
    public class EnderecoService
    {
        public bool Armazenar(EnderecoInputModel endereco)
        {
            EnderecoEntity entity = new EnderecoEntity(0, endereco.IdPessoa, endereco.Logradouro, endereco.Numero, endereco.Complemento, endereco.Bairro);
            return new EnderecoRepository().Gravar(entity);
        }
                
        
    }

    public bool ExcluirEndereco(int id)
       => new EnderecoRepository().ExcluirEndereco(id);


    public bool EditarEndereco(BuscarEnderecoInputModel p)
    {
        //Recebendo o objeto de entrada e convertendo ele em um objeto para a persistência
        EnderecoEntity obj = new EnderecoEntity(p.Id, p.PessoaId, p.Logradouro, p.Numero, p.Complemento, p.Bairro);

        //Gambi de momento - chamando o repositório para salvar a pessoa no banco - rever
        return new EnderecoRepository().Editar(obj);
    }




    public List<EnderecoEntity> ObterEndereco(string logradouro, string numero)
    => new EnderecoRepository().ObterEndereco(logradouro, numero);
}


