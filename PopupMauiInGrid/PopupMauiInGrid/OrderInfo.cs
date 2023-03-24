using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopupMauiInGrid
{
    public class OrderInfo : INotifyPropertyChanged
    {
        public OrderInfo()
        {
            
        }

        #region private variables

        private double _orderID;
        private double _employeeID;
        private string _customerID;        
        private string _shipCountry;
        
        #endregion

        #region Public Properties

        public double OrderID
        {
            get
            {
                return _orderID;
            }
            set
            {
                this._orderID = value;
                RaisePropertyChanged("OrderID");
            }
        }

        public double EmployeeID
        {
            get
            {
                return _employeeID;
            }
            set
            {
                this._employeeID = value;
                RaisePropertyChanged("EmployeeID");
            }
        }

        public string CustomerID
        {
            get
            {
                return _customerID;
            }
            set
            {
                this._customerID = value;
                RaisePropertyChanged("CustomerID");
            }
        }
        
        public string ShipCountry
        {
            get
            {
                return _shipCountry;
            }
            set
            {
                this._shipCountry = value;
                RaisePropertyChanged("ShipCountry");
            }
        }
        
        #endregion

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(String Name)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(Name));
        }

        #endregion
    }
}
