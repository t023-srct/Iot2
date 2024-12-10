using System;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Data.SqlClient;

namespace Iot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 10 * 60 * 1000; // 10 นาที
            timer1.Tick += timer1_Tick;
            timer1.Start();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //DateTime now = DateTime.Now;

            //if (now.Second == 0 || now.Second == 10 || now.Second == 20 || now.Second == 30 || now.Second == 40 || now.Second == 50)
            //{
            //    LoadData();
            //}
            //LoadData();
            // อัพเดตทุก 1 วิ
            //timer1.Interval = 10 * 60 * 1000; // 10 นาที
            //timer1.Tick += timer1_Tick;
            //timer1.Start();
            LoadData();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //    //System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            //    //timer.Interval = (1 * 1000); // 1 seconds in milliseconds
            //    //timer.Tick += new EventHandler(timer1_Tick);
            //    //timer.Start();
            //    // อัพเดตทุก 1 วิ
            //    timer1.Interval = 1 * 60 * 1000; // 10 นาที
            //    timer1.Tick += timer1_Tick;
            //    timer1.Start();
            LoadData();

        }

        private async void LoadData()
        {
            try
            {
                string url = "http://10.0.0.1/di_value/slot_0"; // URL API
                using (HttpClient client = new HttpClient())
                {
                    // เพิ่ม Authentication Header
                    var byteArray = Encoding.ASCII.GetBytes("root:00000000"); // root = username, 00000000 = password
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

                    // เรียก API
                    string response = await client.GetStringAsync(url);

                    // อัปเดต Label ด้วยข้อมูล JSON
                    UpdateLabels(response);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void UpdateLabels(string json)
        {
            try
            {
                var data = JObject.Parse(json);
                var diVal = data["DIVal"];

                if (diVal != null && diVal.HasValues) // ตรวจสอบว่ามีข้อมูลใน DIVal
                {
                    DateTime now = DateTime.Now;

                    foreach (var item in diVal)
                    {
                        int? channel = item["Ch"]?.Value<int?>();
                        int? value = item["Val"]?.Value<int?>();

                        if (channel.HasValue && value.HasValue)
                        {
                            // แปลงค่าเป็น ON/OFF
                            string statusText = value.Value == 1 ? "ON" : "OFF";
                            Color statusColor = value.Value == 1 ? Color.Green : Color.Red;

                            // อัปเดต Label
                            switch (channel.Value)
                            {
                                case 0:
                                    labelStatus0.Text = statusText;
                                    labelStatus0.ForeColor = statusColor;
                                    break;
                                case 1:
                                    labelStatus1.Text = statusText;
                                    labelStatus1.ForeColor = statusColor;
                                    break;
                                case 2:
                                    labelStatus2.Text = statusText;
                                    labelStatus2.ForeColor = statusColor;
                                    break;
                                case 3:
                                    labelStatus3.Text = statusText;
                                    labelStatus3.ForeColor = statusColor;
                                    break;
                            }

                            // บันทึกลงฐานข้อมูล
                            SaveToDatabase(channel.Value, value.Value, now);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No data found in DIVal.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SaveToDatabase(int channel, int value, DateTime timestamp)
        {
            try
            {
                // Connection String
                string connectionString = "Server=DESKTOP-GRJ8OJC\\SQLEXPRESS;Database=IoT;Trusted_Connection=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL Command สำหรับ INSERT ข้อมูล
                    string query = "INSERT INTO dbo.Status (Ch, Val, DT) VALUES (@channel, @value, @timestamp)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@channel", "Ch" + channel); // แปลงเลข Channel เป็น "Ch0", "Ch1", ...
                        command.Parameters.AddWithValue("@value", value);
                        command.Parameters.AddWithValue("@timestamp", timestamp);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        
    }
}
