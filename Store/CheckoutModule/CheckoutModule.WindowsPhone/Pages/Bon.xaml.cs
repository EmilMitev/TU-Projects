namespace CheckoutModule.Pages
{
    using CheckoutModule.Common;
    using CheckoutModule.Contracts;
    using System.Collections.Generic;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;
    using Windows.UI.Xaml.Navigation;

    public sealed partial class Bon : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        public Bon()
        {
            this.InitializeComponent();

            this.navigationHelper = new NavigationHelper(this);
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

            decimal totalSum = 0;

            List<ISellable> items = (List<ISellable>)e.Parameter;

            this.listItems.ItemsSource = items;

            foreach (var item in items)
            {
                totalSum += item.Total;
            }

            decimal change = Cart.UserChart.Money - totalSum;
            Cart.UserChart.Money = change;

            this.TotalBill.Text = totalSum.ToString();
            this.Change.Text = change.ToString();
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
