using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MemoryGame_ApexTheme
{
    public class Match : ReturnMatch
    {
        private static Button firstButtonPressed;
        private static Button secondButtonPressed;


        public Match() { }

        public Match(Button button_1, Button button_2)
        {
            firstButtonPressed = button_1;
            secondButtonPressed = button_2;
        }

        public Button[] GetButtons()
        {
            Button[] result = { firstButtonPressed, secondButtonPressed };
            Debug.WriteLine("From GetButtons(): 1." + result[0] + " 2." + result[1]);
            return result;
        }

        public void SetNewButtons(Button button_1, Button button_2)
        {
            firstButtonPressed = button_1;
            secondButtonPressed = button_2;
        }

        public static void SetFirstButton(Button button_1)         //in future, just lock one and check if locked to get second button
        {
            firstButtonPressed = button_1;
        }

        public static void SetSecondButton(Button button_2)
        {
            secondButtonPressed = button_2;
        }

        public bool Matched()
        {
            if (firstButtonPressed != null || secondButtonPressed != null)
            {
                if (firstButtonPressed == secondButtonPressed)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
