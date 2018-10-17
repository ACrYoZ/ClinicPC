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
using System.Windows.Shapes;

namespace Clinic
{
    /// <summary>
    /// Логика взаимодействия для Verification.xaml
    /// </summary>
    public partial class Verification : Window
    {
        public Verification()
        {
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_Yes_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UserRequest u = this.Owner as UserRequest;
                u.Inquiry();
                u.update_datagrid();
                this.Close();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
