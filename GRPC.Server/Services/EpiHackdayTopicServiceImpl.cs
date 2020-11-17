using DB.Access.Repositories;
using Grpc.Core;
using System.Threading.Tasks;
using System.Linq;

namespace GRPC.Server.Services
{
    public class EpiHackdayTopicServiceImpl : EpiHackdayTopicService.EpiHackdayTopicServiceBase
    {
        private readonly IEpiHackdayRepository _epiHackdayRepository;

        public EpiHackdayTopicServiceImpl(IEpiHackdayRepository epiHackdayRepository)
        {
            _epiHackdayRepository = epiHackdayRepository;
        }

        public override Task<AllHackdayTopic> GetAllTopic(Empty request, ServerCallContext context)
        { 
            var allHackDayTopic = new AllHackdayTopic();
            allHackDayTopic.HackdayTopics.Add(_epiHackdayRepository.GetAll().Select(it => new HackdayTopic
            {
                Author = it.Author,
                CreatedTime = it.CreatedTime.ToString(),
                Name = it.Name,
                Office = it.Office
            }));
            return Task.FromResult(allHackDayTopic);
        }

        public override Task GetAllTopicStream(Empty request, IServerStreamWriter<HackdayTopic> responseStream, ServerCallContext context)
        {
            return base.GetAllTopicStream(request, responseStream, context);
        }
    }
}
