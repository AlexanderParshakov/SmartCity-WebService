using SmartCityDataAccess.DataAccess;
using SmartCityDataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Web.Http;

namespace SmartCityWebService.Controllers
{
    public class BuildingsController : ApiController
    {
        [HttpGet]
        [Route("api/Buildings")]
        public DTOBuilding GetById(int id)
        {
            return Repository.GetBuildingById(id);
        }
    }
}