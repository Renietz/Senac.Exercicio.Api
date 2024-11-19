using Microsoft.AspNetCore.Mvc;
using Senac.Exercicio.Domain.DTO;
using Senac.Exercicio.Domain.Entities;
using Senac.Exercicio.Service;

namespace Senac.Exercicio.Api.Controllers


{
    [ApiController]

    [Route("[controller]")]
    public class EnderecooController

    {
        [HttpPost]
        public bool Gravar(EnderecoInputModel model)
            => new EnderecoService().Armazenar(model);


        [HttpGet, Route("logradouro, numero")]
        public List<EnderecoEntity> ObterEndereco(string logradouro, string numero)
        => new EnderecoService().ObterEndereco(logradouro, numero);

        [HttpPut]
        public bool EditarEndereco(BuscarEnderecoInputModel p)
            => new EnderecoService().EditarEndereco(p);
        [HttpDelete]
        public bool ExcluirEndereco(int id)
           => new EnderecoService().ExcluirEndereco(id);



    }
}
