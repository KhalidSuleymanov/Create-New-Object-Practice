using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Drink
    {
        double _alcoholPercent;

        public double AlcoholPercent
        {
            set
            {
                if(value >= 1 && value <= 100)
                {
                    _alcoholPercent = value;
                }
            }
            get
            {
                return _alcoholPercent;
            }
        }
    }
}
