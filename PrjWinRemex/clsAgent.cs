using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjWinRemex
{
    class clsAgent
    {
        private string vAgentid;
        //private string vNumber;
        private string vName;
        private string vStatus;
        private string vPin;
        private clsListClient vClients;
       // private clsListAccount vAccounts;

        public clsAgent(string agentid, string name, string pin, string status, clsListClient clients)
        {
            vAgentid = agentid;
            vName = name;
            vPin = pin;
            vStatus = status;
            vClients = clients;
        }

        public clsAgent(string agentid, string name, string pin, string status)
        {
            vAgentid = agentid;
            vName = name;
            vPin = pin;
            vStatus = status;
            vClients = new clsListClient();

        }

        public clsAgent()
        {
            vAgentid = vName = vPin = vStatus = "Not defined";
            vClients = new clsListClient();
        }

        public string agentid
        {
            get => vAgentid;
        }

        public string Name
        {
            get => vName;
            set
            {
                vName = value;
            }
        }

        public string Status
        {
            get => vStatus;
        }

        public string Pin
        {
            get => vPin;
        }

        public clsListClient Clients
        {
            get => vClients;
            set
            {
                vClients = value;
            }
        }

        public void Register(string agentid, string name, string pin)
        {
            vAgentid = agentid;
            vName = name;
            vPin = pin;
            vStatus = "active";
        }

        public string Display()
        {
            string info = "\nAgentid: " + vAgentid + "\nName: " + vName + "\nPin: " +
                vPin + "\nAccounts: \n" + vClients.Display();
            return info;
        }
    }
}
