using Grpc.Net.Client;
using System.Diagnostics;
using System.Threading.Tasks;
using WPF.Client.Commons;

namespace WPF.Client.Models
{
    public class GrpcActionCompute : IActionComputable
    {
        public async Task<(long, int)> ExecuteThenComputeAsync(string url)
        {
            var stopwatch = Stopwatch.StartNew();
            using var channel = GrpcChannel.ForAddress(url);
            var client = new GRPC.Server.EpiHackdayTopicService.EpiHackdayTopicServiceClient(channel);
            var allTopic = client.GetAllTopic(new GRPC.Server.Empty());
            var totalSize = 0;
            foreach (var topic in allTopic.HackdayTopics)
            {
                totalSize += topic.CalculateSize();
            }
            stopwatch.Stop();
            return await Task.FromResult((stopwatch.ElapsedMilliseconds, totalSize));
        }
    }
}
