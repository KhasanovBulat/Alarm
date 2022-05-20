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
    public partial class Settings : Form
    {
        Alarm_Main form1 = new Alarm_Main();
        public Settings()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                form1.AlarmTime.Text = hours_cb.Text + ":" + min_cb.Text;
                form1.AlarmName_1.Text = alarm_name.Text;
                if (Yes.Checked)
                {
                    form1.Repeats.Text = "Повторяется";
                }
                if (No.Checked)
                {
                    form1.Repeats.Text = "Не повторяется";
                }
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
