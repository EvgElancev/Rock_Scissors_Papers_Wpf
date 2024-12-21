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
    public partial class MainWindow : Window
    {
        private int userScope = 0;
        private int computerScope = 0;
        private const int maxRounds = 3;
        private int number = 0;
        private int rounds = 0;
        private Player newPlayer = new Player(new Uri("/Assets/default.jpg", UriKind.Relative));
        private Game newGame = new Game(new Uri("/Assets/default.jpg", UriKind.Relative));
        private Result result = new Result();
        public MainWindow()
        {
            InitializeComponent();

            

            ChoiseImgPlayer.Source = new BitmapImage(newPlayer.choiceUri);
            ChoiseImgUI.Source = new BitmapImage(newGame.choicePCUri);

            
        }

        private void RockBtn_Click(object sender, RoutedEventArgs e)
        {
            rounds++;
           
            newPlayer.choice = "Rock";
            newPlayer.choiceUri = new Uri("/Assets/Rock.png", UriKind.Relative);
            ChoiseImgPlayer.Source = new  BitmapImage(newPlayer.choiceUri);

            newGame.ComputerCoiceGenerate();
            ChoiseImgUI.Source = new BitmapImage(newGame.choicePCUri);

            GameStart(newPlayer.choice, newGame.ComputerCoice);
            GetStatistica();


        }

        private void ScissorsBtn_Click(object sender, RoutedEventArgs e)
        {
            rounds++;
            
            newPlayer.choice = "Scissors";
            newPlayer.choiceUri = new Uri("/Assets/Scissors.jpg", UriKind.Relative);
            ChoiseImgPlayer.Source = new BitmapImage(newPlayer.choiceUri);

            newGame.ComputerCoiceGenerate();
            ChoiseImgUI.Source = new BitmapImage(newGame.choicePCUri);
            
            GameStart(newPlayer.choice, newGame.ComputerCoice);
            if (rounds >= maxRounds)
            {
                MessageBox.Show("Игра закончена", "Вывод", MessageBoxButton.OK, MessageBoxImage.Information);
                userScope = 0;
                computerScope = 0;
                UserScope.Content = userScope.ToString();
                PcScope.Content = computerScope.ToString();
                //Записать статистику
                rounds = 0;
                return;
            }
            GetStatistica();
        }

        private void PaperBtn_Click(object sender, RoutedEventArgs e)
        {
            rounds++;
         
            newPlayer.choice = "Paper";
            newPlayer.choiceUri = new Uri("/Assets/Paper.jpg", UriKind.Relative);
            ChoiseImgPlayer.Source = new BitmapImage(newPlayer.choiceUri);

            newGame.ComputerCoiceGenerate();
            ChoiseImgUI.Source = new BitmapImage(newGame.choicePCUri);

            GameStart(newPlayer.choice, newGame.ComputerCoice);

            GetStatistica();
        }

       private void GameStart (string playerChoise, string computerChoise)
        {
            //Отображается картинка выбора компьютера
            if (newPlayer.choice == newGame.ComputerCoice)
            {
                userScope++;
                computerScope++;              
                UserScope.Content = userScope.ToString(); 
                PcScope.Content = computerScope.ToString();
                MessageBox.Show("Ничья", "Результат", MessageBoxButton.OK, MessageBoxImage.Information);
                
            }
            if(playerChoise == "Rock" && computerChoise =="Paper")
            {
                WinAI();
               
            }
            else if(playerChoise =="Paper" && computerChoise == "Rock")
            {
                WinPlayer();
                
            }
            else if(playerChoise == "Paper" && computerChoise == "Scissors")
            {
                WinAI();
                
            }
            else if(playerChoise =="Scissors" && computerChoise == "Paper")
            {
                WinPlayer();
                
            }
            else if(playerChoise=="Scissors" && computerChoise == "Rock")
            {
                WinAI();
               
            }
            else if (playerChoise == "Rock" && computerChoise == "Scissors")
            {
                WinPlayer();
               
            }
            else
            {
                return;
            }
           
            //Результат игры
        }

        

        private void WinAI()
        {
            computerScope++;
            UserScope.Content = userScope.ToString();
            PcScope.Content = computerScope.ToString();
            
            MessageBox.Show("Выграл компьютер", "Результат", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void WinPlayer()
        {
            userScope++;
            UserScope.Content = userScope.ToString();
            PcScope.Content = computerScope.ToString();
            
            MessageBox.Show("Вы выиграли", "Результат", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void GetStatistica()
        {
            if (rounds >= maxRounds)
            {
                number++;
                if(userScope == computerScope)
                {
                    result.total = "Ничья";
                }else if(userScope > computerScope)
                {
                    result.total = "Выигрыш";
                }
                else
                {
                    result.total = "Проигрыш";
                }     
                result.userScope = userScope.ToString();
                result.aiScope = computerScope.ToString();
                result.numberGame = number;
                userScope = 0;
                computerScope = 0;
                UserScope.Content = userScope.ToString();
                PcScope.Content = computerScope.ToString();
                rounds = 0;
               
                Statistica.Items.Add(result);
                MessageBox.Show("Игра закончена", "Вывод", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            else
            {
                return;
            }
        }
    }
}