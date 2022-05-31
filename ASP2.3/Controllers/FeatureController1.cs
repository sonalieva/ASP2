using ASP2._3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP2._3.Controllers
{
    public class FeatureController1 : Controller
    {
        public List<Feature> features = new List<Feature>
        {
          new Feature {Id = 1, Title="Lorem Ipsum",Icon="bi bi-card-checklist",Descrition="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"  },
          new Feature {Id = 2, Title="Dolor Sitema", Icon="bi bi-bar-chart",Descrition="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"},
          new Feature {Id = 3, Title="Lorem Ipsumm",Icon="bi bi-binoculars",Descrition="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"},


        };
        public IActionResult Detail(int id)
        {
            Feature feature = features.Find(x => x.Id == id);
            ViewBag.feature = feature;
            return View();
        }
    }
}
