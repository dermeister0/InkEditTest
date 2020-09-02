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

            SimpleHelpers.ObjectPool<InkEdit>.MaxCapacity = 16;
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                SimpleHelpers.ObjectPool<InkEdit>.Clear();

                components?.Dispose();
            }
            base.Dispose(disposing);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    InkEdit ie = SimpleHelpers.ObjectPool<InkEdit>.Get(() => new InkEdit());

                    ie.Left = x * 50;
                    ie.Top = y * 50;
                    ie.Width = 40;
                    ie.Height = 40;

                    panel1.Controls.Add(ie);
                }
            }
        }

        private void btnDisposeAndClear_Click(object sender, EventArgs e)
        {
            for (int i = panel1.Controls.Count - 1; i >= 0; i--)
            {
                var control = panel1.Controls[i] as InkEdit;
                SimpleHelpers.ObjectPool<InkEdit>.Put(control);
            }
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