using System;
using System.Threading;
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
            firstButtonPressed.ImageIndex = 1;              //covering cards
            secondButtonPressed.ImageIndex = 1;

            firstButtonPressed = null;
            secondButtonPressed = null;
        }
        

        public Button[] GetButtons()
        {
            Button[] result = { firstButtonPressed, secondButtonPressed };
            return result;
        }


        public void AddButton(Button newButton)
        {
            if (firstButtonPressed == null)
            {
                firstButtonPressed = newButton;
                firstButtonPressed.ImageIndex = 0;                      //uncovering card
            }
            else
            { 
                secondButtonPressed = newButton;
                secondButtonPressed.ImageIndex = 0;
                Thread.Sleep(1000);
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

        public void DisposeButtons()
        {
            firstButtonPressed.Dispose();
            secondButtonPressed.Dispose();

            firstButtonPressed = null;
            secondButtonPressed = null;
        }
    }
}
