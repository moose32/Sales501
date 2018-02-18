using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales501
{
    class Cart
    {
        double _totalCost;
        int _numItems;
        int _numItemReturns;
        double _rebateAmount;
        string _customerID;
        Stack<Item> items;

        public Cart()
        {
            _totalCost = 0;
            _numItems = 0;
            _numItemReturns = 0;
            _rebateAmount = 0;
            _customerID = "";
            items = new Stack<Item>();
        }

        public void addItem(Item item)
        {
            items.Push(item);
            _numItems++;
            _totalCost += item.cost;
        }

        public void pay()
        {
            while(items.Peek() != null)
            {
                items.Pop();
            }
            _numItems = 0;
            _totalCost = 0;
        }

        public void itemReturn(Item item, int date)
        {
            Rebate rebates = new Rebate(date);
            double rebate = rebates.rebates / 100;
            _totalCost -= item.cost;
            _numItemReturns++;
            _rebateAmount = (item.cost * rebate);
        }

        public double totalCost
        {
            get
            {
                return _totalCost;
            }
            set
            {
                _totalCost = value;
            }
        }

        public string customerID
        {
            get
            {
                return _customerID;
            }
            set
            {
                _customerID = value;
            }
        }
        
        public double rebateAmount
        {
            get
            {
                return _rebateAmount;
            }
        }
    }
}
