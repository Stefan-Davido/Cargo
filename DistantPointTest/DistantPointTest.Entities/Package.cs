using System;
using System.Collections.Generic;
using System.Text;

namespace DistantPointTest.Entities
{
    public class Package
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Depth { get; set; }
        public double Weight { get; set; }
        public string Courier { get; set; }
        public double Cost { get; set; }
        public double cubicCM
        {
            get => Weight * Height * Depth;
            set
            {
                cubicCM = value;
            }
        }

        public virtual double BasedOnDimensions(Package package)
        {
            return package.Cost;
        }

        public virtual double BasedOnWeight(Package package)
        {
            return package.Cost;
        }

        public virtual bool ValidationCheck(double Weight, double Dimension)
        {
            return false;
        }
    }
}
