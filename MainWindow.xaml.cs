using Rock_Scissors_Papers_Wpf.Data;
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

        private Player newPlayer = new Player(new Uri("/Assets/default.jpg", UriKind.Relative));
        Game newGame = new Game(new Uri("/Assets/default.jpg", UriKind.Relative));
        //private string[] coicesPcArr = ["Rock", "Paper", "Scissors"];
       

        public MainWindow()
        {
            InitializeComponent();
            
            ChoiseImgPlayer.Source = new BitmapImage(newPlayer.choiceUri);
            ChoiseImgUI.Source = new BitmapImage(newGame.choicePCUri);
            
            //Statistica.Text = newGame.ComputerCoice;
        }

        private void RockBtn_Click(object sender, RoutedEventArgs e)
        {
            newPlayer.choice = "Rock";
            newPlayer.choiceUri = new Uri("/Assets/Rock.png", UriKind.Relative);
            ChoiseImgPlayer.Source = new  BitmapImage(newPlayer.choiceUri);

            newGame.ComputerCoiceGenerate();
            ChoiseImgUI.Source = new BitmapImage(newGame.choicePCUri);
        


        }

        private void ScissorsBtn_Click(object sender, RoutedEventArgs e)
        {
            newPlayer.choice = "Scissors";
            newPlayer.choiceUri = new Uri("/Assets/Scissors.jpg", UriKind.Relative);
            ChoiseImgPlayer.Source = new BitmapImage(newPlayer.choiceUri);

            newGame.ComputerCoiceGenerate();
            ChoiseImgUI.Source = new BitmapImage(newGame.choicePCUri);
        }

        private void PaperBtn_Click(object sender, RoutedEventArgs e)
        {
            newPlayer.choice = "Paper";
            newPlayer.choiceUri = new Uri("/Assets/Paper.jpg", UriKind.Relative);
            ChoiseImgPlayer.Source = new BitmapImage(newPlayer.choiceUri);

            newGame.ComputerCoiceGenerate();
            ChoiseImgUI.Source = new BitmapImage(newGame.choicePCUri);
        }

       private void GameStart (string playerChoise, string computerChoise)
        {
            //Отображается картинка выбора компьютера

            //Результат игры
        }

       
    }
}