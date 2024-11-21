using Newtonsoft.Json;
using System.Configuration;
using System.Net.Http;
using Domain.gettaxiusa.com.Entities;
using System.Net;
using System.Text.Json.Serialization;
using System.Xml.Linq;
using MTRDesktopApplication.Dtos;
namespace MTRDesktopApplication
{
    public partial class Login : Form
    {
        private readonly HttpClient httpClient = new HttpClient();
        string baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
        private EmployeeLoginResponce empinfo = new EmployeeLoginResponce();
        public Login()
        {
            InitializeComponent();
        }
        private async Task<bool> MakeHttpPostRequest<T>(string endpoint, object data)
        {
            string url = baseUrl + endpoint;
            string jsonData = JsonConvert.SerializeObject(data);
            HttpContent content = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            string responseData = await response.Content.ReadAsStringAsync();
            var employeeLogin = JsonConvert.DeserializeObject<EmployeeLoginResponce>(responseData);
            if(employeeLogin != null )
            {
                bool isSuccess = true;
                GlobalServices.Domainid = employeeLogin.domainId.ToString();
                GlobalServices.FirstName = employeeLogin.FirstName;
                GlobalServices.Status = employeeLogin.Status;
                empinfo.FirstName = employeeLogin.FirstName;
                empinfo.Status = employeeLogin.Status;
                empinfo.domainId = employeeLogin.domainId;
                empinfo.domainName = employeeLogin.domainName;
                empinfo.nickName= employeeLogin.nickName;
                return isSuccess;
            }
           
            return false;
            }
            private async void button1_Click(object sender, EventArgs e)
            {
                ShowTickButtonPictureBox();
                var payload = new EmployeeLogin
                {
                    LoginId = mailTextBox.Text,
                    Password = passwordtextBox.Text,
                };
                var response = await MakeHttpPostRequest<StaffList>("api/EmployeeLogin/EmployeeLogin", payload);
                HideTickButtonPictureBox();
                MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
                mainLayoutScreen.DashBoard(empinfo);
            }
            public void ShowTickButtonPictureBox()
        {
            if (tickButtonPictureBox != null)
            {
                tickButtonPictureBox.Visible = true;
                tickButtonPictureBox.BringToFront();
            }
        }
        public void HideTickButtonPictureBox()
        {
            if (tickButtonPictureBox != null)
            {
                tickButtonPictureBox.Visible = false;
            }
        }
    }
}