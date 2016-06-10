namespace TouchAssistant
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Point startPoint;

        private int minHeight = 100;

        private int fullHeight = 200;

        private bool isActivated = false;

        private DateTime lastActivation = DateTime.Now;

        private ApplicationModel[] model;

        private MainWindowViewModel viewModel;

        public MainWindow()
        {
            this.InitializeComponent();
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            WindowHelper.SetWindowStyle(this, WindowHelper.WindowStyle.NoActivate);
        }

        private void Deactivation()
        {
            this.Opacity = 0.3;
            this.isActivated = false;
        }

        private void Activation()
        {
            this.lastActivation = DateTime.Now;
            if (this.isActivated) return;
            this.Opacity = 0.8;
            var dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += (s, e) =>
            {
                Debug.WriteLine("Tick");
                if ((DateTime.Now - this.lastActivation).TotalSeconds > 2)
                {
                    this.Deactivation();
                }

                dispatcherTimer.Stop();
            };
            dispatcherTimer.Interval = new TimeSpan(0, 0, 3);
            dispatcherTimer.Start();
            this.isActivated = true;
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            var currentPoint = e.GetPosition(button);
            if (e.LeftButton == MouseButtonState.Pressed && button.IsMouseCaptured &&
                (Math.Abs(currentPoint.X - this.startPoint.X) > SystemParameters.MinimumHorizontalDragDistance ||
                Math.Abs(currentPoint.Y - this.startPoint.Y) > SystemParameters.MinimumVerticalDragDistance))
            {
                // Prevent Click from firing
                button.ReleaseMouseCapture();
                this.DragMove();
            }
        }

        private void Button_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var button = sender as Button;
            this.startPoint = e.GetPosition(button);
        }

        private void Switch_Button_Click(object sender, RoutedEventArgs e)
        {
            this.SwitchSize();
        }

        private void SwitchSize()
        {
            if (this.SizeToContent == SizeToContent.Height)
            {
                this.SizeToContent = SizeToContent.Manual;
                this.Height = this.minHeight;
            }
            else
            {
                this.SizeToContent = SizeToContent.Height;
                this.Height = double.NaN;
            }
        }

        private void Shortcut_Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var vm = button?.DataContext as KeyViewModel;
            if (!vm?.Key.HasValue ?? false)
            {
                Debug.WriteLine("No value");
                return;
            }

            SendKeys.Send(vm.Key.Value);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.fullHeight = (int)this.Height;
            this.SwitchSize();
            this.Activation();
            this.model = DataGen.GetData();
            this.viewModel = new MainWindowViewModel();
            this.DataContext = this.viewModel;
            this.StartSearchingWindow();
        }

        private void StartSearchingWindow()
        {
            var dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += (s, e) =>
            {
                var title = WindowHelper.GetActiveWindowTitle();
                if (title == null) return;
                var am = this.model.FirstOrDefault(_ => Regex.IsMatch(title, _.TitleMatchPattern));
                this.viewModel.InitData(am);
            };
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 800);
            dispatcherTimer.Start();
        }

        private void Window_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            this.Activation();
        }
    }
}