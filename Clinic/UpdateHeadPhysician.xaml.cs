using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
using System.Drawing.Imaging;
using System.Net;
using Newtonsoft.Json;

namespace Clinic
{
    public partial class UpdateHeadPhysician : Window
    {
        public string url = "http://myclinic.ddns.net:8080/Code/";
        public string fileName;
        string ext;

        public UpdateHeadPhysician()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Cвязывание ComboBox c Position
            ParserJSON pj = new ParserJSON();
            string resultPosition = pj.GetPosition();
            PositionObject po = JsonConvert.DeserializeObject<PositionObject>(resultPosition);
            Cb_Position.ItemsSource = po.positions;
            Cb_Position.DisplayMemberPath = "position_name";
        }

        private void LoadForm()
        {
            ParserJSON pj = new ParserJSON();
            HeadPhysicianWindows hpw = new HeadPhysicianWindows();

            hpw.DoctorsGrid.ItemsSource = null;
            string result = pj.GetDoctors();
            RootObject ro = JsonConvert.DeserializeObject<RootObject>(result);
            hpw.DoctorsGrid.ItemsSource = ro.doctors;

          
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
                     ext = System.IO.Path.GetExtension(ofd.FileName);
                    fileName = System.IO.Path.GetFileNameWithoutExtension(ofd.FileName);
                    image.Source = new BitmapImage(new Uri(ofd.FileName, UriKind.Absolute));
                    UploadImage(fileName + ext);
                }
                catch(Exception ex)
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
            byte[] result = Client.UploadFile(url +"upload.php", "POST", fileToUpload);
            File.Delete(fileToUpload);
        }

        private void Input_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var mailValidate = new System.Net.Mail.MailAddress(Tb_Mail.Text);
                if (Tb_Mail.Text == mailValidate.Address) { 

                //ComboBoxItem ComboItem = (ComboBoxItem)Cb_Position.SelectedItem;
                string position = Cb_Position.Text;
                string images = "http://myclinic.ddns.net:8080/" + "files/" + fileName + ext;
                string fromDate = From_DpWork.Text.Replace(".", "-");
                string fromTime = FromTime.Text + ":00";
                string toDate =   To_DpWork.Text.Replace(".", "-");
                string toTime =   ToTime.Text + ":00";

                //Показывает дату в нужном формате
                fromDate = string.Join("-", fromDate.Split(new char[] { '-' }).Reverse());
                toDate = string.Join("-", toDate.Split(new char[] { '-' }).Reverse());

                //Дата и время в формате гггг-мм-дд 00:00:00
                string FromDataTime = fromDate + " " + fromTime;
                string ToDataTime = toDate + " " + toTime;

                //Запрос к php скрипту на сервере через WebClient
                string Answer = new WebClient().DownloadString(url + "add_doctors.php?mail=" + Tb_Mail.Text + "&surname=" + Tb_Surname.Text + "&name=" +
                 Tb_Name.Text + "&patronymic=" + Tb_Patronymic.Text + "&phone=" + Tb_Number.Text + "&passport=" + Tb_Passport.Text + "&position=" + position +
                 "&images=" + images + "&parlor=" + Tb_Parlor.Text + "&description=" + Tb_Description.Text + "&FromDataTime=" + FromDataTime + "&ToDataTime=" + ToDataTime);

                //Указываем родителя
                HeadPhysicianWindows h = this.Owner as HeadPhysicianWindows;
                h.update_datagrid();

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
