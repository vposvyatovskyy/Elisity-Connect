using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Elisity_Connect.ViewModel
{
    public class MainWindowViewModel
    {
        public DateTime CurrentDateTime { get; set; } = new DateTime();
        public string ActiveTime { get; set; }
        public MainWindowViewModel()
        {
            CurrentDateTime = DateTime.Now;
            ActiveTime = string.Format("Active Time: {0}", DateTime.Now.TimeOfDay.TotalHours.ToString());
        }

    }
}
