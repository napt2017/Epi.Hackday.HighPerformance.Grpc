using DB.Access;
using DB.Access.Entities;
using DB.Access.Repositories;
using Grpc.Net.Client;
using GRPC.Server;
using Microsoft.EntityFrameworkCore;
using System; 
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
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
            //LoadAllTopic(topicRepository); 

            // Import topic
            //ImportTopicFromFile(topicRepository);
            //CallGrpc();
            //CallRest();
            ComputeXmlSize();
            Console.Read();
        }

        static void ComputeXmlSize(string path= @"C:\Users\ngan\Desktop\hack-day-topics.xml")
        {
            var xmlString = File.ReadAllText(path);
            Console.WriteLine($"Size on bytes: {System.Text.Encoding.UTF8.GetBytes(xmlString).Length}");
        }


        static void CallRest()
        {
            using var wc = new WebClient();
            var jsonData = wc.DownloadString("https://localhost:5001/EpiHackday");
            Console.WriteLine(jsonData);
            var totalSize = System.Text.Encoding.UTF8.GetBytes(jsonData).Length;
            Console.WriteLine($"=======================TOTAL SIZE: {totalSize}========================");
        }

        static void CallGrpc()
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new EpiHackdayTopicService.EpiHackdayTopicServiceClient(channel);
            var allTopic = client.GetAllTopic(new Empty());
            var totalSize = 0;
            foreach (var topic in allTopic.HackdayTopics)
            {
                totalSize += topic.CalculateSize();
                Console.WriteLine($"Name: {topic.Name} --Author:{topic.Author} --Office: {topic.Office}");
            }

            Console.WriteLine($"=======================TOTAL SIZE: {totalSize}========================");
        }

        static void ImportTopicFromFile(IEpiHackdayRepository epiHackdayRepository, string jsonFilePath = "data.json")
        {
            var jsonContent = File.ReadAllText(jsonFilePath);
            var epiHackDayTopics = JsonSerializer.Deserialize<DB.Access.Entities.HackdayTopic[]>(jsonContent, new JsonSerializerOptions 
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
            var topic = new DB.Access.Entities.HackdayTopic
            {
                Author = "NgocAnh.Nguyen",
                CreatedTime = DateTime.Now,
                Name = "High Performance -GRPC in .NET 5.0"
            };
            epiHackdayRepository.AddTopic(topic);
            Console.WriteLine($"New insert topic id: {topic.Id}");
        }
    }

    class SerializationSizer : System.IO.Stream
    {
        private int totalSize;
        public override void Write(byte[] buffer, int offset, int count)
        {
            this.totalSize += count;
        }

        public override bool CanRead
        {
            get { return false; }
        }

        public override bool CanSeek
        {
            get { return false; }
        }

        public override bool CanWrite
        {
            get { return true; }
        }

        public override void Flush()
        {
            // Nothing to do
        }

        public override long Length
        {
            get { return totalSize; }
        }

        public override long Position
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        public override long Seek(long offset, System.IO.SeekOrigin origin)
        {
            throw new NotImplementedException();
        }

        public override void SetLength(long value)
        {
            throw new NotImplementedException();
        }
    }
}
