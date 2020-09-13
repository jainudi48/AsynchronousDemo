using AsynchronousDemo.Data;
using AsynchronousDemo.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsynchronousDemo
{
    public partial class Form1 : Form
    {
        JobDataModel jobs;
        public Form1()
        {
            InitializeComponent();
            AddJobs();
        }

        private void AddJobs()
        {
            jobs = new JobDataModel();
            foreach(var job in jobs.JobList)
            {
                rtbSyncJobs.Text += job + "\n";
                rtbAsyncJobs.Text += job + "\n";
            }
        }

        private void btnSyncReset_Click(object sender, EventArgs e)
        {
            rtbSyncProcessedTime.Text = string.Empty;
            lblSyncCPUTime.Text = string.Empty;
            lblSyncClockTime.Text = string.Empty;
        }

        private void btnAsyncReset_Click(object sender, EventArgs e)
        {
            rtbAsyncProcessedTime.Text = string.Empty;
            lblAsyncCPUTime.Text = string.Empty;
            lblAsyncClockTime.Text = string.Empty;
        }

        private void btnSyncRun_Click(object sender, EventArgs e)
        {
            int totalCPUTime = 0;
            rtbSyncProcessedTime.Text = string.Empty;
            lblSyncCPUTime.Text = string.Empty;
            lblSyncClockTime.Text = string.Empty;
            WebsiteDownloadManager processSync = new WebsiteDownloadManager();

            Stopwatch stopwatch = Stopwatch.StartNew();
            foreach (var jobURI in jobs.JobList)
            {
                rtbSyncProcessedTime.Text += processSync.DownloadWebsite(jobURI, ref totalCPUTime).ToString() + "\n";
            }
            stopwatch.Stop();

            lblSyncClockTime.Text = stopwatch.ElapsedMilliseconds.ToString();
            lblSyncCPUTime.Text = totalCPUTime.ToString();
        }

        private async void btnAsyncRun_Click(object sender, EventArgs e)
        {
            int totalCPUTime = 0;
            rtbAsyncProcessedTime.Text = string.Empty;
            lblAsyncCPUTime.Text = string.Empty;
            lblAsyncClockTime.Text = string.Empty;
            WebsiteDownloadManager process = new WebsiteDownloadManager();
            List<Task<int>> tasks = new List<Task<int>>();

            Stopwatch stopwatch = Stopwatch.StartNew();
            foreach (var jobURI in jobs.JobList)
            {
                tasks.Add(Task.Run(() => process.DownloadWebsite(jobURI, ref totalCPUTime)));
            }
            
            var timeList = await Task.WhenAll(tasks);
            stopwatch.Stop();

            foreach (var time in timeList)
            {
                rtbAsyncProcessedTime.Text += time + "\n";
            }

            lblAsyncClockTime.Text = stopwatch.ElapsedMilliseconds.ToString();
            lblAsyncCPUTime.Text = totalCPUTime.ToString();
        }
    }
}
