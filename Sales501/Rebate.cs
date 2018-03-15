using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales501
{
    class Rebate
    {
        int[] _rebates = new int[13];
        int _date;
        public Rebate(int date)
        {
            _rebates[1] = 7;
            _rebates[2] = 0;
            _rebates[3] = 0;
            _rebates[4] = 0;
            _rebates[5] = 0;
            _rebates[6] = 10;
            _rebates[7] = 11;
            _rebates[8] = 0;
            _rebates[9] = 0;
            _rebates[10] = 10;
            _rebates[11] = 12;
            _rebates[12] = 0;
            _date = date;
        }
        //
        public int rebates
        {
            get
            {
                return _rebates[_date];
            }
        }
    }
}
