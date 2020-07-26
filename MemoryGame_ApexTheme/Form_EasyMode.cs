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
        GetFormInfo formInfo;
        GameEnder gameEnder;
        long secondsElapsed;


        public Form_EasyMode()
        {
            InitializeComponent();
        }

        public uint GetTrialsCount()
        {
            return Convert.ToUInt32(TrialsCounter);
        }

        private async void Form_EasyMode_Load(object sender, EventArgs e)                   
        {
            formInfo = new GetFormInfo(this);
            formInfo.Shuffle();
            long secondsElapsed = Convert.ToInt64(TimeElapsed.Text);

            gameEnder = new GameEnder(this);

            gameEnder.EndGame(this.GetTrialsCount(), TimeElapsed.Text);
        }


        #region Buttons
        private void Banglore_1_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref Banglore_1);
            CheckForMatches.Matched();
        }

        private void Banglore_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref Banglore_2);
            CheckForMatches.Matched();
        }

        private void Bloodhound_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref Bloodhound);
            CheckForMatches.Matched();
        }

        private void Bloodhound_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref Bloodhound_2);
            CheckForMatches.Matched();
        }

        private void Caustic_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref Caustic);
            CheckForMatches.Matched();
        }

        private void Caustic_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref Caustic_2);
            CheckForMatches.Matched();
        }

        private void Lifeline_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref Lifeline);
            CheckForMatches.Matched();
        }

        private void Lifeline2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref Lifeline2);
            CheckForMatches.Matched();
        }

        private void Pathfinder_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref Pathfinder);
            CheckForMatches.Matched();
        }

        private void Pathfinder_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref Pathfinder_2);
            CheckForMatches.Matched();
        }

        private void Wraith_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref Wraith);
            CheckForMatches.Matched();
        }

        private void Wraith_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref Wraith_2);
            CheckForMatches.Matched();
        }

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            formInfo.Timer(ref secondsElapsed, ref TimeElapsed);
            TrialsCounter.Text = CheckForMatches.GetTrialsCount().ToString();
        }
    }
}
