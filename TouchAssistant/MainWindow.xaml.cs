namespace TouchAssistant
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Interop;

    /// <summary>
    /// Enumeration for virtual keys.
    /// </summary>
    public enum VirtualKeys
        : ushort
    {
        /// <summary></summary>
        LeftButton = 0x01,

        /// <summary></summary>
        RightButton = 0x02,

        /// <summary></summary>
        Cancel = 0x03,

        /// <summary></summary>
        MiddleButton = 0x04,

        /// <summary></summary>
        ExtraButton1 = 0x05,

        /// <summary></summary>
        ExtraButton2 = 0x06,

        /// <summary></summary>
        Back = 0x08,

        /// <summary></summary>
        Tab = 0x09,

        /// <summary></summary>
        Clear = 0x0C,

        /// <summary></summary>
        Return = 0x0D,

        /// <summary></summary>
        Shift = 0x10,

        /// <summary></summary>
        Control = 0x11,

        /// <summary></summary>
        Menu = 0x12,

        /// <summary></summary>
        Pause = 0x13,

        /// <summary></summary>
        CapsLock = 0x14,

        /// <summary></summary>
        Kana = 0x15,

        /// <summary></summary>
        Hangeul = 0x15,

        /// <summary></summary>
        Hangul = 0x15,

        /// <summary></summary>
        Junja = 0x17,

        /// <summary></summary>
        Final = 0x18,

        /// <summary></summary>
        Hanja = 0x19,

        /// <summary></summary>
        Kanji = 0x19,

        /// <summary></summary>
        Escape = 0x1B,

        /// <summary></summary>
        Convert = 0x1C,

        /// <summary></summary>
        NonConvert = 0x1D,

        /// <summary></summary>
        Accept = 0x1E,

        /// <summary></summary>
        ModeChange = 0x1F,

        /// <summary></summary>
        Space = 0x20,

        /// <summary></summary>
        Prior = 0x21,

        /// <summary></summary>
        Next = 0x22,

        /// <summary></summary>
        End = 0x23,

        /// <summary></summary>
        Home = 0x24,

        /// <summary></summary>
        Left = 0x25,

        /// <summary></summary>
        Up = 0x26,

        /// <summary></summary>
        Right = 0x27,

        /// <summary></summary>
        Down = 0x28,

        /// <summary></summary>
        Select = 0x29,

        /// <summary></summary>
        Print = 0x2A,

        /// <summary></summary>
        Execute = 0x2B,

        /// <summary></summary>
        Snapshot = 0x2C,

        /// <summary></summary>
        Insert = 0x2D,

        /// <summary></summary>
        Delete = 0x2E,

        /// <summary></summary>
        Help = 0x2F,

        /// <summary></summary>
        N0 = 0x30,

        /// <summary></summary>
        N1 = 0x31,

        /// <summary></summary>
        N2 = 0x32,

        /// <summary></summary>
        N3 = 0x33,

        /// <summary></summary>
        N4 = 0x34,

        /// <summary></summary>
        N5 = 0x35,

        /// <summary></summary>
        N6 = 0x36,

        /// <summary></summary>
        N7 = 0x37,

        /// <summary></summary>
        N8 = 0x38,

        /// <summary></summary>
        N9 = 0x39,

        /// <summary></summary>
        A = 0x41,

        /// <summary></summary>
        B = 0x42,

        /// <summary></summary>
        C = 0x43,

        /// <summary></summary>
        D = 0x44,

        /// <summary></summary>
        E = 0x45,

        /// <summary></summary>
        F = 0x46,

        /// <summary></summary>
        G = 0x47,

        /// <summary></summary>
        H = 0x48,

        /// <summary></summary>
        I = 0x49,

        /// <summary></summary>
        J = 0x4A,

        /// <summary></summary>
        K = 0x4B,

        /// <summary></summary>
        L = 0x4C,

        /// <summary></summary>
        M = 0x4D,

        /// <summary></summary>
        N = 0x4E,

        /// <summary></summary>
        O = 0x4F,

        /// <summary></summary>
        P = 0x50,

        /// <summary></summary>
        Q = 0x51,

        /// <summary></summary>
        R = 0x52,

        /// <summary></summary>
        S = 0x53,

        /// <summary></summary>
        T = 0x54,

        /// <summary></summary>
        U = 0x55,

        /// <summary></summary>
        V = 0x56,

        /// <summary></summary>
        W = 0x57,

        /// <summary></summary>
        X = 0x58,

        /// <summary></summary>
        Y = 0x59,

        /// <summary></summary>
        Z = 0x5A,

        /// <summary></summary>
        LeftWindows = 0x5B,

        /// <summary></summary>
        RightWindows = 0x5C,

        /// <summary></summary>
        Application = 0x5D,

        /// <summary></summary>
        Sleep = 0x5F,

        /// <summary></summary>
        Numpad0 = 0x60,

        /// <summary></summary>
        Numpad1 = 0x61,

        /// <summary></summary>
        Numpad2 = 0x62,

        /// <summary></summary>
        Numpad3 = 0x63,

        /// <summary></summary>
        Numpad4 = 0x64,

        /// <summary></summary>
        Numpad5 = 0x65,

        /// <summary></summary>
        Numpad6 = 0x66,

        /// <summary></summary>
        Numpad7 = 0x67,

        /// <summary></summary>
        Numpad8 = 0x68,

        /// <summary></summary>
        Numpad9 = 0x69,

        /// <summary></summary>
        Multiply = 0x6A,

        /// <summary></summary>
        Add = 0x6B,

        /// <summary></summary>
        Separator = 0x6C,

        /// <summary></summary>
        Subtract = 0x6D,

        /// <summary></summary>
        Decimal = 0x6E,

        /// <summary></summary>
        Divide = 0x6F,

        /// <summary></summary>
        F1 = 0x70,

        /// <summary></summary>
        F2 = 0x71,

        /// <summary></summary>
        F3 = 0x72,

        /// <summary></summary>
        F4 = 0x73,

        /// <summary></summary>
        F5 = 0x74,

        /// <summary></summary>
        F6 = 0x75,

        /// <summary></summary>
        F7 = 0x76,

        /// <summary></summary>
        F8 = 0x77,

        /// <summary></summary>
        F9 = 0x78,

        /// <summary></summary>
        F10 = 0x79,

        /// <summary></summary>
        F11 = 0x7A,

        /// <summary></summary>
        F12 = 0x7B,

        /// <summary></summary>
        F13 = 0x7C,

        /// <summary></summary>
        F14 = 0x7D,

        /// <summary></summary>
        F15 = 0x7E,

        /// <summary></summary>
        F16 = 0x7F,

        /// <summary></summary>
        F17 = 0x80,

        /// <summary></summary>
        F18 = 0x81,

        /// <summary></summary>
        F19 = 0x82,

        /// <summary></summary>
        F20 = 0x83,

        /// <summary></summary>
        F21 = 0x84,

        /// <summary></summary>
        F22 = 0x85,

        /// <summary></summary>
        F23 = 0x86,

        /// <summary></summary>
        F24 = 0x87,

        /// <summary></summary>
        NumLock = 0x90,

        /// <summary></summary>
        ScrollLock = 0x91,

        /// <summary></summary>
        NEC_Equal = 0x92,

        /// <summary></summary>
        Fujitsu_Jisho = 0x92,

        /// <summary></summary>
        Fujitsu_Masshou = 0x93,

        /// <summary></summary>
        Fujitsu_Touroku = 0x94,

        /// <summary></summary>
        Fujitsu_Loya = 0x95,

        /// <summary></summary>
        Fujitsu_Roya = 0x96,

        /// <summary></summary>
        LeftShift = 0xA0,

        /// <summary></summary>
        RightShift = 0xA1,

        /// <summary></summary>
        LeftControl = 0xA2,

        /// <summary></summary>
        RightControl = 0xA3,

        /// <summary></summary>
        LeftMenu = 0xA4,

        /// <summary></summary>
        RightMenu = 0xA5,

        /// <summary></summary>
        BrowserBack = 0xA6,

        /// <summary></summary>
        BrowserForward = 0xA7,

        /// <summary></summary>
        BrowserRefresh = 0xA8,

        /// <summary></summary>
        BrowserStop = 0xA9,

        /// <summary></summary>
        BrowserSearch = 0xAA,

        /// <summary></summary>
        BrowserFavorites = 0xAB,

        /// <summary></summary>
        BrowserHome = 0xAC,

        /// <summary></summary>
        VolumeMute = 0xAD,

        /// <summary></summary>
        VolumeDown = 0xAE,

        /// <summary></summary>
        VolumeUp = 0xAF,

        /// <summary></summary>
        MediaNextTrack = 0xB0,

        /// <summary></summary>
        MediaPrevTrack = 0xB1,

        /// <summary></summary>
        MediaStop = 0xB2,

        /// <summary></summary>
        MediaPlayPause = 0xB3,

        /// <summary></summary>
        LaunchMail = 0xB4,

        /// <summary></summary>
        LaunchMediaSelect = 0xB5,

        /// <summary></summary>
        LaunchApplication1 = 0xB6,

        /// <summary></summary>
        LaunchApplication2 = 0xB7,

        /// <summary></summary>
        OEM1 = 0xBA,

        /// <summary></summary>
        OEMPlus = 0xBB,

        /// <summary></summary>
        OEMComma = 0xBC,

        /// <summary></summary>
        OEMMinus = 0xBD,

        /// <summary></summary>
        OEMPeriod = 0xBE,

        /// <summary></summary>
        OEM2 = 0xBF,

        /// <summary></summary>
        OEM3 = 0xC0,

        /// <summary></summary>
        OEM4 = 0xDB,

        /// <summary></summary>
        OEM5 = 0xDC,

        /// <summary></summary>
        OEM6 = 0xDD,

        /// <summary></summary>
        OEM7 = 0xDE,

        /// <summary></summary>
        OEM8 = 0xDF,

        /// <summary></summary>
        OEMAX = 0xE1,

        /// <summary></summary>
        OEM102 = 0xE2,

        /// <summary></summary>
        ICOHelp = 0xE3,

        /// <summary></summary>
        ICO00 = 0xE4,

        /// <summary></summary>
        ProcessKey = 0xE5,

        /// <summary></summary>
        ICOClear = 0xE6,

        /// <summary></summary>
        Packet = 0xE7,

        /// <summary></summary>
        OEMReset = 0xE9,

        /// <summary></summary>
        OEMJump = 0xEA,

        /// <summary></summary>
        OEMPA1 = 0xEB,

        /// <summary></summary>
        OEMPA2 = 0xEC,

        /// <summary></summary>
        OEMPA3 = 0xED,

        /// <summary></summary>
        OEMWSCtrl = 0xEE,

        /// <summary></summary>
        OEMCUSel = 0xEF,

        /// <summary></summary>
        OEMATTN = 0xF0,

        /// <summary></summary>
        OEMFinish = 0xF1,

        /// <summary></summary>
        OEMCopy = 0xF2,

        /// <summary></summary>
        OEMAuto = 0xF3,

        /// <summary></summary>
        OEMENLW = 0xF4,

        /// <summary></summary>
        OEMBackTab = 0xF5,

        /// <summary></summary>
        ATTN = 0xF6,

        /// <summary></summary>
        CRSel = 0xF7,

        /// <summary></summary>
        EXSel = 0xF8,

        /// <summary></summary>
        EREOF = 0xF9,

        /// <summary></summary>
        Play = 0xFA,

        /// <summary></summary>
        Zoom = 0xFB,

        /// <summary></summary>
        Noname = 0xFC,

        /// <summary></summary>
        PA1 = 0xFD,

        /// <summary></summary>
        OEMClear = 0xFE
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int GWL_EXSTYLE = -20;

        private const int WS_EX_NOACTIVATE = 0x08000000;

        private Point startPoint;

        private int minHeight = 100;

        private int fullHeight = 200;

        private bool isActivated = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        public static extern IntPtr SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);

            //Set the window style to noactivate.
            WindowInteropHelper helper = new WindowInteropHelper(this);
            SetWindowLong(helper.Handle, GWL_EXSTYLE, GetWindowLong(helper.Handle, GWL_EXSTYLE) | WS_EX_NOACTIVATE);
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
            DragMove();
        }

        private void Button_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            var currentPoint = e.GetPosition(button);
            if (e.LeftButton == MouseButtonState.Pressed && button.IsMouseCaptured &&
                (Math.Abs(currentPoint.X - startPoint.X) > SystemParameters.MinimumHorizontalDragDistance ||
                Math.Abs(currentPoint.Y - startPoint.Y) > SystemParameters.MinimumVerticalDragDistance))
            {
                // Prevent Click from firing
                button.ReleaseMouseCapture();
                DragMove();
            }
        }

        private void Button_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var button = sender as Button;
            startPoint = e.GetPosition(button);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.SwitchSize();
        }
        private void SwitchSize()
        {
            //this.Height = this.Height == minHeight ? fullHeight : minHeight;
            if (SizeToContent == SizeToContent.Height)
            {
                this.SizeToContent = SizeToContent.Manual;
                this.Height = minHeight;
            }
            else
            {
                this.SizeToContent = SizeToContent.Height;
                this.Height = double.NaN;
            }
            //this.Height = this.Height == double.NaN ? minHeight : double.NaN;
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
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
            Activation();
        }

        DateTime lastActivation = DateTime.Now;
        ApplicationModel[] model;
        MainWindowViewModel viewModel;
    }

    internal class WindowHelper
    {
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        internal static string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }
    }

    internal class DataGen
    {
        internal static ApplicationModel[] GetData()
        {
            var m = new List<ApplicationModel>();
            var tckeys = new KeyModel[]
            {
                new KeyModel { FunctionName="Up", Key= VirtualKeys.Up },
                new KeyModel { FunctionName="Down", Key= VirtualKeys.Down },
            };
            m.Add(new ApplicationModel { Name = "Total Commander", TitleMatchPattern = "Total Commander.*", Keys = tckeys });

            return m.ToArray();
        }
    }

    internal class ApplicationModel
    {
        public string Name { get; set; }
        public string TitleMatchPattern { get; set; }
        public KeyModel[] Keys { get; set; }
    }
    internal class KeyModel
    {
        public string FunctionName { get; set; }
        public VirtualKeys Key { get; set; }
    }

    internal class SendKeys
    {
        private const uint KEYEVENTF_KEYUP = 0x0002;

        private const uint KEYEVENTF_EXTENDEDKEY = 0x0001;

        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);

        public static void Send(VirtualKeys key)
        {
            keybd_event((byte)key, 0, KEYEVENTF_EXTENDEDKEY | 0, 0);
        }
    }
}