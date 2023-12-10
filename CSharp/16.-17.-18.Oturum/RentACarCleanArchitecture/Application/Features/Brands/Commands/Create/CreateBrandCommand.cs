using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.Create
{
    //CreateBrandCommand :Marka oluşturma emri
    //Request<> :son kullanıcıdan(swagger) bir Command gelir.
    //Bu işlem sonrası MediatR kullanıcıya bir dönüş yapma ihtiyacı duyar.
    public class CreateBrandCommand:IRequest<CreatedBrandResponse>
    {
        public string Name { get; set; }
    }
}
