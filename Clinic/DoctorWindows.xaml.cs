using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для DoctorWindows.xaml
    /// </summary>
    public partial class DoctorWindows : Window
    {
        public DoctorWindows()
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

        private void Change_account_Click(object sender, RoutedEventArgs e)
        {
            MainWindows mw = new MainWindows();
            mw.Show();
            this.Close();
        }

        private void Mi_CloseWindows_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void JournalGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Performance();
            }
            catch(Exception ex) { }
        }

        private void JournalGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            try
            {
                int selectedColumn = JournalGrid.CurrentCell.Column.DisplayIndex;
                var selectedCell = JournalGrid.SelectedCells[selectedColumn];
                var cellContent = selectedCell.Column.GetCellContent(selectedCell.Item);
                if (cellContent is TextBlock)
                {
                    CursorPosition.Text = "Выбрано:  " + (cellContent as TextBlock).Text;
                }
            }
            catch(Exception ex) { }
        }

        private void Mi_AddRecord_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Performance();
            }
            catch(Exception ex) { }
        }

        public void update_datagrid()
        {
            ParserJSON pj = new ParserJSON();
            string result = pj.GetJournal();
            RadixObject ro = JsonConvert.DeserializeObject<RadixObject>(result);
            JournalGrid.ItemsSource = ro.journal;

            this.Title = DataValue.Position;
        }

        private void Performance()
        {
            try
            {
                //получаем id выделенной строки
                DataGrid x = (DataGrid)this.FindName("JournalGrid");
                var index = x.SelectedIndex;

                //Получение значение ячейки пациента
                var ci_p = new DataGridCellInfo(JournalGrid.Items[index], JournalGrid.Columns[0]);
                var content_p = ci_p.Column.GetCellContent(ci_p.Item) as TextBlock;

                if (content_p.Text != null)
                {
                    this.Opacity = 0.5;
                }

                //Для взятие фамилии
                //string trimmedPatient = content_p.Text;
                //string patient = trimmedPatient.Trim();
                //string surnamePatient = trimmedPatient.Substring(0, trimmedPatient.IndexOf(' ') + 1);

                //Получение значение ячейки даты
                var ci_d = new DataGridCellInfo(JournalGrid.Items[index], JournalGrid.Columns[2]);
                var content_d = ci_d.Column.GetCellContent(ci_d.Item) as TextBlock;

                DataValue.Value = content_p.Text;
                DataValue.Date = content_d.Text;

                AppendRecord a = new AppendRecord();
                a.Owner = this;
                a.ShowDialog();
                this.Opacity = 1;
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Mi_Userdiagnosis_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Opacity = 0.5;
                DiagnosisUser du = new DiagnosisUser();
                du.ShowDialog();
                this.Opacity = 1;
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
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
        private void textBoxName_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            try
            {
                ParserJSON pj = new ParserJSON();
                string result = pj.GetJournal();
                RadixObject ro = JsonConvert.DeserializeObject<RadixObject>(result);
                JournalGrid.ItemsSource = ro.journal;

                var oc = ro.journal;
                DataValue.TextSearch = textBoxName.Text;
                var filter_col = oc.Where(itemF => itemF.search == textBoxName.Text);

                JournalGrid.ItemsSource = filter_col;

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

        private void Change_password_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Opacity = 0.5;
                ChangePassword cp = new ChangePassword();
                cp.ShowDialog();
                this.Opacity = 1;
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
