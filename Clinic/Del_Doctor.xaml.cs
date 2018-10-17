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
    /// Логика взаимодействия для Del_Doctor.xaml
    /// </summary>
    public partial class Del_Doctor : Window
    {
        public Del_Doctor()
        {
            InitializeComponent();
        }

        private void Btn_Del_Click(object sender, RoutedEventArgs e)
        {
            try{
                string passport = Tb_PassportNumber.Text;
                string Answer = new WebClient().DownloadString(DataValue.Url + "Code/del_doctors.php?" + "passportNumber=" + passport);

                HeadPhysicianWindows h = this.Owner as HeadPhysicianWindows;
                h.update_datagrid();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
