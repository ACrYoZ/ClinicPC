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
    /// Логика взаимодействия для AppendRecord.xaml
    /// </summary>
    public partial class AppendRecord : Window
    {
        string url = "http://myclinic.ddns.net:8080/Code/add_userdiagnosis.php";

        public AppendRecord()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Tb_Patient.Text = DataValue.Value;
            Tb_Date.Text = DataValue.Date;

            Rb_No.IsChecked = true;
        }


        private void Record_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Rb_Yes.IsChecked == true)
                {
                    DataValue.RadioButton = "1";
                }
                else
                {
                    DataValue.RadioButton = "0";
                }

                string SetcurrentDate = DateTime.Now.ToString();
                string OnlyDate = SetcurrentDate.Substring(0, SetcurrentDate.Length - 8);
                string currentDate = OnlyDate.Replace(".", "-");
                currentDate = string.Join("-", currentDate.Split(new char[] { '-' }).Reverse()); 

                string Answer = new WebClient().DownloadString(url + "?date=" + Tb_Date.Text + "&diagnosis=" + Tb_Diagnos.Text + "&medication=" + Tb_Medication.Text + "&passed=" +
                    DataValue.RadioButton + "&currentDate=" + currentDate);

                DoctorWindows d = this.Owner as DoctorWindows;
                d.update_datagrid();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
