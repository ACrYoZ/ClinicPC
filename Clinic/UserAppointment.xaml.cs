using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для UserAppointment.xaml
    /// </summary>
    public partial class UserAppointment : Window
    {
        public UserAppointment()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                ParserJSON pj = new ParserJSON();
                //Cвязывание ComboBox c Position
                string resultPosition = pj.GetPosition();
                PositionObject po = JsonConvert.DeserializeObject<PositionObject>(resultPosition);
                Cb_Position.ItemsSource = po.positions;
                Cb_Position.DisplayMemberPath = "position_name";

                string resultPatient = pj.GetPatient();
                RadicalObject ro = JsonConvert.DeserializeObject<RadicalObject>(resultPatient);
                Cb_Patient.ItemsSource = ro.patients;
                Cb_Patient.DisplayMemberPath = "fio";
            }
            catch (Exception) { }
        }

        private void Cb_Position_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                ParserJSON pj = new ParserJSON();
                DataValue.ChoiceDoctors = Cb_Position.Text;

                string resultDoctor = pj.GetChoiceDoctors();
                SelObject so = JsonConvert.DeserializeObject<SelObject>(resultDoctor);
                Cb_Doctor.ItemsSource = so.doctors;
                Cb_Doctor.DisplayMemberPath = "fio";
            }
            catch(Exception ex) { }
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_Accept_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string Date = DatePicker.Text.Replace(".", "-");
                string Time = TimePicker.Text + ":00";

                //Показывает дату в нужном формате
                Date = string.Join("-", Date.Split(new char[] { '-' }).Reverse());
                //Дата + время
                string DataTime = Date + " " + Time;
                string cause = Tb_Cause.Text;
           
                string position = Cb_Position.Text;
                string trimmedDoctor = Cb_Doctor.Text;
                var Doctor = trimmedDoctor.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                //убрать пробелы
                //nameDoctor = nameDoctor.Replace(" ", string.Empty);

                string trimmedPatient = Cb_Patient.Text;
                var Patient = trimmedPatient.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


                string Answer = new WebClient().DownloadString("http://myclinic.ddns.net:8080/" + "Code/user_appointment.php?" + "dateTime=" + DataTime + "&cause=" + cause +
                 "&surnamePatient=" + Patient[0] + "&namePatient="+ Patient[1] + "&surnameDoctor=" + Doctor[0] + "&nameDoctor="+ Doctor[1] + "&position=" + position);

                MessageBox.Show("Пациент " + Patient[0] +" " + Patient[1] + " " + Patient[2] + " добавлен в журнал");

                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };

        }
    }
}
