﻿using PostSharp.Patterns.Model;

namespace NotifyPropertyChangedDemo
{
    [NotifyPropertyChanged]
    public class CustomerViewModel
    {
        #region Constructors

        public CustomerViewModel()
        {
        }

        #endregion Constructors

        #region Properties

        public CustomerModel Customer
        {
            get; set;
        }

        public string FullName
        {
            get
            {
                if (this.Customer == null) return "null";

                return string.Format("{0} {1} from {2}",
                    this.Customer.FirstName,
                    this.Customer.LastName,
                    this.Customer.PrincipalAddress != null ? this.Customer.PrincipalAddress.FullAddress: "?");
            }
        }

        #endregion Properties
    }
}