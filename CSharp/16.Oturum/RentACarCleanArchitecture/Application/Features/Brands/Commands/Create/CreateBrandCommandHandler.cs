using Application.Services.Repositories;
using Domain.Entites;
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
        public async Task<CreatedBrandResponse>? Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            Brand brand = new Brand();
            brand.Name = request.Name;
            brand.Id = Guid.NewGuid();


            var createdBrand = await _brandRepository.AddAsync(brand);

            CreatedBrandResponse createdBrandResponse = new CreatedBrandResponse();
            createdBrandResponse.Id = createdBrand.Id;
            createdBrandResponse.Name = createdBrand.Name;
            createdBrandResponse.CreatedDate = createdBrand.CreatedDate;

            return createdBrandResponse;

        }
    }
}
