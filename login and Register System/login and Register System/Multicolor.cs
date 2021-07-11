using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace login_and_Register_System
{
    public partial class Multicolor : Form
    {
        private string user_pass;

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "yKfYk7fqfvZ1CYopCZls6mlFaih1WP3DM01hH0EL",
            BasePath = "https://fir-183c6-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;

        private Button currentButton;// Feild này để nhận giá trị của nút nhấn
        private Random random;// Feild này để nhận giá trị của Random
        private int temIndex;
        private Form activeForm;


        public Multicolor(string login)
        {
            InitializeComponent();
            random = new Random();
            button_Go_Home.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.user_pass = login;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] // thư viện này giúp việc kéo giản form phù hợp
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (temIndex == index)
            {
               index = random.Next(ThemeColor.ColorList.Count);
            }
            temIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActiveButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color,-0.2);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.2);
                    button_Go_Home.Visible = true;
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)// Phương thức setup các Form con khi nhân nút
        {
            if (activeForm != null)// Đóng Form chính
            {
                activeForm.Close();
            }
            ActiveButton(btnSender);// Xác định nút nhấn
            activeForm = childForm;// Mở Form tương ứng
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_Desktop.Controls.Add(childForm); // Đưa các Form con vào vùng làm việc Desktop 
            //this.panelDesktop.Tag = childForm;
            childForm.BringToFront();// Xóa phần Desktop cũ
            childForm.Show();
            label_Home.Text = childForm.Text;// Chỉnh Lable theo tên của form con
        }

        private void DisableButton()
        {
            panelMenu.BackColor = Color.FromArgb(76, 0, 153);
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(76,0,153);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void House_button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Form_House(user_pass), sender);
        }

        private void button_Air_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Air(user_pass), sender);
        }

        private void Hum_button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Humidity(user_pass), sender);
        }

        private void Tem_button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Form_Tem(user_pass), sender);
        }

        private void Led_button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Form_LED(user_pass), sender);
        }

        private void button_Go_Home_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(0, 153, 153);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
            label_Home.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0,153,153);
            panelLogo.BackColor = Color.FromArgb(0,70,70);
            panelMenu.BackColor = Color.FromArgb(0, 153, 153);
            currentButton = null;
            button_Go_Home.Visible = false;
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_MaxZise_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button_MinSize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void Multicolor_Load(object sender, EventArgs e)
        {
            Lable_ID.Text = "B-N-Q";
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
