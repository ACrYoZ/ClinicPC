using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
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
    /// Логика взаимодействия для UserRequest.xaml
    /// </summary>
    public partial class UserRequest : Window
    {
        public UserRequest()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                update_datagrid();

                //Настройка таймера 
                System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();

                timer.Tick += new EventHandler(TimerDatagrid);
                timer.Interval = new TimeSpan(0, 0, 50);
                timer.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void TimerDatagrid(object sender, EventArgs e)
        {
            update_datagrid();
        }

        public void update_datagrid()
        {
            ParserJSON pj = new ParserJSON();
            string result = pj.GetRegister();
            RegisterObject ro = JsonConvert.DeserializeObject<RegisterObject>(result);
            RegisterGrid.ItemsSource = ro.register;
       
        }

        private void Btn_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Mi_accept_Click(object sender, RoutedEventArgs e)
        {
            Inquiry();
        }

        public void Inquiry()
        {
            try
            {
                //получаем id выделенной строки
                DataGrid x = (DataGrid)this.FindName("RegisterGrid");
                var index = x.SelectedIndex;

                //Получение значение ячейки имя доктора
                var name_r = new DataGridCellInfo(RegisterGrid.Items[index], RegisterGrid.Columns[3]);
                var content_name = name_r.Column.GetCellContent(name_r.Item) as TextBlock;

                //Получение значение ячейки должности
                var pos_r = new DataGridCellInfo(RegisterGrid.Items[index], RegisterGrid.Columns[4]);
                var content_pos = pos_r.Column.GetCellContent(pos_r.Item) as TextBlock;

                //Получение значение ячейки кабинета
                var cab_r = new DataGridCellInfo(RegisterGrid.Items[index], RegisterGrid.Columns[5]);
                var content_cab = cab_r.Column.GetCellContent(cab_r.Item) as TextBlock;

                //Получение значение ячейки даты
                var date_t = new DataGridCellInfo(RegisterGrid.Items[index], RegisterGrid.Columns[0]);
                var content_date = date_t.Column.GetCellContent(date_t.Item) as TextBlock;

                //Получение номера паспорта пациента
                var passport_t = new DataGridCellInfo(RegisterGrid.Items[index], RegisterGrid.Columns[2]);
                var content_passport = passport_t.Column.GetCellContent(passport_t.Item) as TextBlock;

                //Получение аннотации
                var an_t = new DataGridCellInfo(RegisterGrid.Items[index], RegisterGrid.Columns[6]);
                var content_an = an_t.Column.GetCellContent(an_t.Item) as TextBlock;

                //Обрезка имени доктора для отправки
                string trimmedDoctor = content_name.Text;
                string doctor = trimmedDoctor.Trim();

                string nameDoctor = trimmedDoctor.Substring(0, trimmedDoctor.IndexOf(' ') + 1);
                string position = content_pos.Text;
                string parlor = content_cab.Text;
                string dateTime = content_date.Text;
                string passport = content_passport.Text;
                string annotation = content_an.Text;

                //Запрос 
                string Answer = new WebClient().DownloadString(DataValue.Url + "Code/request_accept.php?" + "passportNumber=" + passport + "&dateTime=" + dateTime +
                    "&parlor=" + parlor + "&position=" + position + "&nameDoctor=" + nameDoctor + "&annotation=" + annotation);

                //Обновление DataGrid
                update_datagrid();
            }
            catch (Exception ex) { };
           
        }

        private void RegisterGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Verification v = new Verification();
                v.Owner = this;
                v.ShowDialog();
            }
            catch(Exception ex) { }
        }

        private void Mi_reject_Click(object sender, RoutedEventArgs e)
        {
            try { 
            DataGrid r = (DataGrid)this.FindName("RegisterGrid");
            var index_r = r.SelectedIndex;

            //Получение номера паспорта пациента
            var passport_r = new DataGridCellInfo(RegisterGrid.Items[index_r], RegisterGrid.Columns[2]);
            var content_r = passport_r.Column.GetCellContent(passport_r.Item) as TextBlock;
            
            //Получение даты и времени
            var date_t = new DataGridCellInfo(RegisterGrid.Items[index_r], RegisterGrid.Columns[0]);
            var content_date = date_t.Column.GetCellContent(date_t.Item) as TextBlock;

            string passport = content_r.Text;
            string dateTime = content_date.Text;

                //Запрос 
                string Answer = new WebClient().DownloadString(DataValue.Url + "Code/reject_user.php?" + "passportNumber=" + passport + "&dateTime=" + dateTime);

            //Обновление DataGrid
            update_datagrid();
            }
            catch (Exception ex) { };
        }
    }
}
