using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm
{
    public partial class Alarm_Main : Form
    {
        public Alarm_Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Settings settings = new Settings();
           
        }
    }
}
