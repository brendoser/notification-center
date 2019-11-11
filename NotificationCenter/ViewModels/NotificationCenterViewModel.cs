using NotificationCenter.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace NotificationCenter.ViewModels
{
    public class NotificationCenterViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<NotificationData> notifications = new ObservableCollection<NotificationData>() {};

        public ObservableCollection<NotificationData> Notifications
        {
            get { return notifications; }
            set { notifications = value;  NotifyPropertyChanged("Notifications"); }
        }

        public void AddNotification(string color, string header, string body)
        {
            SolidColorBrush Color = null;
            if(color == "Red")
            {
                Color = Brushes.Red;
            }
            else if(color == "Blue")
            {
                Color = Brushes.Blue;
            }
            else if(color == "Yellow")
            {
                Color = Brushes.Yellow;
            }
            notifications.Add(new NotificationData(Color, header, body));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
