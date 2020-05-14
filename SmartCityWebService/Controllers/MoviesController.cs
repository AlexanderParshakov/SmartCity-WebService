using SmartCityDataAccess.DataAccess;
using SmartCityDataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace SmartCityWebService.Controllers
{
    public class MoviesController : ApiController
    {
        [HttpGet]
        [Route("api/Movies/")]
        public List<DTOEvent> Get()
        {
            return Repository.GetMovies();
        }
    }
}