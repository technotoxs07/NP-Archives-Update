using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace NP_Archives
{
    public partial class startup_age : Form
    {
        public startup_age()
        {
            InitializeComponent();
        }

        private void startup_age_Load(object sender, EventArgs e)
        {
            tmrwastetine.Start();

        }

        private void timefader_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.01)
                this.Opacity = this.Opacity - 0.03;
            else
                kill_tmrFader();
        }
        homepage hmp = new homepage();

        private void kill_tmrFader()
        {
            timefader.Stop();
            hmp.ShowDialog();
            startup_age stp = new startup_age();
            stp.Close();
        }

        private void tmrwastetine_Tick(object sender, EventArgs e)
        {
            tmrwastetine.Stop();
            timefader.Start();
        }
    }
}
