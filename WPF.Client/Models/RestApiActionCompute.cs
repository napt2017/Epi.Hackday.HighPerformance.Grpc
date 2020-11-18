using System;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;
using System.Text;
using WPF.Client.Commons;

namespace WPF.Client.Models
{
    public class RestApiActionCompute : IActionComputable
    {
        public async Task<(long, int)> ExecuteThenComputeAsync(string url)
        {
            var stopwatch = Stopwatch.StartNew();
            using var wc = new WebClient();
            var response = await wc.DownloadStringTaskAsync(url);
            stopwatch.Stop();
            return await Task.FromResult((stopwatch.ElapsedMilliseconds, Encoding.UTF8.GetBytes(response).Length));
        }
    }
}
