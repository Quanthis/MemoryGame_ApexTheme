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

        public Form_EasyMode()
        {
            InitializeComponent();
        }

        private async void Form_EasyMode_Load(object sender, EventArgs e)
        {
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
