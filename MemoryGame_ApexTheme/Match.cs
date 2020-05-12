using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MemoryGame_ApexTheme
{
    public class Match : ReturnMatch, ButtonsToDispose, IDisposable
    {
        private Button firstButtonPressed;
        private Button secondButtonPressed;
        private int trialsCount;
        private bool disposed = false;

        public Match()
        {
            trialsCount = 0;
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


        public void AddButton(ref Button newButton)
        {
            if (firstButtonPressed == null)
            {
                firstButtonPressed = newButton;
                firstButtonPressed.ImageIndex = 0;                                           //uncovering card
            }
            else
            { 
                secondButtonPressed = newButton;
                secondButtonPressed.ImageIndex = 0;
                secondButtonPressed.Refresh();

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
                        ++trialsCount;
                        return true;
                    }
                    else
                    {
                        NullButtons();
                        ++trialsCount;
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

        public int GetTrialsCount()
        {
            return trialsCount;
        }

        #region Cleaning

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    firstButtonPressed.Dispose();
                    secondButtonPressed.Dispose();
                }

                disposed = true;
            }
        }

        ~Match()
        {
            Dispose(false);
        }

        #endregion
    }
}
