using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjWinRemex
{
    class clsListAgent
    {

        // declare a private or hidden .net dictionary
        private Dictionary<string, clsAgent> myList;
        public clsListAgent()
        {
            myList = new Dictionary<string, clsAgent>();
        }

        public int Quantity
        {
            get => myList.Count;

        }

        public Dictionary<string, clsAgent>.ValueCollection Elements
        {
            get => myList.Values;

        }

        public bool Add(clsAgent agent)
        {
            if (Exist(agent.agentid) == false)
            {
                myList.Add(agent.agentid, agent);
                return true;
            }
            else { return false; }
        }

        public bool Delete(string agentid)
        {
            return myList.Remove(agentid);
        }

        public clsAgent Find(string agentid)
        {
            if (Exist(agentid) == true)
            {
                return myList[agentid];
            }
            else { return null; }

        }

        public bool Exist(string agentid)
        {
            return myList.ContainsKey(agentid);
        }

        public string Display()
        {
            string info = "\n ---------\n";
            foreach (clsAgent itm in myList.Values)
            {
                info += itm.Display() + "\n --------\n";

            }
            return info;
        }

    }
}
