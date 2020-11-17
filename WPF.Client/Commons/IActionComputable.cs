using System.Threading.Tasks;

namespace WPF.Client.Commons
{
    public interface IActionComputable
    {
        Task<(long, int)> ExecuteThenComputeAsync(string url);
    }
}
