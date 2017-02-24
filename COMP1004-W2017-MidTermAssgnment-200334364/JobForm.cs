// App Name : Job Form
// Author's Name : Kinjal Patel 
// Student ID : 200334364
// App Creation Date : February 22, 2017

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_MidTermAssgnment_200334364
{
    public partial class JobForm : Form
    {
        public Form previosForm;

        private int _DEX = Convert.ToInt32(Program.character.DEX);
        private int _END = Convert.ToInt32(Program.character.END);
        private int _INT = Convert.ToInt32(Program.character.INT);
        private int _CHA = Convert.ToInt32(Program.character.CHA);

        public String holdValue;        
        public JobForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            character.Health = HealthPointsLabel.Text;

            FinalForm finalForm = new FinalForm();

            finalForm.previousForm = this;
            finalForm.Show();
            this.Hide();
        }

        private void SoldierRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            holdValue = 30 + _END.ToString();
            HealthPointsLabel.Text = holdValue;
        }

        private void RogueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            holdValue = 28 + _DEX.ToString();
            HealthPointsLabel.Text = holdValue;
        }

        private void MagickerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            holdValue = 15 + _INT.ToString();
            HealthPointsLabel.Text = holdValue;
        }

        private void CultistRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            holdValue = 24 + _CHA.ToString();
            HealthPointsLabel.Text = holdValue;
        }
    }
}
