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
    /// Логика взаимодействия для Statistic.xaml
    /// </summary>
    public partial class Statistic : Window
    {
        public Statistic()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                ParserJSON pj = new ParserJSON();
                string resultdoc = pj.GetCountDoctors();
                CountDoctors cd = JsonConvert.DeserializeObject<CountDoctors>(resultdoc);
                var countdoc = cd.doctors[0];
                lb_CountDoctor.Content = countdoc.Doctors;

                string resultpat = pj.GetCountPatient();
                CountPatients cp = JsonConvert.DeserializeObject<CountPatients>(resultpat);
                var countpat = cp.patients[0];
                lb_CountPatient.Content = countpat.Patient;

                string resuls = pj.GetCountChief();
                CountChief ch = JsonConvert.DeserializeObject<CountChief>(resuls);
                var countch = ch.doctors[0];
                lb_CountC.Content = countch.Chief;

                string resulo = pj.GetCountOculist();
                CountOculist co = JsonConvert.DeserializeObject<CountOculist>(resulo);
                var counto = co.doctors[0];
                lb_CountO.Content = counto.Oculist;

                string resus = pj.GetCountSurgeon();
                CountSurgeon cs = JsonConvert.DeserializeObject<CountSurgeon>(resus);
                var counts = cs.doctors[0];
                lb_CountS.Content = counts.Surgeon;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
