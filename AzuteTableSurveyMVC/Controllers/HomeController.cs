﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using RadioDb.Repository;

namespace AzuteTableSurveyMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public async Task<ActionResult> SurveyQuetions()
        {
            var data = await SurveyQuetionRepository.Instance.Read(1);
            return View(data);
        }

        public class Test
        {
            public string test1 { get; set; }
            public string test2 { get; set; } 
        }

        [HttpPost]
        public async Task<ActionResult> SurveyQuetions(Test test)
        {
            var data = await SurveyQuetionRepository.Instance.Read(1);
            return View(data);
        }
    }
}