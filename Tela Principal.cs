using RestSharp;
using Newtonsoft.Json;


namespace APP_CLIMA
{
    public partial class Tela_Principal : Form
    {
        public Tela_Principal()
        {
            InitializeComponent();
        }

        public class WeatherResponse
        {
            public MainWeatherData Main { get; set; }
            public WindData Wind { get; set; }
            public WeatherData[] Weather { get; set; }
            public string Name { get; set; }
        }

        public class MainWeatherData
        {
            public double Temp { get; set; }
            public double Humidity { get; set; }
        }

        public class WindData
        {
            public double Speed { get; set; }
        }

        public class WeatherData
        {
            public string Description { get; set; }
        }




        private WeatherResponse GetWeatherData(string cidade)
        {
            string apiKey = "a9f82e04e675cd1a5def62dbd2021d3c"; // Substitua pela sua chave de API da OpenWeatherMap
            string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={cidade}&appid={apiKey}&units=metric&lang=pt_br";

            var client = new RestClient(apiUrl);
            var request = new RestRequest();
            request.Method = Method.Get; // Correção do método

            RestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
                WeatherResponse weatherData = JsonConvert.DeserializeObject<WeatherResponse>(response.Content);
                return weatherData;
            }
            else
            {
                return null;
            }
        }

        private void Btn_Pesq_Click_1(object sender, EventArgs e)
        {
            string cidade = Txb_Pesq.Text;

            if (!string.IsNullOrEmpty(cidade))
            {
                WeatherResponse weatherData = GetWeatherData(cidade);

                if (weatherData != null)
                {
                    Lbl_City.Visible = true;
                    Lbl_Temper.Visible = true;
                    Lbl_Umid.Visible = true;
                    Lbl_Vento.Visible = true;
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = false;

                    Lbl_Temper.Text = $"{weatherData.Main.Temp}°C";
                    Lbl_Umid.Text = $"{weatherData.Main.Humidity}%";
                    Lbl_Vento.Text = $"{weatherData.Wind.Speed} m/s";
                    Lbl_City.Text = $"{weatherData.Name}";
                    Lbl_Descricao.Text = $"{weatherData.Weather[0].Description}";
                    Lbl_Descricao.Text = Lbl_Descricao.Text.ToUpper();
                    Lbl_City.Text = Lbl_City.Text.ToUpper();

                }
                else
                {
                    Lbl_City.Visible = true;
                    Lbl_City.Text = "Erro, tente novamente!";
                }
            }
            else
            {
                Txb_Pesq.BackColor = Color.IndianRed;
                Lbl_Digite.Visible = true;
            }
        }

        private void Tela_Principal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Txb_Pesq.Focus())
                {
                    Btn_Pesq.PerformClick();
                    Lbl_City.Focus();
                }
            }
        }

        private void Txb_Pesq_TextChanged(object sender, EventArgs e)
        {
            Txb_Pesq.BackColor = Color.LightGray;
            Lbl_Digite.Visible = false;
        }
    }
}