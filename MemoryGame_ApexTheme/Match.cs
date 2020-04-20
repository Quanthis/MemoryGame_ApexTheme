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


        public Match() { }

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
                Debug.WriteLine("Before index changing: " + firstButtonPressed.ImageIndex);
                firstButtonPressed.ImageIndex = 0;                                           //uncovering card
                Debug.WriteLine("After index changing: " + firstButtonPressed.ImageIndex);
            }
            else
            { 
                secondButtonPressed = newButton;
                Debug.WriteLine("Before index changing: " + secondButtonPressed.ImageIndex);
                secondButtonPressed.ImageIndex = 0;
                secondButtonPressed.Refresh();
                Debug.WriteLine("After index changing: " + secondButtonPressed.ImageIndex);
                Thread.Sleep(500);
            }
        }

        public bool Matched()
        {
            if (firstButtonPressed != null && secondButtonPressed != null)
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
