using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjWinRemex
{
    public class clsClient
    {
        private string vNumber;
        private string vName;
        private string vEmail;
        private string vStatus;
        private string vPin;
        //private clsListAccount vAccounts;

        public clsClient(string number, string name, string email, string pin, string status) //,clsListAccount accounts)
        {
            vNumber = number;
            vName = name;
            vEmail = email;
            vPin = pin;
            vStatus = status;
            //vAccounts = accounts;
        }

        //public clsClient(string number, string name, string pin, string status)
        //{
        //    vNumber = number;
        //    vName = name;
        //    vPin = pin;
        //    vStatus = status;
        //   // vAccounts = new clsListAccount();

        //}

        public clsClient()
        {
            vNumber = vName = vPin = "Not defined";
            vStatus = "Active"; 
            vEmail = "Example@gmail.com";
            //vAccounts = new clsListAccount();
        }

        public string Number
        {
            get => vNumber;
        }

        public string Name
        {
            get => vName;
            set
            {
                vName = value;
            }
        }

        public string email
        {
            get => vEmail;
            set
            {
                vEmail = value;
            }
        }
        
        public string pin
        {
            get => vPin;
            set
            {
                vPin = value;
            }
        }
         
        

        //public clsListAccount Accounts
        //{
        //    get => vAccounts;
        //    set
        //    {
        //        vAccounts = value;
        //    }
        //}

        public void Register(string number, string name, string pin)
        {
            vNumber = number;
            vName = name;
            vPin = pin;
            vStatus = "active";
            //vPin = pin;
            //vStatus = "active";
        }

        public string Display()
        {
            string info = "\nNumber: " + vNumber + "\nName: " + vName +"\nStatus: " + vStatus + "\n Email: " +
                 vEmail;// + vAccounts.Display();
            return info;
        }
    }
}