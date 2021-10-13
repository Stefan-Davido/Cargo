using DistantPointTest.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistantPointTest.Service.Interfaces
{
    public interface IMaltaShip
    {
        public bool ValidationCheck(double Weight, double Dimension);
        public double BasedOnDimensions(Package package);
        public double BasedOnWeight(Package package);

    }
}
