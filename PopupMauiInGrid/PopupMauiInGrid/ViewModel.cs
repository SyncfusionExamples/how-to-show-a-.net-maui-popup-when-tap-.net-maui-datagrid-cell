using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopupMauiInGrid
{
    public class ViewModel : NotificationObject
    {
        OrderInfoRepository order;
        public ViewModel()
        {
            SetRowstoGenerate(50);
        }

        #region ItemsSource

        private ObservableCollection<OrderInfo> ordersInfo;
        public ObservableCollection<OrderInfo> OrdersInfo
        {
            get { return ordersInfo; }
            set { this.ordersInfo = value; }
        }

        private ObservableCollection<int> comboBoxItemSource = new ObservableCollection<int>();
        public ObservableCollection<int> ComboBoxItemSource
        {
            get { return comboBoxItemSource; }
            set
            {
                comboBoxItemSource = value;
                RaisePropertyChanged("ComboBoxItemSource");
            }
        }
        private ObservableCollection<object> selectedItems = new ObservableCollection<object>();
        public ObservableCollection<object> SelectedItems
        {
            get { return selectedItems; }
            set
            {
                selectedItems = value;
                RaisePropertyChanged("SelectedItems");
            }
        }

        private object selectedItem;
        public object SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                RaisePropertyChanged("SelectedItem");
            }
        }

        private int selectedIndex;
        public int SelectedIndex
        {
            get { return selectedIndex; }
            set
            {
                selectedIndex = value;
                RaisePropertyChanged("SelectedIndex");
            }
        }
        #endregion

        #region ItemSource Generator

        public void SetRowstoGenerate(int count)
        {
            order = new OrderInfoRepository();
            ordersInfo = order.GetOrderDetails(count);

        }

        #endregion
    }

    public class NotificationObject : INotifyPropertyChanged
    {
        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
