using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using XamarinFApi.Services;
using XamarinFApi.ViewModels;

namespace XamarinFApi
{
    public static class Startup
    {
        private static IServiceProvider serviceProvider;
        public static void ConfigureServices()
        {
            var services = new ServiceCollection();

            //add services
            services.AddHttpClient<IApiPrService, ApiPrService>(c =>
            {
                c.BaseAddress = new Uri("http://10.0.2.2:50438/api/");
                c.DefaultRequestHeaders.Add("Accept", "application/json");
            });

            //add viewmodels
            services.AddTransient<ProductsViewModel>();
            services.AddTransient<AddProductViewModel>();
            services.AddTransient<ProductDetailsViewModel>();

            serviceProvider = services.BuildServiceProvider();
        }

        public static T Resolve<T>() => serviceProvider.GetService<T>();

    }
}
