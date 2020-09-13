﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousDemo.Data
{
    class JobDataModel
    {
        public string[] JobList { get; } = new string[] 
        { 
            "https://www.youtube.com/",
            "https://developer.android.com/docs",
            "https://www.getcusjo.com/", 
            "https://timesofindia.indiatimes.com/news", 
            "https://www.amazon.in/", 
            "https://edition.cnn.com/", 
            "https://stackoverflow.com/" 
        };
    }
}
