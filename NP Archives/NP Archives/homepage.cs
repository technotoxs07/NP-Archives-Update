using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace NP_Archives
{
    public partial class homepage : Form
    {

        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState (out int conn, int val);

        int mov;
        int movX;
        int movY;
        public homepage()
        {
            InitializeComponent();
        }

        private void homepage_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbltimer.Text = DateTime.Now.ToLongTimeString();
            lbldate.Text = DateTime.Now.ToLongDateString();

            //checking internet connection
            int Out;
            if(InternetGetConnectedState(out Out, 0) == true)
            {
                lblinternetconnectioncheck.Text = "Connected To Server";
                lblinternetconnectioncheck.ForeColor= Color.Green;
            }
            else
            {
                lblinternetconnectioncheck.Text = "Oops! You Are not Connected to Internet And Server";
                lblinternetconnectioncheck.ForeColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            startup_age stp = new startup_age();
            stp.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void schoollvlbn_Click(object sender, EventArgs e)
        {
            gotoschool(new schoollevel());
        }

        private Form activeForm = null;

        private void gotoschool(schoollevel ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            backgrod.Controls.Add(ChildForm);
            backgrod.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void backgrod_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            lbltimer.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

      

        private void gotocollege(collegelevel ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            backgrod.Controls.Add(ChildForm);
            backgrod.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void btncollegelevel_Click(object sender, EventArgs e)
        {
            gotocollege(new collegelevel());

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            gotobachelors(new bachelorslevel());
        }

        private void gotobachelors(bachelorslevel ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            backgrod.Controls.Add(ChildForm);
            backgrod.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Only For CSIT And Admin User", MessageBoxButtons.RetryCancel.ToString());
        }
    }
}