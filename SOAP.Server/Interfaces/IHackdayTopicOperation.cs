using DB.Access.Entities;
using System.Collections.Generic;
using System.ServiceModel;

namespace SOAP.Server.Interfaces
{
    [ServiceContract]
    public interface IHackdayTopicOperation
    {
        [OperationContract]
        List<HackdayTopic> GetAllHackdayTopic();
    }
}
