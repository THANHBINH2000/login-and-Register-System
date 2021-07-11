using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace login_and_Register_System.Forms
{
    public partial class Form_LED : Form
    {
        private string user_pass;
        public Form_LED(string login)
        {
            InitializeComponent();
            this.user_pass = login;
        }
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "yKfYk7fqfvZ1CYopCZls6mlFaih1WP3DM01hH0EL",
            BasePath = "https://fir-183c6-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;

        private void Form_LED_Load(object sender, EventArgs e)
        {
            LoadTheme();
            timer1.Start();
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("there was problem in the internet.");
            }
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btns.BackColor = ThemeColor.PrimaryColor;
                    btns.ForeColor = Color.Gainsboro;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                    //btns.Font = new System.Drawing.Font("Baskerville Old Face", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
            Data_lable.ForeColor = ThemeColor.SecondaryColor;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox_Clock.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
        }

        private void button_ShowData_Click(object sender, EventArgs e)
        {
            string UserPass_Led = user_pass + " Led-List";
            string UserPass_Hisled = user_pass + " History-Led";

            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Device");
            dt.Columns.Add("Time");
            dt.Columns.Add("Clock");

            FirebaseResponse response = client.Get(UserPass_Led + "/");
            Dictionary<string, Data_Led> getData = response.ResultAs<Dictionary<string, Data_Led>>();

            try
            {
                foreach (var get in getData)
                {
                    dt.Rows.Add(

                        get.Value.ID,
                        get.Value.Device,
                        get.Value.Time,
                        get.Value.Clock
                        );
                }
            }
            catch
            {
                MessageBox.Show("No Data");
            }

            DataView dv = new DataView(dt);

            if (comboBox1.Text != "")
                dv.RowFilter = "[" + comboBox1.Text + "]" + " LIKE '%" + textBox_search.Text + "%'";
            else
                MessageBox.Show("Can't Find Data");

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = dv;


            int count = dataGridView1.RowCount;
            textBox_NumberData.Text = count.ToString();
        }

        private void button_Retrieve_Click(object sender, EventArgs e)
        {
            string UserPass_Led = user_pass + " Led-List";
            string UserPass_HisLed = user_pass + " History-led";
            FirebaseResponse response = client.Get(UserPass_Led + "/" + textBox_ID.Text);

            Data_Led std = response.ResultAs<Data_Led>();

            if (textBox_ID.Text.Equals(std.ID))
            {
                textBox_Device.Text = std.Device;
                textBox_Time.Text = std.Time;

                MessageBox.Show("Data Found");
            }
            var history = client.Set(UserPass_HisLed + "/" + "Retrieve ID : " + textBox_ID.Text + " Time " + textBox_Clock.Text, std);
        }

        private void button_Insert_Click(object sender, EventArgs e)
        {
            string UserPass_Led = user_pass + " Led-List";
            string UserPass_HisLed = user_pass + " History-led";
            Data_Led std = new Data_Led()
            {
                ID = textBox_ID.Text,
                Device = textBox_Device.Text,
                Time = textBox_Time.Text,
                Clock = textBox_Clock.Text
            };
            FirebaseResponse setter = client.Set(UserPass_Led + "/" + textBox_ID.Text, std);
            MessageBox.Show("data inserted successfully");
            var history = client.Set(UserPass_HisLed + "/" + "Insert ID : " + textBox_ID.Text + " Time " + textBox_Clock.Text, std);
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            Data_Led std = new Data_Led()
            {
                ID = textBox_ID.Text,
                Device = textBox_Device.Text,
                Time = textBox_Time.Text,
                Clock = textBox_Clock.Text
            };
            string UserPass_Led = user_pass + " Led-List";
            string UserPass_HisLed = user_pass + " History-led";
            FirebaseResponse response = client.Delete(UserPass_Led + "/" + textBox_ID.Text);
            MessageBox.Show("Deleted Data");
            var history = client.Set(UserPass_HisLed + "/" + "Delete ID : " + textBox_ID.Text + " Time " + textBox_Clock.Text, std);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UserPass_Led = user_pass + " Led-List";
            string UserPass_HisLed = user_pass + " History-led";

            FirebaseResponse response = client.Get(UserPass_Led + "/" + textBox_ID.Text);
            Data_Led std = new Data_Led()
            {
                ID = textBox_ID.Text,
                Device = textBox_Device.Text,
                Time = textBox_Time.Text,
                Clock = textBox_Clock.Text
            };

            if (textBox_ID.Text.Equals(std.ID))
            {
                response = client.Set(UserPass_Led + "/" + textBox_ID.Text, std);
                MessageBox.Show("data Update successfully");
                var history = client.Set(UserPass_HisLed + "/" + "Update ID : " + textBox_ID.Text + " Time " + textBox_Clock.Text, std);
                textBox_ID.Text = string.Empty;
                textBox_Device.Text = string.Empty;
                textBox_Time.Text = string.Empty;
                textBox_Clock.Text = string.Empty;
            }
        }
    }
}




