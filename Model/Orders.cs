using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelDeliverySystem.Model
{
    public class Orders
    {
        private int id;
        private string customer;
        private string station;
        private string location;
        private string gas;
        private double price;
        private double quantity;
        private double total;
        private string deliveryDatetime;
        private string deliveryLocation;
        private string orderedDateTime;
        private string status;

        public Orders(int id, string customer, string station, string location, string gas, double price, double quantity, double total, string deliveryDatetime,
            string deliveryLocation, string orderedDateTime, string status)
        {
            this.id = id;
            this.customer = customer;
            this.station = station;
            this.location = location;
            this.gas = gas;
            this.price = price;
            this.quantity = quantity;
            this.total = total;
            this.deliveryDatetime = deliveryDatetime;
            this.deliveryLocation = deliveryLocation;
            this.orderedDateTime = orderedDateTime;
            this.status = status;
        }

        public int GetId()
        {
            return id;
        }

        public string GetCustomer()
        {
            return customer;
        }

        public string GetStation()
        {
            return station;
        }

        public string GetLocation() 
        { 
            return location; 
        }

        public string GetGas()
        {
            return gas;
        }

        public double GetPrice()
        {
            return price;
        }

        public double GetQuantity()
        {
            return quantity;
        }

        public double GetTotal()
        {
            return total;
        }

        public string GetDeliveryLocation()
        {
            return deliveryLocation;
        }

        public string GetDeliveryDatetime()
        {
            return deliveryDatetime;
        }

        public string GetOrderedDatetime()
        {
            return orderedDateTime;
        }


        public string GetStatus()
        {
            return status;
        }

    }
}
