using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExternalService.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace ExternalService.Controllers
{
    public class ExternalServiceMVCController : Controller, IExternalService
    {
        public ComplexDataType GetComplexData()
        {
            return new ComplexDataType {IntData = 7, StingData = "seven" };
        }

        public ComplexDataType GetComplexDataWithParameter(ComplexDataType complexParameter)
        {
            return complexParameter;
        }

        public string GetSimpleData()
        {
            return "five";
        }

        public string GetSimpleDataWithParameter(string simpleParameter)
        {
            return simpleParameter;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}