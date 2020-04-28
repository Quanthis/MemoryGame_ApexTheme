using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;
using System.Drawing;

namespace MemoryGame_ApexTheme
{
    public partial class Form_EasyMode : Form
    {
        Match CheckForMatches = new Match();
        CardPositions[] positions;

        public Form_EasyMode()
        {
            InitializeComponent();
        }

        private async void Form_EasyMode_Load(object sender, EventArgs e)                   
        {
            positions = GetButtonsLocations();
            Shuffle();
        }

        public void Shuffle()
        {
            uint buttonNo = CalculateButtons();

            RandomizePositions randomize = new RandomizePositions(buttonNo, positions);
            CardPositions[] cardPositions = new CardPositions[buttonNo];
            cardPositions = randomize.ReturnNewPositions();

            uint i = 0;
            foreach (Button button in Controls.OfType<Button>())
            {
                /*int posX = randomize.ReturnNewPositions()[i].X;
                int posY = randomize.ReturnNewPositions()[i].Y;*/

                int posX = cardPositions[i].X;
                int posY = cardPositions[i].Y;

                button.Location = new Point(posX, posY);
                button.Refresh();

                ++i;
            }
        }

        public CardPositions[] GetButtonsLocations()
        {
            uint buttons = CalculateButtons();

            CardPositions[] cardsPositions = new CardPositions[buttons];
            Debug.WriteLine(buttons);

            ushort i = 0;

            foreach (Button button in Controls.OfType<Button>())
            {

                cardsPositions[i] = new CardPositions();
                cardsPositions[i].X = button.Location.X;
                cardsPositions[i].Y = button.Location.Y;

                Debug.WriteLine("X: " + cardsPositions[i].X + " Y: " + cardsPositions[i].Y);
                ++i;
                
            }

            return cardsPositions;
        }

        public uint CalculateButtons()
        {
            uint result = 0;

            foreach(var button in Controls.OfType<Button>())
            {
                ++result;
            }

            return result;
        }

        #region Buttons
        private void Banglore_1_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(Banglore_1);
            CheckForMatches.Matched();
        }

        private void Banglore_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(Banglore_2);
            CheckForMatches.Matched();
        }

        private void Bloodhound_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(Bloodhound);
            CheckForMatches.Matched();
        }

        private void Bloodhound_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(Bloodhound_2);
            CheckForMatches.Matched();
        }

        private void Caustic_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(Caustic);
            CheckForMatches.Matched();
        }

        private void Caustic_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(Caustic_2);
            CheckForMatches.Matched();
        }

        private void Lifeline_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(Lifeline);
            CheckForMatches.Matched();
        }

        private void Lifeline2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(Lifeline2);
            CheckForMatches.Matched();
        }

        private void Pathfinder_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(Pathfinder);
            CheckForMatches.Matched();
        }

        private void Pathfinder_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(Pathfinder_2);
            CheckForMatches.Matched();
        }

        private void Wraith_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(Wraith);
            CheckForMatches.Matched();
        }

        private void Wraith_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(Wraith_2);
            CheckForMatches.Matched();
        }

        #endregion
    }
}
