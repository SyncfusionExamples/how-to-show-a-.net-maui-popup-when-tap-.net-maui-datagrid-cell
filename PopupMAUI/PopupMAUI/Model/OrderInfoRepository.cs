using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopupMAUI
{
    public class OrderInfoRepository
    {
        public OrderInfoRepository()
        {
        }       

        #region GetOrderDetails

        public ObservableCollection<OrderInfo> GetOrderDetails(int count)
        {                     
            Random random = new Random();
            ObservableCollection<OrderInfo> orderDetails = new ObservableCollection<OrderInfo>();

            for (int i = 10001; i <= count + 10000; i++)
            {
                var shipcountry = ShipCountry[random.Next(5)];               

                var order = new OrderInfo()
                {
                    OrderID = i,
                    CustomerID = CustomerID[random.Next(15)],
                    EmployeeID = random.Next(1700, 1720),                   
                    ShipCountry = ShipCountry[random.Next(5)]                    
                };
                orderDetails.Add(order);
            }
            return orderDetails;
        }

        #endregion

        #region MainGrid DataSource        

        string[] CustomerID = new string[] {
            "Alfki",
            "Frans",
            "Merep",
            "Folko",
            "Simob",
            "Warth",
            "Vaffe",
            "Furib",
            "Seves",
            "Linod",
            "Riscu",
            "Picco",
            "Blonp",
            "Welli",
            "Folig"
        };

        string[] ShipCountry = new string[] {

            "Argentina",
            "Austria",
            "Belgium",
            "Brazil",
            "Canada",
            "Denmark",
            "Finland",
            "France",
            "Germany",
            "Ireland",
            "Italy",
            "Mexico",
            "Norway",
            "Poland",
            "Portugal",
            "Spain",
            "Sweden",
            "Switzerland",
            "UK",
            "USA",
            "Venezuela"
        };       

        #endregion

    }
}
