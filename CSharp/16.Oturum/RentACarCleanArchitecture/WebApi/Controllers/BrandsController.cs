using Application.Features.Brands.Commands.Create;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        IMediator _mediator;
        public BrandsController(IMediator mediator) 
        { 
            _mediator = mediator; 
        }
       
        [HttpPost]
        //Burada 'CreateBrandCommand' bir parametre bekler.
        //Bu parametreyi [FromBody] ifadesi ile, örneğin swagger üzerinde ekleme işlemi neticesinde bir json verisi oluşur ve veri Json tipinde buraya alınır ve bu json verisi CreateBrandCommand tipine çevrilerek parametremize aktarılır.
        //FromBody burada, Json verisini CreateBrandCommand tipine eşitler.
        public async Task<IActionResult> Add([FromBody] CreateBrandCommand createBrandCommand) 
        {
            //MediatR'ın buradaki görevi, Handle içindeki listeden ilgili Command'i bulmasıdır.
            //Yaşadığımız bina bir 'Handle' ise içindeki kişiler/daireler ise birer Command'dir.
            CreatedBrandResponse response = await _mediator.Send(createBrandCommand); 
            return Ok(response); 
        }
    }
}
