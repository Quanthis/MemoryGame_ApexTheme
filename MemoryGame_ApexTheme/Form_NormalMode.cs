using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame_ApexTheme
{
    public partial class Form_NormalMode : Form
    {
        Match CheckForMatches = new Match();
        GetFormInfo formInfo;
        long secondsElapsed;

        public Form_NormalMode()
        {
            InitializeComponent();
        }

        private void Form_NormalMode_Load(object sender, EventArgs e)
        {
            formInfo = new GetFormInfo(this);
            formInfo.Shuffle();
            secondsElapsed = Convert.ToInt64(TimeElapsed.Text);
        }


        #region Buttons
        private void Banglore_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref Banglore);
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

        private void Crypto_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref Crypto);
            CheckForMatches.Matched();
        }

        private void Crypto_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref Crypto_2);
            CheckForMatches.Matched();
        }

        private void Gibraltar_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref Gibraltar);
            CheckForMatches.Matched();
        }

        private void Gibraltar_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref Gibraltar_2);
            CheckForMatches.Matched();
        }

        private void Lifeline_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref Lifeline);
            CheckForMatches.Matched();
        }

        private void Lifeline_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref Lifeline_2);
            CheckForMatches.Matched();
        }

        private void Mirage_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref Mirage);
            CheckForMatches.Matched();
        }

        private void Mirage_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref Mirage_2);
            CheckForMatches.Matched();
        }

        private void Octane_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref Octane);
            CheckForMatches.Matched();
        }

        private void Octane_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref Octane_2);
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

        private void Revenant_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref Revenant);
            CheckForMatches.Matched();
        }

        private void Revenant_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref Revenant_2);
            CheckForMatches.Matched();
        }

        private void Wattson_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref Wattson);
            CheckForMatches.Matched();
        }

        private void Wattson_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref Wattson_2);
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

        private void Backpack_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref Backpack);
            CheckForMatches.Matched();
        }

        private void Bacppack_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref Backpack_2);
            CheckForMatches.Matched();
        }

        private void EnergyAmmo_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref EnergyAmmo);
            CheckForMatches.Matched();
        }

        private void EnergyAmmo_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref EnergyAmmo_2);
            CheckForMatches.Matched();
        }

        private void HeavyAmmo_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref HeavyAmmo);
            CheckForMatches.Matched();
        }

        private void HeavyAmmo_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref HeavyAmmo_2);
            CheckForMatches.Matched();
        }

        private void LightAmmo_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref LightAmmo);
            CheckForMatches.Matched();
        }

        private void LightAmmo_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref LightAmmo_2);
            CheckForMatches.Matched();
        }

        private void ShotgunAmmo_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref ShotgunAmmo);
            CheckForMatches.Matched();
        }

        private void ShotgunAmmo_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref ShotgunAmmo_2);
            CheckForMatches.Matched();
        }

        private void SniperAmmo_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref SniperAmmo);
            CheckForMatches.Matched();
        }

        private void SniperAmmo_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ref SniperAmmo_2);
            CheckForMatches.Matched();
        }

        #endregion

        private void Timer_Tick(object sender, EventArgs e)
        {
            formInfo.Timer(ref secondsElapsed, ref TimeElapsed);
            TrialsCounter.Text = CheckForMatches.GetTrialsCount().ToString();
        }
    }
}
