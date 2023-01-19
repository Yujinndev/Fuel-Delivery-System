using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FuelDeliverySystem.Model
{
    public class Stations
    {
        private int id;
        private string company;
        private string location;
        private double dieselPrice;
        private double unleadedPrice;
        private double premiumPrice;
        private string status;

        public Stations (int id, string company, string location, double dieselPrice, double unleadedPrice, double premiumPrice, string status)
        {
            this.id = id;
            this.company = company;
            this.location = location;
            this.dieselPrice = dieselPrice;
            this.unleadedPrice = unleadedPrice;
            this.premiumPrice = premiumPrice;
            this.status = status;
        }

        public int GetId()
        {
            return id;
        }

        public string GetCompany()
        {
            return company;
        }

        public string GetLocation()
        {
            return location;
        }

        public double GetDieselPrice()
        {
            return dieselPrice;
        }

        public double GetUnleadedPrice()
        {
            return unleadedPrice;
        }

        public double GetPremiumPrice()
        {
            return premiumPrice;
        }

        public string GetStatus()
        {
            return status;
        }
    }
}
