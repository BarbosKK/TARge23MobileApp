using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiCRUD.Data;
using MauiCRUD.Models;
using System.Collections.ObjectModel;


namespace MauiCRUD.ViewModels
{
    public partial class ProductsViewModel : ObservableObject
    {
        private readonly DatabaseContext _context;

        //konstruktor teeme
        public ProductsViewModel(DatabaseContext context)
        {
            _context = context;
        }

        [ObservableProperty]
        private ObservableCollection<Product> _product = new();

        [ObservableProperty]
        private Product _operatingProduct = new();

        [ObservableProperty]
        private bool _isBusy;

        [ObservableProperty]
        private string _busyText;

        public async Task LoadProductAsync()
        {
            await executeAsync(async () =>
            {
                var products = await _context.GetAllAsync<Product>();
                if (products is not null && Product.Any())
                {
                    Products ??= new ObservableCollection<Product>();
                    foreach (var item in products)
                    {
                        Products.Add(product);
                    }
                }
            }, "Fetching products...");

        }
        [RelayCommand]
        private void SetOperatingProduct(Product? product) => SetOperatingProduct = product ?? new();

        [RelayCommand]
        private async Task SaveProductAsync()
        {
            if (SetOperatingProduct is null)
                return;

            var(isValid, e)
        }
    }
}
