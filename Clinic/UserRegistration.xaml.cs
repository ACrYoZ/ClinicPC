using Microsoft.Win32;
using Newtonsoft.Json;
using System;
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
    /// Логика взаимодействия для UserRegistration.xaml
    /// </summary>
    public partial class UserRegistration : Window
    {
        public string url = "http://myclinic.ddns.net:8080/Code/";
        public string fileName;


        public UserRegistration()
        {
            InitializeComponent();
        }

        private void Img_Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            label_images.Visibility = Visibility.Hidden;
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            var encoder = new PngBitmapEncoder();
            if (ofd.ShowDialog(this) == true)
            {
                try
                {   //Получение расширение файла
                    string ext = System.IO.Path.GetExtension(ofd.FileName);

                    fileName = System.IO.Path.GetFileNameWithoutExtension(ofd.FileName);
                    image.Source = new BitmapImage(new Uri(ofd.FileName, UriKind.Absolute));

                    UploadImage(fileName + ext);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //Сохранение картинки, загрузка на сервер
        private void UploadImage(string fileToUpload)
        {
            if (image.Source != null)
            {
                var encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create((BitmapSource)image.Source));
                using (FileStream fstream = new FileStream(fileToUpload, FileMode.Create))
                    encoder.Save(fstream);
            }

            System.Net.WebClient Client = new System.Net.WebClient();
            Client.Headers.Add("Content-Type", "binary/octet-stream");

            byte[] result = Client.UploadFile(url + "upload.php", "POST", fileToUpload);
            File.Delete(fileToUpload);
        }

        private void Input_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var mailValidate = new System.Net.Mail.MailAddress(Tb_Mail.Text);
                if (Tb_Mail.Text == mailValidate.Address)
                {

                    string images = "http://myclinic.ddns.net:8080/" + "files/" + fileName + ".jpg";

                    string Answer = new WebClient().DownloadString(url + "add_userregistration.php?mail=" + Tb_Mail.Text + "&password=" + Tb_Password.Text + "&surname=" + Tb_Surname.Text + "&name=" +
                     Tb_Name.Text + "&patronymic=" + Tb_Patronymic.Text + "&age=" + Tb_Age.Text + "&adress=" + Tb_Adress.Text + "&phone=" + Tb_Number.Text + "&passport=" + Tb_Passport.Text + "&images=" + images);

                    RegistryWindows r = this.Owner as RegistryWindows;
                    r.update_datagrid();

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message + " Возможно некоторые поля не заполнены.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Bt_Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
