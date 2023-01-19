using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelDeliverySystem.Model
{
    public class Accounts
    {
        private int id;
        private string fullname;
        private string phone;
        private string email;
        private string password;
        private string acctype;
        private string landmark;
        private string street;
        private string town;
        private string province;
        private int zipcode;

        public Accounts(int id, string fullname, string phone, string email, string password, string acctype, 
            string landmark, string street, string town, string province, int zipcode)
        {
            this.id = id;
            this.fullname = fullname;
            this.phone = phone;
            this.email = email;
            this.password = password;
            this.acctype = acctype;
            this.landmark = landmark;
            this.street = street;
            this.town = town;
            this.province = province;
            this.zipcode = zipcode;
        }

        public int GetId()
        {
            return id;
        }

        public string GetFullname()
        {
            return fullname;
        }

        public string GetPhone()
        {
            return phone;
        }

        public string GetEmail()
        {
            return email;
        }

        public string GetPassword()
        {
            return password;
        }

        public string GetAcctype()
        {
            return acctype;
        }

        public string GetLandmark()
        {
            return landmark;
        }

        public string GetStreet()
        {
            return street;
        }

        public string GetTown()
        {
            return town;
        }

        public string GetProvince()
        {
            return province;
        }

        public int GetZipcode() 
        {
            return zipcode;
        }
    }
}
