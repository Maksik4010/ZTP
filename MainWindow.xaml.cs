using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public int selectedOption;
        public int selectedLevel;
        public MainWindow()
        {
            InitializeComponent();
            
            
            Imagines.Source = getImage("249");
        }

        private BitmapImage getImage(string img)
        {
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("images/" + img + ".png", UriKind.Relative);
            image.EndInit();
            return image;
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (LearnCheck.IsChecked == true)
            {
                selectedOption = 0;
                if(EasyCheck.IsChecked == true)
                {
                    selectedLevel = 1;
                }
                else if (MediumCheck.IsChecked == true)
                {
                    selectedLevel = 2;
                }
                else if(HardCheck.IsChecked == true)
                {
                    selectedLevel = 3;
                }
                else if(ExpertCheck.IsChecked == true)
                {
                    selectedLevel = 4;
                }
            }
            else if(TestCheck.IsChecked == true)
            {
                selectedOption = 1;
                if (EasyCheck.IsChecked == true)
                {
                    selectedLevel = 1;
                }
                else if (MediumCheck.IsChecked == true)
                {
                    selectedLevel = 2;
                }
                else if (HardCheck.IsChecked == true)
                {
                    selectedLevel = 3;
                }
                else if (ExpertCheck.IsChecked == true)
                {
                    selectedLevel = 4;
                }
            }
            Game game = new Game();
            this.Visibility = Visibility.Hidden;
            game.Show();
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Baza_button_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
