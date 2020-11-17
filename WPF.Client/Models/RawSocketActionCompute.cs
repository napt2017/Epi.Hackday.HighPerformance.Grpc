using System.Threading.Tasks;
using WPF.Client.Commons;

namespace WPF.Client.Models
{
    public class RawSocketActionCompute :IActionComputable
    {
        public async Task<(long, int)> ExecuteThenComputeAsync(string url)
        {
            return await Task.FromResult((1L, 100));
        }
    }
}
