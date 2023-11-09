using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uge1_onsdag
{
    internal class Exercise_2
    {
        string magicWord = "";
        string welcomeText;
        public string Magic()
        {
            for (int i = 0; i < 10; i++)
            {
                if (magicWord == "magic")
                {
                    i = 10;
                    welcomeText = "Welcome to the magic land of C#";
                }
                else
                {
                    Console.Write("Enter the magic word: ");
                    magicWord = Console.ReadLine();
                    welcomeText = "You clearly don't know the magic word!";
                }
            }
            return welcomeText;
        }
        
        

        
    }
}
