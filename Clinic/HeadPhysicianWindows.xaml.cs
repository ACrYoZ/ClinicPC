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
using System.Data.SqlClient;
using System.Data.Sql;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;
using System.Threading;

namespace Clinic
{
    /// <summary>
    /// Логика взаимодействия для UserProfileWindows.xaml
    /// </summary>
    public partial class HeadPhysicianWindows : Window
    {
        string url = "http://myclinic.ddns.net:8080/";

        public HeadPhysicianWindows()
        {
            InitializeComponent();
           
            List<string> styles = new List<string> { "light", "dark" };
            styleBox.SelectionChanged += ThemeChange;
            styleBox.ItemsSource = styles;
            styleBox.SelectedItem = "light";
        }

        private void ThemeChange(object sender, SelectionChangedEventArgs e)
        {
            string style = styleBox.SelectedItem as string;
            //путь к файлу ресурсов
            var uri = new Uri(@"theme\" + style + ".xaml", UriKind.Relative);
            //загрузка словаря ресурсов
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            //очистка ресурсов приложения
            Application.Current.Resources.Clear();
            //добавить загруженный словарь ресурсов 
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
          try
            {
                update_datagrid();
                textBoxName.Text = "Поиск по фамилии";

                //System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
                //timer.Tick += new EventHandler(TimerDatagrid);
                //timer.Interval = new TimeSpan(0, 0, 15);
                //timer.Start();

                var timer = new System.Windows.Threading.DispatcherTimer();
                timer.Interval = new TimeSpan(0, 0, 1);
                timer.IsEnabled = true;
                timer.Tick += (o, t) => { TimeCurrent.Text = DateTime.Now.ToString(); };
                timer.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataLoading()
        {
            try
            {
                DataGrid x = (DataGrid)this.FindName("DoctorsGrid");
                var index = x.SelectedIndex;

                // Получение значение ячеек
                var surname = new DataGridCellInfo(DoctorsGrid.Items[index], DoctorsGrid.Columns[0]);
                var surname_data = surname.Column.GetCellContent(surname.Item) as TextBlock;

                var name = new DataGridCellInfo(DoctorsGrid.Items[index], DoctorsGrid.Columns[1]);
                var name_data = name.Column.GetCellContent(name.Item) as TextBlock;

                if (name_data.Text != null)
                {
                    this.Opacity = 0.5;
                }

                var patronymic = new DataGridCellInfo(DoctorsGrid.Items[index], DoctorsGrid.Columns[2]);
                var patronymic_data = patronymic.Column.GetCellContent(patronymic.Item) as TextBlock;

                var passport = new DataGridCellInfo(DoctorsGrid.Items[index], DoctorsGrid.Columns[3]);
                var passport_data = passport.Column.GetCellContent(passport.Item) as TextBlock;

                var phone = new DataGridCellInfo(DoctorsGrid.Items[index], DoctorsGrid.Columns[4]);
                var phone_data = phone.Column.GetCellContent(phone.Item) as TextBlock;

                var parlor = new DataGridCellInfo(DoctorsGrid.Items[index], DoctorsGrid.Columns[6]);
                var parlor_data = parlor.Column.GetCellContent(parlor.Item) as TextBlock;

                DoctorsData.Surname = surname_data.Text;
                DoctorsData.Name = name_data.Text;
                DoctorsData.Patronymic = patronymic_data.Text;
                DoctorsData.PassportNumber = passport_data.Text;
                DoctorsData.PhoneNumber = phone_data.Text;
                DoctorsData.Parlor = parlor_data.Text;

                AlterDoctors a = new AlterDoctors();
                a.Owner = this;
                a.ShowDialog();
                this.Opacity = 1;
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
            string result = pj.GetDoctors();
            RootObject ro = JsonConvert.DeserializeObject<RootObject>(result);
            DoctorsGrid.ItemsSource = ro.doctors;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Opacity = 0.5;
                UpdateHeadPhysician uhp = new UpdateHeadPhysician();
                uhp.Owner = this;
                uhp.ShowDialog();
                this.Opacity = 1;
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Change_account_Click(object sender, RoutedEventArgs e)
        {
            MainWindows mw = new MainWindows();
            mw.Show();
            this.Close();
        }

        private void Mi_CloseWindows_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DoctorsGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DataLoading();
            }
            catch (Exception ex) { }
        }

        private void DoctorsGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            try
            {
                int selectedColumn = DoctorsGrid.CurrentCell.Column.DisplayIndex;
                var selectedCell = DoctorsGrid.SelectedCells[selectedColumn];
                var cellContent = selectedCell.Column.GetCellContent(selectedCell.Item);
                if (cellContent is TextBlock)
                {
                    CursorPosition.Text = "Выбрано:  " + (cellContent as TextBlock).Text;
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void Mi_DelDoctor_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Opacity = 0.5;
                DataValue.Url = url;
                Del_Doctor del = new Del_Doctor();
                del.Owner = this;
                del.ShowDialog();
                this.Opacity = 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Del_Doctor_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //получаем id выделенной строки
                DataGrid x = (DataGrid)this.FindName("DoctorsGrid");
                var index = x.SelectedIndex;

                //Получение значение ячейки номера паспорта
                var ci_d = new DataGridCellInfo(DoctorsGrid.Items[index], DoctorsGrid.Columns[3]);
                var content_d = ci_d.Column.GetCellContent(ci_d.Item) as TextBlock;

                string passport = content_d.Text;

                //Запрос на удаление
                string Answer = new WebClient().DownloadString(url + "Code/del_doctors.php?" + "passportNumber=" + passport);

                //Обновление DataGrid
                update_datagrid();
            }
            catch (Exception ex)
            {

            }
        }

        private void Support_Click(object sender, RoutedEventArgs e)
        {
            this.Opacity = 0.5;
            SupportWindows s = new SupportWindows();
            s.ShowDialog();
            this.Opacity = 1;
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            this.Opacity = 0.5;
            AboutWindows aw = new AboutWindows();
            aw.ShowDialog();
            this.Opacity = 1;

        }

        private void AlterDoctor_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataLoading();
            }
            catch(Exception ex) { }
        }

        private void textBoxName_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            try
            {
                ParserJSON pj = new ParserJSON();
                string result = pj.GetDoctors();
                RootObject ro = JsonConvert.DeserializeObject<RootObject>(result);
                DoctorsGrid.ItemsSource = ro.doctors;

                var oc = ro.doctors;
                DataValue.TextSearch = textBoxName.Text;
                var filter_col = oc.Where(itemF => itemF.search == textBoxName.Text);

                DoctorsGrid.ItemsSource = filter_col;

                if (textBoxName.Text == "")
                {
                    update_datagrid();
                }
            }
            catch(Exception ex) { };

        }

        private void textBoxName_MouseEnter(object sender, MouseEventArgs e)
        {
            try
            {
                textBoxName.Text = "";
            }
            catch(Exception ex) { }
        }
    }
}
        
    
    

