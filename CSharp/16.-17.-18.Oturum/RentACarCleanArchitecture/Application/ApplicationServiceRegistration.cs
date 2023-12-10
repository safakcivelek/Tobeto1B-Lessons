using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    //Application ile ilgili tüm IoC servis kayıtlarını buraya ekliyorum.
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            //MediatR Pattern kütüphanesini servislere ekler.
            services.AddMediatR(configuration =>
            {
                //Assembly.GetExecutingAssembly() ifadesi, bu sınıfın Assembly'sini temsil eder. Yani Application projesini temsil eder.
                //RegisterServicesFromAssembly ifadesi, bu assembly'deki tüm servisleri MediatR'a ekler bu sayede diğer servislerin içinde MediatR ile uyumlu işlemler metodlar var ise otomatik olarak bulunur.
                //Bu yapı sayesinde, uygulama içindeki farklı servisler birbirleriyle Mediator Pattern üzerinden iletişim kurabilirler. 
                configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            });
            return services;
        }
    }
}
