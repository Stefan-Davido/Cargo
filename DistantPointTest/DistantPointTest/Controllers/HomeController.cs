using DistantPointTest.Entities;
using DistantPointTest.Models;
using DistantPointTest.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DistantPointTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICargo4You _cargo4You;
        private readonly IShipFaster _shipFaster;
        private readonly IMaltaShip _maltaShip;

        public HomeController(
            ILogger<HomeController> logger,
            ICargo4You cargo4You,
            IShipFaster shipFaster,
            IMaltaShip maltaShip)
        {
            _logger = logger;
            _cargo4You = cargo4You;
            _shipFaster = shipFaster;
            _maltaShip = maltaShip;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var dropDown = DropDown();
            ViewBag.Cargo = dropDown;
            return View();
        }

        [HttpPost]
        public IActionResult Index(Package package)
        {
            var dropDown = DropDown();
            ViewBag.Cargo = dropDown;

            if(package.Courier.ToLower() == "cargo4you")
            {
                var check = _cargo4You.ValidationCheck(package.Weight, package.cubicCM);
                if(check == false)
                {
                    
                    ViewBag.Message = "This Courier Doesn't allow this size package";
                }              
                else
                {
                    ViewBag.Cargo = dropDown;
                    ViewBag.Message = "Successfull";
                    var priceByDimensions = _cargo4You.BasedOnDimensions(package);
                    var priceByWeight = _cargo4You.BasedOnWeight(package);

                    if(priceByDimensions >= priceByWeight)
                    {
                        package.Cost = priceByDimensions;
                    }
                    else
                    {
                        package.Cost = priceByWeight;
                    }

                    return View(package);
                }
            }
            if (package.Courier.ToLower() == "maltaship")
            {
                var check = _maltaShip.ValidationCheck(package.Weight, package.cubicCM);
                if(check == false)
                {
                    ViewBag.Message = "This Courier Doesn't allow this size package";
                }              
                else
                {
                    ViewBag.Cargo = dropDown;
                    ViewBag.Message = "Successfull";
                    var priceByDimensions = _maltaShip.BasedOnDimensions(package);
                    var priceByWeight = _maltaShip.BasedOnWeight(package);

                    if(priceByDimensions >= priceByWeight)
                    {
                        package.Cost = priceByDimensions;
                    }
                    else
                    {
                        package.Cost = priceByWeight;
                    }

                    return View(package);
                }
            }
            if(package.Courier.ToLower() == "shipfaster")
            {
                var check = _shipFaster.ValidationCheck(package.Weight, package.cubicCM);
                if(check == false)
                {
                    ViewBag.Message = "This Courier Doesn't allow this size package";
                }              
                else
                {
                    ViewBag.Cargo = dropDown;
                    ViewBag.Message = "Successfull";
                    var priceByDimensions = _shipFaster.BasedOnDimensions(package);
                    var priceByWeight = _shipFaster.BasedOnWeight(package);

                    if(priceByDimensions >= priceByWeight)
                    {
                        package.Cost = priceByDimensions;
                    }
                    else
                    {
                        package.Cost = priceByWeight;
                    }

                    return View(package);
                }
            }
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private List<SelectListItem> DropDown()
        {
            List<SelectListItem> selectList = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Text = "Select Cargo",
                    Value = "No Selected"
                }
            };
            List<string> cargoList = new List<string>();
            cargoList.Add("Cargo4You");
            cargoList.Add("ShipFaster");
            cargoList.Add("MaltaShip");

            foreach(var cargo in cargoList)
            {
                selectList.Add(new SelectListItem
                    {
                        Text = cargo,
                        Value = cargo
                    }
                );
            }

            return selectList;
        }
    }
}
