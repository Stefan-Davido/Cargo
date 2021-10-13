using System;
using System.Collections.Generic;
using System.Text;
using DistantPointTest.Entities;
using DistantPointTest.Service.Interfaces;

namespace DistantPointTest.Service
{
    public class Cargo4You : Package, ICargo4You
    {
        public override bool ValidationCheck(double Weight, double Dimension)
        {
            if(Weight > 20)
            {
                return false;
            }
            else if(Dimension > 2000)
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
                package.Cost = 10;
            }
            else if (package.cubicCM > 1000 && package.cubicCM <= 2000)
            {
                package.Cost = 20;
            }

            return package.Cost;
        }

        public override double BasedOnWeight(Package package)
        {
            if (package.Weight <= 2)
            {
                package.Cost = 15;
            }
            else if (package.Weight > 2 && package.Weight <= 15)
            {
                package.Cost = 18;
            }
            else if (package.Weight > 15 && package.Weight <= 20)
            {
                package.Cost = 35;
            }

            return package.Cost;
        }
    }
}