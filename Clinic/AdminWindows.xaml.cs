using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;


namespace Clinic
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class AdminWindows : Window
    {
        ParserJSON pj = new ParserJSON();

        public AdminWindows()
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
                string result_doc = pj.GetDoctors();
                string result_jour = pj.GetAllJournal();
                RootObject ro_doc = JsonConvert.DeserializeObject<RootObject>(result_doc);
                RadixObject ro_jour = JsonConvert.DeserializeObject<RadixObject>(result_jour);
                JournalGrid.ItemsSource = ro_jour.journal;
                UserGrid.ItemsSource = ro_doc.doctors;

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

        private void MenuItem_Exit(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void JournalGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                int selectedColumn = JournalGrid.CurrentCell.Column.DisplayIndex;
                var selectedCell = JournalGrid.SelectedCells[selectedColumn];
                var cellContent = selectedCell.Column.GetCellContent(selectedCell.Item);
                if (cellContent is TextBlock)
                {
                    MessageBox.Show((cellContent as TextBlock).Text);
                }
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
                    CursorPosition.Text = "Доктора:  " + (cellContent as TextBlock).Text;
                }
            }
            catch(Exception ex) { }
        }

        private void UserGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                int selectedColumn = UserGrid.CurrentCell.Column.DisplayIndex;
                var selectedCell = UserGrid.SelectedCells[selectedColumn];
                var cellContent = selectedCell.Column.GetCellContent(selectedCell.Item);
                if (cellContent is TextBlock)
                {
                    MessageBox.Show((cellContent as TextBlock).Text);
                }
            }
            catch(Exception ex) { }
        }

        private void UserGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            try
            {
                int selectedColumn = UserGrid.CurrentCell.Column.DisplayIndex;
                var selectedCell = UserGrid.SelectedCells[selectedColumn];
                var cellContent = selectedCell.Column.GetCellContent(selectedCell.Item);
                if (cellContent is TextBlock)
                {
                    CursorPosition.Text = "Пользователи:  " + (cellContent as TextBlock).Text;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Mi_statistic_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Statistic s = new Statistic();
                s.ShowDialog();
            }
            catch(Exception ex) { }

        }
    }
}
