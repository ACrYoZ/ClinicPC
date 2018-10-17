using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для AlterDoctors.xaml
    /// </summary>
    public partial class AlterDoctors : Window
    {
        public AlterDoctors()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Tb_Email.Text = DoctorsData.Email;
            Tb_Surname.Text = DoctorsData.Surname;
            Tb_Name.Text = DoctorsData.Name;
            Tb_Patronymic.Text = DoctorsData.Patronymic;
            Tb_Phone.Text = DoctorsData.PhoneNumber;
            Tb_Passport.Text = DoctorsData.PassportNumber;
            Tb_Parlor.Text = DoctorsData.Parlor;

            Load();
         
        }

        private void Load()
        {
            ParserJSON pj = new ParserJSON();
            
            string result = pj.GetLoadDoctors();
            LoadDoctorsObject ld = JsonConvert.DeserializeObject<LoadDoctorsObject>(result);
            var about = ld.doctors[0];
            var login = ld.doctors[0];
            var id = ld.doctors[0];
            DoctorsData.Id = id._id;
            Tb_Description.Text = about.about;
            Tb_Email.Text = login.login;

        }

        

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_Alter_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string Answer = new WebClient().DownloadString(DataValue.Url + "Code/alter_doctors.php?Email=" +
                 Tb_Email.Text + "&Id=" + DoctorsData.Id + "&Surname=" + Tb_Surname.Text + "&Name=" + Tb_Name.Text
                 + "&Patronymic=" + Tb_Patronymic.Text + "&Phone=" + Tb_Phone.Text + "&Passport=" +
                 Tb_Passport.Text + "&Parlor=" + Tb_Parlor.Text + "&Description=" + Tb_Description.Text);

                HeadPhysicianWindows h = this.Owner as HeadPhysicianWindows;
                h.update_datagrid();

                this.Close();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
