using System.Windows.Controls;
using WPF.Client.Commons;
using WPF.Client.Models;

namespace WPF.Client
{
    /// <summary>
    /// Interaction logic for RPCComponent.xaml
    /// </summary>
    public partial class RPCComponent : UserControl
    {
        private readonly RPCModel _rPCModel;
        private readonly IActionComputable _actionComputable;

        public RPCComponent(RPCModel rPCModel, IActionComputable actionComputable)
        {
            _rPCModel = rPCModel;
            _actionComputable = actionComputable;
            this.DataContext = rPCModel;
            InitializeComponent();
        }

        private async void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var (totalExecutionTime, responseSize) = await _actionComputable.ExecuteThenComputeAsync("");
            this._rPCModel.TotalExecutionTime = totalExecutionTime;
            this._rPCModel.TransferDataSize = responseSize;
        }
    }
}
