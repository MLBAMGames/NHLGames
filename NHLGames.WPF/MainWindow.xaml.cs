using System;
using System.ComponentModel;
using MahApps.Metro.Controls;
using NHLGames.WPF.Utilities;
using NHLGames.WPF.ViewModel;

namespace NHLGames.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            var writer = new ConsoleRedirectStreamWriterWpf(richTextBox);
            Console.SetOut(writer);

            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine(e.ToString());
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            var mainWindowViewModel = this.DataContext as MainWindowViewModel;
            mainWindowViewModel?.SettingsViewModel.SaveSetting();
            base.OnClosing(e);
        }
    }
}
