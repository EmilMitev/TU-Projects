namespace CheckoutModule.Pages
{
    using Common;
    using Contracts;
    using ViewModels;
    using SQLite;
    using Store.Models;
    using System.Collections.Generic;
    using System.Linq;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;
    using Windows.UI.Xaml.Navigation;

    public sealed partial class MyCart : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        public MyCart()
        {
            this.InitializeComponent();

            this.navigationHelper = new NavigationHelper(this);

            this.UserName.Text = Cart.UserChart.FirstName;
            this.Money.Text = Cart.UserChart.Money.ToString() + " $";
        }
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        #region NavigationHelper registration
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedTo(e);
            this.ViewModel = new ItemCollectionViewModel(Cart.UserChart.Items);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        public ItemCollectionViewModel ViewModel
        {
            get
            {
                return this.DataContext as ItemCollectionViewModel;
            }
            set
            {
                this.DataContext = value;
            }
        }

        private void Menu_Tapped(object sender, RoutedEventArgs args)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private async void Begin_Transaction(object sender, RoutedEventArgs e)
        {
            if (this.ViewModel.Items.Count() == 0)
            {
                return;
            }

            decimal totalSum = this.ViewModel.Items.Sum(x => (x.Quantity * x.Price));

            if (totalSum > Cart.UserChart.Money)
            {
                return;
            }

            var connection = new SQLiteAsyncConnection("Store.db");
            var records = await connection.Table<Item>().ToListAsync(); //Where(x => x.Id == item.Id).FirstAsync();

            foreach (var item in this.ViewModel.Items)
            {
                Item databaseItem = records.FirstOrDefault(x => x.Id == item.Id);

                if (databaseItem != null)
                {
                    databaseItem.Quantity -= item.Quantity;
                    await connection.UpdateAsync(databaseItem);
                }
            }

            List<ISellable> transferList = new List<ISellable>();

            this.ViewModel.Items.ForEach(x => transferList.Add(x));

            this.ViewModel.Clear();
            Cart.UserChart.Items.Clear();

            //this.Frame.Navigate(typeof(Bon), transferList);
        }

        private void Clear_Cart(object sender, RoutedEventArgs e)
        {
            this.ViewModel.Clear();
            this.TotalSum.Text = "0";
            Cart.UserChart.Items.Clear();
        }
    }
}