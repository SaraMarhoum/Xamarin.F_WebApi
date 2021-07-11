using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinFApi.Models;
using XamarinFApi.Services;

namespace XamarinFApi.ViewModels
{
    public class AddProductViewModel : BaseViewModel
    {
        private readonly IApiPrService _ApiPrService;
        private string name;
        private string price;
        private string description;

        public AddProductViewModel(IApiPrService apiPrService)
        {
            _ApiPrService = apiPrService;

            SaveProductCommand = new Command(async () => await SaveProduct());
        }

        private async Task SaveProduct()
        {
            try
            {
                var product = new Product
                {
                    Name = name,
                    Price = int.Parse(price),
                    Description = description
                };

                await _ApiPrService.AddProduct(product);

                await Shell.Current.GoToAsync("..");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public string Title
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        public string Prix
        {
            get => price;
            set
            {
                price = value;
                OnPropertyChanged(nameof(Prix));
            }
        }
        public string Description
        {
            get => description;
            set
            {
                description = value;
                OnPropertyChanged(nameof(Description));
            }
        }

        public ICommand SaveProductCommand { get; }
    }
}
