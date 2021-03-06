﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame_ApexTheme
{
    public class GetFormInfo
    {
        private Form checkedForm;
        private CardPositions[] positions;

        public GetFormInfo(Form form)
        {
            checkedForm = form;
            positions = GetButtonsLocations();
        }


        public uint CalculateButtons()
        {
            uint result = 0;

            foreach (var button in checkedForm.Controls.OfType<Button>())
            {
                ++result;
            }

            return result;
        }

        public CardPositions[] GetButtonsLocations()
        {
            uint buttons = CalculateButtons();

            CardPositions[] cardsPositions = new CardPositions[buttons];

            ushort i = 0;

            foreach (Button button in checkedForm.Controls.OfType<Button>())
            {
                cardsPositions[i] = new CardPositions(button.Location.X, button.Location.Y);
                ++i;
            }

            return cardsPositions;
        }

        public async void Shuffle()
        {
            uint buttonNo = CalculateButtons();

            RandomizePositions randomize = new RandomizePositions(buttonNo, ref positions);
            CardPositions[] cardPositions = new CardPositions[buttonNo];
            cardPositions = await randomize.ReturnNewPositions();

            uint i = 0;
            foreach (Button button in checkedForm.Controls.OfType<Button>())
            {
                int posX = cardPositions[i].X;
                int posY = cardPositions[i].Y;

                button.Location = new Point(posX, posY);
                button.Refresh();

                ++i;
            }
        }

        public void Timer(ref long secondsElapsed, ref Label whereToSave)
        {
            ++secondsElapsed;
            whereToSave.Text = secondsElapsed.ToString() + "s";
            if (secondsElapsed >= 60)
            {
                /*if(secondsElapsed >= 3600)
                {
                    MessageBox.Show("You've lost.", "Timed out!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    callingForm.Dispose();
                }*/
                int minutesElapsed = (int)(secondsElapsed / 60);
                int rest = (int)(secondsElapsed - minutesElapsed * 60);
                whereToSave.Text = minutesElapsed + " min " + rest + " s";
            }
        }

        #region adminTools
        public void GodMode(ref Form callingForm)
        {
            foreach(var button in callingForm.Controls.OfType<Button>())
            {
                button.ImageIndex = 0;
                button.Refresh();
            }
        }
        #endregion
    }
}
