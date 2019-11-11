using NotificationCenter.Views;
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

namespace NotificationCenter
{
    public partial class MainWindow : Window
    {
        public NotificationCenterControl notificationCenterControl { get; set; } = new NotificationCenterControl();

        public MainWindow()
        {
            InitializeComponent();
            contentPresenter.Content = notificationCenterControl;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            notificationCenterControl.myNotificationCenterControl.AddNotification("Red", "Red header", "Red body is here....");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            notificationCenterControl.myNotificationCenterControl.AddNotification("Blue", "Blue header", "Blue body is here....");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            notificationCenterControl.myNotificationCenterControl.AddNotification("Yellow", "Yellow header", "Yellow body is here....");
        }
    }
}
