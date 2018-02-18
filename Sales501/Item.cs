using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales501
{
    class Item
    {
        double _cost = 0;
        string _name = "";

        public Item(double cost, string name)
        {
            _cost = cost;
            _name = name;
        }

        public double cost
        {
            get
            {
                return _cost;
            }
            set
            {
                _cost = value;
            }
        }

        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
    }
}
