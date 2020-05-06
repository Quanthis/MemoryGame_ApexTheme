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

        private void Banglore_Click(object sender, EventArgs e)
        {

        }


    }
}
