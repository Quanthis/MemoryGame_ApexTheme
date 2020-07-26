using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MemoryGame_ApexTheme
{
    public class GameEnder
    {
        private Form formToCheck;
        private int trialsMinimum;

        public GameEnder(Form checkedForm)
        {
            formToCheck = checkedForm;
            trialsMinimum = GetButtonsNo(false) / 2;
        }

        public async Task EndGame(uint trials, string timeElapsed)
        {
            await Task.Run(() =>
            {
                while (Check().Result == true)
                {
                    Thread.Sleep(700);
                }


                MessageBox.Show($"You've won!\n Your trials: {trials} (minimum for this level: {trialsMinimum} ). \nYour time: {timeElapsed}", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                formToCheck.Close();
            });
        }

        private async Task<bool> Check()
        {
            return await Task.Run(() =>
            {
                if(GetButtonsNo().Result == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            });
        }

        private async Task<int> GetButtonsNo()
        {
            return await Task.Run(() =>
            {
                int i = 0;
                foreach (var item in formToCheck.Controls.OfType<Button>())
                {
                    ++i;
                }
                return i;
            });
        }

        private async Task<int> GetButtonsNo(Form form)
        {
            return await Task.Run(() =>
            {
                int i = 0;
                foreach (var item in form.Controls.OfType<Button>())
                {
                    ++i;
                }
                return i;
            });
        }

        private int GetButtonsNo(bool async)
        {
            int i = 0;
            foreach (var item in formToCheck.Controls.OfType<Button>())
            {
                ++i;
            }
            return i;
        }
    }
}
