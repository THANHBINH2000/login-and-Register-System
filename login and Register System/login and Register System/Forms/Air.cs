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
    public partial class Air : Form
    {
        private string user_pass;
        public Air(string login)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Air_Form_Load(object sender, EventArgs e)
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
            label4.ForeColor = ThemeColor.SecondaryColor;
        }

        private void button_Insert_Click(object sender, EventArgs e)
        {
            Air_Data std = new Air_Data()
            {
                ID = textBox_ID.Text,
                Value = textBox_Value.Text,
                Time = textBox_Time.Text,
                Clock = textBox_Clock.Text
            };
            string UserPass_Air = user_pass + " Air-List";
            string UserPass_HisAir = user_pass + " History-Air";
            FirebaseResponse setter = client.Set(UserPass_Air + "/" + textBox_ID.Text, std);
            MessageBox.Show("data inserted successfully");
            var history = client.Set(UserPass_HisAir + "/" + "Insert ID : " + textBox_ID.Text + " Time " + textBox_Clock.Text, std);
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            Air_Data std = new Air_Data()
            {
                ID = textBox_ID.Text,
                Value = textBox_Value.Text,
                Time = textBox_Time.Text,
                Clock = textBox_Clock.Text
            };
            string UserPass_Air = user_pass + " Air-List";
            string UserPass_HisAir = user_pass + " History-Air";
            FirebaseResponse response = client.Delete(UserPass_Air + "/" +textBox_ID.Text);
            MessageBox.Show("Deleted Data");
            var history = client.Set(UserPass_HisAir + "/" + "Delete ID : " + textBox_ID.Text + " Time " + textBox_Clock.Text,std);

        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            string UserPass_Air = user_pass + " Air-List";
            string UserPass_HisAir = user_pass + " History-Air";
            FirebaseResponse response = client.Get(UserPass_Air + "/" + textBox_ID.Text);
            Air_Data std = new Air_Data()
            {
                ID = textBox_ID.Text,
                Value = textBox_Value.Text,
                Time = textBox_Time.Text,
                Clock = textBox_Clock.Text
            };

            if (textBox_ID.Text.Equals(std.ID))
            {
                response = client.Set(UserPass_Air + "/" + textBox_ID.Text, std);
                MessageBox.Show("data Update successfully");
                var history = client.Set(UserPass_HisAir + "/" + "Update ID : " + textBox_ID.Text + " Time " + textBox_Clock.Text, std);
                textBox_ID.Text = string.Empty;
                textBox_Value.Text = string.Empty;
                textBox_Time.Text = string.Empty;
                textBox_Clock.Text = string.Empty;
            }
        }

        public void loadData()
        {
            string UserPass_Air = user_pass + " Air-List";
            string UserPass_HisAir = user_pass + " History-Air";
            try
            {
                FirebaseResponse response = client.Get(UserPass_Air + "/");
                Dictionary<string, Air_Data> getData = response.ResultAs<Dictionary<string, Air_Data>>();

                foreach (var get in getData)
                {
                    dataGridView1.Rows.Add(

                        get.Value.ID,
                        get.Value.Value,
                        get.Value.Time,
                        get.Value.Clock
                        );
                }
            }
            catch
            {
                MessageBox.Show("No Data");
            }
            
        }

        private void button_ShowData_Click(object sender, EventArgs e)
        {
            string UserPass_Air = user_pass + " Air-List";
            string UserPass_HisAir = user_pass + " History-Air";

            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Value");
            dt.Columns.Add("Time");
            dt.Columns.Add("Clock");

            FirebaseResponse response = client.Get(UserPass_Air + "/");
            Dictionary<string, Air_Data> getData = response.ResultAs<Dictionary<string, Air_Data>>();

            try
            {
                foreach (var get in getData)
                {
                    dt.Rows.Add(

                        get.Value.ID,
                        get.Value.Value,
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
            string UserPass_Air = user_pass + " Air-List";
            string UserPass_HisAir = user_pass + " History-Air";
            FirebaseResponse response = client.Get(UserPass_Air + "/" + textBox_ID.Text);

            Air_Data std = response.ResultAs<Air_Data>();

            if (textBox_ID.Text.Equals(std.ID))
            {
                textBox_Value.Text = std.Value;
                textBox_Time.Text = std.Time;

                MessageBox.Show("Data Found");
            }
            var history = client.Set(UserPass_HisAir + "/" + "Retrieve ID : " + textBox_ID.Text + " Time " + textBox_Clock.Text, std);
        }

        private void textBox_Time_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox_Clock.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
        }

     }
}
