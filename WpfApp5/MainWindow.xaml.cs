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
            lstbx1.HorizontalAlignment = HorizontalAlignment.Left;
            lstbx1.Items.Add("\n");
            lstbx1.Items.Add(new Message
            {
                Text = ChatTxtBox.Text,
                time = DateTime.Now.ToShortTimeString()
            });



            if (ChatTxtBox.Text == "Salam" || ChatTxtBox.Text == "salam")
            {
                lstbx2.HorizontalAlignment = HorizontalAlignment.Right;
                lstbx2.Items.Add("\n");
                lstbx2.Items.Add(AIservice.GetResponseSalam());
            }
            else if(ChatTxtBox.Text== "Necesen?" || ChatTxtBox.Text == "necesen?"|| ChatTxtBox.Text == "Necesen" || ChatTxtBox.Text == "necesen")
            {
                lstbx2.HorizontalAlignment = HorizontalAlignment.Right;
                lstbx2.Items.Add("\n");
                lstbx2.Items.Add(AIservice.GetResponseNecesen());
            }
            else if (ChatTxtBox.Text == "Hardasan?" || ChatTxtBox.Text == "hardasan?" || ChatTxtBox.Text == "hardasan" || ChatTxtBox.Text == "hardasan")
            {
                lstbx2.HorizontalAlignment = HorizontalAlignment.Right;
                lstbx2.Items.Add("\n");
                lstbx2.Items.Add(AIservice.GetResponseHardasan());
            }
            else if (ChatTxtBox.Text != String.Empty)
            {
                lstbx2.HorizontalAlignment = HorizontalAlignment.Right;
                lstbx2.Items.Add("\n");
                lstbx2.Items.Add(AIservice.GetResponseVeS());
            }


            ChatTxtBox.Text = String.Empty;
        }
    }
}
