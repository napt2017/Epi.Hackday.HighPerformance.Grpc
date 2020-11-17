using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF.Client.Models;

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
            //mainGridLayout.ShowGridLines = true;
            mainGridLayout.ColumnDefinitions.Add(new ColumnDefinition());
            mainGridLayout.ColumnDefinitions.Add(new ColumnDefinition());

            mainGridLayout.RowDefinitions.Add(new RowDefinition());
            mainGridLayout.RowDefinitions.Add(new RowDefinition());

            var rpcComponent = new RPCComponent(new Models.RPCModel 
            {
                Type = "Raw Socket Connection",
                RemoteUrl="127.0.0.1",
                Port = 1989
            }, new RawSocketActionCompute());

            mainGridLayout.Children.Add(rpcComponent);
            Grid.SetRow(rpcComponent, 0);
            Grid.SetColumn(rpcComponent, 0);

            rpcComponent = new RPCComponent(new Models.RPCModel
            {
                Type = "REST API",
                RemoteUrl="https://localhost:1990",
                Port = 1990
            }, new RestApiActionCompute());
            mainGridLayout.Children.Add(rpcComponent);
            Grid.SetRow(rpcComponent, 0);
            Grid.SetColumn(rpcComponent, 1);

            rpcComponent = new RPCComponent(new Models.RPCModel
            {
                Type = "SOAP WebService",
                RemoteUrl ="https://localhost:1991",
                Port = 1991
            }, new SoapApiActionCompute());
            mainGridLayout.Children.Add(rpcComponent);
            Grid.SetRow(rpcComponent, 1);
            Grid.SetColumn(rpcComponent, 0);

            rpcComponent = new RPCComponent(new Models.RPCModel
            {
                Type = "GRPC Service",
                RemoteUrl = "https://localhost:2021",
                Port = 2021
            }, new GrpcActionCompute());
            mainGridLayout.Children.Add(rpcComponent);
            Grid.SetRow(rpcComponent, 1);
            Grid.SetColumn(rpcComponent, 1);
        }
    }
}
