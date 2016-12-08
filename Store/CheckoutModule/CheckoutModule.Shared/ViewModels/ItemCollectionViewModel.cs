namespace CheckoutModule.ViewModels
{
    using Contracts;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    public class ItemCollectionViewModel
    {
        private ObservableCollection<ISellable> items;

        public ItemCollectionViewModel()
        {
            this.Items = new ObservableCollection<ISellable>();
        }

        public ItemCollectionViewModel(ICollection<ISellable> sellables)
        {
            this.Items = new ObservableCollection<ISellable>(sellables);
        }

        public ObservableCollection<ISellable> Items
        {
            get
            {
                return this.items;
            }
            set
            {
                if (this.items == null)
                {
                    this.items = new ObservableCollection<ISellable>(value);
                }

                this.items.Clear();
                foreach (var item in value)
                {
                    items.Add(item);
                }
            }
        }

        public decimal TotalSum
        {
            get
            {
                return Items.Sum(x => (x.Quantity * x.Price));
            }
        }

        public void Add(ISellable newItem)
        {
            this.items.Add(newItem);
        }

        public void Clear()
        {
            this.items.Clear();
        }
    }
}