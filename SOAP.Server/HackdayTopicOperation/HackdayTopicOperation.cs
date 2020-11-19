using DB.Access.Entities;
using DB.Access.Repositories;
using SOAP.Server.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SOAP.Server.HackdayTopicOperation
{
    public class HackdayTopicOperation : IHackdayTopicOperation
    {
        private readonly IEpiHackdayRepository _epiHackdayRepository;

        public HackdayTopicOperation(IEpiHackdayRepository epiHackdayRepository)
        {
            _epiHackdayRepository = epiHackdayRepository;
        }

        public List<HackdayTopic> GetAllHackdayTopic()
        {
            return _epiHackdayRepository.GetAll().ToList();
        }
    }
}
