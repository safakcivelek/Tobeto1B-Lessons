using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.Create
{
    //CreateBrandCommandHandler:IRequestHandler<> => Son kullanıcıdan gelen isteği/emri IRequestHandler ile yakala ve geriye bir response gönder.
    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, CreatedBrandResponse>
    {
        public Task<CreatedBrandResponse> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {            
            //sonra dbye eklenecek
            return Task.FromResult(new CreatedBrandResponse { Name = request.Name});
        }
    }
}
