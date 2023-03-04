using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using MODELO;


namespace VISTA
{
    public partial class frmPronostico : Form
    {
        public frmPronostico()
        {
            InitializeComponent();
        }

        string APIkey = "2a706b2e3071e6caecf77c732c95fe3a";

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ObtenerPronostico();
        }

        private void ObtenerPronostico()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", txtCiudad.Text, APIkey);
                var json = web.DownloadString(url);
                Pronostico.root info = JsonConvert.DeserializeObject<Pronostico.root>(json);

                picIcon.ImageLocation = "https://openweathermap.org/img/w/" + info.weather[0].icon + ".png";
                lblCondicion.Text = info.weather[0].main;
                lblDetalles.Text = info.weather[0].description;
                lblAtardecer.Text = convertDateTime(info.sys.sunset).ToShortTimeString();
                lblAmanecer.Text = convertDateTime(info.sys.sunrise).ToShortTimeString(); 
                lblVelViento.Text = info.wind.speed.ToString();
                lblPresion.Text = info.main.pressure.ToString();
            }
        }

        DateTime convertDateTime(long milisec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(milisec).ToLocalTime();
            return day;
        }
    }
}
