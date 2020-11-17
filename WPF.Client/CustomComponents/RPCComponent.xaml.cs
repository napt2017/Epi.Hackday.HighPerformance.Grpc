using System.Windows.Controls;
using WPF.Client.Models;

namespace WPF.Client
{
    /// <summary>
    /// Interaction logic for RPCComponent.xaml
    /// </summary>
    public partial class RPCComponent : UserControl
    {
        private readonly RPCModel _rPCModel;

        public RPCComponent(RPCModel rPCModel)
        {
            _rPCModel = rPCModel;
            this.DataContext = rPCModel;
            InitializeComponent();
        }
    }
}
