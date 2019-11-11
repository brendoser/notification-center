using NotificationCenter.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NotificationCenter.Views
{ 
    public partial class NotificationCenterControl : UserControl
    {
        public NotificationCenterViewModel myNotificationCenterControl = new NotificationCenterViewModel();

        public NotificationCenterControl()
        {
            InitializeComponent();
            DataContext = myNotificationCenterControl;
        }
    }
}
