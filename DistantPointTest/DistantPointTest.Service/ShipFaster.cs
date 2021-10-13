using DistantPointTest.Entities;
using DistantPointTest.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistantPointTest.Service
{
    public class ShipFaster : Package, IShipFaster
    {
        public override bool ValidationCheck(double Weight, double Dimension)
        {
            if (Weight < 10)
            {
                return false;
            }
            else if (Weight > 30)
            {
                return false;
            }
            else if(Dimension > 1700)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public override double BasedOnDimensions(Package package)
        {
            if (package.cubicCM <= 1000)
            {
                package.Cost = 11.99;
            }
            else if (package.cubicCM > 1000 && package.cubicCM <= 1700)
            {
                package.Cost = 21.99;
            }

            return package.Cost;
        }

        public override double BasedOnWeight(Package package)
        {
            if (package.Weight > 10 && package.Weight <= 15)
            {
                package.Cost = 16.50;
            }
            else if (package.Weight > 15 && package.Weight <= 25)
            {
                package.Cost = 36.50;
            }
            else if (package.Weight == 25)
            {
                package.Cost = 40;
            }
            else if (package.Weight > 25)
            {
                var plusKilos = package.Weight - 25;
                package.Cost = (plusKilos * 0.417) + 40;
            }

            return package.Cost;
        }
    }
}
