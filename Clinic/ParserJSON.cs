using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Web;
using System.Net.Http;
using System.Net;
using System.Windows;
using System.Runtime.Serialization.Json;
using System.Threading;

namespace Clinic
{
    class ParserJSON
    {
        string url = "http://myclinic.ddns.net:8080/";

        public string GetDoctors()
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "Code/get_doctors.php"); 

            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "GET";//Можно GET
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                //Ответ от сервера
                string result = streamReader.ReadToEnd();
                //RootObject ro = JsonConvert.DeserializeObject<RootObject>(result);
                return result;
            }
            
        }//GetDoctors()

        public string GetPatient()
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "Code/get_patient.php");

            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "GET";//Можно GET
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                
                string result = streamReader.ReadToEnd();
                //RootObject ro = JsonConvert.DeserializeObject<RootObject>(result);
                return result;
            }

        }

        public string GetJournal()
        {
            string login = DataValue.Login;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "Code/get_journal.php?login=" + login);

            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "GET";//Можно GET
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {

                string result = streamReader.ReadToEnd();
                //RootObject ro = JsonConvert.DeserializeObject<RootObject>(result);
                return result;
            }

        }//GetJournal

        public string GetAllJournal()
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "Code/get_all_journal.php");

            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "GET";//Можно GET
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                //Ответ от сервера
                string result = streamReader.ReadToEnd();
                //RootObject ro = JsonConvert.DeserializeObject<RootObject>(result);
                return result;
            }

        }//GetAllJournal

        public string GetRegister()
        {
            DataValue.Url = url; //для UserRequest

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "Code/get_register.php");

            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "GET";//Можно GET
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                //Ответ от сервера
                string result = streamReader.ReadToEnd();
                //RootObject ro = JsonConvert.DeserializeObject<RootObject>(result);
                return result;
            }

        }//GetRegister

        public string GetPosition()
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "Code/get_position.php");

            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "GET";//Можно GET
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                //Ответ от сервера
                string result = streamReader.ReadToEnd();
                //RootObject ro = JsonConvert.DeserializeObject<RootObject>(result);
                return result;
            }

        }//GetPosition

        public string GetDiagnosis()
        {
            string login = DataValue.Login;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "Code/get_userdiagnosis.php?login=" + login );

            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "GET";//Можно GET
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                //Ответ от сервера
                string result = streamReader.ReadToEnd();
                //RootObject ro = JsonConvert.DeserializeObject<RootObject>(result);
                return result;
            }

        }//GetDiagnosis()


        public string GetChoiceDoctors()
        {
            string choice = DataValue.ChoiceDoctors;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "Code/get_choice_doctor.php?position=" + choice);

            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "GET";//Можно GET
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                //Ответ от сервера
                string result = streamReader.ReadToEnd();
                //RootObject ro = JsonConvert.DeserializeObject<RootObject>(result);
                return result;
            }

        }//GetDiagnosis()

        public string GetLoadDoctors()
        {
            DataValue.Url = url;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "Code/get_doctors_options.php?Passport=" + DoctorsData.PassportNumber);

            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "GET";//Можно GET
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                //Ответ от сервера
                string result = streamReader.ReadToEnd();
                //RootObject ro = JsonConvert.DeserializeObject<RootObject>(result);
                return result;
            }

        }//GetDoctors()

        public string GetCountDoctors()
        {
            DataValue.Url = url;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "Code/count_doctors.php");

            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "GET";//Можно GET
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                //Ответ от сервера
                string result = streamReader.ReadToEnd();
                //RootObject ro = JsonConvert.DeserializeObject<RootObject>(result);
                return result;
            }

        }//

        public string GetCountPatient()
        {
            DataValue.Url = url;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "Code/count_patient.php");

            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "GET";//Можно GET
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                //Ответ от сервера
                string result = streamReader.ReadToEnd();
                //RootObject ro = JsonConvert.DeserializeObject<RootObject>(result);
                return result;
            }

        }//GetDoctors()

        public string GetCountChief()
        {
            DataValue.Url = url;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "Code/count_chief.php");

            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "GET";//Можно GET
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                //Ответ от сервера
                string result = streamReader.ReadToEnd();
                //RootObject ro = JsonConvert.DeserializeObject<RootObject>(result);
                return result;
            }

        }//GetDoctors()

        public string GetCountOculist()
        {
            DataValue.Url = url;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "Code/count_oculist.php");

            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "GET";//Можно GET
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                //Ответ от сервера
                string result = streamReader.ReadToEnd();
                //RootObject ro = JsonConvert.DeserializeObject<RootObject>(result);
                return result;
            }

        }//GetDoctors()

        public string GetCountSurgeon()
        {
            DataValue.Url = url;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "Code/count_surgeon.php");

            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "GET";//Можно GET
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                //Ответ от сервера
                string result = streamReader.ReadToEnd();
                //RootObject ro = JsonConvert.DeserializeObject<RootObject>(result);
                return result;
            }

        }//GetDoctors()

    }//ParserJSON
}//Clinic
