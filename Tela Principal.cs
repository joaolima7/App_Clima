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
                    Lbl_Temper.Text = $"{weatherData.Main.Temp}°C";
                    Lbl_Umid.Text = $"Umidade: {weatherData.Main.Humidity}%";
                    Lbl_Vento.Text = $"Vento: {weatherData.Wind.Speed} m/s";
                    Lbl_City.Text = $"{weatherData.Name}";
                    Lbl_Descricao.Text = $"{weatherData.Weather[0].Description}";
                    Lbl_Descricao.Text = Lbl_Descricao.Text.ToUpper();
                    Lbl_City.Text = Lbl_City.Text.ToUpper();

                }
                else
                {
                    Lbl_Temper.Text = "Falha ao obter dados.";
                    Lbl_Umid.Text = "";
                    Lbl_Vento.Text = "";
                    Lbl_City.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Digite o nome da cidade.");
            }
        }
    }
}