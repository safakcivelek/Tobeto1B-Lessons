using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.Create
{
    //CreatedBrandResponse :oluşturulan marka yanıtı
    public class CreatedBrandResponse
    {
        public Guid Id { get; set; }
        public string Name { get; internal set; }
        public DateTime CreatedDate { get; set; }
    }
}
