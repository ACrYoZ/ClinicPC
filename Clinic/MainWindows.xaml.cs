using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
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


namespace Clinic
{
    /// <summary>
    /// Логика взаимодействия для MainWindows.xaml
    /// </summary>
    public partial class MainWindows : Window
    {
        public MainWindows()
        {
            try
            {
                InitializeComponent();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Enter_Click(object sender, RoutedEventArgs e)
        {
            try {
           
            DataValue.Url = "http://myclinic.ddns.net:8080/Code/";
            Encoding source = Encoding.Unicode;
            Encoding win1251 = Encoding.GetEncoding(1251);

            RegistryWindows rw = new RegistryWindows();
            HeadPhysicianWindows hp = new HeadPhysicianWindows();
            DoctorWindows dw = new DoctorWindows();
            AdminWindows aw = new AdminWindows();
            string Answer = new WebClient().DownloadString(DataValue.Url + "login.php?login=" + Tb_Mail.Text + "&password=" + Tb_Password.Password.ToString());

       
            //Преобразование полученого текста в win1251
            byte[] win1251Bytes = Encoding.Convert(source, win1251, source.GetBytes(Answer));
            string str = Encoding.UTF8.GetString(win1251Bytes, 0, win1251Bytes.Length);
            

            string login = Tb_Mail.Text;
            string password = Tb_Password.Password.ToString();
            DataValue.Login = login;
            DataValue.Position = str;

            if(login == "admin@ya.ru"&& password == "admin")
            {
                aw.Show();
                this.Close();
            }
               else if (login == "registry@ya.ru" && password == "registry")
                {
                    rw.Show();
                    this.Close();
                }
                else {
                    switch (str.ToLower())
                    {
                        case "главврач":
                            {
                                hp.Show();
                                this.Close();
                                break;
                            }
                        case "хирург":
                            {
                                dw.Show();
                                this.Close();
                                break;
                            }
                        case "окулист":
                            {
                                dw.Show();
                                this.Close();
                                break;
                            }
                        case "login empty":
                            {
                                Tb_Mail.BorderBrush = System.Windows.Media.Brushes.Red;
                                Tb_Password.BorderBrush = System.Windows.Media.Brushes.Gray;
                                MessageBox.Show("Не введен логин");
                                break;
                            }
                        case "password empty":
                            {
                                Tb_Mail.BorderBrush = System.Windows.Media.Brushes.Gray;
                                Tb_Password.BorderBrush = System.Windows.Media.Brushes.Red;
                                MessageBox.Show("Не введен пароль");
                                break;
                            }
                        case "empty":
                            {
                                Tb_Mail.BorderBrush = System.Windows.Media.Brushes.Red;
                                Tb_Password.BorderBrush = System.Windows.Media.Brushes.Red;
                                MessageBox.Show("Поля пустые");
                                break;
                            }
                        case "":
                            {
                                Tb_Mail.BorderBrush = System.Windows.Media.Brushes.Red;
                                Tb_Password.BorderBrush = System.Windows.Media.Brushes.Red;
                                MessageBox.Show("Введен неверный логин или пароль");
                                break;
                            }
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      
    }
}
