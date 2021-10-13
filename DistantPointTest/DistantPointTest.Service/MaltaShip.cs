using DistantPointTest.Entities;
using DistantPointTest.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistantPointTest.Service
{
    public class MaltaShip : Package, IMaltaShip
    {
        public override bool ValidationCheck(double Weight, double Dimension)
        {
            if (Weight < 10)
            {
                return false;
            }
            else if (Dimension < 500)
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
                package.Cost = 9.50;
            }
            else if (package.cubicCM > 1000 && package.cubicCM <= 2000)
            {
                package.Cost = 19.50;
            }
            else if(package.cubicCM > 2000 && package.cubicCM <= 5000)
            {
                package.Cost = 48.50;
            }
            else
            {
                package.Cost = 147.50;
            }

            return package.Cost;
        }

        public override double BasedOnWeight(Package package)
        {
            if (package.Weight <= 10 && package.Weight <= 20)
            {
                package.Cost = 16.99;
            }
            else if (package.Weight > 20 && package.Weight <= 30)
            {
                package.Cost = 33.99;
            }
            else if (package.Weight == 30)
            {
                package.Cost = 43.99;
            }
            else if(package.Weight > 30)
            {
                var plusKilos = package.Weight - 30;
                package.Cost = (plusKilos * 0.41) + 43.99;
            }

            return package.Cost;
        }
    }
}
