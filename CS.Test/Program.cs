using DB.Access;
using DB.Access.Entities;
using DB.Access.Repositories;
using Microsoft.EntityFrameworkCore;
using System; 
using System.IO;
using System.Linq;
using System.Text.Json;

namespace CS.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContextOption = new DbContextOptionsBuilder<EpiHackdayDbContext>().UseSqlite("Data Source=D:\\db\\hackday.db").Options;
            var dbContext       = new EpiHackdayDbContext(dbContextOption);
            var topicRepository = new EpiHackdayRepository(dbContext);

            // Insert new topic
            //InsertNewTopic(topicRepository);

            // Load all topic
            LoadAllTopic(topicRepository); 

            // Import topic
            //ImportTopicFromFile(topicRepository);
            Console.Read();
        }

        static void ImportTopicFromFile(IEpiHackdayRepository epiHackdayRepository, string jsonFilePath = "data.json")
        {
            var jsonContent = File.ReadAllText(jsonFilePath);
            var epiHackDayTopics = JsonSerializer.Deserialize<HackdayTopic[]>(jsonContent, new JsonSerializerOptions 
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            epiHackdayRepository.AddTopics(epiHackDayTopics);
            Console.WriteLine("Ok");
        }

        static void LoadAllTopic(IEpiHackdayRepository epiHackdayRepository)
        {
            epiHackdayRepository.GetAll().ToList().ForEach(it =>
            {
                Console.WriteLine($"Id: {it.Id} -Name: {it.Name} -Author: {it.Author} -Created At: {it.CreatedTime}");
            });
        }

        static void InsertNewTopic(IEpiHackdayRepository epiHackdayRepository)
        {
            var topic = new HackdayTopic
            {
                Author = "NgocAnh.Nguyen",
                CreatedTime = DateTime.Now,
                Name = "High Performance -GRPC in .NET 5.0"
            };
            epiHackdayRepository.AddTopic(topic);
            Console.WriteLine($"New insert topic id: {topic.Id}");
        }
    }
}
