using System.Windows;
using System.Windows.Controls;
using WPF.Client.Models;
using System.IO;


namespace WPF.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitGridLayout();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void InitGridLayout()
        {
            var currentDirectory = Directory.GetCurrentDirectory();

            //mainGridLayout.ShowGridLines = true;
            mainGridLayout.ColumnDefinitions.Add(new ColumnDefinition());
            mainGridLayout.ColumnDefinitions.Add(new ColumnDefinition());

            mainGridLayout.RowDefinitions.Add(new RowDefinition());
            mainGridLayout.RowDefinitions.Add(new RowDefinition());

            var rpcComponent = new RPCComponent(new Models.RPCModel 
            {
                Type = "Raw Socket Connection",
                RemoteUrl="127.0.0.1",
                Port = 1989,
                AvatarPath = Path.Combine(currentDirectory, "Resources","raw-socket-icon.png")
            }, new RawSocketActionCompute());

            mainGridLayout.Children.Add(rpcComponent);
            Grid.SetRow(rpcComponent, 0);
            Grid.SetColumn(rpcComponent, 0);

            // Add layout area for REST api call
            rpcComponent = new RPCComponent(new Models.RPCModel
            {
                Type = "REST API",
                RemoteUrl = "https://localhost:1990/EpiHackday",
                Port = 1990,
                AvatarPath = Path.Combine(currentDirectory, "Resources", "rest-icon.png")
            }, new RestApiActionCompute()) ;
            mainGridLayout.Children.Add(rpcComponent);
            Grid.SetRow(rpcComponent, 0);
            Grid.SetColumn(rpcComponent, 1);

            rpcComponent = new RPCComponent(new Models.RPCModel
            {
                Type = "SOAP WebService",
                RemoteUrl ="https://localhost:1991",
                Port = 1991,
                AvatarPath = Path.Combine(currentDirectory, "Resources", "soap-icon.png")
            }, new SoapApiActionCompute());
            mainGridLayout.Children.Add(rpcComponent);
            Grid.SetRow(rpcComponent, 1);
            Grid.SetColumn(rpcComponent, 0);

            // Add layout area for GRPC Service
            rpcComponent = new RPCComponent(new Models.RPCModel
            {
                Type = "GRPC Service",
                RemoteUrl = "https://localhost:1992",
                Port = 1992,
                AvatarPath = Path.Combine(currentDirectory, "Resources", "grpc-icon.png")
            }, new GrpcActionCompute());
            mainGridLayout.Children.Add(rpcComponent);
            Grid.SetRow(rpcComponent, 1);
            Grid.SetColumn(rpcComponent, 1);
        }
    }
}
