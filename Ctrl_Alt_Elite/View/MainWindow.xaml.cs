using Screens;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new Navigator();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }

    public class Navigator : INotifyPropertyChanged
    {
        private Screen currentScreen;

        public Navigator()
        {
            this.currentScreen = new ScreenMenu(this);
        }

        public Screen CurrentScreen
        {
            get
            {
                return currentScreen;
            }
            set
            {
                this.currentScreen = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentScreen)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    public abstract class Screen
    {
        protected readonly Navigator navigator;

        protected Screen(Navigator navigator)
        {
            this.navigator = navigator;
        }

        protected void SwitchTo(Screen screen)
        {
            this.navigator.CurrentScreen = screen;
        }
    }

    public class ScreenMenu : Screen
    {
        public ScreenMenu(Navigator navigator) : base(navigator)
        {
            GoToScreenIndividualStore = new EasyCommand(() => SwitchTo(new ScreenIndividualStore(navigator)));
            GoToScreenStoreOverview = new EasyCommand(() => SwitchTo(new ScreenStoreOverview(navigator)));
            GoToScreenRewards = new EasyCommand(() => SwitchTo(new ScreenRewards(navigator)));

        }

        public ICommand GoToScreenIndividualStore { get; }

        public ICommand GoToScreenStoreOverview { get; }

        public ICommand GoToScreenRewards { get; }

    }


    public class ScreenIndividualStore : Screen
    {
        public ScreenIndividualStore(Navigator navigator) : base(navigator)
        {
        }
    }

    public class ScreenStoreOverview : Screen
    {
        public ScreenStoreOverview(Navigator navigator) : base(navigator)
        {
        }
    }

    public class ScreenRewards : Screen
    {
        public ScreenRewards(Navigator navigator) : base(navigator)
        {
        }
    }
}
