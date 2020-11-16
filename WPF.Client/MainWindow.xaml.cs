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
            mainGridLayout.ShowGridLines = true;
            mainGridLayout.ColumnDefinitions.Add(new ColumnDefinition());
            mainGridLayout.ColumnDefinitions.Add(new ColumnDefinition());

            mainGridLayout.RowDefinitions.Add(new RowDefinition());
            mainGridLayout.RowDefinitions.Add(new RowDefinition());

            var rpcComponent = new RPCComponent();
            mainGridLayout.Children.Add(rpcComponent);
            Grid.SetRow(rpcComponent, 0);
            Grid.SetColumn(rpcComponent, 0);

            rpcComponent = new RPCComponent();
            mainGridLayout.Children.Add(rpcComponent);
            Grid.SetRow(rpcComponent, 0);
            Grid.SetColumn(rpcComponent, 1);

            rpcComponent = new RPCComponent();
            mainGridLayout.Children.Add(rpcComponent);
            Grid.SetRow(rpcComponent, 1);
            Grid.SetColumn(rpcComponent, 0);

            rpcComponent = new RPCComponent();
            mainGridLayout.Children.Add(rpcComponent);
            Grid.SetRow(rpcComponent, 1);
            Grid.SetColumn(rpcComponent, 1);
        }
    }
}
