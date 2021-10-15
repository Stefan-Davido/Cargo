﻿using DistantPointTest.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistantPointTest.Repository.Interfaces
{
    public interface IPricePerCourierRepository
    {
        public void AddPricer(PricePerCourier pricer);
        public void EditPricer(PricePerCourier pricer);
        public void DeletePricer(int id);
        public PricePerCourier GetPricerById(int id);
        public IEnumerable<PricePerCourier> GetAllPricers();
        public PricePerCourier GetPricerByCourierId(int id);
    }
}
