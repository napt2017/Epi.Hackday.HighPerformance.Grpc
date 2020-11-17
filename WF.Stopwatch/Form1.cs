using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace WF.Stopwatch
{
    public partial class Form1 : Form
    {
        private System.Diagnostics.Stopwatch _stopwatch;
        private volatile bool _isStop = false;

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            _stopwatch = System.Diagnostics.Stopwatch.StartNew();
            while (!_isStop)
            {
                if (lbTime.InvokeRequired)
                {

                }
                else
                {
                    lbTime.Text = string.Format("{0:hh\\:mm\\:ss}", _stopwatch.E);
                }
            }
        }
    }
}
