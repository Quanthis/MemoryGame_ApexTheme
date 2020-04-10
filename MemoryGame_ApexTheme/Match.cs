using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MemoryGame_ApexTheme
{
    public class Match : ReturnMatch, ButtonsToDispose
    {
        private Button firstButtonPressed;
        private Button secondButtonPressed;
        //private string thirdButtonPressed;


        public Match() { }

        public Match(Button button_1, Button button_2)
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

        public Button[] GetButtons()
        {
            Button[] result = { firstButtonPressed, secondButtonPressed };
            //Debug.WriteLine("From GetButtons(): 1." + result[0] + " 2." + result[1]);
            return result;
        }


        public void AddButton(Button newButton)
        {
            if (firstButtonPressed == null)
            {
                firstButtonPressed = newButton;
            }
            else
            {
                secondButtonPressed = newButton;
            }

        }

        public bool Matched()
        {
            if (firstButtonPressed != null && secondButtonPressed != null )
            {
                if (firstButtonPressed.Name != secondButtonPressed.Name)
                {
                    if (firstButtonPressed.Text == secondButtonPressed.Text)
                    {
                        DisposeButtons();
                        return true;
                    }
                    else
                    {
                        NullButtons();
                        return false;
                    }
                }

                else return false;
            }
            else
            {
                return false;
            }
        }

        public void DisposeButtons()
        {
            firstButtonPressed.Dispose();
            secondButtonPressed.Dispose();
            NullButtons();
        }
    }
}
