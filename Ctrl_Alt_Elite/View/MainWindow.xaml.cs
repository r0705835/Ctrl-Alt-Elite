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
            /*GoToScreenIndividualStore = new EasyCommand(() => SwitchTo(new ScreenPuzzleGame(navigator)));
            GoToScreenStoreOverview = new EasyCommand(() => SwitchTo(new ScreenPuzzleSelection(navigator)));*/
        }
        /*
        public ICommand GoToScreenIndividualStore { get; }

        public ICommand GoToScreenStoreOverview { get; }
        */
    }


    /*internal class ScreenPuzzleGame : MainWindow.Screen
    {
        public ScreenPuzzleGame(MainWindow.Navigator navigator) : base(navigator)
        {
        }
    }*/
}
