using System;
using System.Collections.ObjectModel;
using System.Linq;
using DynamicData;
using DynamicData.Binding;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using ReactUI.Model;

namespace ReactUI.ViewModel
{
    public class ShopModel : ReactiveObject
    {
        public ShopModel()
        {
            void GetSummary()
            {
                SummaryPrice = Cart.Sum(e => e.Count * e.Cost);
            }

            Cart
                .ToObservableChangeSet()
                .ForEachChange(_ => GetSummary())
                .WhenAnyPropertyChanged(nameof(Product.Count), nameof(Product.Cost))
                .Subscribe(_ => GetSummary());
            Cart.Clear();
        }

        [Reactive] public ObservableCollection<Product> Cart { get; set; } = new ObservableCollection<Product>();
        [Reactive] public Product SelectedProduct { get; set; }
        [Reactive] public double SummaryPrice { get; set; }


        private ShopCommand addItemToCart;
        public ShopCommand AddItemToCart
        {
            get
            {
                return addItemToCart ?? (addItemToCart =
                    new ShopCommand(_ => { Cart.Add(new Product("Новый товар", 1, 1)); }));
            }
        }


        private ShopCommand removeItemFromCart;
        public ShopCommand RemoveItemFromCart
        {
            get
            {
                return removeItemFromCart ?? (removeItemFromCart =
                    new ShopCommand(obj => Cart.Remove(SelectedProduct), obj => SelectedProduct != null));
            }
        }
    }
}