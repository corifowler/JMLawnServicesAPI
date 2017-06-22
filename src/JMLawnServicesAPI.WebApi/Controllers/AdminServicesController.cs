using Microsoft.AspNetCore.Mvc;
using JMLawnServicesAPI.Business;
using DTO = JMLawnServicesAPI.Business.Models;
using System.Collections.Generic;
using JMLawnServicesAPI.Data;
using System.Linq;


namespace JMLawnServicesAPI.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class AdminServicesController : Controller
    {
        private IAdminServices _adminServices;

        public AdminServicesController(IAdminServices adminServices)
        {
            _adminServices = adminServices;
        }

        [HttpGet]
        [Route("test")]
        public string GetTest()
        {
            return "Look Ma, my second pizza service!";
        }

       //Get Location
       [HttpGet]
       [Route("estimate/{estimateId}")]
       public DTO.Location GetEstimate(int estimateId)
       {
           var estimate = _adminServices.GetEstimate(estimateId);

           return estimate;
       }

       //Create Estimate
       [HttpPost]
       [Route("estimate/{newEstimate}")]
       public DTO.Estimate CreateEstimate(DTO.Estimate newEstimate)
       {
           var estimate = _adminServices.CreateEstimate(newEstimate);
           var estimate2 = _adminServices.GetEstimate(estimate.estimateId);

           return estimate2;
       }

    
    }
}