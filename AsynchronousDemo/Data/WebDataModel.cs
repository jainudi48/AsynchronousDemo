using System;

namespace AsynchronousDemo.Data
{
    class WebDataModel
    {
        public string URI { get; set; } = "";
        public string WebData { get; set; } = "";
        public TimeSpan TimeElapsed { get; set; } = TimeSpan.Zero;
    }
}
