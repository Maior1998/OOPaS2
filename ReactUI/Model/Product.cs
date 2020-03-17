using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace ReactUI.Model
{
    public class Product : ReactiveObject
    {
        public Product(string name, int count, double cost)
        {
            Name = name;
            Count = count;
            Cost = cost;
        }

        [Reactive] public string Name { get; set; }
        [Reactive] public int Count { get; set; }
        [Reactive] public double Cost { get; set; }
    }
}