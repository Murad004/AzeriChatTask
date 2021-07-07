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

namespace WpfApp5
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
        private void SendBtn_Click(object sender, RoutedEventArgs e)
        {
            lstbx.HorizontalAlignment = HorizontalAlignment.Left;
            lstbx.Items.Add(new Message
            {
                Text = ChatTxtBox.Text,
                time = DateTime.Now.ToShortTimeString()
            });



            if (ChatTxtBox.Text == "Salam" || ChatTxtBox.Text == "salam")
            {
                lstbx.HorizontalAlignment = HorizontalAlignment.Right;
                lstbx.Items.Add("\n");
                lstbx.Items.Add(AIservice.GetResponseSalam());
            }


            ChatTxtBox.Text = String.Empty;
        }
    }
}
