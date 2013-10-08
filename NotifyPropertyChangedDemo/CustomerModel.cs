using System.Collections.ObjectModel;

namespace NotifyPropertyChangedDemo
{
    public class CustomerModel : ModelBase
    {
        #region Properties

        public ObservableCollection<AddressModel> Addresses
        {
            get; set;
        }

        public string Email
        {
            get; set;
        }

        public string FirstName
        {
            get; set;
        }

        public string LastName
        {
            get; set;
        }

        public string Mobile
        {
            get; set;
        }

        public string Phone
        {
            get; set;
        }

        public AddressModel PrincipalAddress
        {
            get; set;
        }

        #endregion Properties
    }
}