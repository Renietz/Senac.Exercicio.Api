using Microsoft.AspNetCore.Mvc;
using Senac.Exercicio.Domain.DTO;
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

       
            


    }
}
