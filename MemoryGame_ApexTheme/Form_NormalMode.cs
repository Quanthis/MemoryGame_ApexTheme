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

        public Form_NormalMode()
        {
            InitializeComponent();
        }

        private void Form_NormalMode_Load(object sender, EventArgs e)
        {
            formInfo = new GetFormInfo(this);
            formInfo.Shuffle();
        }


        #region Buttons
        private void Banglore_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(Banglore);
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

        private void Crypto_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(Crypto);
            CheckForMatches.Matched();
        }

        private void Crypto_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(Crypto_2);
            CheckForMatches.Matched();
        }

        private void Gibraltar_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(Gibraltar);
            CheckForMatches.Matched();
        }

        private void Gibraltar_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(Gibraltar_2);
            CheckForMatches.Matched();
        }

        private void Lifeline_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(Lifeline);
            CheckForMatches.Matched();
        }

        private void Lifeline_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(Lifeline_2);
            CheckForMatches.Matched();
        }

        private void Mirage_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(Mirage);
            CheckForMatches.Matched();
        }

        private void Mirage_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(Mirage_2);
            CheckForMatches.Matched();
        }

        private void Octane_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(Octane);
            CheckForMatches.Matched();
        }

        private void Octane_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(Octane_2);
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

        private void Revenant_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(Revenant);
            CheckForMatches.Matched();
        }

        private void Revenant_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(Revenant_2);
            CheckForMatches.Matched();
        }

        private void Wattson_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(Wattson);
            CheckForMatches.Matched();
        }

        private void Wattson_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(Wattson_2);
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

        private void Backpack_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(Backpack);
            CheckForMatches.Matched();
        }

        private void Bacppack_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(Backpack_2);
            CheckForMatches.Matched();
        }

        private void EnergyAmmo_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(EnergyAmmo);
            CheckForMatches.Matched();
        }

        private void EnergyAmmo_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(EnergyAmmo_2);
            CheckForMatches.Matched();
        }

        private void HeavyAmmo_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(HeavyAmmo);
            CheckForMatches.Matched();
        }

        private void HeavyAmmo_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(HeavyAmmo_2);
            CheckForMatches.Matched();
        }

        private void LightAmmo_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(LightAmmo);
            CheckForMatches.Matched();
        }

        private void LightAmmo_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(LightAmmo_2);
            CheckForMatches.Matched();
        }

        private void ShotgunAmmo_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ShotgunAmmo);
            CheckForMatches.Matched();
        }

        private void ShotgunAmmo_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(ShotgunAmmo_2);
            CheckForMatches.Matched();
        }

        private void SniperAmmo_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(SniperAmmo);
            CheckForMatches.Matched();
        }

        private void SniperAmmo_2_Click(object sender, EventArgs e)
        {
            CheckForMatches.AddButton(SniperAmmo_2);
            CheckForMatches.Matched();
        }

        #endregion
    }
}
