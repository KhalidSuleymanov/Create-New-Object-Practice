using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Car : Vehicle
    {
        double _fuelCapacity;

        public Car(double fuelCapacity)
        {
            _fuelCapacity = fuelCapacity;
        }
        

        public double FuelCapacity
        {
            set
            {
                if (_currentFuel <= value)
                {
                    _fuelCapacity = value;
                }
                    
            }
            get
            {
                return _fuelCapacity;
            }
        }


        private double _currentFuel;

        public double CurrentFuel
        {
            get
            {
                return _currentFuel;
            }
        }

        public double FuelFor1Km;

        public void AddFuel(int fuel)
        {
            if (_currentFuel + fuel < FuelCapacity)
            {
                _currentFuel += fuel;
            }
                
        }

        public override void Drive(double km)
        {
            double needFuel = km * FuelFor1Km;

            if (_currentFuel >= needFuel)
            {
                _currentFuel -= needFuel;

                _milleage += km;
            }
        }
    }
}
