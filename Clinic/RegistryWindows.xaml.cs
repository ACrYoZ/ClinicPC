using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
    /// Логика взаимодействия для RegistryWindows.xaml
    /// </summary>
    public partial class RegistryWindows : Window
    {

        public RegistryWindows()
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

                //Настройка таймера 
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
            catch (Exception ex)
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
            string result = pj.GetPatient();
            RadicalObject ro = JsonConvert.DeserializeObject<RadicalObject>(result);
            RegistryGrid.ItemsSource = ro.patients;
        }
        

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (RegistryGrid.SelectedItems != null)
                {
                    for (int i = 0; i < RegistryGrid.SelectedItems.Count; i++)
                    {
                        DataRowView datarowView = RegistryGrid.SelectedItems[i] as DataRowView;
                        if (datarowView != null)
                        {
                            DataRow dataRow = (DataRow)datarowView.Row;
                            dataRow.Delete();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Mi_ChangeAccount_Click(object sender, RoutedEventArgs e)
        {
            MainWindows mw = new MainWindows();
            mw.Show();
            this.Close();
        }

        private void Mi_CloseWindows_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RegistryGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                int selectedColumn = RegistryGrid.CurrentCell.Column.DisplayIndex;
                var selectedCell = RegistryGrid.SelectedCells[selectedColumn];
                var cellContent = selectedCell.Column.GetCellContent(selectedCell.Item);
                if (cellContent is TextBlock)
                {
                    MessageBox.Show((cellContent as TextBlock).Text);
                }
            }
            catch (Exception ex)
            {
                //Оставляем пустое, чтоб не мешало при двойном клике на прокрутку
            }
        }

        private void RegistryGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            try
            {
                int selectedColumn = RegistryGrid.CurrentCell.Column.DisplayIndex;
                var selectedCell = RegistryGrid.SelectedCells[selectedColumn];
                var cellContent = selectedCell.Column.GetCellContent(selectedCell.Item);
                if (cellContent is TextBlock)
                {
                    CursorPosition.Text = "Выбрано:  " + (cellContent as TextBlock).Text;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void Mi_Registry_Click(object sender, RoutedEventArgs e)
        {
            this.Opacity = 0.5;
            //UserRegistration ur = new UserRegistration();
            //ur.Show();
            UserRegistration u = new UserRegistration();
            u.Owner = this;
            u.ShowDialog();
            this.Opacity = 1;
        }

        private void Mi_Request_Click(object sender, RoutedEventArgs e)
        {
            this.Opacity = 0.5;
            UserRequest ur = new UserRequest();
            ur.ShowDialog();
            this.Opacity = 1;
        }

        private void Mi_Appointment_Click(object sender, RoutedEventArgs e)
        {
            this.Opacity = 0.5;
            UserAppointment u = new UserAppointment();
            u.ShowDialog();
            this.Opacity = 1;
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            this.Opacity = 0.5;
            SupportWindows s = new SupportWindows();
            s.ShowDialog();
            this.Opacity = 1;
        }

        private void About_this_Click(object sender, RoutedEventArgs e)
        {
            this.Opacity = 0.5;
            AboutWindows aw = new AboutWindows();
            aw.ShowDialog();
            this.Opacity = 1;

        }
        private void textBoxName_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            try
            {
                ParserJSON pj = new ParserJSON();
                string result = pj.GetPatient();
                RadicalObject ro = JsonConvert.DeserializeObject<RadicalObject>(result);
                RegistryGrid.ItemsSource = ro.patients;

                var oc = ro.patients;
                DataValue.TextSearch = textBoxName.Text;
                var filter_col = oc.Where(itemF => itemF.search == textBoxName.Text);

                RegistryGrid.ItemsSource = filter_col;

                if (textBoxName.Text == "")
                {
                    update_datagrid();
                }
            }
            catch (Exception ex) { };

        }

        private void textBoxName_MouseEnter(object sender, MouseEventArgs e)
        {
            textBoxName.Text = "";
        }
    }
}
