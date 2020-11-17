namespace WPF.Client.Models
{
    public class RPCModel
    {
        public string RemoteUrl { get; set; }
        public int Port { get; set; }
        public string Image { get; set; }
        public int TransferDataSize { get; set; }
        public int TotalExecutionTime { get; set; }
        public string Type { get; set; }
    }
}
