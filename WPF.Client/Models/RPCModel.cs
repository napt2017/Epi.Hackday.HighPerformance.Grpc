using System.Windows;

namespace WPF.Client.Models
{
    public class RPCModel: DependencyObject
    {
        public string RemoteUrl { get; set; }
        public int Port { get; set; }
        public string Image { get; set; }
        public string Type { get; set; }
        public string AvatarPath { get; set; }

        public int TransferDataSize
        {
            get { return (int)this.GetValue(TransferDataSizeProperty); }
            set { this.SetValue(TransferDataSizeProperty, value); }
        }
        public static readonly DependencyProperty TransferDataSizeProperty = DependencyProperty.Register(
          "TransferDataSize", typeof(int), typeof(RPCModel), new PropertyMetadata(0));

        public long TotalExecutionTime
        {
            get { return (long)this.GetValue(TotalExecutionTimeProperty); }
            set { this.SetValue(TotalExecutionTimeProperty, value); }
        }
        public static readonly DependencyProperty TotalExecutionTimeProperty = DependencyProperty.Register(
          "TotalExecutionTime", typeof(long), typeof(RPCModel), new PropertyMetadata(0L));
    }
}
