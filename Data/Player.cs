using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Scissors_Papers_Wpf.Data
{
    public class Player
    {
        public string? Name { get; set; }   
        public string? choice { get; set; }

        public Uri? choiceUri { get; set; }  
        public bool status = false;


        public Player(Uri uri) 
        { choiceUri = uri; }

    }
}
