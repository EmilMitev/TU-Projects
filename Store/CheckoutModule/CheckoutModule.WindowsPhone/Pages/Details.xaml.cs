using CheckoutModule.Common;
using CheckoutModule.ViewModels;
using System.Text.RegularExpressions;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace CheckoutModule.Pages
{
    public sealed partial class Details : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        public Details()
        {
            this.InitializeComponent();

            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += this.NavigationHelper_LoadState;
            this.navigationHelper.SaveState += this.NavigationHelper_SaveState;
        }
        
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }
        
        private void NavigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }
        
        private void NavigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        public ItemViewModel ViewModel
        {
            get
            {
                return this.DataContext as ItemViewModel;
            }
            set
            {
                this.DataContext = value;
            }
        }


        #region NavigationHelper registration

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedTo(e);

            ItemViewModel food = (ItemViewModel)e.Parameter;

            this.ViewModel = food;
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedFrom(e);
        }

        #endregion
        private void Menu_Tapped(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void My_Cart(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MyCart));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(this.selectedQuantity.Text, @"^\d+$"))
            {
                return;
            }

            int selectedQuantityValue = int.Parse(this.selectedQuantity.Text);

            if (this.ViewModel.Quantity < selectedQuantityValue)
            {
                return;
            }

            var storedItem = new ItemViewModel
            {
                Id = this.ViewModel.Id,
                Name = this.ViewModel.Name,
                Price = this.ViewModel.Price,
                Measurement = this.ViewModel.Measurement,
                Quantity = selectedQuantityValue
            };

            Cart.UserChart.Items.Add(storedItem);

            this.Frame.Navigate(typeof(MainPage));
        }
    }
}