using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Clinic
{
    /// <summary>
    /// Логика взаимодействия для ChangePassword.xaml
    /// </summary>
    public partial class ChangePassword : Window
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string Answer = new WebClient().DownloadString(DataValue.Url + "change_password.php?login=" + DataValue.Login + "&password=" + textBox.Text);
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
