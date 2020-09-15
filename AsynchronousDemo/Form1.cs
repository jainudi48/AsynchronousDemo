using AsynchronousDemo.Data;
using AsynchronousDemo.Managers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            foreach (var job in jobs.JobList)
            {
                rtbSyncJobs.Text += job + "\n";
                rtbAsyncJobs.Text += job + "\n";
            }
        }

        private void btnSyncReset_Click(object sender, EventArgs e)
        {
            rtbSyncProcessedTime.Text = string.Empty;
            lblSyncCPUTime.Text = string.Empty;
        }

        private void btnAsyncReset_Click(object sender, EventArgs e)
        {
            rtbAsyncProcessedTime.Text = string.Empty;
            lblAsyncCPUTime.Text = string.Empty;
        }

        private void btnSyncRun_Click(object sender, EventArgs e)
        {
            rtbSyncProcessedTime.Text = string.Empty;
            lblSyncCPUTime.Text = string.Empty;
            WebsiteDownloadManager processSync = new WebsiteDownloadManager();

            Stopwatch sw = Stopwatch.StartNew();
            foreach (var jobURI in jobs.JobList)
            {
                rtbSyncProcessedTime.Text += processSync.DownloadWebsite(jobURI).ToString() + "\n";
            }
            sw.Stop();

            lblSyncCPUTime.Text = sw.ElapsedMilliseconds.ToString();
        }

        private async void btnAsyncRun_Click(object sender, EventArgs e)
        {
            rtbAsyncProcessedTime.Text = string.Empty;
            lblAsyncCPUTime.Text = string.Empty;
            WebsiteDownloadManager process = new WebsiteDownloadManager();
            List<Task<int>> tasks = new List<Task<int>>();

            Stopwatch sw = Stopwatch.StartNew();
            foreach (var jobURI in jobs.JobList)
            {
                tasks.Add(Task.Run(() => process.DownloadWebsite(jobURI)));
            }

            var timeList = await Task.WhenAll(tasks);
            sw.Stop();

            foreach (var time in timeList)
            {
                rtbAsyncProcessedTime.Text += time + "\n";
            }

            lblAsyncCPUTime.Text = sw.ElapsedMilliseconds.ToString();
        }
    }
}
