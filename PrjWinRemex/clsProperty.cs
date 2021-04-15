using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjWinRemex
{
    class clsProperty
    {
        private string vRefNumber;
        //private string vNumber;
        private string vAddress;
        private string vStatus;
        private string vType;
        private int vPrice;
        private clsListClient vClients;
        // private clsListAccount vAccounts;

        public clsProperty(string refnumber, string address, string type,int price, string status)//, clsListClient clients)
        {
            vRefNumber = refnumber;
            vAddress = address;
            vType = type;
            vStatus = status;
            vPrice = price;
            //vClients = clients;
        }

        public clsProperty(string refnumber, string address, string type, int price)
        {
            vRefNumber = refnumber;
            vAddress = address;
            vType = type;
            vStatus = "active";
            vPrice = price;
           // vClients = new clsListClient();

        }

        public clsProperty()
        {
            vRefNumber = vAddress = vType = vStatus = "Not defined";
            vPrice = 0;
           // vClients = new clsListClient();
        }

        public string refnumber
        {
            get => vRefNumber;
        }

        public string Address
        {
            get => vAddress;
            set
            {
                vAddress = value;
            }
        }

        public string Status
        {
            get => vStatus;
        }

        public int Price
        {
            get => vPrice;

            set
            {
                vPrice = value;
            }
        }

        //public clsListClient Accounts
        //{
        //    get => vClients;
        //    set
        //    {
        //        vClients = value;
        //    }
        //}

        public void Register(string refnumber, string address, string type, int price)
        {
            vRefNumber = refnumber;
            vAddress = address;
            vType = type;
            vPrice = price;
            vStatus = "active";
        }

        public string Display()
        {
            string info = "\nRefernce id: " + vRefNumber + "\nAddress: " + vAddress + "\nType: " +
                vType + "\nPrice: " + vPrice + "\n Status: " + vStatus; 
            return info;
        }
    }
}
