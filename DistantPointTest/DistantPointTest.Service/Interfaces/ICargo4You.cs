using DistantPointTest.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistantPointTest.Service.Interfaces
{
    public interface ICargo4You
    {
        public double BasedOnDimensions(Package package);
        public double BasedOnWeight(Package package);
        public bool ValidationCheck(double Weight, double Dimension);
    }
}
