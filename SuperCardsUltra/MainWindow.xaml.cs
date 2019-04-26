using System;
using System.Windows;
using System.Windows.Controls;

namespace SuperCardsUltra
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Console.WriteLine("INIT");
            InitializeComponent();
        }

        private void login_button_Click_1(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("HEY HONEY");

            // check if the username and password are 123
            if (tx_ps.Text == "123" && tx_us.Text == "123")
            {
                Console.WriteLine("winner");
                new GameForm().Show();
            }
        }
    }
}
