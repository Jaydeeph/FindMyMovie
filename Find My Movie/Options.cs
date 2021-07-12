using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Find_My_Movie
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            CustomFormatCheckBox.Checked = Properties.Settings.Default.UseCustomMovieFormat;
        }

        private void Options_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.UseCustomMovieFormat = CustomFormatCheckBox.Checked;
            Properties.Settings.Default.Save();
        }

        private void OnClick(object sender, EventArgs e)
        {
            base.OnClick(e);
            this.Close();
        }
    }
}
