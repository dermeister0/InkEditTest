using Microsoft.Ink;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InkTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    var ie = new InkEdit { Left = x * 50, Top = y * 50, Width = 40, Height = 40 };
                    panel1.Controls.Add(ie);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        private void btnDisposeAndClear_Click(object sender, EventArgs e)
        {
            foreach (Control control in panel1.Controls)
            {
                control.Dispose();
            }

            panel1.Controls.Clear();

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }



        private void btnDemo1_Click(object sender, EventArgs e)
        {
            var startMemory = Process.GetCurrentProcess().PrivateMemorySize64;

            btnCreate_Click(sender, e);
            Thread.Sleep(1000);
            btnClear_Click(sender, e);

            var finalMemory = Process.GetCurrentProcess().PrivateMemorySize64;
            var diff = (finalMemory - startMemory) / 1024 / 1024;

            MessageBox.Show($"+{diff} MiB");
        }

        private void btnDemo2_Click(object sender, EventArgs e)
        {
            var startMemory = Process.GetCurrentProcess().PrivateMemorySize64;

            btnCreate_Click(sender, e);
            Thread.Sleep(1000);
            btnDisposeAndClear_Click(sender, e);

            var finalMemory = Process.GetCurrentProcess().PrivateMemorySize64;
            var diff = (finalMemory - startMemory) / 1024 / 1024;

            MessageBox.Show($"+{diff} MiB");
        }


    }
}
