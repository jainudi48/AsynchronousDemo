using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousDemo.Data
{
    class WebDataModel
    {
        public string URI { get; set; } = "";
        public string WebData { get; set; } = "";
        public TimeSpan TimeElapsed { get; set; } = TimeSpan.Zero;
    }
}
