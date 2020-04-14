using System;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace MemoryGame_ApexTheme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void LoadOtherForm(Form loadedForm)
        {
            Visible = false;
            Form modeSetForm = loadedForm;
            DialogResult dialogResult = modeSetForm.ShowDialog();
            Visible = true;
        }

        private void TurnEasyMode_Click(object sender, EventArgs e)
        {
            LoadOtherForm(new Form_EasyMode());
            //Dispose();
        }
        

        private void TurnNormalMode_Click(object sender, EventArgs e)
        {
            LoadOtherForm(new Form_NormalMode());
        }

        private void TurnHardMode_Click(object sender, EventArgs e)
        {
            LoadOtherForm(new Form_HardMode());
        }
    }
}
