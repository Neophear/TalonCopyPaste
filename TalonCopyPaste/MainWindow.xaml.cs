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

namespace TalonCopyPaste
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AllianceNoWarmode(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText("Atalonfarmer-Shadowsong");
        }

        private void AllianceWarmode(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText("Aptalonfarm-Shadowsong");
        }

        private void HordeNoWarmode(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText("Htalonfarmer-Shadowsong");
        }

        private void HordeWarmode(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText("Hptalonfarm-Shadowsong");
        }
    }
}
