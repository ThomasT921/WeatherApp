using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherApp;

namespace WeatherApp
{
    public partial class WeatherForm : Form
    {
        public WeatherForm()
        {
            InitializeComponent();
            //mouse over effects
            button1.MouseEnter += OnMouseEnterButton1;
            button1.MouseLeave += OnMouseLeaveButton1;
            button3.MouseEnter += OnMouseEnterButton3;
            button3.MouseLeave += OnMouseLeaveButton3;
            button2.MouseEnter += OnMouseEnterButton2;
            button2.MouseLeave += OnMouseLeaveButton2;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void OnMouseEnterButton1(object sender, EventArgs e)
        {
            //changed exit X to red
            button1.ForeColor = Color.Red;
            button1.BackColor = Color.Transparent;
        }
        private void OnMouseLeaveButton3(object sender, EventArgs e)
        {
            //changes it back to gray
            button3.ForeColor = Color.DimGray;
            button3.BackColor = Color.Transparent;
        }
        private void OnMouseEnterButton3(object sender, EventArgs e)
        {
            //changed exit X to red
            button3.ForeColor = Color.Red;
            button3.BackColor = Color.Transparent;
        }
        private void OnMouseLeaveButton1(object sender, EventArgs e)
        {
            //changes it back to gray
            button1.ForeColor = Color.DimGray;
            button1.BackColor = Color.Transparent;
        }
        private void OnMouseEnterButton2(object sender, EventArgs e)
        {
            //adds color to get weather button
            button2.BackColor = Color.LightGray;
        }
        private void OnMouseLeaveButton2(object sender, EventArgs e)
        {
            //makes it transparent again
            button2.BackColor = Color.Transparent;
        }
        //background worker work
        private void dowork(object sender, DoWorkEventArgs e)
        {
            //gets passed args
            List<string> arguementList = (List<string>)e.Argument;
            //assigns the then to vars
            string place = arguementList[0];
            string key = arguementList[1];
            //pulling the json data
            WebClient client = new WebClient();
            string jsonDataString = client.DownloadString("https://api.weatherbit.io/v2.0/current?city=" + place + "&key=" + key + "&units=I");
            //putting it into a dict
            var dobj = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonDataString);
            //working down to the actual data
            dynamic dataSet = dobj["data"];
            dynamic dataSet1 = dataSet[0];
            //creates data handling obj
            WeatherHandler weatherData = new WeatherHandler(dataSet1);
            //creates a list to pass the key and place
            List<string> resultList = new List<string>();
            resultList.Add(place);
            resultList.Add(key);

            //can go futher with a forecast with these lists
            /*List<int> sunshineList = new List<int>() { 800, 801, 802};
            List<int> thunderstormList = new List<int>() { 200, 201, 202, 230, 231, 232 };
            List<int> rainList = new List<int>() { 300, 301, 302, 500, 501, 502, 520, 521, 522, 511, 900 };
            List<int> snowlist = new List<int>() { 600, 601, 602, 610, 611, 612, 621, 622, 623 };
            List<int> fogList = new List<int>() { 741, 751};
            List<int> cloudyList = new List<int>() { 803, 804 };
            List<int> weirdList = new List<int>() { 700, 711, 721, 731 };*/
            //could customize different per each of these

            //changing UI here
            this.Invoke(new Action(() =>
            {
                //refer to lists -- changes bg and icon per weather code//////////////////////////
                if (weatherData.WeatherDescription >= 200 && weatherData.WeatherDescription <= 232)
                {
                    this.BackgroundImage = Properties.Resources.stormbackground;
                    pbDescrip.BackgroundImage = Properties.Resources.thunder;
                }
                else if (weatherData.WeatherDescription >= 300 && weatherData.WeatherDescription <= 511)
                {
                    this.BackgroundImage = Properties.Resources.raining;
                    pbDescrip.BackgroundImage = Properties.Resources.raincloud;
                }
                else if (weatherData.WeatherDescription >= 600 && weatherData.WeatherDescription <= 623)
                {
                    this.BackgroundImage = Properties.Resources.SnowfallBg;
                    pbDescrip.BackgroundImage = Properties.Resources.snowflake;
                }
                else if (weatherData.WeatherDescription >= 700 && weatherData.WeatherDescription <= 731)
                {
                    this.BackgroundImage = Properties.Resources.hazebg;
                    pbDescrip.BackgroundImage = Properties.Resources.haze;
                }
                else if (weatherData.WeatherDescription >= 741 && weatherData.WeatherDescription <= 751)
                {
                    this.BackgroundImage = Properties.Resources.foggy;
                    pbDescrip.BackgroundImage = Properties.Resources.fog;
                }
                else if (weatherData.WeatherDescription >= 800 && weatherData.WeatherDescription <= 802)
                {
                    this.BackgroundImage = Properties.Resources.sunshineBackground;
                    pbDescrip.BackgroundImage = Properties.Resources.Sunshine;
                }
                else if (weatherData.WeatherDescription >= 803 && weatherData.WeatherDescription <= 804)
                {
                    this.BackgroundImage = Properties.Resources.cloudybg;
                    pbDescrip.BackgroundImage = Properties.Resources.cloudy;
                }
                else if (weatherData.WeatherDescription == 900)
                {
                    this.BackgroundImage = Properties.Resources.raining;
                    pbDescrip.BackgroundImage = Properties.Resources.raincloud;
                }
                ////////////////////////////////////////////////////////////////////////////////////
                //updates the name of the city typed in
                lblWhere.Text = weatherData.City.ToString() + ", " + weatherData.State.ToString();
                //updates the temp
                lblTemp.Text = weatherData.Temperature.ToString();
                //updates the feels like temp
                lblFeelsLike.Text = "Feels like: " + weatherData.FeelsLikeTemp.ToString();

            }));
            //pushes the result to work completed
            e.Result = resultList;
            //waits 10 min per api
            Thread.Sleep(600 * 1000);
        }
        //after it gets data and updates
        private void RunWorkCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //checks for error on bg thread
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.ToString());
            }
            else
            {
                //pulls vars from list
                List<string> resultsList = (List<string>)e.Result;
                string place = resultsList[0].ToString();
                string key = resultsList[1].ToString();
                //restarts the bg thread ///////////////////////
                BackgroundWorker worker = new BackgroundWorker();
                List<string> arguementList = new List<string>();
                arguementList.Add(place);
                arguementList.Add(key);
                worker.DoWork += dowork;
                worker.RunWorkerCompleted += RunWorkCompleted;
                worker.RunWorkerAsync(argument: arguementList);
                ////////////////////////////////////////////////////
            }
        }
        //makes sure only letters can be entered for city
        private void txtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        //lets me move the window without the control bar on top
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
        //close button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //get weather button
        private void button2_Click(object sender, EventArgs e)
        {
            //validation//////
            bool validated = false;
            while (!validated)
            {
                if (txtCity.Text.Length < 1)
                {
                    MessageBox.Show("Please enter a city into the box");
                    break;
                }
                if (comboState.SelectedIndex < 1)
                {
                    MessageBox.Show("Please select a state.");
                    break;
                }
                validated = true;
            }////////////////////
            //puts input into vars
            string city = txtCity.Text.ToLower();
            string state = comboState.Text.ToUpper();
            //places input into correct state
            string place = city + "," + state;
            //gets api key
            var key = Creds.APIKEY;
            //creates a list for arguments to be pushed to the bg thread
            List<string> arguementList = new List<string>();
            arguementList.Add(place);
            arguementList.Add(key);
            //bg thread
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += dowork;
            worker.RunWorkerCompleted += RunWorkCompleted;
            worker.RunWorkerAsync(argument: arguementList);
            
            //turns off and turns on items
            button2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            txtCity.Visible = false;
            comboState.Visible = false;
            lblWhere.Visible = true;
            pbDescrip.Visible = true;
            lblTemp.Visible = true;
            lblFeelsLike.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
