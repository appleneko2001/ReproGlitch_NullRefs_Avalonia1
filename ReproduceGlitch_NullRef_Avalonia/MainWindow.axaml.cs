using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace ReproduceGlitch_NullRef_Avalonia
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void Button_OnClick(object? sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ShowDialogButton_OnClick(object? sender, RoutedEventArgs e)
        {
            var dialog = new MainWindow();
            dialog.ShowDialog(this);
        }        
		
		private void ShowWindowButton_OnClick(object? sender, RoutedEventArgs e)
        {
            var dialog = new MainWindow();
            dialog.Show();
        }
    }
}