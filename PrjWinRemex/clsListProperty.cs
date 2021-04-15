using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjWinRemex
{
    class clsListProperty
    {

        // declare a private or hidden .net dictionary
        private Dictionary<string, clsProperty> myList;
        public clsListProperty()
        {
            myList = new Dictionary<string, clsProperty>();
        }

        public int Quantity
        {
            get => myList.Count;

        }

        public Dictionary<string, clsProperty>.ValueCollection Elements
        {
            get => myList.Values;

        }

        public bool Add(clsProperty property)
        {
            if (Exist(property.refnumber) == false)
            {
                myList.Add(property.refnumber, property);
                return true;
            }
            else { return false; }
        }

        public bool Delete(string refnumber)
        {
            return myList.Remove(refnumber);
        }

        public clsProperty Find(string refnumber)
        {
            if (Exist(refnumber) == true)
            {
                return myList[refnumber];
            }
            else { return null; }

        }

        public bool Exist(string refnumber)
        {
            return myList.ContainsKey(refnumber);
        }

        public string Display()
        {
            string info = "\n ---------\n";
            foreach (clsProperty itm in myList.Values)
            {
                info += itm.Display() + "\n --------\n";

            }
            return info;
        }

    }
}
