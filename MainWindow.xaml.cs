using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Rock_Scissors_Papers_Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private bool session = false;

        
        
        public MainWindow()
        {
            InitializeComponent();

        }

        private void RockBtn_Click(object sender, RoutedEventArgs e)
        {

            Uri resourseUri = new Uri("/Assets/Rock.png", UriKind.Relative);           
            ChoiseImgPlayer.Source = new BitmapImage(resourseUri);

        }

        private void ScissorsBtn_Click(object sender, RoutedEventArgs e)
        {
            Uri resourseUri = new Uri("/Assets/Scissors.jpg", UriKind.Relative);
            ChoiseImgPlayer.Source = new BitmapImage(resourseUri);
        }

        private void PaperBtn_Click(object sender, RoutedEventArgs e)
        {
            Uri resourseUri = new Uri("/Assets/Paper.jpg", UriKind.Relative);
            ChoiseImgPlayer.Source = new BitmapImage(resourseUri);
        }
    }
}