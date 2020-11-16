using DB.Access.Entities;
using System.Collections.Generic;

namespace DB.Access.Repositories
{
    public interface IEpiHackdayRepository
    {
        void AddTopic(HackdayTopic topic);
        HackdayTopic GetTopic(int id);
        IEnumerable<HackdayTopic> GetAll();
        bool RemoveTopic(int id);
        void UpdateTopic(HackdayTopic topic);

        void AddTopics(params HackdayTopic[] hackdayTopics);
    }

    public class EpiHackdayRepository : IEpiHackdayRepository
    {
        private readonly EpiHackdayDbContext _dbContext;

        public EpiHackdayRepository(EpiHackdayDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public void AddTopic(HackdayTopic topic)
        {
            _dbContext.HackdayTopics.Add(topic);
            _dbContext.SaveChanges();
        }

        public void AddTopics(params HackdayTopic[] hackdayTopics)
        {
            foreach (var topic in hackdayTopics)
            {
                _dbContext.HackdayTopics.Add(topic);
            }
            _dbContext.SaveChanges();
        }

        public IEnumerable<HackdayTopic> GetAll()
        {
            return _dbContext.HackdayTopics;
        }

        public HackdayTopic GetTopic(int id)
        {
            return _dbContext.HackdayTopics.Find(id);
        }

        public bool RemoveTopic(int id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateTopic(HackdayTopic topic)
        {
            throw new System.NotImplementedException();
        }
    }
}
