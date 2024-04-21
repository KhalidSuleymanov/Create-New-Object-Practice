using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Vehicle
    {
        protected double _milleage;
        public double Milleage
        {
            get
            {
                return _milleage;
            }
        }
        public virtual void Drive(double km)
        {
            _milleage += km;
        }
    }
}
