using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Learn_Avalonia
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Find obj by name in XAML
            var button = this.FindControl<Button>("CloseWindowButton");
            // Add event click cho button
            button.Click += Button_Click;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void Button_Click(object? sender, RoutedEventArgs e)
        {
            // Close window
            this.Close();
        }
    }
}