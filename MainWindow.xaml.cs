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
            if(EasyCheck.IsChecked == true)
            {
                if(LearnCheck.IsChecked == true)
                {

                } 
                else if(TestCheck.IsChecked == true)
                {

                }
            } 
            else if(MediumCheck.IsChecked == true)
            {
                if (LearnCheck.IsChecked == true)
                {

                }
                else if (TestCheck.IsChecked == true)
                {

                }
            }
            else if(HardCheck.IsChecked == true)
            {
                if (LearnCheck.IsChecked == true)
                {

                }
                else if (TestCheck.IsChecked == true)
                {

                }
            }
            else if(ExpertCheck.IsChecked == true)
            {
                if (LearnCheck.IsChecked == true)
                {

                }
                else if (TestCheck.IsChecked == true)
                {

                }
            }
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        
    }
}
