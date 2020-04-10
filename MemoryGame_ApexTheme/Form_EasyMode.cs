using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;

namespace MemoryGame_ApexTheme
{
    public partial class Form_EasyMode : Form
    {
        Match CheckForMatches = new Match();
        bool disposeButtons = false;

        public Form_EasyMode()
        {
            InitializeComponent();
        }

        private async void Form_EasyMode_Load(object sender, EventArgs e)
        {
            //Match Check = CheckForMatches;
            CheckForDisposing();
        }

        private void Banglore_1_Click(object sender, EventArgs e)
        {
            Match.firstButtonPressed = Banglore_1.Text;
            disposeButtons = CheckForMatches.Matched();
            DisposeButton();
        }

        private void Banglore_2_Click(object sender, EventArgs e)
        {
            Match.secondButtonPressed = Banglore_2.Text;
            disposeButtons = CheckForMatches.Matched();
            DisposeButton();
        }

        private async Task CheckForDisposing()
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    Debug.WriteLine(disposeButtons);
                    if (disposeButtons)
                    {
                        string[] buttonsToDispose = CheckForMatches.GetButtons();
                        //foreach (var item in buttonsToDispose)
                        {
                            int i = 0;
                            //Debug.WriteLine("From CheckForDisposing(): " + item);
                            foreach (Button button in Controls.OfType<Button>())
                            {
                                if (button.Name.Contains("Banglore"))
                                {
                                    //DisposeButton(button.Text);
                                    ++i;
                                }

                            }
                        }
                    }

                    Thread.Sleep(500);
                }
            });
        }

        private void DisposeButton(string buttonText)
        {
            foreach(Button button in Controls.OfType<Button>())
            {
                if(button.Text == buttonText)
                {
                    button.Dispose();
                }
            }

            /*if(disposeButtons)
            {
                Banglore_1.Dispose();
                Banglore_2.Dispose();
            }*/
        }

        private void DisposeButton()
        {
            /*foreach(Button button in Controls.OfType<Button>())
            {
                if(button.Text == buttonText)
                {
                    button.Dispose();
                }
            }*/

            if (disposeButtons)
            {
                Banglore_1.Dispose();
                Banglore_2.Dispose();
            }
        }
    }
}
