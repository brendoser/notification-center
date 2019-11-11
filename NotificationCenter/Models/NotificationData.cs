using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace NotificationCenter.ViewModels
{
    public class NotificationData
    {
        public SolidColorBrush Fill { get; set; } = Brushes.Blue;

        public string Header { get; set; }

        public string Body { get; set; }

        public NotificationData(SolidColorBrush fill, string header, string body)
        {
            Fill = fill;
            Header = header;
            Body = body;
        }
    }
}
