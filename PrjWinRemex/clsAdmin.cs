using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjWinRemex
{
    class clsAdmin
    {
        private string vAdminNumber;
        private string vName;
        private string vEmail;
        private string vStatus;
        private string vPin;
        private clsListAgent vAgents;

        public clsAdmin(string adminnumber, string name, string email, string pin, string status, clsListAgent agent )
        {
            vAdminNumber = adminnumber;
            vName = name;
            vEmail = email;
            vPin = pin;
            vStatus = status;
            vAgents = agent;
        }

        //public clsClient(string number, string name, string pin, string status)
        //{
        //    vNumber = number;
        //    vName = name;
        //    vPin = pin;
        //    vStatus = status;
        //   // vAccounts = new clsListAccount();

        //}

        public clsAdmin()
        {
            vAdminNumber = vName = vPin = "Not defined";
            vStatus = "Active";
            vEmail = "Example@gmail.com";
            vAgents = new clsListAgent();
        }

        public string AdminNumber
        {
            get => vAdminNumber;
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



        public clsListAgent Agent
        {
            get => vAgents;
            set
            {
                vAgents = value;
            }
        }

        public void Register(string adminnumber, string name, string pin)//, clsListAgent agent)
        {
            vAdminNumber = adminnumber;
            vName = name;
            vPin = pin;
            vStatus = "active";
            //vAgents = agent;
            //vPin = pin;
            //vStatus = "active";
        }

        public string Display()
        {
            string info = "\nAdmin_Number: " + vAdminNumber + "\nName: " + vName + "\nStatus: " + vStatus + "\n Email: " +
                 vEmail + vAgents.Display();
            return info;
        }
    }
}
