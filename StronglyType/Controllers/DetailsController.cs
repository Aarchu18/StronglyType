using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StronglyType.Models.SportsModel;

namespace StronglyType.Controllers
{
    public class DetailsController : Controller
    {
        public IActionResult Index()
        {
            ArrayList sportData = getData();

            return View(sportData);

        }
        public ArrayList getData()
        {
            SportsData data = new SportsData();
            return data.getData();
        }


    }
}
    
