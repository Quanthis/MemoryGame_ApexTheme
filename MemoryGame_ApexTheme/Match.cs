using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MemoryGame_ApexTheme
{
    public class Match : ReturnMatch
    {
        private string firstButtonPressed;
        private string secondButtonPressed;
        //private string thirdButtonPressed;


        public Match() { }

        public Match(string button_1, string button_2)
        {
            firstButtonPressed = button_1;
            secondButtonPressed = button_2;
        }

        public void NullButtons()
        {
            firstButtonPressed = null;
            secondButtonPressed = null;   
        }

        public void NullFirstButton()
        {
            firstButtonPressed = null;
        }

        public string[] GetButtons()
        {
            string[] result = { firstButtonPressed, secondButtonPressed };
            //Debug.WriteLine("From GetButtons(): 1." + result[0] + " 2." + result[1]);
            return result;
        }


        public void AddButton(string newButtonName)
        {
            if (firstButtonPressed == null)
            {
                firstButtonPressed = newButtonName;
            }
            else
            {
                secondButtonPressed = newButtonName;
            }

        }

        public bool Matched()
        {
            if (firstButtonPressed != null && secondButtonPressed != null )
            {

                if (firstButtonPressed == secondButtonPressed)
                {
                    NullButtons();
                    return true;
                }
                else
                {
                    NullButtons();
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
