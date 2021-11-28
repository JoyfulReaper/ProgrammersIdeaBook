namespace FetchWeather
{
    public partial class WeatherForm : Form
    {
        private ApiHelper apiHelper;

        public WeatherForm()
        {
            InitializeComponent();
            apiHelper = new ApiHelper();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var weather = await apiHelper.GetWeather(txtKey.Text, txtLocation.Text);

            lblTempFData.Text = weather.current?.temp_f.ToString() + " (f)" ?? "(unknown)";
            lblFeelsLikeData.Text = weather.current?.feelslike_f.ToString() + " (f)" ?? "(unknown)";
            lblHumidityData.Text = weather.current?.humidity.ToString() ?? "(unknown)";
            lblWindSpeedData.Text = weather.current?.wind_mph.ToString() + " mph" ?? "(unknown)";

            if (weather.location != null)
            {
                lblLocationData.Text = $"{weather.location.name}, {weather.location.region}, {weather.location.country}";
            } else
            {
                lblLocationData.Text = "(unknown)";
            }
        }
    }
}