using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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

namespace Clinic
{
    /// <summary>
    /// Логика взаимодействия для UserDiagnosis.xaml
    /// </summary>
    public partial class DiagnosisUser : Window
    {
        public DiagnosisUser()
        {
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void update_datagrid()
        {
            ParserJSON pj = new ParserJSON();
            string result = pj.GetDiagnosis();
            DiagnosisObject di = JsonConvert.DeserializeObject<DiagnosisObject>(result);
            DiagnosisGrid.ItemsSource = di.userdiagnosis;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            update_datagrid();
        }

        private void DiagnosisGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                int selectedColumn = DiagnosisGrid.CurrentCell.Column.DisplayIndex;
                var selectedCell = DiagnosisGrid.SelectedCells[selectedColumn];
                var cellContent = selectedCell.Column.GetCellContent(selectedCell.Item);
                if (cellContent is TextBlock)
                {
                    MessageBox.Show((cellContent as TextBlock).Text);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
