using ASP2._3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP2._3.Controllers
{
    public class HomeController : Controller
    {
        private List<Service> services = new List<Service>
        {
            new Service { Id = 1, Title ="Lorem Ipsum", Descrition="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi" , Icon="bx bxl-dribbble"},
            new Service { Id = 2, Title ="Sed ut perspiciatis", Descrition="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi", Icon="bx bx-file"},
            new Service { Id = 3, Title ="Magni Dolores", Descrition="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi" , Icon="bx bx-tachometer"},
            new Service { Id = 4, Title ="Nemo Enim", Descrition="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi" , Icon="bx bx-world"},
            new Service { Id = 5, Title ="Dele cardo", Descrition="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi" , Icon="bx bx-slideshow"},
            new Service { Id = 6, Title ="Divera don", Descrition="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi" , Icon="bx bx-arch"}




        };
        public List<Feature> features = new List<Feature>
        {
          new Feature {Id = 1, Title="Lorem Ipsum",Descrition="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident", Icon="bi bi-card-checklist"},
          new Feature {Id = 2, Title="Dolor Sitema",Descrition="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident", Icon="bi bi-card-checklist", Icon="bi bi-bar-chart"},
          new Feature {Id = 3, Title="Sed ut perspiciatis",Descrition="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident", Icon="bi bi-card-checklist", Icon="bi bi-binoculars"},


        };
        public IActionResult Index()
        {
            ViewBag.Service = services;
            ViewBag.Feature = features;
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Service()
        {
            ViewBag.Service = services;
            return View();
        }
        public IActionResult Detail(int id)
        {
            Service service = services.Find(x => x.Id == id);
            ViewBag.Service = service;
            Feature feature = features.Find(x => x.Id == id);
            ViewBag.Feature = feature;
            return View();
        }
    }
}
