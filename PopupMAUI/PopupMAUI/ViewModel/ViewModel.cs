using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopupMAUI
{
    public class ViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<OrderInfo> ordersInfo;
        public ObservableCollection<OrderInfo> OrdersInfo
        {
            get { return ordersInfo; }
            set { this.ordersInfo = value; RaisePropertyChanged("OrdersInfo"); }
        }

        public ViewModel()
        {
            SetRowstoGenerate(50);
        }       

        #region ItemSource Generator

        public void SetRowstoGenerate(int count)
        {
            var order = new OrderInfoRepository();
            ordersInfo = order.GetOrderDetails(count);
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
