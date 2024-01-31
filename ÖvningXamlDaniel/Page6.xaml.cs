using System.Windows;
using System.Windows.Media;

namespace ButtonColorChangeExample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MyButton_MouseEnter(object sender, RoutedEventArgs e)
        {
            // Ändra färg när musen går över knappen
            ((Button)sender).Background = Brushes.LightBlue;
        }

        private void MyButton_MouseLeave(object sender, RoutedEventArgs e)
        {
            // Återställ färg när musen lämnar knappen
            ((Button)sender).Background = SystemColors.ControlBrush;
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            // Ändra färg när knappen klickas
            ((Button)sender).Background = Brushes.Orange;

            // Lägg till din logik här för knappklickhändelsen
            MessageBox.Show("Knappen klickades!");
        }
    }
}

