using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MemoryGame_ApexTheme
{
    public partial class Form_EasyMode : Form
    {
        Match CheckForMatches = new Match();

        public Form_EasyMode()
        {
            InitializeComponent();
        }

        private async void Form_EasyMode_Load(object sender, EventArgs e)
        {
            Match Check = CheckForMatches;
            CheckForDisposing();
        }

        private void Banglore_1_Click(object sender, EventArgs e)
        {
            Match.SetFirstButton(Banglore_1);
            Debug.WriteLine("From Bagnlore1.Click(): " + CheckForMatches.GetButtons());
        }

        private void Banglore_2_Click(object sender, EventArgs e)
        {
            Match.SetSecondButton(Banglore_2);
        }

        private async Task CheckForDisposing()
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    bool disposeButtons = CheckForMatches.Matched();
                    if (disposeButtons)
                    {
                        Button[] buttonsToDispose = CheckForMatches.GetButtons();
                        foreach (var item in buttonsToDispose)
                        {
                            Debug.WriteLine("From CheckForDisposing(): " + item);
                            Banglore_1.Dispose();
                        }
                    }

                    Thread.Sleep(500);
                }
            });
        }
    }
}
