using DB.Access.Entities;
using DB.Access.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace REST.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EpiHackdayController : ControllerBase
    {
        private readonly IEpiHackdayRepository _epiHackdayRepository;

        public EpiHackdayController(IEpiHackdayRepository epiHackdayRepository)
        {
            _epiHackdayRepository = epiHackdayRepository;
        }

        [HttpGet]
        public IEnumerable<HackdayTopic> Get()
        {
            return _epiHackdayRepository.GetAll();
        }
    }
}
