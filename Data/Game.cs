using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Scissors_Papers_Wpf.Data
{
    internal class Game
    {
        public string? ComputerCoice { get; set; }

        private string[] choicesPcArr = [ "Rock", "Paper", "Scissors" ];
        
        public Uri? choicePCUri { get; set; }

        public bool status = false;
        
        public Game(Uri uri)        
        {          
            choicePCUri = uri;          
        }

        public void ComputerCoiceGenerate()
        {         
           Random random = new Random();
            ComputerCoice = choicesPcArr[random.Next(0, choicesPcArr.Length)];
            SetImage(ComputerCoice);
        }

        private void SetImage(string choice)
        {
            if(choice  == "Rock")
            {
                choicePCUri = new Uri("/Assets/Rock.png", UriKind.Relative);
                return;
            }
            if(choice == "Paper")
            {
                choicePCUri = new Uri("/Assets/Paper.jpg", UriKind.Relative);
            }
            if(choice == "Scissors")
            {
                choicePCUri = new Uri("/Assets/Scissors.jpg", UriKind.Relative);
            }
            
            
        }
    }
}
