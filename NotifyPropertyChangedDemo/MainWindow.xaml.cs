using System.Collections.ObjectModel;
using System.Windows;

namespace NotifyPropertyChangedDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Constructors

        public MainWindow()
        {
            InitializeComponent();
            CustomerViewModel customerViewModel = new CustomerViewModel
                                                      {
                                                          Customer = new CustomerModel()
                                                          {
                                                              FirstName = "Ankur",
                                                              LastName = "Bhatnagar",
                                                              Addresses = new ObservableCollection<AddressModel>()
                                                                                                       {
                                                                                                           new AddressModel
                                                                                                               {
                                                                                                                   Line1 = "388 Greenwich St",
                                                                                                                   City = "New York"
                                                                                                               },
                                                                                                           new AddressModel()
                                                                                                               {
                                                                                                                   Line1 = "111 Wall St",
                                                                                                                   City = "New York"
                                                                                                               },
                                                                                                               new AddressModel
                                                                                                                   {
                                                                                                                       Line1 = "4600 Jasmin Dr",
                                                                                                                       City = "Center Valley"
                                                                                                                   }
                                                                                                       }
                                                          },

                                                      };
            customerViewModel.Customer.PrincipalAddress = customerViewModel.Customer.Addresses[0];
            this.DataContext = customerViewModel;
        }

        #endregion Constructors
    }
}