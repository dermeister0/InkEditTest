using Microsoft.Ink;
using System;
using System.Diagnostics;
using System.Threading;
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

        private void btnDisposeAndClear_Click(object sender, EventArgs e)
        {
            while (panel1.Controls.Count > 0)
            {
                var lastIndex = panel1.Controls.Count - 1;
                var control = panel1.Controls[lastIndex];
                panel1.Controls.RemoveAt(lastIndex);

                control.Dispose();
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
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

        private void btnDemo3_Click(object sender, EventArgs e)
        {
            var startMemory = Process.GetCurrentProcess().PrivateMemorySize64;

            for (int i = 0; i < 10; i++)
            {
                btnCreate_Click(sender, e);
                Thread.Sleep(1000);
                btnDisposeAndClear_Click(sender, e);
                Thread.Sleep(1000);
            }

            var finalMemory = Process.GetCurrentProcess().PrivateMemorySize64;
            var diff = (finalMemory - startMemory) / 1024 / 1024;

            MessageBox.Show($"+{diff} MiB");
        }
    }
}