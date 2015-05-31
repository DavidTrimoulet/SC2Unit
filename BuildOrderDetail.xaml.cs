using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Windows.Threading;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using SC2Unit.ViewModels;

namespace SC2Unit
{
    public partial class BuildOrderDetail : PhoneApplicationPage, INotifyPropertyChanged
    {
        private ObservableCollection<Order> playedOrder;
        public ObservableCollection<Order> PlayedOrder 
        { 
            get { return playedOrder; } 
            set { NotifyPropertyChanged(ref playedOrder, value) ;} 
        }

       
        public BuildOrder CurrentBuildOrder { get; set; }
        public int LastCursor { get; set; }
        public int OrderCursor { get; set; }
        public int TimerCursor { get; set; }
        public PlayManager OrderPlayer { get; set; }
        public DispatcherTimer Timer { get; set; }

        public BuildOrderDetail()
        {
            InitializeComponent();
            OrderPlayer = new PlayManager();
            PlayedOrder = new ObservableCollection<Order>();
            Timer = new DispatcherTimer();
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            if (DataContext == null)
            {
                string selectedItem = "";
                NavigationContext.QueryString.TryGetValue("selectedItem", out selectedItem);
                CurrentBuildOrder = App.ViewModel.FindBuildOrder(selectedItem);
                TitleTextBlock.Text = CurrentBuildOrder.Title;
                DataContext = PlayedOrder;
                OrderCursor = 0;
                TimerCursor = 0;
                LastCursor = CurrentBuildOrder.Orders.Count;
                RunOrder();
            }


        }

        void RunOrder()
        {
            if (TimerCursor < LastCursor)
            {
                Timer.Interval = TimeSpan.FromSeconds(CurrentBuildOrder.Orders.ElementAt(TimerCursor).Timing);
                Timer.Tick += OnTimerTick;
                TimerCursor++;
                Timer.Start();
            }
            
        }

        void OnTimerTick(Object sender, EventArgs args)
        {
            if (OrderCursor < LastCursor)
            {
                PlayedOrder.Add(CurrentBuildOrder.Orders.ElementAt(OrderCursor));
                OrderPlayer.PlayOrder(CurrentBuildOrder.Orders.ElementAt(OrderCursor).Content);
                OrderCursor++;
                RunOrder();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool NotifyPropertyChanged<T>(ref T variable, T valeur, [CallerMemberName] string propertyName = null)
        {
            if (object.Equals(variable, valeur)) return false;

            variable = valeur;
            NotifyPropertyChanged(propertyName);
            return true;
        }
        
    }
}